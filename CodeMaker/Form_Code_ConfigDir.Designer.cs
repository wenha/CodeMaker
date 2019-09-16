namespace CodeMaker
{
    partial class Form_Code_ConfigDir
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
            this.configDir_cb_NormalPattern = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.configDir_cb_Add = new System.Windows.Forms.CheckBox();
            this.configDir_cb_Delete = new System.Windows.Forms.CheckBox();
            this.configDir_cb_Modify = new System.Windows.Forms.CheckBox();
            this.configDir_cb_IsExist = new System.Windows.Forms.CheckBox();
            this.configDir_cb_GetAll = new System.Windows.Forms.CheckBox();
            this.configDir_cb_GetById = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.configDir_tb_OutputDir = new System.Windows.Forms.TextBox();
            this.configDir_Btn_OpenFolder = new System.Windows.Forms.Button();
            this.configDir_btn_Build = new System.Windows.Forms.Button();
            this.configDir_Btn_Cancel = new System.Windows.Forms.Button();
            this.configDir_label_progress = new System.Windows.Forms.Label();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(39, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "生成模式：";
            // 
            // configDir_cb_NormalPattern
            // 
            this.configDir_cb_NormalPattern.AutoSize = true;
            this.configDir_cb_NormalPattern.Location = new System.Drawing.Point(67, 43);
            this.configDir_cb_NormalPattern.Name = "configDir_cb_NormalPattern";
            this.configDir_cb_NormalPattern.Size = new System.Drawing.Size(95, 16);
            this.configDir_cb_NormalPattern.TabIndex = 1;
            this.configDir_cb_NormalPattern.TabStop = true;
            this.configDir_cb_NormalPattern.Text = "普通三层架构";
            this.configDir_cb_NormalPattern.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(220, 43);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(95, 16);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "radioButton1";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(39, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 14);
            this.label2.TabIndex = 2;
            this.label2.Text = "生成方法：";
            // 
            // configDir_cb_Add
            // 
            this.configDir_cb_Add.AutoSize = true;
            this.configDir_cb_Add.Location = new System.Drawing.Point(67, 104);
            this.configDir_cb_Add.Name = "configDir_cb_Add";
            this.configDir_cb_Add.Size = new System.Drawing.Size(48, 16);
            this.configDir_cb_Add.TabIndex = 3;
            this.configDir_cb_Add.Text = "新增";
            this.configDir_cb_Add.UseVisualStyleBackColor = true;
            // 
            // configDir_cb_Delete
            // 
            this.configDir_cb_Delete.AutoSize = true;
            this.configDir_cb_Delete.Location = new System.Drawing.Point(160, 104);
            this.configDir_cb_Delete.Name = "configDir_cb_Delete";
            this.configDir_cb_Delete.Size = new System.Drawing.Size(48, 16);
            this.configDir_cb_Delete.TabIndex = 3;
            this.configDir_cb_Delete.Text = "删除";
            this.configDir_cb_Delete.UseVisualStyleBackColor = true;
            // 
            // configDir_cb_Modify
            // 
            this.configDir_cb_Modify.AutoSize = true;
            this.configDir_cb_Modify.Location = new System.Drawing.Point(246, 104);
            this.configDir_cb_Modify.Name = "configDir_cb_Modify";
            this.configDir_cb_Modify.Size = new System.Drawing.Size(48, 16);
            this.configDir_cb_Modify.TabIndex = 3;
            this.configDir_cb_Modify.Text = "修改";
            this.configDir_cb_Modify.UseVisualStyleBackColor = true;
            // 
            // configDir_cb_IsExist
            // 
            this.configDir_cb_IsExist.AutoSize = true;
            this.configDir_cb_IsExist.Location = new System.Drawing.Point(345, 104);
            this.configDir_cb_IsExist.Name = "configDir_cb_IsExist";
            this.configDir_cb_IsExist.Size = new System.Drawing.Size(120, 16);
            this.configDir_cb_IsExist.TabIndex = 3;
            this.configDir_cb_IsExist.Text = "判断记录是否存在";
            this.configDir_cb_IsExist.UseVisualStyleBackColor = true;
            // 
            // configDir_cb_GetAll
            // 
            this.configDir_cb_GetAll.AutoSize = true;
            this.configDir_cb_GetAll.Location = new System.Drawing.Point(67, 141);
            this.configDir_cb_GetAll.Name = "configDir_cb_GetAll";
            this.configDir_cb_GetAll.Size = new System.Drawing.Size(96, 16);
            this.configDir_cb_GetAll.TabIndex = 3;
            this.configDir_cb_GetAll.Text = "查询所有记录";
            this.configDir_cb_GetAll.UseVisualStyleBackColor = true;
            // 
            // configDir_cb_GetById
            // 
            this.configDir_cb_GetById.AutoSize = true;
            this.configDir_cb_GetById.Location = new System.Drawing.Point(210, 141);
            this.configDir_cb_GetById.Name = "configDir_cb_GetById";
            this.configDir_cb_GetById.Size = new System.Drawing.Size(96, 16);
            this.configDir_cb_GetById.TabIndex = 3;
            this.configDir_cb_GetById.Text = "查询主键记录";
            this.configDir_cb_GetById.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(39, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 14);
            this.label3.TabIndex = 4;
            this.label3.Text = "目录设置：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(67, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 5;
            this.label4.Text = "项目目录：";
            // 
            // configDir_tb_OutputDir
            // 
            this.configDir_tb_OutputDir.Location = new System.Drawing.Point(136, 223);
            this.configDir_tb_OutputDir.Name = "configDir_tb_OutputDir";
            this.configDir_tb_OutputDir.Size = new System.Drawing.Size(282, 21);
            this.configDir_tb_OutputDir.TabIndex = 6;
            // 
            // configDir_Btn_OpenFolder
            // 
            this.configDir_Btn_OpenFolder.Location = new System.Drawing.Point(420, 222);
            this.configDir_Btn_OpenFolder.Name = "configDir_Btn_OpenFolder";
            this.configDir_Btn_OpenFolder.Size = new System.Drawing.Size(35, 23);
            this.configDir_Btn_OpenFolder.TabIndex = 7;
            this.configDir_Btn_OpenFolder.Text = "...";
            this.configDir_Btn_OpenFolder.UseVisualStyleBackColor = true;
            this.configDir_Btn_OpenFolder.Click += new System.EventHandler(this.configDir_Btn_OpenFolder_Click);
            // 
            // configDir_btn_Build
            // 
            this.configDir_btn_Build.Location = new System.Drawing.Point(107, 279);
            this.configDir_btn_Build.Name = "configDir_btn_Build";
            this.configDir_btn_Build.Size = new System.Drawing.Size(75, 23);
            this.configDir_btn_Build.TabIndex = 8;
            this.configDir_btn_Build.Text = "生成";
            this.configDir_btn_Build.UseVisualStyleBackColor = true;
            this.configDir_btn_Build.Click += new System.EventHandler(this.configDir_btn_Build_Click);
            // 
            // configDir_Btn_Cancel
            // 
            this.configDir_Btn_Cancel.Location = new System.Drawing.Point(345, 279);
            this.configDir_Btn_Cancel.Name = "configDir_Btn_Cancel";
            this.configDir_Btn_Cancel.Size = new System.Drawing.Size(75, 23);
            this.configDir_Btn_Cancel.TabIndex = 8;
            this.configDir_Btn_Cancel.Text = "取消";
            this.configDir_Btn_Cancel.UseVisualStyleBackColor = true;
            this.configDir_Btn_Cancel.Click += new System.EventHandler(this.configDir_Btn_Cancel_Click);
            // 
            // configDir_label_progress
            // 
            this.configDir_label_progress.AutoSize = true;
            this.configDir_label_progress.ForeColor = System.Drawing.Color.Red;
            this.configDir_label_progress.Location = new System.Drawing.Point(136, 250);
            this.configDir_label_progress.Name = "configDir_label_progress";
            this.configDir_label_progress.Size = new System.Drawing.Size(41, 12);
            this.configDir_label_progress.TabIndex = 9;
            this.configDir_label_progress.Text = "label5";
            // 
            // Form_Code_ConfigDir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 341);
            this.Controls.Add(this.configDir_label_progress);
            this.Controls.Add(this.configDir_Btn_Cancel);
            this.Controls.Add(this.configDir_btn_Build);
            this.Controls.Add(this.configDir_Btn_OpenFolder);
            this.Controls.Add(this.configDir_tb_OutputDir);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.configDir_cb_GetById);
            this.Controls.Add(this.configDir_cb_GetAll);
            this.Controls.Add(this.configDir_cb_IsExist);
            this.Controls.Add(this.configDir_cb_Modify);
            this.Controls.Add(this.configDir_cb_Delete);
            this.Controls.Add(this.configDir_cb_Add);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.configDir_cb_NormalPattern);
            this.Controls.Add(this.label1);
            this.Name = "Form_Code_ConfigDir";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "生成代码至目录";
            this.Load += new System.EventHandler(this.Form_Code_ConfigDir_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton configDir_cb_NormalPattern;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox configDir_cb_Add;
        private System.Windows.Forms.CheckBox configDir_cb_Delete;
        private System.Windows.Forms.CheckBox configDir_cb_Modify;
        private System.Windows.Forms.CheckBox configDir_cb_IsExist;
        private System.Windows.Forms.CheckBox configDir_cb_GetAll;
        private System.Windows.Forms.CheckBox configDir_cb_GetById;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox configDir_tb_OutputDir;
        private System.Windows.Forms.Button configDir_Btn_OpenFolder;
        private System.Windows.Forms.Button configDir_btn_Build;
        private System.Windows.Forms.Button configDir_Btn_Cancel;
        private System.Windows.Forms.Label configDir_label_progress;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
    }
}