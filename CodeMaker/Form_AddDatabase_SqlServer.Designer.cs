namespace CodeMaker
{
    partial class Form_AddDatabase_SqlServer
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_SqlServer_Add = new System.Windows.Forms.Button();
            this.btn_SqlServer_Test = new System.Windows.Forms.Button();
            this.btn_SqlServer_Preview = new System.Windows.Forms.Button();
            this.cBox_SqlServer_Remenber = new System.Windows.Forms.CheckBox();
            this.tBox_SqlServer_Pwd = new System.Windows.Forms.TextBox();
            this.tBox_SqlServer_UserName = new System.Windows.Forms.TextBox();
            this.cBtn_SqlServer_ServerName = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_SqlServer_Add);
            this.panel1.Controls.Add(this.btn_SqlServer_Test);
            this.panel1.Controls.Add(this.btn_SqlServer_Preview);
            this.panel1.Controls.Add(this.cBox_SqlServer_Remenber);
            this.panel1.Controls.Add(this.tBox_SqlServer_Pwd);
            this.panel1.Controls.Add(this.tBox_SqlServer_UserName);
            this.panel1.Controls.Add(this.cBtn_SqlServer_ServerName);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(36, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(406, 258);
            this.panel1.TabIndex = 0;
            // 
            // btn_SqlServer_Add
            // 
            this.btn_SqlServer_Add.Location = new System.Drawing.Point(261, 212);
            this.btn_SqlServer_Add.Name = "btn_SqlServer_Add";
            this.btn_SqlServer_Add.Size = new System.Drawing.Size(75, 23);
            this.btn_SqlServer_Add.TabIndex = 10;
            this.btn_SqlServer_Add.Text = "确认添加";
            this.btn_SqlServer_Add.UseVisualStyleBackColor = true;
            this.btn_SqlServer_Add.Click += new System.EventHandler(this.btn_SqlServer_Add_Click);
            // 
            // btn_SqlServer_Test
            // 
            this.btn_SqlServer_Test.Location = new System.Drawing.Point(161, 212);
            this.btn_SqlServer_Test.Name = "btn_SqlServer_Test";
            this.btn_SqlServer_Test.Size = new System.Drawing.Size(75, 23);
            this.btn_SqlServer_Test.TabIndex = 9;
            this.btn_SqlServer_Test.Text = "测试连接";
            this.btn_SqlServer_Test.UseVisualStyleBackColor = true;
            this.btn_SqlServer_Test.Click += new System.EventHandler(this.btn_SqlServer_Test_Click);
            // 
            // btn_SqlServer_Preview
            // 
            this.btn_SqlServer_Preview.Location = new System.Drawing.Point(61, 212);
            this.btn_SqlServer_Preview.Name = "btn_SqlServer_Preview";
            this.btn_SqlServer_Preview.Size = new System.Drawing.Size(75, 23);
            this.btn_SqlServer_Preview.TabIndex = 8;
            this.btn_SqlServer_Preview.Text = "上一步";
            this.btn_SqlServer_Preview.UseVisualStyleBackColor = true;
            this.btn_SqlServer_Preview.Click += new System.EventHandler(this.btn_SqlServer_Preview_Click);
            // 
            // cBox_SqlServer_Remenber
            // 
            this.cBox_SqlServer_Remenber.AutoSize = true;
            this.cBox_SqlServer_Remenber.Location = new System.Drawing.Point(134, 175);
            this.cBox_SqlServer_Remenber.Name = "cBox_SqlServer_Remenber";
            this.cBox_SqlServer_Remenber.Size = new System.Drawing.Size(72, 16);
            this.cBox_SqlServer_Remenber.TabIndex = 7;
            this.cBox_SqlServer_Remenber.Text = "记住密码";
            this.cBox_SqlServer_Remenber.UseVisualStyleBackColor = true;
            // 
            // tBox_SqlServer_Pwd
            // 
            this.tBox_SqlServer_Pwd.Location = new System.Drawing.Point(132, 134);
            this.tBox_SqlServer_Pwd.Name = "tBox_SqlServer_Pwd";
            this.tBox_SqlServer_Pwd.Size = new System.Drawing.Size(159, 21);
            this.tBox_SqlServer_Pwd.TabIndex = 6;
            // 
            // tBox_SqlServer_UserName
            // 
            this.tBox_SqlServer_UserName.Location = new System.Drawing.Point(132, 92);
            this.tBox_SqlServer_UserName.Name = "tBox_SqlServer_UserName";
            this.tBox_SqlServer_UserName.Size = new System.Drawing.Size(159, 21);
            this.tBox_SqlServer_UserName.TabIndex = 5;
            // 
            // cBtn_SqlServer_ServerName
            // 
            this.cBtn_SqlServer_ServerName.FormattingEnabled = true;
            this.cBtn_SqlServer_ServerName.Location = new System.Drawing.Point(132, 51);
            this.cBtn_SqlServer_ServerName.Name = "cBtn_SqlServer_ServerName";
            this.cBtn_SqlServer_ServerName.Size = new System.Drawing.Size(159, 20);
            this.cBtn_SqlServer_ServerName.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(84, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "密码：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(72, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "登录名：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "服务器：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(68, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "设置SqlServer连接属性：";
            // 
            // Form_AddDatabase_SqlServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 317);
            this.Controls.Add(this.panel1);
            this.Name = "Form_AddDatabase_SqlServer";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "添加SQLServer服务器";
            this.Load += new System.EventHandler(this.Form_AddDatabase_SqlServer_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_SqlServer_Add;
        private System.Windows.Forms.Button btn_SqlServer_Test;
        private System.Windows.Forms.Button btn_SqlServer_Preview;
        private System.Windows.Forms.CheckBox cBox_SqlServer_Remenber;
        private System.Windows.Forms.TextBox tBox_SqlServer_Pwd;
        private System.Windows.Forms.TextBox tBox_SqlServer_UserName;
        private System.Windows.Forms.ComboBox cBtn_SqlServer_ServerName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}