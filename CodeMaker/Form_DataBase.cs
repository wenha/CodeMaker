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
    }
}
