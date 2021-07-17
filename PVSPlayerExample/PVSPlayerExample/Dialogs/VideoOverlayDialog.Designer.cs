
namespace PVSPlayerExample
{
	partial class VideoOverlayDialog
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
            this.bitmapLabel = new System.Windows.Forms.Label();
            this.transparencyButton = new PVSPlayerExample.DropDownButton();
            this.transparencyMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.fromDialogMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fromMouseMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fromScanMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.offMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opacityButton = new PVSPlayerExample.DropDownButton();
            this.opacityMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem8 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem9 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem10 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem11 = new System.Windows.Forms.ToolStripMenuItem();
            this.clearButton = new PVSPlayerExample.CustomButton();
            this.openButton = new PVSPlayerExample.CustomButton();
            this.placementButton = new PVSPlayerExample.DropDownButton();
            this.placementMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.bottomPanel = new System.Windows.Forms.Panel();
            this.applyButton = new PVSPlayerExample.CustomButton();
            this.okButton = new PVSPlayerExample.CustomButton();
            this.cancelButton = new PVSPlayerExample.CustomButton();
            this.pvsPanel = new System.Windows.Forms.Panel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.transparencyColorPanel = new System.Windows.Forms.Panel();
            this.placementLight = new PVSPlayerExample.LightPanel();
            this.opacityLight = new PVSPlayerExample.LightPanel();
            this.bitmapPanel = new PVSPlayerExample.BufferedPanel();
            this.displayMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.flipXToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flipYToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flipXYToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.rotate90ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rotate90ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.rotate270ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.sepiaMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inverseMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grayscaleMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blackWhiteMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.restoreBitmapMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transparencyMenu.SuspendLayout();
            this.opacityMenu.SuspendLayout();
            this.bottomPanel.SuspendLayout();
            this.bitmapPanel.SuspendLayout();
            this.displayMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // bitmapLabel
            // 
            this.bitmapLabel.BackColor = System.Drawing.Color.Transparent;
            this.bitmapLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bitmapLabel.ForeColor = System.Drawing.Color.White;
            this.bitmapLabel.Location = new System.Drawing.Point(5, 5);
            this.bitmapLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bitmapLabel.Name = "bitmapLabel";
            this.bitmapLabel.Size = new System.Drawing.Size(403, 276);
            this.bitmapLabel.TabIndex = 0;
            this.bitmapLabel.Text = "[ Dán hoặc kéo thả 1 ảnh vào đây ]";
            this.bitmapLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // transparencyButton
            // 
            this.transparencyButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.transparencyButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.transparencyButton.DropDown = this.transparencyMenu;
            this.transparencyButton.ForeColor = System.Drawing.Color.White;
            this.transparencyButton.Location = new System.Drawing.Point(167, 25);
            this.transparencyButton.Margin = new System.Windows.Forms.Padding(4);
            this.transparencyButton.Name = "transparencyButton";
            this.transparencyButton.Size = new System.Drawing.Size(133, 28);
            this.transparencyButton.TabIndex = 2;
            this.transparencyButton.TabStop = false;
            this.transparencyButton.Text = "Transparency ";
            this.toolTip1.SetToolTip(this.transparencyButton, "Off");
            this.transparencyButton.UseVisualStyleBackColor = true;
            // 
            // transparencyMenu
            // 
            this.transparencyMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.transparencyMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fromDialogMenuItem,
            this.fromMouseMenuItem,
            this.fromScanMenuItem,
            this.toolStripSeparator1,
            this.offMenuItem});
            this.transparencyMenu.Name = "transparencyMenu";
            this.transparencyMenu.Size = new System.Drawing.Size(237, 114);
            // 
            // fromDialogMenuItem
            // 
            this.fromDialogMenuItem.Enabled = false;
            this.fromDialogMenuItem.Name = "fromDialogMenuItem";
            this.fromDialogMenuItem.Size = new System.Drawing.Size(236, 26);
            this.fromDialogMenuItem.Text = "From Color Dialog…";
            this.fromDialogMenuItem.Click += new System.EventHandler(this.FromDialogMenuItem_Click);
            // 
            // fromMouseMenuItem
            // 
            this.fromMouseMenuItem.Enabled = false;
            this.fromMouseMenuItem.Name = "fromMouseMenuItem";
            this.fromMouseMenuItem.Size = new System.Drawing.Size(236, 26);
            this.fromMouseMenuItem.Text = "From Mouse Selection…";
            this.fromMouseMenuItem.Click += new System.EventHandler(this.FromMouseMenuItem_Click);
            // 
            // fromScanMenuItem
            // 
            this.fromScanMenuItem.Enabled = false;
            this.fromScanMenuItem.Name = "fromScanMenuItem";
            this.fromScanMenuItem.Size = new System.Drawing.Size(236, 26);
            this.fromScanMenuItem.Text = "From Image Scan";
            this.fromScanMenuItem.Click += new System.EventHandler(this.FromScanMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(233, 6);
            // 
            // offMenuItem
            // 
            this.offMenuItem.Checked = true;
            this.offMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.offMenuItem.Name = "offMenuItem";
            this.offMenuItem.Size = new System.Drawing.Size(236, 26);
            this.offMenuItem.Text = "Transparency Off";
            this.offMenuItem.Click += new System.EventHandler(this.OffMenuItem_Click);
            // 
            // opacityButton
            // 
            this.opacityButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.opacityButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.opacityButton.DropDown = this.opacityMenu;
            this.opacityButton.ForeColor = System.Drawing.Color.White;
            this.opacityButton.Location = new System.Drawing.Point(308, 25);
            this.opacityButton.Margin = new System.Windows.Forms.Padding(4);
            this.opacityButton.Name = "opacityButton";
            this.opacityButton.Size = new System.Drawing.Size(133, 28);
            this.opacityButton.TabIndex = 4;
            this.opacityButton.TabStop = false;
            this.opacityButton.Text = "Opacity ";
            this.toolTip1.SetToolTip(this.opacityButton, "100%");
            this.opacityButton.UseVisualStyleBackColor = true;
            // 
            // opacityMenu
            // 
            this.opacityMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.opacityMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4,
            this.toolStripMenuItem5,
            this.toolStripMenuItem6,
            this.toolStripMenuItem7,
            this.toolStripMenuItem8,
            this.toolStripMenuItem9,
            this.toolStripMenuItem10,
            this.toolStripMenuItem11});
            this.opacityMenu.Name = "opacityMenu";
            this.opacityMenu.Size = new System.Drawing.Size(115, 264);
            this.opacityMenu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.OpacityMenu_ItemClicked);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(114, 26);
            this.toolStripMenuItem2.Text = "  10%";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(114, 26);
            this.toolStripMenuItem3.Text = "  20%";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(114, 26);
            this.toolStripMenuItem4.Text = "  30%";
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(114, 26);
            this.toolStripMenuItem5.Text = "  40%";
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(114, 26);
            this.toolStripMenuItem6.Text = "  50%";
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(114, 26);
            this.toolStripMenuItem7.Text = "  60%";
            // 
            // toolStripMenuItem8
            // 
            this.toolStripMenuItem8.Name = "toolStripMenuItem8";
            this.toolStripMenuItem8.Size = new System.Drawing.Size(114, 26);
            this.toolStripMenuItem8.Text = "  70%";
            // 
            // toolStripMenuItem9
            // 
            this.toolStripMenuItem9.Name = "toolStripMenuItem9";
            this.toolStripMenuItem9.Size = new System.Drawing.Size(114, 26);
            this.toolStripMenuItem9.Text = "  80%";
            // 
            // toolStripMenuItem10
            // 
            this.toolStripMenuItem10.Name = "toolStripMenuItem10";
            this.toolStripMenuItem10.Size = new System.Drawing.Size(114, 26);
            this.toolStripMenuItem10.Text = "  90%";
            // 
            // toolStripMenuItem11
            // 
            this.toolStripMenuItem11.Checked = true;
            this.toolStripMenuItem11.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolStripMenuItem11.Name = "toolStripMenuItem11";
            this.toolStripMenuItem11.Size = new System.Drawing.Size(114, 26);
            this.toolStripMenuItem11.Text = "100%";
            // 
            // clearButton
            // 
            this.clearButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.clearButton.Enabled = false;
            this.clearButton.ForeColor = System.Drawing.Color.White;
            this.clearButton.Location = new System.Drawing.Point(25, 356);
            this.clearButton.Margin = new System.Windows.Forms.Padding(4);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(204, 28);
            this.clearButton.TabIndex = 7;
            this.clearButton.TabStop = false;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // openButton
            // 
            this.openButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.openButton.ForeColor = System.Drawing.Color.White;
            this.openButton.Location = new System.Drawing.Point(237, 356);
            this.openButton.Margin = new System.Windows.Forms.Padding(4);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(204, 28);
            this.openButton.TabIndex = 8;
            this.openButton.TabStop = false;
            this.openButton.Text = "Select Image…";
            this.openButton.UseVisualStyleBackColor = true;
            this.openButton.Click += new System.EventHandler(this.OpenButton_Click);
            // 
            // placementButton
            // 
            this.placementButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.placementButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.placementButton.DropDown = this.placementMenu;
            this.placementButton.ForeColor = System.Drawing.Color.White;
            this.placementButton.Location = new System.Drawing.Point(25, 25);
            this.placementButton.Margin = new System.Windows.Forms.Padding(4);
            this.placementButton.Name = "placementButton";
            this.placementButton.Size = new System.Drawing.Size(133, 28);
            this.placementButton.TabIndex = 0;
            this.placementButton.TabStop = false;
            this.placementButton.Text = "Placement";
            this.toolTip1.SetToolTip(this.placementButton, "Stretch");
            this.placementButton.UseVisualStyleBackColor = true;
            // 
            // placementMenu
            // 
            this.placementMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.placementMenu.Name = "placementMenu";
            this.placementMenu.Size = new System.Drawing.Size(61, 4);
            this.placementMenu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.PlacementMenu_ItemClicked);
            // 
            // bottomPanel
            // 
            this.bottomPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bottomPanel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.bottomPanel.Controls.Add(this.applyButton);
            this.bottomPanel.Controls.Add(this.okButton);
            this.bottomPanel.Controls.Add(this.cancelButton);
            this.bottomPanel.Controls.Add(this.pvsPanel);
            this.bottomPanel.Location = new System.Drawing.Point(1, 406);
            this.bottomPanel.Margin = new System.Windows.Forms.Padding(4);
            this.bottomPanel.Name = "bottomPanel";
            this.bottomPanel.Size = new System.Drawing.Size(461, 62);
            this.bottomPanel.TabIndex = 9;
            // 
            // applyButton
            // 
            this.applyButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.applyButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.applyButton.FocusBorder = true;
            this.applyButton.ForeColor = System.Drawing.Color.White;
            this.applyButton.Location = new System.Drawing.Point(335, 17);
            this.applyButton.Margin = new System.Windows.Forms.Padding(4);
            this.applyButton.Name = "applyButton";
            this.applyButton.Size = new System.Drawing.Size(112, 28);
            this.applyButton.TabIndex = 3;
            this.applyButton.Text = "Apply";
            this.applyButton.UseVisualStyleBackColor = false;
            this.applyButton.Click += new System.EventHandler(this.ApplyButton_Click);
            // 
            // okButton
            // 
            this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.okButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okButton.FocusBorder = true;
            this.okButton.ForeColor = System.Drawing.Color.White;
            this.okButton.Location = new System.Drawing.Point(87, 17);
            this.okButton.Margin = new System.Windows.Forms.Padding(4);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(112, 28);
            this.okButton.TabIndex = 1;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = false;
            this.okButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.FocusBorder = true;
            this.cancelButton.ForeColor = System.Drawing.Color.White;
            this.cancelButton.Location = new System.Drawing.Point(211, 17);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(4);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(112, 28);
            this.cancelButton.TabIndex = 2;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.CancelButton_Click);
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
            // transparencyColorPanel
            // 
            this.transparencyColorPanel.BackColor = System.Drawing.Color.White;
            this.transparencyColorPanel.ForeColor = System.Drawing.Color.White;
            this.transparencyColorPanel.Location = new System.Drawing.Point(176, 36);
            this.transparencyColorPanel.Margin = new System.Windows.Forms.Padding(4);
            this.transparencyColorPanel.Name = "transparencyColorPanel";
            this.transparencyColorPanel.Size = new System.Drawing.Size(3, 7);
            this.transparencyColorPanel.TabIndex = 3;
            this.toolTip1.SetToolTip(this.transparencyColorPanel, "Transparency Off");
            // 
            // placementLight
            // 
            this.placementLight.BackColor = System.Drawing.Color.White;
            this.placementLight.Location = new System.Drawing.Point(35, 36);
            this.placementLight.Margin = new System.Windows.Forms.Padding(4);
            this.placementLight.Name = "placementLight";
            this.placementLight.Size = new System.Drawing.Size(3, 7);
            this.placementLight.TabIndex = 1;
            // 
            // opacityLight
            // 
            this.opacityLight.BackColor = System.Drawing.Color.White;
            this.opacityLight.Location = new System.Drawing.Point(317, 36);
            this.opacityLight.Margin = new System.Windows.Forms.Padding(4);
            this.opacityLight.Name = "opacityLight";
            this.opacityLight.Size = new System.Drawing.Size(3, 7);
            this.opacityLight.TabIndex = 5;
            // 
            // bitmapPanel
            // 
            this.bitmapPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(18)))), ((int)(((byte)(19)))));
            this.bitmapPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bitmapPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bitmapPanel.Controls.Add(this.bitmapLabel);
            this.bitmapPanel.Location = new System.Drawing.Point(25, 60);
            this.bitmapPanel.Margin = new System.Windows.Forms.Padding(4);
            this.bitmapPanel.Name = "bitmapPanel";
            this.bitmapPanel.Size = new System.Drawing.Size(415, 288);
            this.bitmapPanel.TabIndex = 6;
            // 
            // displayMenu
            // 
            this.displayMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.displayMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.flipXToolStripMenuItem,
            this.flipYToolStripMenuItem,
            this.flipXYToolStripMenuItem,
            this.toolStripSeparator2,
            this.rotate90ToolStripMenuItem,
            this.rotate90ToolStripMenuItem1,
            this.rotate270ToolStripMenuItem,
            this.toolStripSeparator3,
            this.sepiaMenuItem,
            this.inverseMenuItem,
            this.grayscaleMenuItem,
            this.blackWhiteMenuItem,
            this.toolStripSeparator4,
            this.restoreBitmapMenuItem});
            this.displayMenu.Name = "rotateMenu";
            this.displayMenu.ShowImageMargin = false;
            this.displayMenu.Size = new System.Drawing.Size(162, 286);
            this.displayMenu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.DisplayMenu_ItemClicked);
            // 
            // flipXToolStripMenuItem
            // 
            this.flipXToolStripMenuItem.Name = "flipXToolStripMenuItem";
            this.flipXToolStripMenuItem.Size = new System.Drawing.Size(161, 24);
            this.flipXToolStripMenuItem.Text = "Flip X";
            // 
            // flipYToolStripMenuItem
            // 
            this.flipYToolStripMenuItem.Name = "flipYToolStripMenuItem";
            this.flipYToolStripMenuItem.Size = new System.Drawing.Size(161, 24);
            this.flipYToolStripMenuItem.Text = "Flip Y";
            // 
            // flipXYToolStripMenuItem
            // 
            this.flipXYToolStripMenuItem.Name = "flipXYToolStripMenuItem";
            this.flipXYToolStripMenuItem.Size = new System.Drawing.Size(161, 24);
            this.flipXYToolStripMenuItem.Text = "Flip XY";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(158, 6);
            // 
            // rotate90ToolStripMenuItem
            // 
            this.rotate90ToolStripMenuItem.Name = "rotate90ToolStripMenuItem";
            this.rotate90ToolStripMenuItem.Size = new System.Drawing.Size(161, 24);
            this.rotate90ToolStripMenuItem.Text = "Rotate   90°";
            // 
            // rotate90ToolStripMenuItem1
            // 
            this.rotate90ToolStripMenuItem1.Name = "rotate90ToolStripMenuItem1";
            this.rotate90ToolStripMenuItem1.Size = new System.Drawing.Size(161, 24);
            this.rotate90ToolStripMenuItem1.Text = "Rotate 180°";
            // 
            // rotate270ToolStripMenuItem
            // 
            this.rotate270ToolStripMenuItem.Name = "rotate270ToolStripMenuItem";
            this.rotate270ToolStripMenuItem.Size = new System.Drawing.Size(161, 24);
            this.rotate270ToolStripMenuItem.Text = "Rotate 270°";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(158, 6);
            // 
            // sepiaMenuItem
            // 
            this.sepiaMenuItem.Name = "sepiaMenuItem";
            this.sepiaMenuItem.Size = new System.Drawing.Size(161, 24);
            this.sepiaMenuItem.Text = "+ Sepia";
            // 
            // inverseMenuItem
            // 
            this.inverseMenuItem.Name = "inverseMenuItem";
            this.inverseMenuItem.Size = new System.Drawing.Size(161, 24);
            this.inverseMenuItem.Text = "+ Inverse";
            // 
            // grayscaleMenuItem
            // 
            this.grayscaleMenuItem.Name = "grayscaleMenuItem";
            this.grayscaleMenuItem.Size = new System.Drawing.Size(161, 24);
            this.grayscaleMenuItem.Text = "+ Grayscale";
            // 
            // blackWhiteMenuItem
            // 
            this.blackWhiteMenuItem.Name = "blackWhiteMenuItem";
            this.blackWhiteMenuItem.Size = new System.Drawing.Size(161, 24);
            this.blackWhiteMenuItem.Text = "+ Black && White";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(158, 6);
            // 
            // restoreBitmapMenuItem
            // 
            this.restoreBitmapMenuItem.Name = "restoreBitmapMenuItem";
            this.restoreBitmapMenuItem.Size = new System.Drawing.Size(161, 24);
            this.restoreBitmapMenuItem.Text = "Restore Image";
            // 
            // VideoOverlayDialog
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(465, 470);
            this.Controls.Add(this.bitmapPanel);
            this.Controls.Add(this.opacityLight);
            this.Controls.Add(this.placementLight);
            this.Controls.Add(this.transparencyColorPanel);
            this.Controls.Add(this.opacityButton);
            this.Controls.Add(this.transparencyButton);
            this.Controls.Add(this.placementButton);
            this.Controls.Add(this.bottomPanel);
            this.Controls.Add(this.openButton);
            this.Controls.Add(this.clearButton);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "VideoOverlayDialog";
            this.Opacity = 0.95D;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Video Image Overlay";
            this.Shown += new System.EventHandler(this.BitmapOverlayDialog_Shown);
            this.transparencyMenu.ResumeLayout(false);
            this.opacityMenu.ResumeLayout(false);
            this.bottomPanel.ResumeLayout(false);
            this.bitmapPanel.ResumeLayout(false);
            this.displayMenu.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Label bitmapLabel;
		private DropDownButton transparencyButton;
		private DropDownButton opacityButton;
		private CustomButton clearButton;
		private CustomButton openButton;
		private DropDownButton placementButton;
		private System.Windows.Forms.Panel bottomPanel;
		private System.Windows.Forms.Panel pvsPanel;
		private CustomButton cancelButton;
		private CustomButton okButton;
		private System.Windows.Forms.ContextMenuStrip transparencyMenu;
		private System.Windows.Forms.ContextMenuStrip opacityMenu;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem7;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem8;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem9;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem10;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem11;
		private System.Windows.Forms.ContextMenuStrip placementMenu;
		private System.Windows.Forms.ToolStripMenuItem fromDialogMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem offMenuItem;
		private System.Windows.Forms.ToolTip toolTip1;
		private System.Windows.Forms.ToolStripMenuItem fromMouseMenuItem;
		private System.Windows.Forms.Panel transparencyColorPanel;
		private LightPanel placementLight;
		private LightPanel opacityLight;
		private BufferedPanel bitmapPanel;
		private System.Windows.Forms.ContextMenuStrip displayMenu;
		private System.Windows.Forms.ToolStripMenuItem flipXToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem flipYToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem flipXYToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripMenuItem rotate90ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem rotate90ToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem rotate270ToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
		private System.Windows.Forms.ToolStripMenuItem sepiaMenuItem;
		private System.Windows.Forms.ToolStripMenuItem inverseMenuItem;
		private System.Windows.Forms.ToolStripMenuItem grayscaleMenuItem;
		private System.Windows.Forms.ToolStripMenuItem blackWhiteMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
		private System.Windows.Forms.ToolStripMenuItem restoreBitmapMenuItem;
		private CustomButton applyButton;
		private System.Windows.Forms.ToolStripMenuItem fromScanMenuItem;
	}
}