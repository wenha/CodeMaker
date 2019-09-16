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

namespace CodeMaker
{
    public partial class Form_Config_NameSpace : Form
    {
        private Config_NameSpace config_NameSpace = new Config_NameSpace();

        public Form_Config_NameSpace()
        {
            InitializeComponent();
        }

        private void ShowList()
        {
            this.listView1.Items.Clear();

            var nlist = config_NameSpace.GetAll();
            foreach (var list in nlist)
            {
                this.listView1.Items.Add(new ListViewItem(new string[] { list.Name1, list.Name2 }));
            }
        }

        private void nameSpace_Btn_Add_Click(object sender, EventArgs e)
        {
            ConfigNameSpace cns = GetModel();

            if (cns != null)
            {
                if (config_NameSpace.Add(cns))
                {
                    MessageBox.Show("添加成功!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ShowList();
                }
            }
            else
            {
                MessageBox.Show("添加失败!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private ConfigNameSpace GetModel()
        {
            string n1 = this.nameSpace_tb_nameSpace1.Text;
            string n2 = this.nameSpace_tb_nameSpace2.Text;

            if (string.IsNullOrEmpty(n1))
            {
                MessageBox.Show("命名空间不能为空", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);

                return null;
            }

            ConfigNameSpace cns = new ConfigNameSpace()
            {
                Name1 = n1.Trim(),
                Name2 = n2.Trim()
            };

            return cns;
        }

        private void Form_Config_NameSpace_Load(object sender, EventArgs e)
        {
            ShowList();
        }

        private void nameSpace_Btn_Refresh_Click(object sender, EventArgs e)
        {
            ShowList();
        }

        private void nameSpace_Btn_Save_Click(object sender, EventArgs e)
        {
            var items = listView1.SelectedItems;
            if (items.Count == 0)
            {
                return;
            }
            var item = items[0];

            ConfigNameSpace cns = GetModel();
            if (cns != null)
            {
                if (config_NameSpace.Save(cns, item.SubItems[0].Text))
                {
                    MessageBox.Show("保存成功!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ShowList();
                }
                else
                {
                    MessageBox.Show("保存失败!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void nameSpace_Btn_Delete_Click(object sender, EventArgs e)
        {
            if (this.nameSpace_tb_nameSpace1.Text.IsNullOrEmpty())
            {
                MessageBox.Show("您没有选择要删除的项!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (config_NameSpace.Delete(this.nameSpace_tb_nameSpace1.Text.Trim()))
            {
                MessageBox.Show("删除成功!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ShowList();
            }
            else
            {
                MessageBox.Show("删除失败!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
