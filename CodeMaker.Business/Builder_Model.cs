using CodeMaker.Common;
using CodeMaker.IData;
using CodeMaker.Model.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeMaker.Business
{
    internal class Builder_Model
    {
        private ICreateCode createInstance;
        private IDataBase databaseInstance;
        private Import import;
        public Builder_Model(DatabaseType dbType)
        {
            this.createInstance = Factory.Factory.CreateCreateCodeInstance(dbType);
            this.databaseInstance = Factory.Factory.CreateDatabaseInstance(dbType);
            this.import = new Import(dbType);
        }
        /// <summary>
        /// 得到实体层
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        public string GetModelClass(Model.CodeCreate param)
        {
            Model.Servers server = Config.GetServer(param.ServerID);
            if (server == null)
            {
                return string.Empty;
            }

            List<Model.Fields> fields = databaseInstance.GetFields(server.ID, param.DbName, param.TableName);
            StringBuilder model = new StringBuilder(import.GetImport_Model());
            model.Append("namespace " + param.NameSpace + (string.IsNullOrEmpty(param.NameSpace) ? "" : ".") + param.CNSC.Model + (string.IsNullOrEmpty(param.NameSpace1) ? "" : "." + param.NameSpace1) + "\r\n");
            model.Append("{\r\n");
            model.Append("\t[Serializable]\r\n");
            model.Append("\tpublic class " + param.ClassName + "\r\n");
            model.Append("\t{\r\n");
            foreach (var field in fields)
            {
                model.Append("\t\t/// <summary>\r\n");
                model.Append("\t\t/// " + (string.IsNullOrEmpty(field.Note) ? field.Name : field.Note) + "\r\n");
                model.Append("\t\t/// </summary>\r\n");
                model.Append("\t\t[DisplayName(\"" + (string.IsNullOrEmpty(field.Note) ? field.Name : field.Note) + "\")]\r\n");
                model.Append("\t\tpublic " + field.DotNetType + " " + field.Name + " { get; set; }\r\n\r\n");
            }
            model.Append("\t}\r\n");
            model.Append("}\r\n");
            return model.ToString();
        }
    }
}
