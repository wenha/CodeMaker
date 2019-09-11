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

        private void serverTreeView_DoubleClick(object sender, EventArgs e)
        {
            AddTreeNode addNode = new AddTreeNode(AddNodes);
            this.ServerTreeView.BeginInvoke(addNode, false);
        }

        /// <summary>
        /// 加载下一级节点
        /// </summary>
        /// <param name="isRefresh"></param>
        private void AddNodes(bool isRefresh = false)
        {
            TreeNode selNode = ServerTreeView.SelectedNode;
            if (selNode == null)
            {
                return;
            }

            if (selNode.Nodes.Count > 0 && !isRefresh)
            {
                return;
            }

            selNode.Nodes.Clear();
            TreeNode rootNode = GetRoot(selNode);
            if (rootNode == null)
            {
                return;
            }

            TreeNodeTag rootNodeTag = (TreeNodeTag)rootNode.Tag;
            if (!(rootNodeTag.Tag is Servers))
            {
                return;
            }

            Servers server = (Servers)rootNodeTag.Tag;
            TreeNodeTag nodeTag = (TreeNodeTag)selNode.Tag;
            Database dataBase = new Database(server.Type);

            if (!dataBase.TestDatabaseConnnection(server.ID, out string msg))
            {
                MessageBox.Show(msg, "连接失败", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            switch (nodeTag.Type)
            {
                case TreeNodeType.Server:
                    var dbs = dataBase.GetDatabases(server.ID);
                    foreach (var db in dbs)
                    {
                        TreeNode dbNode = new TreeNode()
                        {
                            Name = db,
                            Text = db,
                            ImageIndex = 1,
                            SelectedImageIndex = 1,
                            Tag = new TreeNodeTag()
                            {
                                Type = TreeNodeType.DataBase,
                                Tag = db
                            }
                        };
                        selNode.Nodes.Add(dbNode);
                    }
                    break;
                case TreeNodeType.DataBase:
                    //添加表节点
                    TreeNode tblNode = new TreeNode()
                    {
                        Name = "表",
                        Text = "表",
                        Tag = new Model.TreeNodeTag() { Type = TreeNodeType.TableNode, Tag = nodeTag.Tag.ToString() },
                        ImageIndex = 4,
                        SelectedImageIndex = 4
                    };
                    selNode.Nodes.Add(tblNode);

                    //添加视图节点
                    TreeNode viewNode = new TreeNode()
                    {
                        Name = "视图",
                        Text = "视图",
                        Tag = new Model.TreeNodeTag() { Type = TreeNodeType.ViewNode, Tag = nodeTag.Tag.ToString() },
                        ImageIndex = 4,
                        SelectedImageIndex = 4
                    };
                    selNode.Nodes.Add(viewNode);
                    break;
                case TreeNodeType.TableNode: //表节点加载表
                    var tables = dataBase.GetTables(server.ID, nodeTag.Tag.ToString());
                    foreach (var table in tables)
                    {
                        TreeNode tblNode1 = new TreeNode();
                        tblNode1.Name = table.Name;
                        tblNode1.Text = table.Name;
                        tblNode1.ImageIndex = 2;
                        tblNode1.SelectedImageIndex = 2;
                        tblNode1.Tag = new Model.TreeNodeTag() { Type = TreeNodeType.Table, Tag = table.Name };
                        selNode.Nodes.Add(tblNode1);
                    }
                    break;
                case TreeNodeType.ViewNode: //视图节点加载视图
                    var views = dataBase.GetViews(server.ID, nodeTag.Tag.ToString());
                    foreach (var view in views)
                    {
                        TreeNode viewNode1 = new TreeNode();
                        viewNode1.Name = view.Name;
                        viewNode1.Text = view.Name;
                        viewNode1.ImageIndex = 2;
                        viewNode1.SelectedImageIndex = 2;
                        viewNode1.Tag = new Model.TreeNodeTag() { Type = TreeNodeType.View, Tag = view.Name };
                        selNode.Nodes.Add(viewNode1);
                    }
                    break;
                case TreeNodeType.View:
                case TreeNodeType.Table: //表加载字段
                    var fields = dataBase.GetFields(server.ID, ((Model.TreeNodeTag)selNode.Parent.Tag).Tag.ToString(), ((Model.TreeNodeTag)selNode.Tag).Tag.ToString());
                    foreach (var field in fields)
                    {
                        TreeNode fldNode = new TreeNode();
                        fldNode.Name = field.Name;
                        fldNode.Text = string.Format("{0}({1}{2},{3})", field.Name, field.Type, field.Length != -1 ? "(" + field.Length.ToString() + ")" : "", field.IsNull ? "null" : "not null");
                        fldNode.ImageIndex = field.IsPrimaryKey ? 5 : 3;
                        fldNode.SelectedImageIndex = field.IsPrimaryKey ? 5 : 3;
                        fldNode.Tag = new Model.TreeNodeTag() { Type = TreeNodeType.Field, Tag = field };
                        selNode.Nodes.Add(fldNode);
                    }
                    break;
            }
            selNode.Expand();
        }

        /// <summary>
        /// 得到节点的根节点
        /// </summary>
        /// <param name="node"></param>
        /// <returns></returns>
        public TreeNode GetRoot(TreeNode node)
        {
            TreeNode node1 = node;
            while (node1.Parent != null)
            {
                node1 = node1.Parent;
            }

            return node1;
        }
    }
}
