namespace PVSPlayerExample
{
    partial class FormMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.heThongMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aBCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.videoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ListVideoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HeThongToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlDisplayContainer = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.heThongMenuItem,
            this.aBCToolStripMenuItem,
            this.videoToolStripMenuItem,
            this.HeThongToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1202, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // heThongMenuItem
            // 
            this.heThongMenuItem.Name = "heThongMenuItem";
            this.heThongMenuItem.Size = new System.Drawing.Size(77, 24);
            this.heThongMenuItem.Text = "Ghi hình";
            this.heThongMenuItem.Click += new System.EventHandler(this.heThongMenuItem_Click);
            // 
            // aBCToolStripMenuItem
            // 
            this.aBCToolStripMenuItem.Name = "aBCToolStripMenuItem";
            this.aBCToolStripMenuItem.Size = new System.Drawing.Size(132, 24);
            this.aBCToolStripMenuItem.Text = "Kê khai hỏi cung";
            // 
            // videoToolStripMenuItem
            // 
            this.videoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ListVideoToolStripMenuItem});
            this.videoToolStripMenuItem.Name = "videoToolStripMenuItem";
            this.videoToolStripMenuItem.Size = new System.Drawing.Size(116, 24);
            this.videoToolStripMenuItem.Text = "Quản lý Video";
            // 
            // ListVideoToolStripMenuItem
            // 
            this.ListVideoToolStripMenuItem.Name = "ListVideoToolStripMenuItem";
            this.ListVideoToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.ListVideoToolStripMenuItem.Text = "Danh sách video";
            // 
            // HeThongToolStripMenuItem
            // 
            this.HeThongToolStripMenuItem.Name = "HeThongToolStripMenuItem";
            this.HeThongToolStripMenuItem.Size = new System.Drawing.Size(85, 24);
            this.HeThongToolStripMenuItem.Text = "Hệ thống";
            // 
            // pnlDisplayContainer
            // 
            this.pnlDisplayContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlDisplayContainer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlDisplayContainer.Location = new System.Drawing.Point(0, 26);
            this.pnlDisplayContainer.Margin = new System.Windows.Forms.Padding(0);
            this.pnlDisplayContainer.MinimumSize = new System.Drawing.Size(1200, 650);
            this.pnlDisplayContainer.Name = "pnlDisplayContainer";
            this.pnlDisplayContainer.Size = new System.Drawing.Size(1202, 650);
            this.pnlDisplayContainer.TabIndex = 1;
            // 
            // FormMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1202, 668);
            this.Controls.Add(this.pnlDisplayContainer);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1220, 715);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PHẦN MỀM GHI HÌNH HỎI CUNG - DEMO VERSION-0.1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem heThongMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aBCToolStripMenuItem;
        private System.Windows.Forms.Panel pnlDisplayContainer;
        private System.Windows.Forms.ToolStripMenuItem videoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ListVideoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HeThongToolStripMenuItem;
    }
}

