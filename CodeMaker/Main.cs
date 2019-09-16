using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace CodeMaker
{
    public partial class Main : Form
    {
        public static Main Instance;

        public static Form_DataBase form_DataBase = null;

        public static Form_Home form_Home = null;

        public static Form_TemplateTree from_TemplateTree = null;


        public Main()
        {
            InitializeComponent();
            Instance = this;
        }

        private void Main_Load(object sender, EventArgs e)
        {
            form_DataBase = new Form_DataBase();
            form_DataBase.Show(mainPanel, DockState.DockLeft);

            form_Home = new Form_Home();
            form_Home.Show(mainPanel);
            form_Home.Activate();
        }

        public void ShowServerList()
        {
            if (form_DataBase == null)
            {
                form_DataBase = new Form_DataBase();
                form_DataBase.Show(mainPanel, DockState.DockLeftAutoHide);
            }
            form_DataBase.Activate();
        }

        public void ShowHome()
        {
            if (form_Home == null)
            {
                form_Home = new Form_Home();
                form_Home.Show(mainPanel);
            }
            form_Home.Activate();
        }

        private void toolBtn_Home_Click(object sender, EventArgs e)
        {
            ShowHome();
        }

        private void toolBtn_Server_Click(object sender, EventArgs e)
        {
            ShowServerList();
        }

        private void toolBtn_AddDatabase_Click(object sender, EventArgs e)
        {
            form_DataBase.toolBtnAdd_Click(sender, e);
        }

        private void toolBtn_DelDatabase_Click(object sender, EventArgs e)
        {
            form_DataBase.RemoveServer();
        }

        private void toolStripMenu_Server_Add_Click(object sender, EventArgs e)
        {
            form_DataBase.toolBtnAdd_Click(sender, e);
        }

        private void toolStripMenu_Server_Delete_Click(object sender, EventArgs e)
        {
            form_DataBase.RemoveServer();
        }

        private void toolStripMenu_Server_Exit_Click(object sender, EventArgs e)
        {
            Exit();
        }

        /// <summary>
        /// 退出系统
        /// </summary>
        private void Exit()
        {
            Application.Exit();
        }

        private void toolStripMenu_Help_About_Click(object sender, EventArgs e)
        {
            Form_About fa = new Form_About();
            fa.ShowDialog();
        }

        private void toolStripMenu_Config_NameSpace_Click(object sender, EventArgs e)
        {
            Form_Config_NameSpace fcn = new Form_Config_NameSpace();
            fcn.ShowDialog();
        }

        private void toolStripMenu_Build_Folder_Click(object sender, EventArgs e)
        {
            form_DataBase.ShowCodeDir();
        }
    }
}
