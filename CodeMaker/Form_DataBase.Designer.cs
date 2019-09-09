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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.ServerTreeView = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(220, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // ServerTreeView
            // 
            this.ServerTreeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ServerTreeView.Location = new System.Drawing.Point(0, 25);
            this.ServerTreeView.Name = "ServerTreeView";
            this.ServerTreeView.Size = new System.Drawing.Size(220, 544);
            this.ServerTreeView.TabIndex = 1;
            // 
            // Form_DataBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(220, 569);
            this.Controls.Add(this.ServerTreeView);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form_DataBase";
            this.Text = "Form_DataBase";
            this.Load += new System.EventHandler(this.Form_DataBase_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.TreeView ServerTreeView;
    }
}