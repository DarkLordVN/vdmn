using System.ComponentModel;
using System.Windows.Forms;

namespace PVSPlayerExample
{
    partial class AboutDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        ///// <summary>
        ///// Clean up any resources being used.
        ///// </summary>
        ///// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        //protected override void Dispose(bool disposing)
        //{
        //    if (disposing && (components != null))
        //    {
        //        components.Dispose();
        //    }
        //    base.Dispose(disposing);
        //}

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.aboutLabel1 = new System.Windows.Forms.Label();
            this.aboutLabel2 = new System.Windows.Forms.Label();
            this.urlLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bottomPanel = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pvsPanel = new System.Windows.Forms.Panel();
            this.OKButton = new PVSPlayerExample.CustomButton();
            this.logoPanel = new System.Windows.Forms.Panel();
            this.bottomPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // aboutLabel1
            // 
            this.aboutLabel1.ForeColor = System.Drawing.Color.Black;
            this.aboutLabel1.Location = new System.Drawing.Point(85, 86);
            this.aboutLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.aboutLabel1.Name = "aboutLabel1";
            this.aboutLabel1.Size = new System.Drawing.Size(552, 70);
            this.aboutLabel1.TabIndex = 0;
            this.aboutLabel1.Text = "Phần mềm thuộc sở hữu của KCTECH\r\nĐịa chỉ: xxx\r\n\r\n";
            this.aboutLabel1.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // aboutLabel2
            // 
            this.aboutLabel2.AutoSize = true;
            this.aboutLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aboutLabel2.ForeColor = System.Drawing.Color.Black;
            this.aboutLabel2.Location = new System.Drawing.Point(85, 37);
            this.aboutLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.aboutLabel2.Name = "aboutLabel2";
            this.aboutLabel2.Size = new System.Drawing.Size(204, 25);
            this.aboutLabel2.TabIndex = 1;
            this.aboutLabel2.Text = "Thông tin về chúng tôi";
            this.aboutLabel2.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // urlLabel
            // 
            this.urlLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.urlLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.urlLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.urlLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.urlLabel.Location = new System.Drawing.Point(140, 202);
            this.urlLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.urlLabel.Name = "urlLabel";
            this.urlLabel.Size = new System.Drawing.Size(343, 36);
            this.urlLabel.TabIndex = 3;
            this.urlLabel.Text = "Về chúng tôi.\r\nwww.dkl.com";
            this.urlLabel.Click += new System.EventHandler(this.UrlLabel_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(103, 5);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(104, 50);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(255, 5);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(104, 50);
            this.panel2.TabIndex = 5;
            // 
            // bottomPanel
            // 
            this.bottomPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bottomPanel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.bottomPanel.Controls.Add(this.panel3);
            this.bottomPanel.Controls.Add(this.pvsPanel);
            this.bottomPanel.Controls.Add(this.OKButton);
            this.bottomPanel.Controls.Add(this.panel1);
            this.bottomPanel.Controls.Add(this.panel2);
            this.bottomPanel.Location = new System.Drawing.Point(1, 266);
            this.bottomPanel.Margin = new System.Windows.Forms.Padding(4);
            this.bottomPanel.Name = "bottomPanel";
            this.bottomPanel.Size = new System.Drawing.Size(665, 62);
            this.bottomPanel.TabIndex = 8;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(404, 5);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(104, 50);
            this.panel3.TabIndex = 11;
            // 
            // pvsPanel
            // 
            this.pvsPanel.Location = new System.Drawing.Point(13, 12);
            this.pvsPanel.Margin = new System.Windows.Forms.Padding(4);
            this.pvsPanel.Name = "pvsPanel";
            this.pvsPanel.Size = new System.Drawing.Size(56, 41);
            this.pvsPanel.TabIndex = 10;
            this.pvsPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.PvsPanel_Paint);
            // 
            // OKButton
            // 
            this.OKButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.OKButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.OKButton.FocusBorder = true;
            this.OKButton.ForeColor = System.Drawing.Color.White;
            this.OKButton.Location = new System.Drawing.Point(536, 17);
            this.OKButton.Margin = new System.Windows.Forms.Padding(4);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(112, 28);
            this.OKButton.TabIndex = 7;
            this.OKButton.Text = "Đóng";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // logoPanel
            // 
            this.logoPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.logoPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logoPanel.Location = new System.Drawing.Point(88, 198);
            this.logoPanel.Margin = new System.Windows.Forms.Padding(4);
            this.logoPanel.Name = "logoPanel";
            this.logoPanel.Size = new System.Drawing.Size(53, 41);
            this.logoPanel.TabIndex = 9;
            this.logoPanel.Click += new System.EventHandler(this.UrlLabel_Click);
            this.logoPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.LogoPanel_Paint);
            // 
            // AboutDialog
            // 
            this.AcceptButton = this.OKButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(668, 329);
            this.Controls.Add(this.logoPanel);
            this.Controls.Add(this.bottomPanel);
            this.Controls.Add(this.urlLabel);
            this.Controls.Add(this.aboutLabel2);
            this.Controls.Add(this.aboutLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutDialog";
            this.Opacity = 0.95D;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Thông tin";
            this.TransparencyKey = System.Drawing.Color.RosyBrown;
            this.Shown += new System.EventHandler(this.AboutDialog_Shown);
            this.Click += new System.EventHandler(this.OKButton_Click);
            this.bottomPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label aboutLabel1;
        private Label aboutLabel2;
        private Label urlLabel;
        internal Panel panel1;
        internal Panel panel2;
        private Panel bottomPanel;
        private CustomButton OKButton;
        private Panel logoPanel;
        private Panel pvsPanel;
        internal Panel panel3;
    }
}