using CodeMaker.Common;
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

            var serverList = new Config.get
        }
    }
}
