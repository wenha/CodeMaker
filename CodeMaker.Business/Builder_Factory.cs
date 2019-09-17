using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeMaker.IData;
using CodeMaker.Model;
using CodeMaker.Model.Enum;

namespace CodeMaker.Business
{
    internal class Builder_Factory
    {
        private ICreateCode createInstance;
        private IDataBase databaseInstance;
        private Import import;

        public Builder_Factory(DatabaseType dbType)
        {
            this.createInstance = Factory.Factory.CreateCreateCodeInstance(dbType);
            this.databaseInstance = Factory.Factory.CreateDatabaseInstance(dbType);
            this.import = new Import(dbType);
        }

        /// <summary>
        /// 得到工厂层代码
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        public string GetFactoryClass(CodeCreate param)
        {
            Servers server = Common.Config.GetServer(param.ServerID);
            if (server == null)
            {
                return string.Empty;
            }
            List<Fields> fields = databaseInstance.GetFields(server.ID, param.DbName, param.TableName);

            StringBuilder factory = new StringBuilder(import.GetImport_Factory());
            factory.Append("namespace " + param.NameSpace + (string.IsNullOrEmpty(param.NameSpace) ? "" : ".") + param.CNSC.Factory + (string.IsNullOrEmpty(param.NameSpace1) ? "" : "." + param.NameSpace1) + "\r\n");
            factory.Append("{\r\n");

            factory.Append("\tpublic class " + param.ClassName + "\r\n");
            factory.Append("\t{\r\n");
            factory.Append("\t\t/// <summary>\r\n");
            factory.Append("\t\t/// 创建实例对象\r\n");
            factory.Append("\t\t/// </summary>\r\n");
            factory.Append("\t\tpublic static " + param.NameSpace + (string.IsNullOrEmpty(param.NameSpace) ? "" : ".") + param.CNSC.Interface + (string.IsNullOrEmpty(param.NameSpace1) ? "" : "." + param.NameSpace1) + ".I" + param.ClassName + " CreateInstance()\r\n"); ;
            factory.Append("\t\t{\r\n");
            factory.Append("\t\t\treturn Factory.CreateInstance(\"" + param.ClassName + "\") as " + param.CNSC.Interface + ".I" + param.ClassName + ";\r\n");
            factory.Append("\t\t}\r\n");
            factory.Append("\t}\r\n");
            factory.Append("}\r\n");

            return factory.ToString();
        }
    }
}
