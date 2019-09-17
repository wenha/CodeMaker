using CodeMaker.IData;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeMaker.Common;
using CodeMaker.Model;
using CodeMaker.Model.Enum;

namespace CodeMaker.Data.SqlServer
{
    public class DataBase : IDataBase
    {
        /// <summary>
        /// 测试数据库连接
        /// </summary>
        /// <param name="serverID">连接字符串</param>
        /// <param name="errMessage">错误信息</param>
        /// <returns></returns>
        public bool TestDatabaseConnection(string serverID, out string errMessage)
        {
            SqlConnection conn = new SqlConnection(Config.GetConnectionString(serverID));
            try
            {
                conn.Open();
                errMessage = string.Empty;
                return true;
            }
            catch (SqlException err)
            {
                errMessage = err.Message;
                return false;
            }
            finally
            {
                conn.Dispose();
            }
        }

        /// <summary>
        /// 得到服务器所有数据库
        /// </summary>
        /// <param name="serverID"></param>
        /// <returns></returns>
        public List<string> GetDatabaseList(string serverID)
        {
            List<string> dbList = new List<string>();
            string connString = Config.GetConnectionString(serverID);
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("select name from sysdatabases", conn))
                {
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        dbList.Add(dr.GetString(0));
                    }
                    dr.Close();
                    dr.Dispose();
                }
            }
            return dbList;
        }

        /// <summary>
        /// 得到数据库所有表
        /// </summary>
        /// <param name="serverID"></param>
        /// <param name="dbName"></param>
        /// <returns></returns>
        public List<Tables> GetTables(string serverID, string dbName)
        {
            List<Tables> tblList = new List<Tables>();
            using (SqlConnection conn = new SqlConnection(Config.GetConnectionString(serverID, dbName)))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT name FROM sysobjects WHERE xtype='u' order by name", conn))
                {
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        tblList.Add(new Tables() { Name = dr.GetString(0) });
                    }
                    dr.Close();
                    dr.Dispose();
                }
            }
            return tblList;
        }

        /// <summary>
        /// 得到数据库所有视图
        /// </summary>
        /// <param name="serverID"></param>
        /// <param name="dbName"></param>
        /// <returns></returns>
        public List<Views> GetViews(string serverID, string dbName)
        {
            List<Views> viewList = new List<Views>();
            using (SqlConnection conn = new SqlConnection(Config.GetConnectionString(serverID, dbName)))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("select name from sys.views order by name", conn))
                {
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        viewList.Add(new Views() { Name = dr.GetString(0) });
                    }
                    dr.Close();
                    dr.Dispose();
                }
            }
            return viewList;
        }
        /// <summary>
        /// 得到一个表中所有字段
        /// </summary>
        /// <param name="serverID"></param>
        /// <param name="dbName"></param>
        /// <param name="tableName"></param>
        /// <returns></returns>
        public List<Fields> GetFields(string serverID, string dbName, string tableName)
        {
            List<Fields> fieldsList = new List<Fields>();
            Servers server = Config.GetServer(serverID);
            if (server == null)
            {
                return fieldsList;
            }

            using (SqlConnection conn = new SqlConnection(Config.GetConnectionString(serverID, dbName)))
            {
                conn.Open();
                string sql = string.Format(@"select a.name as f_name,b.name as t_name,[length],a.isnullable as is_null from 
                        sys.syscolumns a inner join sys.types b on b.user_type_id=a.xtype where object_id('{0}')=id order by a.colid", tableName);
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        fieldsList.Add(new Fields()
                        {
                            Name = dr.GetString(0),
                            Type = dr.GetString(1),
                            Length = GetFieldLength(dr.GetString(1), dr.GetInt16(2)),
                            IsNull = 1 == dr.GetInt32(3),
                            IsPrimaryKey = IsPrimaryKey(serverID, dbName, tableName, dr.GetString(0)),
                            IsIdentity = IsIdentity(serverID, dbName, tableName, dr.GetString(0)),
                            DotNetType = GetFieldType(dr.GetString(1), 1 == dr.GetInt32(3)),
                            DotNetSqlType = GetFieldSqlType(dr.GetString(1)),
                            Note = GetFieldNote(serverID, dbName, tableName, dr.GetString(0))
                        });
                    }
                    dr.Close();
                    dr.Dispose();
                }
            }
            return fieldsList;
        }

        /// <summary>
        /// 判断一个表的某列是否为主键
        /// </summary>
        /// <param name="serverID"></param>
        /// <param name="dbName"></param>
        /// <param name="tableName"></param>
        /// <param name="fieldName"></param>
        /// <returns></returns>
        private bool IsPrimaryKey(string serverID, string dbName, string tableName, string fieldName)
        {
            using (SqlConnection conn = new SqlConnection(Common.Config.GetConnectionString(serverID, dbName)))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "sp_pkeys";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@table_name", tableName));
                    using (SqlDataAdapter dap = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        dap.Fill(dt);
                        return dt.Select("COLUMN_NAME='" + fieldName + "'").Length > 0;
                    }
                }
            }
        }

        /// <summary>
        /// 判断一个表的某列是否为自增列
        /// </summary>
        /// <param name="serverID"></param>
        /// <param name="dbName"></param>
        /// <param name="tableName"></param>
        /// <param name="fieldName"></param>
        /// <returns></returns>
        private bool IsIdentity(string serverID, string dbName, string tableName, string fieldName)
        {
            using (SqlConnection conn = new SqlConnection(Config.GetConnectionString(serverID, dbName)))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "select COLUMNPROPERTY(object_id('" + tableName + "'),'" + fieldName + "','IsIdentity')";
                    return "1" == cmd.ExecuteScalar().ToString();
                }
            }
        }

        /// <summary>
        /// 得到一个字段的备注说明
        /// </summary>
        /// <param name="serverID"></param>
        /// <param name="dbName"></param>
        /// <param name="tableName"></param>
        /// <param name="fieldName"></param>
        /// <returns></returns>
        private string GetFieldNote(string serverID, string dbName, string tableName, string fieldName)
        {
            using (SqlConnection conn = new SqlConnection(Config.GetConnectionString(serverID, dbName)))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = @"select value from sys.extended_properties a 
                        left join sys.syscolumns b on a.major_id=b.id and a.minor_id=b.colid 
                        where a.name='MS_Description' and object_id('" + tableName + "')=a.major_id and b.name='" + fieldName + "'";
                    object obj = cmd.ExecuteScalar();
                    return obj == null ? string.Empty : obj.ToString();
                }
            }
        }

        /// <summary>
        /// 得到字段的常规类型
        /// </summary>
        /// <param name="typeName"></param>
        /// <param name="isNull"></param>
        /// <returns></returns>
        private string GetFieldType(string typeName, bool isNull)
        {
            string r = string.Empty;
            switch (typeName.Trim().ToLower())
            {
                case "varchar":
                case "nvarchar":
                case "text":
                case "ntext":
                case "char":
                case "nchar":
                case "xml":
                    r = "string";
                    break;
                case "uniqueidentifier":
                    r = isNull ? "Guid?" : "Guid";
                    break;
                case "bit":
                    r = isNull ? "bool?" : "bool";
                    break;
                case "bigint":
                    r = isNull ? "long?" : "long";
                    break;
                case "int":
                    r = isNull ? "int?" : "int";
                    break;
                case "tinyint":
                    r = isNull ? "byte?" : "byte";
                    break;
                case "smallint":
                    r = isNull ? "short?" : "short";
                    break;
                case "smallmoney":
                case "decimal":
                case "numeric":
                case "money":
                    r = isNull ? "decimal?" : "decimal";
                    break;
                case "real":
                    r = isNull ? "float?" : "float";
                    break;
                case "float":
                    r = isNull ? "double?" : "double";
                    break;
                case "date":
                case "datetime":
                case "datetime2":
                case "smalldatetime":
                case "datetimeoffset":
                    r = isNull ? "DateTime?" : "DateTime";
                    break;
            }
            return r;
        }

        /// <summary>
        /// 得到字段的SqlDbType字符串
        /// </summary>
        /// <param name="typeName"></param>
        /// <returns></returns>
        private string GetFieldSqlType(string typeName)
        {
            string r = string.Empty;
            switch (typeName)
            {
                case "varchar":
                    r = "SqlDbType.VarChar";
                    break;
                case "nvarchar":
                    r = "SqlDbType.NVarChar";
                    break;
                case "text":
                    r = "SqlDbType.Text";
                    break;
                case "ntext":
                    r = "SqlDbType.NText";
                    break;
                case "char":
                    r = "SqlDbType.Char";
                    break;
                case "nchar":
                    r = "SqlDbType.VarChar";
                    break;
                case "uniqueidentifier":
                    r = "SqlDbType.UniqueIdentifier";
                    break;
                case "bigint":
                    r = "SqlDbType.BigInt";
                    break;
                case "bit":
                    r = "SqlDbType.Bit";
                    break;
                case "int":
                    r = "SqlDbType.Int";
                    break;
                case "tinyint":
                    r = "SqlDbType.TinyInt";
                    break;
                case "smallint":
                    r = "SqlDbType.SmallInt";
                    break;
                case "smallmoney":
                    r = "SqlDbType.SmallMoney";
                    break;
                case "numeric":
                case "decimal":
                    r = "SqlDbType.Decimal";
                    break;
                case "float":
                    r = "SqlDbType.Float";
                    break;
                case "money":
                    r = "SqlDbType.Money";
                    break;
                case "real":
                    r = "SqlDbType.Real";
                    break;
                case "datetime":
                    r = "SqlDbType.DateTime";
                    break;
                case "datetime2":
                    r = "SqlDbType.DateTime2";
                    break;
                case "smalldatetime":
                    r = "SqlDbType.SmallDateTime";
                    break;
                case "date":
                    r = "SqlDbType.Date";
                    break;
                case "datetimeoffset":
                    r = "SqlDbType.DateTimeOffset";
                    break;
            }
            return r;
        }

        /// <summary>
        /// 得到字段的参数长度
        /// </summary>
        /// <param name="typeName"></param>
        /// <param name="length"></param>
        /// <returns></returns>
        private int GetFieldLength(string typeName, int length)
        {
            int r = -1;
            switch (typeName)
            {
                case "varchar":
                    r = length == -1 ? -1 : length;
                    break;
                case "nvarchar":
                    r = length == -1 ? -1 : length;
                    break;
                case "numeric":
                case "decimal":
                case "datetime":
                case "smalldatetime":
                    r = length;
                    break;
            }
            return r;
        }
    }
}
