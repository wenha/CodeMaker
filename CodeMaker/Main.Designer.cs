namespace CodeMaker
{
    partial class Main
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.服务器ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenu_Server_Add = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenu_Server_Delete = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenu_Server_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.生成ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolBtn_Home = new System.Windows.Forms.ToolStripButton();
            this.toolBtn_Server = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolBtn_AddDatabase = new System.Windows.Forms.ToolStripButton();
            this.toolBtn_DelDatabase = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton12 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton7 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolBtn_About = new System.Windows.Forms.ToolStripButton();
            this.toolBtn_Exit = new System.Windows.Forms.ToolStripButton();
            this.mainPanel = new WeifenLuo.WinFormsUI.Docking.DockPanel();
            this.toolStripMenu_Config_NameSpace = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenu_Config_Class = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenu_Config_Save = new System.Windows.Forms.ToolStripMenuItem();
            this.数据库服务器配置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenu_Build_Text = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenu_Build_Folder = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenu_Help_About = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.服务器ToolStripMenuItem,
            this.设置ToolStripMenuItem,
            this.生成ToolStripMenuItem,
            this.帮助ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 服务器ToolStripMenuItem
            // 
            this.服务器ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenu_Server_Add,
            this.toolStripMenu_Server_Delete,
            this.toolStripSeparator5,
            this.toolStripMenu_Server_Exit});
            this.服务器ToolStripMenuItem.Name = "服务器ToolStripMenuItem";
            this.服务器ToolStripMenuItem.ShortcutKeyDisplayString = "(F)";
            this.服务器ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F)));
            this.服务器ToolStripMenuItem.Size = new System.Drawing.Size(70, 21);
            this.服务器ToolStripMenuItem.Text = "服务器(&F)";
            // 
            // toolStripMenu_Server_Add
            // 
            this.toolStripMenu_Server_Add.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenu_Server_Add.Image")));
            this.toolStripMenu_Server_Add.Name = "toolStripMenu_Server_Add";
            this.toolStripMenu_Server_Add.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.toolStripMenu_Server_Add.Size = new System.Drawing.Size(237, 22);
            this.toolStripMenu_Server_Add.Text = "添加数据库服务器(&N)";
            this.toolStripMenu_Server_Add.Click += new System.EventHandler(this.toolStripMenu_Server_Add_Click);
            // 
            // toolStripMenu_Server_Delete
            // 
            this.toolStripMenu_Server_Delete.Name = "toolStripMenu_Server_Delete";
            this.toolStripMenu_Server_Delete.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.toolStripMenu_Server_Delete.Size = new System.Drawing.Size(237, 22);
            this.toolStripMenu_Server_Delete.Text = "注销数据库服务器(&E)";
            this.toolStripMenu_Server_Delete.Click += new System.EventHandler(this.toolStripMenu_Server_Delete_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(234, 6);
            // 
            // toolStripMenu_Server_Exit
            // 
            this.toolStripMenu_Server_Exit.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenu_Server_Exit.Image")));
            this.toolStripMenu_Server_Exit.Name = "toolStripMenu_Server_Exit";
            this.toolStripMenu_Server_Exit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.toolStripMenu_Server_Exit.Size = new System.Drawing.Size(237, 22);
            this.toolStripMenu_Server_Exit.Text = "退出生成器(&Q)";
            this.toolStripMenu_Server_Exit.Click += new System.EventHandler(this.toolStripMenu_Server_Exit_Click);
            // 
            // 设置ToolStripMenuItem
            // 
            this.设置ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenu_Config_NameSpace,
            this.toolStripMenu_Config_Class,
            this.toolStripMenu_Config_Save,
            this.数据库服务器配置ToolStripMenuItem});
            this.设置ToolStripMenuItem.Name = "设置ToolStripMenuItem";
            this.设置ToolStripMenuItem.Size = new System.Drawing.Size(60, 21);
            this.设置ToolStripMenuItem.Text = "设置(&C)";
            // 
            // 生成ToolStripMenuItem
            // 
            this.生成ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenu_Build_Text,
            this.toolStripMenu_Build_Folder});
            this.生成ToolStripMenuItem.Name = "生成ToolStripMenuItem";
            this.生成ToolStripMenuItem.Size = new System.Drawing.Size(60, 21);
            this.生成ToolStripMenuItem.Text = "生成(&B)";
            // 
            // 帮助ToolStripMenuItem
            // 
            this.帮助ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenu_Help_About});
            this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            this.帮助ToolStripMenuItem.Size = new System.Drawing.Size(61, 21);
            this.帮助ToolStripMenuItem.Text = "帮助(&H)";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolBtn_Home,
            this.toolBtn_Server,
            this.toolStripSeparator1,
            this.toolBtn_AddDatabase,
            this.toolBtn_DelDatabase,
            this.toolStripSeparator2,
            this.toolStripButton12,
            this.toolStripButton6,
            this.toolStripButton7,
            this.toolStripSeparator3,
            this.toolStripButton4,
            this.toolStripButton5,
            this.toolStripSeparator4,
            this.toolBtn_About,
            this.toolBtn_Exit});
            this.toolStrip1.Location = new System.Drawing.Point(0, 25);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolBtn_Home
            // 
            this.toolBtn_Home.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtn_Home.Image = ((System.Drawing.Image)(resources.GetObject("toolBtn_Home.Image")));
            this.toolBtn_Home.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtn_Home.Name = "toolBtn_Home";
            this.toolBtn_Home.Size = new System.Drawing.Size(23, 22);
            this.toolBtn_Home.Text = "显示起始页";
            this.toolBtn_Home.Click += new System.EventHandler(this.toolBtn_Home_Click);
            // 
            // toolBtn_Server
            // 
            this.toolBtn_Server.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtn_Server.Image = ((System.Drawing.Image)(resources.GetObject("toolBtn_Server.Image")));
            this.toolBtn_Server.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtn_Server.Name = "toolBtn_Server";
            this.toolBtn_Server.Size = new System.Drawing.Size(23, 22);
            this.toolBtn_Server.Text = "显示数据库管理器";
            this.toolBtn_Server.Click += new System.EventHandler(this.toolBtn_Server_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolBtn_AddDatabase
            // 
            this.toolBtn_AddDatabase.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtn_AddDatabase.Image = ((System.Drawing.Image)(resources.GetObject("toolBtn_AddDatabase.Image")));
            this.toolBtn_AddDatabase.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtn_AddDatabase.Name = "toolBtn_AddDatabase";
            this.toolBtn_AddDatabase.Size = new System.Drawing.Size(23, 22);
            this.toolBtn_AddDatabase.Text = "添加数据库服务器";
            this.toolBtn_AddDatabase.Click += new System.EventHandler(this.toolBtn_AddDatabase_Click);
            // 
            // toolBtn_DelDatabase
            // 
            this.toolBtn_DelDatabase.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtn_DelDatabase.Image = ((System.Drawing.Image)(resources.GetObject("toolBtn_DelDatabase.Image")));
            this.toolBtn_DelDatabase.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtn_DelDatabase.Name = "toolBtn_DelDatabase";
            this.toolBtn_DelDatabase.Size = new System.Drawing.Size(23, 22);
            this.toolBtn_DelDatabase.Text = "注销数据库服务器";
            this.toolBtn_DelDatabase.Click += new System.EventHandler(this.toolBtn_DelDatabase_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton12
            // 
            this.toolStripButton12.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton12.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton12.Image")));
            this.toolStripButton12.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton12.Name = "toolStripButton12";
            this.toolStripButton12.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton12.Text = "类库命名设置";
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton6.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton6.Image")));
            this.toolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton6.Text = "配置生成目录";
            // 
            // toolStripButton7
            // 
            this.toolStripButton7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton7.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton7.Image")));
            this.toolStripButton7.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton7.Name = "toolStripButton7";
            this.toolStripButton7.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton7.Text = "配置数据库服务器";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton4.Text = "生成代码至文本";
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton5.Text = "生成代码至目录";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // toolBtn_About
            // 
            this.toolBtn_About.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtn_About.Image = ((System.Drawing.Image)(resources.GetObject("toolBtn_About.Image")));
            this.toolBtn_About.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtn_About.Name = "toolBtn_About";
            this.toolBtn_About.Size = new System.Drawing.Size(23, 22);
            this.toolBtn_About.Text = "关于生成器";
            // 
            // toolBtn_Exit
            // 
            this.toolBtn_Exit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtn_Exit.Image = ((System.Drawing.Image)(resources.GetObject("toolBtn_Exit.Image")));
            this.toolBtn_Exit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtn_Exit.Name = "toolBtn_Exit";
            this.toolBtn_Exit.Size = new System.Drawing.Size(23, 22);
            this.toolBtn_Exit.Text = "退出生成器";
            // 
            // mainPanel
            // 
            this.mainPanel.ActiveAutoHideContent = null;
            this.mainPanel.BackColor = System.Drawing.Color.White;
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this.mainPanel.Location = new System.Drawing.Point(0, 50);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(800, 400);
            this.mainPanel.TabIndex = 2;
            // 
            // toolStripMenu_Config_NameSpace
            // 
            this.toolStripMenu_Config_NameSpace.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenu_Config_NameSpace.Image")));
            this.toolStripMenu_Config_NameSpace.Name = "toolStripMenu_Config_NameSpace";
            this.toolStripMenu_Config_NameSpace.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenu_Config_NameSpace.Text = "命名空间设置";
            this.toolStripMenu_Config_NameSpace.Click += new System.EventHandler(this.toolStripMenu_Config_NameSpace_Click);
            // 
            // toolStripMenu_Config_Class
            // 
            this.toolStripMenu_Config_Class.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenu_Config_Class.Image")));
            this.toolStripMenu_Config_Class.Name = "toolStripMenu_Config_Class";
            this.toolStripMenu_Config_Class.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenu_Config_Class.Text = "类库命名设置";
            // 
            // toolStripMenu_Config_Save
            // 
            this.toolStripMenu_Config_Save.Name = "toolStripMenu_Config_Save";
            this.toolStripMenu_Config_Save.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenu_Config_Save.Text = "保存目录设置";
            // 
            // 数据库服务器配置ToolStripMenuItem
            // 
            this.数据库服务器配置ToolStripMenuItem.Name = "数据库服务器配置ToolStripMenuItem";
            this.数据库服务器配置ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.数据库服务器配置ToolStripMenuItem.Text = "数据库服务器设置";
            // 
            // toolStripMenu_Build_Text
            // 
            this.toolStripMenu_Build_Text.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenu_Build_Text.Image")));
            this.toolStripMenu_Build_Text.Name = "toolStripMenu_Build_Text";
            this.toolStripMenu_Build_Text.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.T)));
            this.toolStripMenu_Build_Text.Size = new System.Drawing.Size(235, 22);
            this.toolStripMenu_Build_Text.Text = "生成选中表至文本(&T)";
            // 
            // toolStripMenu_Build_Folder
            // 
            this.toolStripMenu_Build_Folder.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenu_Build_Folder.Image")));
            this.toolStripMenu_Build_Folder.Name = "toolStripMenu_Build_Folder";
            this.toolStripMenu_Build_Folder.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.toolStripMenu_Build_Folder.Size = new System.Drawing.Size(235, 22);
            this.toolStripMenu_Build_Folder.Text = "生成选中表至目录(&D)";
            this.toolStripMenu_Build_Folder.Click += new System.EventHandler(this.toolStripMenu_Build_Folder_Click);
            // 
            // toolStripMenu_Help_About
            // 
            this.toolStripMenu_Help_About.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenu_Help_About.Image")));
            this.toolStripMenu_Help_About.Name = "toolStripMenu_Help_About";
            this.toolStripMenu_Help_About.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenu_Help_About.Text = "关于生成器";
            this.toolStripMenu_Help_About.Click += new System.EventHandler(this.toolStripMenu_Help_About_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "代码生成器";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 服务器ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 设置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 生成ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenu_Server_Add;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenu_Server_Delete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenu_Server_Exit;
        private System.Windows.Forms.ToolStripButton toolBtn_Home;
        private System.Windows.Forms.ToolStripButton toolBtn_Server;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolBtn_AddDatabase;
        private System.Windows.Forms.ToolStripButton toolBtn_DelDatabase;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton12;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        private System.Windows.Forms.ToolStripButton toolStripButton7;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton toolBtn_About;
        private System.Windows.Forms.ToolStripButton toolBtn_Exit;
        private WeifenLuo.WinFormsUI.Docking.DockPanel mainPanel;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenu_Config_NameSpace;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenu_Config_Class;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenu_Config_Save;
        private System.Windows.Forms.ToolStripMenuItem 数据库服务器配置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenu_Build_Text;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenu_Build_Folder;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenu_Help_About;
    }
}

