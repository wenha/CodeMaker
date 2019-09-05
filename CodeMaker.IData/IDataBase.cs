using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeMaker.Model;

namespace CodeMaker.IData
{
    public interface IDataBase
    {
        /// <summary>
        /// 测试数据库连接
        /// </summary>
        /// <param name="serverID">连接字符串</param>
        /// <param name="errMessage">错误信息</param>
        /// <returns></returns>
        bool TestDatabaseConnection(string serverID, out string errMessage);

        /// <summary>
        /// 得到服务器所有数据库
        /// </summary>
        /// <param name="serverID"></param>
        /// <returns></returns>
        List<string> GetDatabaseList(string serverID);

        /// <summary>
        /// 得到数据库所有表
        /// </summary>
        /// <param name="serverID"></param>
        /// <param name="dbName"></param>
        /// <returns></returns>
        List<Tables> GetTables(string serverID, string dbName);

        /// <summary>
        /// 得到数据库所有视图
        /// </summary>
        /// <param name="serverID"></param>
        /// <param name="dbName"></param>
        /// <returns></returns>
        List<Views> GetViews(string serverID, string dbName);

        /// <summary>
        /// 得到一个表中所有字段
        /// </summary>
        /// <param name="serverID"></param>
        /// <param name="dbName"></param>
        /// <param name="tableName"></param>
        /// <returns></returns>
        List<Fields> GetFields(string serverID, string dbName, string tableName);
    }
}
