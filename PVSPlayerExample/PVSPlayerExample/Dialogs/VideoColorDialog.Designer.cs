namespace PVSPlayerExample
{
    partial class VideoColorDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.components = new System.ComponentModel.Container();
            this.brightnessPanel = new System.Windows.Forms.Panel();
            this.colorDialogMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.resetItemMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearItemMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.resetAllMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearAllMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.closeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.brightnessLight = new PVSPlayerExample.LightPanel();
            this.brightnessValue = new System.Windows.Forms.Label();
            this.brightnessLabel = new System.Windows.Forms.Label();
            this.brightnessSlider = new PVSPlayerExample.CustomSlider2();
            this.contrastPanel = new System.Windows.Forms.Panel();
            this.contrastLight = new PVSPlayerExample.LightPanel();
            this.contrastValue = new System.Windows.Forms.Label();
            this.contrastLabel = new System.Windows.Forms.Label();
            this.contrastSlider = new PVSPlayerExample.CustomSlider2();
            this.huePanel = new System.Windows.Forms.Panel();
            this.hueLight = new PVSPlayerExample.LightPanel();
            this.hueValue = new System.Windows.Forms.Label();
            this.hueLabel = new System.Windows.Forms.Label();
            this.hueSlider = new PVSPlayerExample.CustomSlider2();
            this.saturationPanel = new System.Windows.Forms.Panel();
            this.saturationLight = new PVSPlayerExample.LightPanel();
            this.saturationValue = new System.Windows.Forms.Label();
            this.saturationLabel = new System.Windows.Forms.Label();
            this.saturationSlider = new PVSPlayerExample.CustomSlider2();
            this.brightnessPanel.SuspendLayout();
            this.colorDialogMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.brightnessSlider)).BeginInit();
            this.contrastPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contrastSlider)).BeginInit();
            this.huePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hueSlider)).BeginInit();
            this.saturationPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.saturationSlider)).BeginInit();
            this.SuspendLayout();
            // 
            // brightnessPanel
            // 
            this.brightnessPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.brightnessPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.brightnessPanel.ContextMenuStrip = this.colorDialogMenu;
            this.brightnessPanel.Controls.Add(this.brightnessLight);
            this.brightnessPanel.Controls.Add(this.brightnessValue);
            this.brightnessPanel.Controls.Add(this.brightnessLabel);
            this.brightnessPanel.Controls.Add(this.brightnessSlider);
            this.brightnessPanel.Location = new System.Drawing.Point(5, 5);
            this.brightnessPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.brightnessPanel.Name = "brightnessPanel";
            this.brightnessPanel.Size = new System.Drawing.Size(363, 62);
            this.brightnessPanel.TabIndex = 0;
            // 
            // colorDialogMenu
            // 
            this.colorDialogMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.colorDialogMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resetItemMenuItem,
            this.clearItemMenuItem,
            this.toolStripSeparator2,
            this.resetAllMenuItem,
            this.clearAllMenuItem,
            this.toolStripSeparator1,
            this.closeMenuItem});
            this.colorDialogMenu.Name = "contextMenuStrip1";
            this.colorDialogMenu.ShowImageMargin = false;
            this.colorDialogMenu.Size = new System.Drawing.Size(169, 136);
            this.colorDialogMenu.Opening += new System.ComponentModel.CancelEventHandler(this.ColorDialogMenu_Opening);
            // 
            // resetItemMenuItem
            // 
            this.resetItemMenuItem.Name = "resetItemMenuItem";
            this.resetItemMenuItem.Size = new System.Drawing.Size(168, 24);
            this.resetItemMenuItem.Text = "Reset Item";
            this.resetItemMenuItem.Click += new System.EventHandler(this.ResetItemMenuItem_Click);
            // 
            // clearItemMenuItem
            // 
            this.clearItemMenuItem.Name = "clearItemMenuItem";
            this.clearItemMenuItem.Size = new System.Drawing.Size(168, 24);
            this.clearItemMenuItem.Text = "Clear Item";
            this.clearItemMenuItem.Click += new System.EventHandler(this.ClearItemMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(165, 6);
            // 
            // resetAllMenuItem
            // 
            this.resetAllMenuItem.Name = "resetAllMenuItem";
            this.resetAllMenuItem.Size = new System.Drawing.Size(168, 24);
            this.resetAllMenuItem.Text = "Reset All Settings";
            this.resetAllMenuItem.Click += new System.EventHandler(this.ResetAllMenuItem_Click);
            // 
            // clearAllMenuItem
            // 
            this.clearAllMenuItem.Name = "clearAllMenuItem";
            this.clearAllMenuItem.Size = new System.Drawing.Size(168, 24);
            this.clearAllMenuItem.Text = "Clear All Settings";
            this.clearAllMenuItem.Click += new System.EventHandler(this.ClearAllMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(165, 6);
            // 
            // closeMenuItem
            // 
            this.closeMenuItem.Name = "closeMenuItem";
            this.closeMenuItem.Size = new System.Drawing.Size(168, 24);
            this.closeMenuItem.Text = "Close";
            this.closeMenuItem.Click += new System.EventHandler(this.CloseMenuItem_Click);
            // 
            // brightnessLight
            // 
            this.brightnessLight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.brightnessLight.Location = new System.Drawing.Point(12, 26);
            this.brightnessLight.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.brightnessLight.Name = "brightnessLight";
            this.brightnessLight.Size = new System.Drawing.Size(3, 7);
            this.brightnessLight.TabIndex = 3;
            // 
            // brightnessValue
            // 
            this.brightnessValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.brightnessValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brightnessValue.Location = new System.Drawing.Point(303, 6);
            this.brightnessValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.brightnessValue.Name = "brightnessValue";
            this.brightnessValue.Size = new System.Drawing.Size(59, 46);
            this.brightnessValue.TabIndex = 2;
            this.brightnessValue.Text = "0.00";
            this.brightnessValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // brightnessLabel
            // 
            this.brightnessLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brightnessLabel.Location = new System.Drawing.Point(21, 18);
            this.brightnessLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.brightnessLabel.Name = "brightnessLabel";
            this.brightnessLabel.Size = new System.Drawing.Size(96, 23);
            this.brightnessLabel.TabIndex = 0;
            this.brightnessLabel.Text = "Độ sáng";
            // 
            // brightnessSlider
            // 
            this.brightnessSlider.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.brightnessSlider.AutoSize = false;
            this.brightnessSlider.LargeChange = 10;
            this.brightnessSlider.Location = new System.Drawing.Point(112, 5);
            this.brightnessSlider.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.brightnessSlider.Maximum = 100;
            this.brightnessSlider.Minimum = -100;
            this.brightnessSlider.Name = "brightnessSlider";
            this.brightnessSlider.Size = new System.Drawing.Size(197, 55);
            this.brightnessSlider.TabIndex = 1;
            this.brightnessSlider.TickFrequency = 20;
            this.brightnessSlider.TickStyle = System.Windows.Forms.TickStyle.Both;
            // 
            // contrastPanel
            // 
            this.contrastPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.contrastPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.contrastPanel.ContextMenuStrip = this.colorDialogMenu;
            this.contrastPanel.Controls.Add(this.contrastLight);
            this.contrastPanel.Controls.Add(this.contrastValue);
            this.contrastPanel.Controls.Add(this.contrastLabel);
            this.contrastPanel.Controls.Add(this.contrastSlider);
            this.contrastPanel.Location = new System.Drawing.Point(5, 71);
            this.contrastPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.contrastPanel.Name = "contrastPanel";
            this.contrastPanel.Size = new System.Drawing.Size(363, 62);
            this.contrastPanel.TabIndex = 1;
            // 
            // contrastLight
            // 
            this.contrastLight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.contrastLight.Location = new System.Drawing.Point(12, 26);
            this.contrastLight.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.contrastLight.Name = "contrastLight";
            this.contrastLight.Size = new System.Drawing.Size(3, 7);
            this.contrastLight.TabIndex = 4;
            // 
            // contrastValue
            // 
            this.contrastValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.contrastValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contrastValue.Location = new System.Drawing.Point(303, 6);
            this.contrastValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.contrastValue.Name = "contrastValue";
            this.contrastValue.Size = new System.Drawing.Size(59, 46);
            this.contrastValue.TabIndex = 2;
            this.contrastValue.Text = "0.00";
            this.contrastValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // contrastLabel
            // 
            this.contrastLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contrastLabel.Location = new System.Drawing.Point(21, 18);
            this.contrastLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.contrastLabel.Name = "contrastLabel";
            this.contrastLabel.Size = new System.Drawing.Size(96, 23);
            this.contrastLabel.TabIndex = 0;
            this.contrastLabel.Text = "Tương phản";
            // 
            // contrastSlider
            // 
            this.contrastSlider.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.contrastSlider.AutoSize = false;
            this.contrastSlider.LargeChange = 10;
            this.contrastSlider.Location = new System.Drawing.Point(112, 5);
            this.contrastSlider.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.contrastSlider.Maximum = 100;
            this.contrastSlider.Minimum = -100;
            this.contrastSlider.Name = "contrastSlider";
            this.contrastSlider.Size = new System.Drawing.Size(197, 55);
            this.contrastSlider.TabIndex = 1;
            this.contrastSlider.TickFrequency = 20;
            this.contrastSlider.TickStyle = System.Windows.Forms.TickStyle.Both;
            // 
            // huePanel
            // 
            this.huePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.huePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.huePanel.ContextMenuStrip = this.colorDialogMenu;
            this.huePanel.Controls.Add(this.hueLight);
            this.huePanel.Controls.Add(this.hueValue);
            this.huePanel.Controls.Add(this.hueLabel);
            this.huePanel.Controls.Add(this.hueSlider);
            this.huePanel.Location = new System.Drawing.Point(373, 5);
            this.huePanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.huePanel.Name = "huePanel";
            this.huePanel.Size = new System.Drawing.Size(363, 62);
            this.huePanel.TabIndex = 2;
            // 
            // hueLight
            // 
            this.hueLight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.hueLight.Location = new System.Drawing.Point(12, 26);
            this.hueLight.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.hueLight.Name = "hueLight";
            this.hueLight.Size = new System.Drawing.Size(3, 7);
            this.hueLight.TabIndex = 4;
            // 
            // hueValue
            // 
            this.hueValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.hueValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hueValue.Location = new System.Drawing.Point(303, 6);
            this.hueValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.hueValue.Name = "hueValue";
            this.hueValue.Size = new System.Drawing.Size(59, 46);
            this.hueValue.TabIndex = 2;
            this.hueValue.Text = "0.00";
            this.hueValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // hueLabel
            // 
            this.hueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hueLabel.Location = new System.Drawing.Point(21, 18);
            this.hueLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.hueLabel.Name = "hueLabel";
            this.hueLabel.Size = new System.Drawing.Size(96, 23);
            this.hueLabel.TabIndex = 0;
            this.hueLabel.Text = "Màu sắc";
            // 
            // hueSlider
            // 
            this.hueSlider.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.hueSlider.AutoSize = false;
            this.hueSlider.LargeChange = 10;
            this.hueSlider.Location = new System.Drawing.Point(112, 5);
            this.hueSlider.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.hueSlider.Maximum = 100;
            this.hueSlider.Minimum = -100;
            this.hueSlider.Name = "hueSlider";
            this.hueSlider.Size = new System.Drawing.Size(197, 55);
            this.hueSlider.TabIndex = 1;
            this.hueSlider.TickFrequency = 20;
            this.hueSlider.TickStyle = System.Windows.Forms.TickStyle.Both;
            // 
            // saturationPanel
            // 
            this.saturationPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.saturationPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.saturationPanel.ContextMenuStrip = this.colorDialogMenu;
            this.saturationPanel.Controls.Add(this.saturationLight);
            this.saturationPanel.Controls.Add(this.saturationValue);
            this.saturationPanel.Controls.Add(this.saturationLabel);
            this.saturationPanel.Controls.Add(this.saturationSlider);
            this.saturationPanel.Location = new System.Drawing.Point(373, 71);
            this.saturationPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.saturationPanel.Name = "saturationPanel";
            this.saturationPanel.Size = new System.Drawing.Size(363, 62);
            this.saturationPanel.TabIndex = 3;
            // 
            // saturationLight
            // 
            this.saturationLight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.saturationLight.Location = new System.Drawing.Point(12, 26);
            this.saturationLight.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.saturationLight.Name = "saturationLight";
            this.saturationLight.Size = new System.Drawing.Size(3, 7);
            this.saturationLight.TabIndex = 4;
            // 
            // saturationValue
            // 
            this.saturationValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.saturationValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saturationValue.Location = new System.Drawing.Point(303, 6);
            this.saturationValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.saturationValue.Name = "saturationValue";
            this.saturationValue.Size = new System.Drawing.Size(59, 46);
            this.saturationValue.TabIndex = 2;
            this.saturationValue.Text = "0.00";
            this.saturationValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // saturationLabel
            // 
            this.saturationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saturationLabel.Location = new System.Drawing.Point(21, 18);
            this.saturationLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.saturationLabel.Name = "saturationLabel";
            this.saturationLabel.Size = new System.Drawing.Size(96, 23);
            this.saturationLabel.TabIndex = 0;
            this.saturationLabel.Text = "Bão hòa";
            // 
            // saturationSlider
            // 
            this.saturationSlider.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.saturationSlider.AutoSize = false;
            this.saturationSlider.LargeChange = 10;
            this.saturationSlider.Location = new System.Drawing.Point(112, 5);
            this.saturationSlider.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.saturationSlider.Maximum = 100;
            this.saturationSlider.Minimum = -100;
            this.saturationSlider.Name = "saturationSlider";
            this.saturationSlider.Size = new System.Drawing.Size(197, 55);
            this.saturationSlider.TabIndex = 1;
            this.saturationSlider.TickFrequency = 20;
            this.saturationSlider.TickStyle = System.Windows.Forms.TickStyle.Both;
            // 
            // VideoColorDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(744, 140);
            this.Controls.Add(this.brightnessPanel);
            this.Controls.Add(this.contrastPanel);
            this.Controls.Add(this.huePanel);
            this.Controls.Add(this.saturationPanel);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(173)))), ((int)(((byte)(146)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinimizeBox = false;
            this.Name = "VideoColorDialog";
            this.Opacity = 0.95D;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Video Color";
            this.TransparencyKey = System.Drawing.Color.RosyBrown;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.VideoColorDialog_FormClosing);
            this.Shown += new System.EventHandler(this.VideoColorDialog_Shown);
            this.brightnessPanel.ResumeLayout(false);
            this.colorDialogMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.brightnessSlider)).EndInit();
            this.contrastPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.contrastSlider)).EndInit();
            this.huePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.hueSlider)).EndInit();
            this.saturationPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.saturationSlider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel brightnessPanel;
        private System.Windows.Forms.Label brightnessLabel;
        private System.Windows.Forms.Label brightnessValue;
        private CustomSlider2 brightnessSlider;
        private System.Windows.Forms.Panel contrastPanel;
        private System.Windows.Forms.Label contrastValue;
        private System.Windows.Forms.Label contrastLabel;
        private CustomSlider2 contrastSlider;
        private System.Windows.Forms.Panel huePanel;
        private System.Windows.Forms.Label hueValue;
        private System.Windows.Forms.Label hueLabel;
        private CustomSlider2 hueSlider;
        private System.Windows.Forms.Panel saturationPanel;
        private System.Windows.Forms.Label saturationValue;
        private System.Windows.Forms.Label saturationLabel;
        private CustomSlider2 saturationSlider;
        private LightPanel brightnessLight;
        private LightPanel contrastLight;
        private LightPanel hueLight;
        private LightPanel saturationLight;
        private System.Windows.Forms.ContextMenuStrip colorDialogMenu;
        private System.Windows.Forms.ToolStripMenuItem clearAllMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetAllMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetItemMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearItemMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem closeMenuItem;
	}
}