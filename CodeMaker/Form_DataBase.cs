using CodeMaker.Common;
using CodeMaker.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CodeMaker.Model.Enum;
using CodeMaker.Business;

namespace CodeMaker
{
    public partial class Form_DataBase : Form
    {
        private delegate void AddTreeNode(bool refresh);

        public Form_DataBase()
        {
            InitializeComponent();
        }

        private void Form_DataBase_Load(object sender, EventArgs e)
        {
            //不捕获对错误线程的调用
            Form.CheckForIllegalCrossThreadCalls = false;

            var serverList = new Config_Servers().GetAll();

            foreach (var server in serverList)
            {
                Servers ser = new Servers();
                ser.DatabaseName = server.Database;
                ser.ID = server.Name;
                ser.Name = server.ServerName;
                ser.Password = server.Pwd;
                ser.Port = server.Port.IsInt() ? server.Port.ToInt() : -1;
                ser.Server = server.ServerName;

                ser.Type = Enum.TryParse(server.Type, out DatabaseType dbType) ? dbType : DatabaseType.Empty;
                ser.UserID = server.Uid;

                Config.AddServerList(ser);

                TreeNode rootNode = new TreeNode();
                rootNode.Name = server.Name;
                rootNode.Text = string.Format("{0}({1}{2})", server.ServerName, server.Type.ToString(), server.Uid.IsNullOrEmpty() ? "" : string.Format("-{0}", server.Uid));
                rootNode.ImageIndex = 0;
                rootNode.SelectedImageIndex = 0;
                rootNode.Tag = new TreeNodeTag() { Type = TreeNodeType.Server, Tag = ser };

                ServerTreeView.Nodes.Add(rootNode);
            }
        }

        private void toolBtnAdd_Click(object sender, EventArgs e)
        {
            Form_AddDatabase f_add = new Form_AddDatabase();
            f_add.ShowDialog();
        }

        /// <summary>
        /// 树形列表中添加一个服务器
        /// </summary>
        /// <param name="serverID"></param>
        public void AddServer(string serverID)
        {
            Servers server = Config.GetServer(serverID);

            if (server == null)
            {
                return;
            }

            ServerTreeView.Nodes.RemoveByKey(server.ID);

            TreeNode RootNode = new TreeNode()
            {
                Name = server.ID,
                Text = string.Format("{0}({1}{2})", server.Name, server.Type.ToString(), server.UserID.IsNullOrEmpty() ? "" : string.Format("-{0}", server.UserID)),
                ImageIndex = 0,
                SelectedImageIndex = 0,
                Tag = new TreeNodeTag()
                {
                    Type = TreeNodeType.Server,
                    Tag = server
                },
            };

            ServerTreeView.Nodes.Add(RootNode);
            Database dataBase = new Database(server.Type);

            List<string> dbList = dataBase.GetDatabases(serverID);
            foreach (var db in dbList)
            {
                TreeNode dbNode = new TreeNode()
                {
                    Name = db,
                    Text = db,
                    Tag = new TreeNodeTag()
                    {
                        Type = TreeNodeType.DataBase,
                        Tag = db
                    },
                    ImageIndex = 1,
                    SelectedImageIndex = 1
                };

                RootNode.Nodes.Add(dbNode);

                TreeNode tbNode = new TreeNode()
                {
                    Name = "表",
                    Text = "表",
                    Tag = new TreeNodeTag()
                    {
                        Type = TreeNodeType.TableNode,
                        Tag = db
                    },
                    ImageIndex = 4,
                    SelectedImageIndex = 4
                };

                dbNode.Nodes.Add(tbNode);

                TreeNode viNode = new TreeNode()
                {
                    Name = "视图",
                    Text = "视图",
                    Tag = new TreeNodeTag()
                    {
                        Type = TreeNodeType.ViewNode,
                        Tag = db
                    },
                    ImageIndex = 4,
                    SelectedImageIndex = 4
                };

                dbNode.Nodes.Add(viNode);
            }
            RootNode.Expand();

            Main.Instance.ShowServerList();
        }
    }
}
