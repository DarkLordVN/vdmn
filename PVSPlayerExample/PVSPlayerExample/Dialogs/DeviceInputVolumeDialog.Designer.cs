
namespace MediaKCTech
{
	partial class DeviceInputVolumeDialog
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
		//	if (disposing && (components != null))
		//	{
		//		components.Dispose();
		//	}
		//	base.Dispose(disposing);
		//}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeviceInputVolumeDialog));
            this.deviceNameLabel = new System.Windows.Forms.Label();
            this.volumeDial = new MediaKCTech.Dial();
            this.volumeSlider = new MediaKCTech.CustomSlider2();
            this.volumeLabel = new System.Windows.Forms.Label();
            this.volumeMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.muteMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lowVolumeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mediumVolumeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.highVolumeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maximumVolumeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bottomPanel = new System.Windows.Forms.Panel();
            this.muteButton = new MediaKCTech.CustomButton();
            this.OKButton = new MediaKCTech.CustomButton();
            this.pvsPanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.volumeSlider)).BeginInit();
            this.volumeMenu.SuspendLayout();
            this.bottomPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // deviceNameLabel
            // 
            this.deviceNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.deviceNameLabel.AutoEllipsis = true;
            this.deviceNameLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deviceNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deviceNameLabel.ForeColor = System.Drawing.Color.Black;
            this.deviceNameLabel.Location = new System.Drawing.Point(12, 26);
            this.deviceNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.deviceNameLabel.Name = "deviceNameLabel";
            this.deviceNameLabel.Size = new System.Drawing.Size(621, 28);
            this.deviceNameLabel.TabIndex = 0;
            this.deviceNameLabel.Text = "Thiết bị";
            this.deviceNameLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.deviceNameLabel.Click += new System.EventHandler(this.DeviceNameLabel_Click);
            // 
            // volumeDial
            // 
            this.volumeDial.Image = ((System.Drawing.Bitmap)(resources.GetObject("volumeDial.Image")));
            this.volumeDial.Location = new System.Drawing.Point(25, 64);
            this.volumeDial.Margin = new System.Windows.Forms.Padding(4);
            this.volumeDial.MaximumSize = new System.Drawing.Size(55, 55);
            this.volumeDial.MinimumSize = new System.Drawing.Size(55, 55);
            this.volumeDial.Name = "volumeDial";
            this.volumeDial.Size = new System.Drawing.Size(55, 55);
            this.volumeDial.TabIndex = 1;
            this.volumeDial.Text = "dial1";
            this.volumeDial.Value = 0;
            this.volumeDial.ValueChanged += new System.EventHandler<MediaKCTech.Dial.ValueChangedEventArgs>(this.VolumeDial_ValueChanged);
            this.volumeDial.MouseDown += new System.Windows.Forms.MouseEventHandler(this.VolumeControl_MouseDown);
            this.volumeDial.MouseUp += new System.Windows.Forms.MouseEventHandler(this.VolumeControl_MouseUp);
            // 
            // volumeSlider
            // 
            this.volumeSlider.AutoSize = false;
            this.volumeSlider.LargeChange = 10;
            this.volumeSlider.Location = new System.Drawing.Point(105, 71);
            this.volumeSlider.Margin = new System.Windows.Forms.Padding(4);
            this.volumeSlider.Maximum = 100;
            this.volumeSlider.Name = "volumeSlider";
            this.volumeSlider.Size = new System.Drawing.Size(445, 55);
            this.volumeSlider.TabIndex = 2;
            this.volumeSlider.TickFrequency = 5;
            this.volumeSlider.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.volumeSlider.ValueChanged += new System.EventHandler(this.VolumeSlider_ValueChanged);
            this.volumeSlider.MouseDown += new System.Windows.Forms.MouseEventHandler(this.VolumeControl_MouseDown);
            this.volumeSlider.MouseUp += new System.Windows.Forms.MouseEventHandler(this.VolumeControl_MouseUp);
            // 
            // volumeLabel
            // 
            this.volumeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.volumeLabel.ForeColor = System.Drawing.Color.Black;
            this.volumeLabel.Location = new System.Drawing.Point(547, 75);
            this.volumeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.volumeLabel.Name = "volumeLabel";
            this.volumeLabel.Size = new System.Drawing.Size(92, 42);
            this.volumeLabel.TabIndex = 3;
            this.volumeLabel.Text = "75";
            this.volumeLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // volumeMenu
            // 
            this.volumeMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.volumeMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.muteMenuItem,
            this.lowVolumeMenuItem,
            this.mediumVolumeMenuItem,
            this.highVolumeMenuItem,
            this.maximumVolumeMenuItem});
            this.volumeMenu.Name = "volumeMenu";
            this.volumeMenu.ShowImageMargin = false;
            this.volumeMenu.Size = new System.Drawing.Size(174, 124);
            // 
            // muteMenuItem
            // 
            this.muteMenuItem.Name = "muteMenuItem";
            this.muteMenuItem.Size = new System.Drawing.Size(173, 24);
            this.muteMenuItem.Text = "Fade Out";
            this.muteMenuItem.Click += new System.EventHandler(this.MuteMenuItem_Click);
            // 
            // lowVolumeMenuItem
            // 
            this.lowVolumeMenuItem.Name = "lowVolumeMenuItem";
            this.lowVolumeMenuItem.Size = new System.Drawing.Size(173, 24);
            this.lowVolumeMenuItem.Text = "Low Volume";
            this.lowVolumeMenuItem.Click += new System.EventHandler(this.LowVolumeMenuItem_Click);
            // 
            // mediumVolumeMenuItem
            // 
            this.mediumVolumeMenuItem.Name = "mediumVolumeMenuItem";
            this.mediumVolumeMenuItem.Size = new System.Drawing.Size(173, 24);
            this.mediumVolumeMenuItem.Text = "Medium Volume";
            this.mediumVolumeMenuItem.Click += new System.EventHandler(this.MediumVolumeMenuItem_Click);
            // 
            // highVolumeMenuItem
            // 
            this.highVolumeMenuItem.Name = "highVolumeMenuItem";
            this.highVolumeMenuItem.Size = new System.Drawing.Size(173, 24);
            this.highVolumeMenuItem.Text = "High Volume";
            this.highVolumeMenuItem.Click += new System.EventHandler(this.HighVolumeMenuItem_Click);
            // 
            // maximumVolumeMenuItem
            // 
            this.maximumVolumeMenuItem.Name = "maximumVolumeMenuItem";
            this.maximumVolumeMenuItem.Size = new System.Drawing.Size(173, 24);
            this.maximumVolumeMenuItem.Text = "Maximum Volume";
            this.maximumVolumeMenuItem.Click += new System.EventHandler(this.MaximumVolumeMenuItem_Click);
            // 
            // bottomPanel
            // 
            this.bottomPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bottomPanel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.bottomPanel.Controls.Add(this.muteButton);
            this.bottomPanel.Controls.Add(this.OKButton);
            this.bottomPanel.Controls.Add(this.pvsPanel);
            this.bottomPanel.Location = new System.Drawing.Point(1, 149);
            this.bottomPanel.Margin = new System.Windows.Forms.Padding(4);
            this.bottomPanel.Name = "bottomPanel";
            this.bottomPanel.Size = new System.Drawing.Size(640, 62);
            this.bottomPanel.TabIndex = 4;
            // 
            // muteButton
            // 
            this.muteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.muteButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.muteButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.muteButton.FocusBorder = true;
            this.muteButton.ForeColor = System.Drawing.Color.White;
            this.muteButton.Location = new System.Drawing.Point(388, 18);
            this.muteButton.Margin = new System.Windows.Forms.Padding(4);
            this.muteButton.Name = "muteButton";
            this.muteButton.Size = new System.Drawing.Size(112, 28);
            this.muteButton.TabIndex = 2;
            this.muteButton.Text = "Tắt tiếng";
            this.muteButton.UseVisualStyleBackColor = false;
            this.muteButton.Click += new System.EventHandler(this.MuteButton_Click);
            // 
            // OKButton
            // 
            this.OKButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.OKButton.FocusBorder = true;
            this.OKButton.ForeColor = System.Drawing.Color.White;
            this.OKButton.Location = new System.Drawing.Point(512, 18);
            this.OKButton.Margin = new System.Windows.Forms.Padding(4);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(112, 28);
            this.OKButton.TabIndex = 1;
            this.OKButton.Text = "Xác nhận";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // pvsPanel
            // 
            this.pvsPanel.Location = new System.Drawing.Point(13, 12);
            this.pvsPanel.Margin = new System.Windows.Forms.Padding(4);
            this.pvsPanel.Name = "pvsPanel";
            this.pvsPanel.Size = new System.Drawing.Size(56, 41);
            this.pvsPanel.TabIndex = 0;
            this.pvsPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.PvsPanel_Paint);
            // 
            // DeviceInputVolumeDialog
            // 
            this.AcceptButton = this.OKButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(644, 213);
            this.ContextMenuStrip = this.volumeMenu;
            this.Controls.Add(this.bottomPanel);
            this.Controls.Add(this.volumeSlider);
            this.Controls.Add(this.volumeLabel);
            this.Controls.Add(this.volumeDial);
            this.Controls.Add(this.deviceNameLabel);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(173)))), ((int)(((byte)(146)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DeviceInputVolumeDialog";
            this.Opacity = 0.95D;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Âm lượng đầu vào của thiết bị âm thanh";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MasterVolumeDialog_FormClosing);
            this.Shown += new System.EventHandler(this.MasterVolumeDialog_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.volumeSlider)).EndInit();
            this.volumeMenu.ResumeLayout(false);
            this.bottomPanel.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label deviceNameLabel;
		private Dial volumeDial;
		private CustomSlider2 volumeSlider;
		private System.Windows.Forms.Label volumeLabel;
		private System.Windows.Forms.ContextMenuStrip volumeMenu;
		private System.Windows.Forms.ToolStripMenuItem muteMenuItem;
		private System.Windows.Forms.ToolStripMenuItem lowVolumeMenuItem;
		private System.Windows.Forms.ToolStripMenuItem mediumVolumeMenuItem;
		private System.Windows.Forms.ToolStripMenuItem highVolumeMenuItem;
		private System.Windows.Forms.ToolStripMenuItem maximumVolumeMenuItem;
		private System.Windows.Forms.Panel bottomPanel;
		private System.Windows.Forms.Panel pvsPanel;
		private CustomButton OKButton;
		private CustomButton muteButton;
	}
}