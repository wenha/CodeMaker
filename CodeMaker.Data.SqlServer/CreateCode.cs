using CodeMaker.Common;
using CodeMaker.IData;
using CodeMaker.Model;
using CodeMaker.Model.Enum;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeMaker.Data.SqlServer
{
    public class CreateCode : ICreateCode
    {
        /// <summary>
        /// 得到数据层命名空间
        /// </summary>
        /// <returns></returns>
        public string GetDataNameSpace()
        {
            return "System.Data.SqlClient";
        }

        /// <summary>
        /// 得到参数名称
        /// </summary>
        /// <returns></returns>
        public string GetParamsName(string name)
        {
            return string.Format("@{0}", name);
        }

        /// <summary>
        /// 得到参数名称(实例化参数时用的名称)
        /// </summary>
        /// <returns></returns>
        public string GetParamsName1(string name)
        {
            return string.Format("@{0}", name);
        }

        /// <summary>
        /// 得到参数类型
        /// </summary>
        /// <returns></returns>
        public string GetParamsType()
        {
            return "SqlParameter";
        }

        /// <summary>
        /// 得到DataReader类型
        /// </summary>
        /// <returns></returns>
        public string GetDataReaderType()
        {
            return "SqlDataReader";
        }

        /// <summary>
        /// 查询自增ID的方法
        /// </summary>
        /// <returns></returns>
        public string GetIdentityMethod()
        {
            return "SCOPE_IDENTITY()";
        }
    }
}
