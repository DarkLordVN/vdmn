using System.ComponentModel;
using System.Windows.Forms;

namespace MediaKCTech
{
    partial class ErrorDialog
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.bottomPanel = new System.Windows.Forms.Panel();
            this.pvsPanel = new System.Windows.Forms.Panel();
            this.OKButton = new MediaKCTech.CustomButton();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.copyMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copyToClipboardMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bottomPanel.SuspendLayout();
            this.copyMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(65, 32);
            this.label1.MaximumSize = new System.Drawing.Size(380, 1000);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            this.label1.UseMnemonic = false;
            // 
            // bottomPanel
            // 
            this.bottomPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bottomPanel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.bottomPanel.Controls.Add(this.pvsPanel);
            this.bottomPanel.Controls.Add(this.OKButton);
            this.bottomPanel.Controls.Add(this.checkBox2);
            this.bottomPanel.Controls.Add(this.checkBox1);
            this.bottomPanel.Location = new System.Drawing.Point(1, 85);
            this.bottomPanel.Name = "bottomPanel";
            this.bottomPanel.Size = new System.Drawing.Size(465, 49);
            this.bottomPanel.TabIndex = 2;
            // 
            // pvsPanel
            // 
            this.pvsPanel.Location = new System.Drawing.Point(11, 9);
            this.pvsPanel.Name = "pvsPanel";
            this.pvsPanel.Size = new System.Drawing.Size(42, 33);
            this.pvsPanel.TabIndex = 3;
            this.pvsPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.PvsPanel_Paint);
            // 
            // OKButton
            // 
            this.OKButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.OKButton.FocusBorder = true;
            this.OKButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OKButton.ForeColor = System.Drawing.Color.White;
            this.OKButton.Location = new System.Drawing.Point(369, 14);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(84, 23);
            this.OKButton.TabIndex = 2;
            this.OKButton.Text = "Xác nhận";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.Button1_Click);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Checked = true;
            this.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox2.ForeColor = System.Drawing.Color.Black;
            this.checkBox2.Location = new System.Drawing.Point(67, 4);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(193, 22);
            this.checkBox2.TabIndex = 0;
            this.checkBox2.Text = "Xóa khỏi danh sách phát";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.ForeColor = System.Drawing.Color.Black;
            this.checkBox1.Location = new System.Drawing.Point(67, 25);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(188, 22);
            this.checkBox1.TabIndex = 1;
            this.checkBox1.Text = "Phát tệp media tiếp theo";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.CheckBox1_CheckedChanged);
            // 
            // copyMenu
            // 
            this.copyMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.copyMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToClipboardMenuItem});
            this.copyMenu.Name = "copyMenu";
            this.copyMenu.ShowImageMargin = false;
            this.copyMenu.Size = new System.Drawing.Size(227, 28);
            // 
            // copyToClipboardMenuItem
            // 
            this.copyToClipboardMenuItem.Name = "copyToClipboardMenuItem";
            this.copyToClipboardMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyToClipboardMenuItem.Size = new System.Drawing.Size(226, 24);
            this.copyToClipboardMenuItem.Text = "Copy to Clipboard";
            this.copyToClipboardMenuItem.Click += new System.EventHandler(this.CopyToClipboardMenuItem_Click);
            // 
            // ErrorDialog
            // 
            this.AcceptButton = this.OKButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(468, 135);
            this.ContextMenuStrip = this.copyMenu;
            this.Controls.Add(this.bottomPanel);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ErrorDialog";
            this.Opacity = 0.95D;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Thông báo lỗi";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ErrorDialog_FormClosed);
            this.Shown += new System.EventHandler(this.ErrorDialog_Shown);
            this.bottomPanel.ResumeLayout(false);
            this.bottomPanel.PerformLayout();
            this.copyMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Panel bottomPanel;
        private CustomButton OKButton;
        internal CheckBox checkBox1;
        internal CheckBox checkBox2;
        private Panel pvsPanel;
		private ContextMenuStrip copyMenu;
		private ToolStripMenuItem copyToClipboardMenuItem;
	}
}