using System.ComponentModel;
using System.Windows.Forms;

namespace FolderView
{
    partial class AboutDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutDialog));
			this.aboutLabel1 = new System.Windows.Forms.Label();
			this.aboutLabel2 = new System.Windows.Forms.Label();
			this.urlLabel = new System.Windows.Forms.Label();
			this.panel5 = new System.Windows.Forms.Panel();
			this.panel1 = new System.Windows.Forms.Panel();
			this.OKButton = new FolderView.CustomButton();
			this.logoPanel = new System.Windows.Forms.Panel();
			this.panel5.SuspendLayout();
			this.SuspendLayout();
			// 
			// aboutLabel1
			// 
			this.aboutLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(173)))), ((int)(((byte)(146)))));
			this.aboutLabel1.Location = new System.Drawing.Point(64, 62);
			this.aboutLabel1.Name = "aboutLabel1";
			this.aboutLabel1.Size = new System.Drawing.Size(416, 62);
			this.aboutLabel1.TabIndex = 0;
			this.aboutLabel1.Text = resources.GetString("aboutLabel1.Text");
			this.aboutLabel1.Click += new System.EventHandler(this.OKButton_Click);
			// 
			// aboutLabel2
			// 
			this.aboutLabel2.AutoSize = true;
			this.aboutLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.aboutLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(173)))), ((int)(((byte)(146)))));
			this.aboutLabel2.Location = new System.Drawing.Point(64, 32);
			this.aboutLabel2.Name = "aboutLabel2";
			this.aboutLabel2.Size = new System.Drawing.Size(153, 16);
			this.aboutLabel2.TabIndex = 1;
			this.aboutLabel2.Text = "About PVS.MediaPlayer";
			this.aboutLabel2.Click += new System.EventHandler(this.OKButton_Click);
			// 
			// urlLabel
			// 
			this.urlLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.urlLabel.Cursor = System.Windows.Forms.Cursors.Hand;
			this.urlLabel.ForeColor = System.Drawing.Color.SlateGray;
			this.urlLabel.Location = new System.Drawing.Point(104, 141);
			this.urlLabel.Name = "urlLabel";
			this.urlLabel.Size = new System.Drawing.Size(236, 29);
			this.urlLabel.TabIndex = 3;
			this.urlLabel.Text = "Article and code available free at CodeProject.\r\nwww.codeproject.com";
			this.urlLabel.Click += new System.EventHandler(this.UrlLabel_Click);
			// 
			// panel5
			// 
			this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
			this.panel5.Controls.Add(this.panel1);
			this.panel5.Controls.Add(this.OKButton);
			this.panel5.Location = new System.Drawing.Point(1, 192);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(497, 49);
			this.panel5.TabIndex = 8;
			// 
			// panel1
			// 
			this.panel1.Location = new System.Drawing.Point(12, 9);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(42, 33);
			this.panel1.TabIndex = 8;
			this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.PVSLogo_Paint);
			// 
			// OKButton
			// 
			this.OKButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.OKButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
			this.OKButton.FocusBorder = true;
			this.OKButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(173)))), ((int)(((byte)(146)))));
			this.OKButton.Location = new System.Drawing.Point(399, 14);
			this.OKButton.Name = "OKButton";
			this.OKButton.Size = new System.Drawing.Size(84, 23);
			this.OKButton.TabIndex = 7;
			this.OKButton.Text = "OK";
			this.OKButton.UseVisualStyleBackColor = true;
			this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
			// 
			// logoPanel
			// 
			this.logoPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.logoPanel.Cursor = System.Windows.Forms.Cursors.Hand;
			this.logoPanel.Location = new System.Drawing.Point(66, 138);
			this.logoPanel.Name = "logoPanel";
			this.logoPanel.Size = new System.Drawing.Size(40, 33);
			this.logoPanel.TabIndex = 9;
			this.logoPanel.Click += new System.EventHandler(this.UrlLabel_Click);
			this.logoPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.LogoPanel_Paint);
			// 
			// AboutDialog
			// 
			this.AcceptButton = this.OKButton;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
			this.ClientSize = new System.Drawing.Size(499, 242);
			this.Controls.Add(this.logoPanel);
			this.Controls.Add(this.panel5);
			this.Controls.Add(this.urlLabel);
			this.Controls.Add(this.aboutLabel2);
			this.Controls.Add(this.aboutLabel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "AboutDialog";
			this.Opacity = 0.9D;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.TransparencyKey = System.Drawing.Color.RosyBrown;
			this.Shown += new System.EventHandler(this.AboutDialog_Shown);
			this.Click += new System.EventHandler(this.OKButton_Click);
			this.panel5.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private Label aboutLabel1;
        private Label aboutLabel2;
        private Label urlLabel;
        private Panel panel5;
        private CustomButton OKButton;
        private Panel logoPanel;
        private Panel panel1;
    }
}