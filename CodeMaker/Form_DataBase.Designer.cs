namespace CodeMaker
{
    partial class Form_DataBase
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_DataBase));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolBtnAdd = new System.Windows.Forms.ToolStripButton();
            this.toolBtnDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.ServerTreeView = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolBtnAdd,
            this.toolBtnDelete,
            this.toolStripSeparator1,
            this.toolStripButton4});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(220, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolBtnAdd
            // 
            this.toolBtnAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtnAdd.Image = ((System.Drawing.Image)(resources.GetObject("toolBtnAdd.Image")));
            this.toolBtnAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnAdd.Name = "toolBtnAdd";
            this.toolBtnAdd.Size = new System.Drawing.Size(23, 22);
            this.toolBtnAdd.Text = "添加数据库服务器";
            this.toolBtnAdd.Click += new System.EventHandler(this.toolBtnAdd_Click);
            // 
            // toolBtnDelete
            // 
            this.toolBtnDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtnDelete.Image = ((System.Drawing.Image)(resources.GetObject("toolBtnDelete.Image")));
            this.toolBtnDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnDelete.Name = "toolBtnDelete";
            this.toolBtnDelete.Size = new System.Drawing.Size(23, 22);
            this.toolBtnDelete.Text = "注销数据库服务器";
            this.toolBtnDelete.Click += new System.EventHandler(this.toolBtnDelete_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton4.Text = "刷新";
            // 
            // ServerTreeView
            // 
            this.ServerTreeView.CheckBoxes = true;
            this.ServerTreeView.Cursor = System.Windows.Forms.Cursors.Default;
            this.ServerTreeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ServerTreeView.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ServerTreeView.ImageIndex = 0;
            this.ServerTreeView.ImageList = this.imageList1;
            this.ServerTreeView.Location = new System.Drawing.Point(0, 25);
            this.ServerTreeView.Name = "ServerTreeView";
            this.ServerTreeView.SelectedImageIndex = 0;
            this.ServerTreeView.ShowLines = false;
            this.ServerTreeView.ShowNodeToolTips = true;
            this.ServerTreeView.Size = new System.Drawing.Size(220, 544);
            this.ServerTreeView.TabIndex = 1;
            this.ServerTreeView.DoubleClick += new System.EventHandler(this.serverTreeView_DoubleClick);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "(36,46).png");
            this.imageList1.Images.SetKeyName(1, "(42,48).png");
            this.imageList1.Images.SetKeyName(2, "(18,12).png");
            this.imageList1.Images.SetKeyName(3, "(11,30).png");
            this.imageList1.Images.SetKeyName(4, "(02,29).png");
            this.imageList1.Images.SetKeyName(5, "pri.png");
            // 
            // Form_DataBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(220, 569);
            this.Controls.Add(this.ServerTreeView);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form_DataBase";
            this.ShowIcon = false;
            this.TabText = "数据库服务器";
            this.Text = "数据库服务器";
            this.Load += new System.EventHandler(this.Form_DataBase_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.TreeView ServerTreeView;
        private System.Windows.Forms.ToolStripButton toolBtnAdd;
        private System.Windows.Forms.ToolStripButton toolBtnDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ImageList imageList1;
    }
}