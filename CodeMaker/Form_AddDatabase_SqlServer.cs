using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CodeMaker.Business;
using CodeMaker.Common;
using CodeMaker.Model;
using CodeMaker.Model.Enum;

namespace CodeMaker
{
    public partial class Form_AddDatabase_SqlServer : Form
    {
        private DatabaseType dbType;

        private Database DatabaseBll = null;

        private IEnumerable<ConfigServers> serverList;

        public Form_AddDatabase_SqlServer(DatabaseType dbType)
        {
            InitializeComponent();
            this.dbType = dbType;
            this.DatabaseBll = new Database(dbType);
        }

        private void btn_SqlServer_Preview_Click(object sender, EventArgs e)
        {
            Form_AddDatabase fa = new Form_AddDatabase();

            fa.ShowDialog();
            
            this.Close();
        }

        private void Form_AddDatabase_SqlServer_Load(object sender, EventArgs e)
        {
            Config_Servers configServer = new Config_Servers();

            serverList = configServer.GetAll().Where(s => s.Type == this.dbType.ToString());

            foreach (var server in serverList)
            {
                this.cBtn_SqlServer_ServerName.Items.Add(server.ServerName);
            }

            ConfigServers defaultServer = configServer.GetDefault(this.dbType);
            if (defaultServer != null)
            {
                this.cBtn_SqlServer_ServerName.Text = defaultServer.ServerName;
                this.tBox_SqlServer_Pwd.Text = defaultServer.Pwd;
                this.tBox_SqlServer_UserName.Text = defaultServer.Uid;
                this.cBox_SqlServer_Remenber.Checked = !defaultServer.Pwd.IsNullOrEmpty();
            }
        }

        /// <summary>
        /// 测试连接
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_SqlServer_Test_Click(object sender, EventArgs e)
        {
            this.btn_SqlServer_Test.Text = "测试中.....";
            this.btn_SqlServer_Test.Enabled = false;

            if (!test_link_sqlServer(out string msg))
            {
                MessageBox.Show(msg, "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("连接成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            this.btn_SqlServer_Test.Text = "测试连接";
            this.btn_SqlServer_Test.Enabled = true;
        }

        /// <summary>
        /// 测试服务器连接
        /// </summary>
        /// <param name="msg"></param>
        /// <returns></returns>
        private bool test_link_sqlServer(out string msg)
        {
            msg = string.Empty;
            string server = this.cBtn_SqlServer_ServerName.Text;
            string userId = this.tBox_SqlServer_UserName.Text;
            string pwd = this.tBox_SqlServer_Pwd.Text;

            if (string.IsNullOrEmpty(server))
            {
                msg = "服务器不能为空";
                return false;
            }

            if (string.IsNullOrEmpty(userId))
            {
                msg = "登录名不能为空";
                return false;
            }

            if (string.IsNullOrEmpty(pwd))
            {
                msg = "密码不能为空";
                return false;
            }

            Config.AddServerList(new Servers()
            {
                ID = string.Format("{0}({1})", server.Trim(), dbType.ToString()),
                Name = server.Trim(),
                Type = dbType,
                DatabaseName = "",
                Server = server.Trim(),
                UserID = userId.Trim(),
                Password = pwd.Trim()
            });

            return DatabaseBll.TestDatabaseConnnection(string.Format("{0}({1})", server.Trim(), dbType.ToString()), out msg);
        }

        private void btn_SqlServer_Add_Click(object sender, EventArgs e)
        {
            if (!test_link_sqlServer(out string msg))
            {
                MessageBox.Show(msg, "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                Main.form_DataBase.AddServer(string.Format("{0}({1})", this.cBtn_SqlServer_ServerName.Text.Trim(),
                    dbType.ToString()));
                this.Close();
                AddServer();
            }
        }

        private void AddServer()
        {
            string serverName = this.cBtn_SqlServer_ServerName.Text;
            string userId = this.tBox_SqlServer_UserName.Text;
            string pwd = this.tBox_SqlServer_Pwd.Text;

            ConfigServers server = new ConfigServers()
            {
                Name = string.Format("{0}({1})",serverName,dbType.ToString()),
                Port = "",
                Database = "",
                file = "",
                Pwd = this.cBox_SqlServer_Remenber.Checked?pwd:"",
                ServerName = serverName,
                Type = dbType.ToString(),
                Uid = userId
            };
            Form_AddDatabase.AddServerToXml(server);
        }
    }
}
