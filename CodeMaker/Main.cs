using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            form_DataBase.TopLevel = false;
            form_DataBase.Dock = DockStyle.Left;
            form_DataBase.FormBorderStyle = FormBorderStyle.None;

            splitContainer1.Panel1.Controls.Add(form_DataBase);
            form_DataBase.Show();
        }

        public void ShowServerList()
        {
            if (form_DataBase == null)
            {
                form_DataBase = new Form_DataBase();
                form_DataBase.TopLevel = false;
                form_DataBase.Dock = DockStyle.Left;
                form_DataBase.FormBorderStyle = FormBorderStyle.None;

                splitContainer1.Panel1.Controls.Add(form_DataBase);
                form_DataBase.Show();
            }
            form_DataBase.Activate();
        }
    }
}
