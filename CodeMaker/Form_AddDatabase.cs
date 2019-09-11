using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CodeMaker.Common;
using CodeMaker.Model;
using CodeMaker.Model.Enum;

namespace CodeMaker
{
    public partial class Form_AddDatabase : Form
    {
        private DatabaseType DatabaseType = DatabaseType.Empty;

        public Form_AddDatabase()
        {
            InitializeComponent();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            initDatabaseType();

            switch (DatabaseType)
            {
                case DatabaseType.SqlServer2000:
                case DatabaseType.SqlServer2008:
                case DatabaseType.SqlServer2005:
                    this.Close();
                    Form_AddDatabase_SqlServer fasql = new Form_AddDatabase_SqlServer(DatabaseType.SqlServer2000);
                    fasql.ShowDialog();
                    break;
            }
        }

        private void initDatabaseType()
        {
            if (this.rBtn_SqlServer.Checked)
            {
                DatabaseType = DatabaseType.SqlServer2000;
            }
        }

        private void Form_AddDatabase_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 保存服务器至配置文件
        /// </summary>
        /// <param name="configServer"></param>
        public static void AddServerToXml(ConfigServers configServer)
        {
            new Config_Servers().Add(configServer);
        }
    }
}
