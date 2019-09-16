namespace CodeMaker
{
    partial class Form_Config_NameSpace
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.nameSpace_tb_nameSpace1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nameSpace_tb_nameSpace2 = new System.Windows.Forms.TextBox();
            this.nameSpace_Btn_Add = new System.Windows.Forms.Button();
            this.nameSpace_Btn_Save = new System.Windows.Forms.Button();
            this.nameSpace_Btn_Delete = new System.Windows.Forms.Button();
            this.nameSpace_Btn_Refresh = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "命名空间：";
            // 
            // nameSpace_tb_nameSpace1
            // 
            this.nameSpace_tb_nameSpace1.Location = new System.Drawing.Point(83, 12);
            this.nameSpace_tb_nameSpace1.Name = "nameSpace_tb_nameSpace1";
            this.nameSpace_tb_nameSpace1.Size = new System.Drawing.Size(120, 21);
            this.nameSpace_tb_nameSpace1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(229, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "二级命名空间：";
            // 
            // nameSpace_tb_nameSpace2
            // 
            this.nameSpace_tb_nameSpace2.Location = new System.Drawing.Point(324, 12);
            this.nameSpace_tb_nameSpace2.Name = "nameSpace_tb_nameSpace2";
            this.nameSpace_tb_nameSpace2.Size = new System.Drawing.Size(160, 21);
            this.nameSpace_tb_nameSpace2.TabIndex = 3;
            // 
            // nameSpace_Btn_Add
            // 
            this.nameSpace_Btn_Add.BackColor = System.Drawing.SystemColors.Control;
            this.nameSpace_Btn_Add.Location = new System.Drawing.Point(50, 54);
            this.nameSpace_Btn_Add.Name = "nameSpace_Btn_Add";
            this.nameSpace_Btn_Add.Size = new System.Drawing.Size(75, 23);
            this.nameSpace_Btn_Add.TabIndex = 4;
            this.nameSpace_Btn_Add.Text = "添加";
            this.nameSpace_Btn_Add.UseVisualStyleBackColor = false;
            this.nameSpace_Btn_Add.Click += new System.EventHandler(this.nameSpace_Btn_Add_Click);
            // 
            // nameSpace_Btn_Save
            // 
            this.nameSpace_Btn_Save.BackColor = System.Drawing.SystemColors.Control;
            this.nameSpace_Btn_Save.Location = new System.Drawing.Point(155, 54);
            this.nameSpace_Btn_Save.Name = "nameSpace_Btn_Save";
            this.nameSpace_Btn_Save.Size = new System.Drawing.Size(75, 23);
            this.nameSpace_Btn_Save.TabIndex = 5;
            this.nameSpace_Btn_Save.Text = "保存";
            this.nameSpace_Btn_Save.UseVisualStyleBackColor = false;
            this.nameSpace_Btn_Save.Click += new System.EventHandler(this.nameSpace_Btn_Save_Click);
            // 
            // nameSpace_Btn_Delete
            // 
            this.nameSpace_Btn_Delete.BackColor = System.Drawing.SystemColors.Control;
            this.nameSpace_Btn_Delete.Location = new System.Drawing.Point(260, 54);
            this.nameSpace_Btn_Delete.Name = "nameSpace_Btn_Delete";
            this.nameSpace_Btn_Delete.Size = new System.Drawing.Size(75, 23);
            this.nameSpace_Btn_Delete.TabIndex = 6;
            this.nameSpace_Btn_Delete.Text = "删除";
            this.nameSpace_Btn_Delete.UseVisualStyleBackColor = false;
            this.nameSpace_Btn_Delete.Click += new System.EventHandler(this.nameSpace_Btn_Delete_Click);
            // 
            // nameSpace_Btn_Refresh
            // 
            this.nameSpace_Btn_Refresh.BackColor = System.Drawing.SystemColors.Control;
            this.nameSpace_Btn_Refresh.Location = new System.Drawing.Point(365, 54);
            this.nameSpace_Btn_Refresh.Name = "nameSpace_Btn_Refresh";
            this.nameSpace_Btn_Refresh.Size = new System.Drawing.Size(75, 23);
            this.nameSpace_Btn_Refresh.TabIndex = 7;
            this.nameSpace_Btn_Refresh.Text = "刷新";
            this.nameSpace_Btn_Refresh.UseVisualStyleBackColor = false;
            this.nameSpace_Btn_Refresh.Click += new System.EventHandler(this.nameSpace_Btn_Refresh_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listView1.Location = new System.Drawing.Point(14, 92);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(480, 209);
            this.listView1.TabIndex = 8;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "一级命名空间";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "二级命名空间";
            // 
            // Form_Config_NameSpace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 313);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.nameSpace_Btn_Refresh);
            this.Controls.Add(this.nameSpace_Btn_Delete);
            this.Controls.Add(this.nameSpace_Btn_Save);
            this.Controls.Add(this.nameSpace_Btn_Add);
            this.Controls.Add(this.nameSpace_tb_nameSpace2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nameSpace_tb_nameSpace1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form_Config_NameSpace";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "命名空间设置";
            this.Load += new System.EventHandler(this.Form_Config_NameSpace_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nameSpace_tb_nameSpace1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nameSpace_tb_nameSpace2;
        private System.Windows.Forms.Button nameSpace_Btn_Add;
        private System.Windows.Forms.Button nameSpace_Btn_Save;
        private System.Windows.Forms.Button nameSpace_Btn_Delete;
        private System.Windows.Forms.Button nameSpace_Btn_Refresh;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
    }
}