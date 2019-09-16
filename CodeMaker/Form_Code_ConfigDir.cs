using CodeMaker.Common;
using CodeMaker.Model;
using CodeMaker.Model.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeMaker
{
    public partial class Form_Code_ConfigDir : Form
    {
        public Form_Code_ConfigDir()
        {
            InitializeComponent();
        }

        private void configDir_Btn_OpenFolder_Click(object sender, EventArgs e)
        {
            this.folderBrowserDialog.ShowDialog();
            this.configDir_tb_OutputDir.Text = this.folderBrowserDialog.SelectedPath;
        }

        private void configDir_btn_Build_Click(object sender, EventArgs e)
        {
            this.configDir_btn_Build.Enabled = false;

            if (!this.configDir_tb_OutputDir.Text.IsPath())
            {
                MessageBox.Show("项目目录为空或不合法", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.configDir_btn_Build.Enabled = true;
                return;
            }

            AddDirectory();
            AddNameSpace();

            System.Threading.Thread th = new System.Threading.Thread(CreateToDir);
            th.Start();
        }

        private void configDir_Btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form_Code_ConfigDir_Load(object sender, EventArgs e)
        {
            Form.CheckForIllegalCrossThreadCalls = false;
            this.configDir_label_progress.Text = "";

            ConfigNameSpace cns = new Config_NameSpace().GetDefault();
            if (cns != null)
            {

            }

            var dirDefault = new Config_Directory().GetDefault();
            if (dirDefault != null)
            {
                this.configDir_tb_OutputDir.Text = dirDefault.Name;
            }
        }

        private void AddDirectory()
        {
            new Config_Directory().Add(new ConfigDirectory() { Name = this.configDir_tb_OutputDir.Text.Trim() });
        }

        private void AddNameSpace()
        {
            new Config_NameSpace().Add(new ConfigNameSpace() { Name1 = "", Name2 = "" });
        }

        private void CreateToDir()
        {
            List<TreeNode> NodeList = Main.form_DataBase.GetTreeViewSelected();
            if (NodeList.Count == 0)
            {
                return;
            }
            TreeNode serverNode = Main.form_DataBase.GetRoot(NodeList.First());
            TreeNode dbNode = NodeList.First().Parent.Parent;

            List<BuilderMethods> methods = new List<BuilderMethods>();
            if (configDir_cb_Add.Checked)
            {
                methods.Add(BuilderMethods.Add);
            }
            if (configDir_cb_GetAll.Checked)
            {
                methods.Add(BuilderMethods.SelectAll);
            }
            Servers server = (Servers)((TreeNodeTag)serverNode.Tag).Tag;
            Business.CreateCode CreateCode = new Business.CreateCode(server.Type);
            CodeCreate param = new CodeCreate();

            param.DbName = ((TreeNodeTag)dbNode.Tag).Tag.ToString();
            param.NameSpace = "";
            param.NameSpace1 = "";
            param.ServerID = server.ID;
            param.BuilderType = BuilderType.Default;
            param.MethodList = methods;
            param.CNSC = new Config_NameSpaceClass().GetDefault();

            Business.CreateCode CreateCodeInstince = new Business.CreateCode(server.Type);
            StreamWriter sw;
            string FileName = string.Empty;
            foreach (TreeNode node in NodeList)
            {
                param.TableName = ((TreeNodeTag)node.Tag).Tag.ToString();
                param.ClassName = param.TableName;

                //生成实体类
                FileName = Func.ExistsDirectory(string.Format("{0}\\{1}.{2}\\{3}{4}.cs", configDir_tb_OutputDir.Text, param.NameSpace, param.CNSC.Model, param.NameSpace1.IsNullOrEmpty() ? "" : param.NameSpace1 + "\\", param.ClassName));
                sw = File.CreateText(FileName);
                sw.Write(CreateCodeInstince.GetModelClass(param));
                sw.Close();
                sw.Dispose();
                configDir_label_progress.Text = string.Format("生成文件:{0}", FileName);

                //生成数据类
                FileName = Func.ExistsDirectory(string.Format("{0}\\{1}.{2}\\{3}{4}.cs", configDir_tb_OutputDir.Text, param.NameSpace, param.CNSC.Data, param.NameSpace1.IsNullOrEmpty() ? "" : param.NameSpace1 + "\\", param.ClassName));
                sw = File.CreateText(FileName);
                sw.Write(CreateCodeInstince.GetDataClass(param));
                sw.Close();
                sw.Dispose();
                configDir_label_progress.Text = string.Format("生成文件:{0}", FileName);

                //生成业务类
                FileName = Func.ExistsDirectory(string.Format("{0}\\{1}.{2}\\{3}{4}.cs", configDir_tb_OutputDir.Text, param.NameSpace, param.CNSC.Business, param.NameSpace1.IsNullOrEmpty() ? "" : param.NameSpace1 + "\\", param.ClassName));
                sw = File.CreateText(FileName);
                sw.Write(CreateCodeInstince.GetBusinessClass(param));
                sw.Close();
                sw.Dispose();
                configDir_label_progress.Text = string.Format("生成文件:{0}", FileName);

                if (param.BuilderType == BuilderType.Factory)
                {
                    //生成接口类
                    FileName = Func.ExistsDirectory(string.Format("{0}\\{1}.{2}\\{3}{4}.cs", configDir_tb_OutputDir.Text, param.NameSpace, param.CNSC.Interface, param.NameSpace1.IsNullOrEmpty() ? "" : param.NameSpace1 + "\\", param.ClassName));
                    sw = File.CreateText(FileName);
                    sw.Write(CreateCodeInstince.GetInterfaceClass(param));
                    sw.Close();
                    sw.Dispose();
                    configDir_label_progress.Text = string.Format("生成文件:{0}", FileName);

                    //生成工厂类
                    FileName = Func.ExistsDirectory(string.Format("{0}\\{1}.{2}\\{3}{4}.cs", configDir_tb_OutputDir.Text, param.NameSpace, param.CNSC.Factory, param.NameSpace1.IsNullOrEmpty() ? "" : param.NameSpace1 + "\\", param.ClassName));
                    sw = File.CreateText(FileName);
                    sw.Write(CreateCodeInstince.GetFactoryClass(param));
                    sw.Close();
                    sw.Dispose();
                    configDir_label_progress.Text = string.Format("生成文件:{0}", FileName);
                }
            }
            MessageBox.Show("生成完成!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.configDir_label_progress.Text = "生成已完成";
            this.configDir_btn_Build.Enabled = true;
        }
    }
}
