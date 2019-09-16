namespace CodeMaker
{
    partial class Form_AddDatabase
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
            this.btnNext = new System.Windows.Forms.Button();
            this.rBtn_Sqlite = new System.Windows.Forms.RadioButton();
            this.rBtn_MySql = new System.Windows.Forms.RadioButton();
            this.rBtn_Oracle = new System.Windows.Forms.RadioButton();
            this.rBtn_SqlServer = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnNext);
            this.panel1.Controls.Add(this.rBtn_Sqlite);
            this.panel1.Controls.Add(this.rBtn_MySql);
            this.panel1.Controls.Add(this.rBtn_Oracle);
            this.panel1.Controls.Add(this.rBtn_SqlServer);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(436, 354);
            this.panel1.TabIndex = 0;
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(104, 236);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 2;
            this.btnNext.Text = "下一步";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // rBtn_Sqlite
            // 
            this.rBtn_Sqlite.AutoSize = true;
            this.rBtn_Sqlite.Location = new System.Drawing.Point(123, 183);
            this.rBtn_Sqlite.Name = "rBtn_Sqlite";
            this.rBtn_Sqlite.Size = new System.Drawing.Size(59, 16);
            this.rBtn_Sqlite.TabIndex = 1;
            this.rBtn_Sqlite.TabStop = true;
            this.rBtn_Sqlite.Text = "Sqlite";
            this.rBtn_Sqlite.UseVisualStyleBackColor = true;
            // 
            // rBtn_MySql
            // 
            this.rBtn_MySql.AutoSize = true;
            this.rBtn_MySql.Location = new System.Drawing.Point(123, 144);
            this.rBtn_MySql.Name = "rBtn_MySql";
            this.rBtn_MySql.Size = new System.Drawing.Size(53, 16);
            this.rBtn_MySql.TabIndex = 1;
            this.rBtn_MySql.TabStop = true;
            this.rBtn_MySql.Text = "MySql";
            this.rBtn_MySql.UseVisualStyleBackColor = true;
            // 
            // rBtn_Oracle
            // 
            this.rBtn_Oracle.AutoSize = true;
            this.rBtn_Oracle.Location = new System.Drawing.Point(123, 104);
            this.rBtn_Oracle.Name = "rBtn_Oracle";
            this.rBtn_Oracle.Size = new System.Drawing.Size(59, 16);
            this.rBtn_Oracle.TabIndex = 1;
            this.rBtn_Oracle.TabStop = true;
            this.rBtn_Oracle.Text = "Oracle";
            this.rBtn_Oracle.UseVisualStyleBackColor = true;
            // 
            // rBtn_SqlServer
            // 
            this.rBtn_SqlServer.AutoSize = true;
            this.rBtn_SqlServer.Location = new System.Drawing.Point(123, 68);
            this.rBtn_SqlServer.Name = "rBtn_SqlServer";
            this.rBtn_SqlServer.Size = new System.Drawing.Size(83, 16);
            this.rBtn_SqlServer.TabIndex = 1;
            this.rBtn_SqlServer.TabStop = true;
            this.rBtn_SqlServer.Text = "SQL Server";
            this.rBtn_SqlServer.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(101, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "选择数据库类型：";
            // 
            // Form_AddDatabase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 354);
            this.Controls.Add(this.panel1);
            this.Name = "Form_AddDatabase";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "添加服务器";
            this.Load += new System.EventHandler(this.Form_AddDatabase_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rBtn_Sqlite;
        private System.Windows.Forms.RadioButton rBtn_MySql;
        private System.Windows.Forms.RadioButton rBtn_Oracle;
        private System.Windows.Forms.RadioButton rBtn_SqlServer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNext;
    }
}