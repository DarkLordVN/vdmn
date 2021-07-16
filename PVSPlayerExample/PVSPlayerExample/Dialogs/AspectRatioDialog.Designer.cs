namespace PVSPlayerExample
{
    partial class AspectRatioDialog
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
            this.headLabel = new System.Windows.Forms.Label();
            this.infoLabel = new System.Windows.Forms.Label();
            this.widthBox = new System.Windows.Forms.TextBox();
            this.heightBox = new System.Windows.Forms.TextBox();
            this.colonLabel = new System.Windows.Forms.Label();
            this.presetButton = new PVSPlayerExample.DropDownButton();
            this.presetRatesMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem10 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem8 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem9 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.reversedMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restoreCheckBox = new System.Windows.Forms.CheckBox();
            this.dvdCheckBox = new System.Windows.Forms.CheckBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.widthErrorPanel = new System.Windows.Forms.Panel();
            this.heightErrorPanel = new System.Windows.Forms.Panel();
            this.bottomPanel = new System.Windows.Forms.Panel();
            this.updateButton = new PVSPlayerExample.CustomButton();
            this.pvsPanel = new System.Windows.Forms.Panel();
            this.cancelButton = new PVSPlayerExample.CustomButton();
            this.okButton = new PVSPlayerExample.CustomButton();
            this.useRatioCheckBox = new System.Windows.Forms.CheckBox();
            this.displayPanel = new System.Windows.Forms.Panel();
            this.videoPanel = new PVSPlayerExample.VideoPanel();
            this.nameLabel = new System.Windows.Forms.Label();
            this.sizeTitleLabel = new System.Windows.Forms.Label();
            this.sizeLabel = new System.Windows.Forms.Label();
            this.presetRatesMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.bottomPanel.SuspendLayout();
            this.displayPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // headLabel
            // 
            this.headLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.headLabel.AutoSize = true;
            this.headLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(173)))), ((int)(((byte)(146)))));
            this.headLabel.Location = new System.Drawing.Point(467, 15);
            this.headLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.headLabel.Name = "headLabel";
            this.headLabel.Size = new System.Drawing.Size(208, 25);
            this.headLabel.TabIndex = 1;
            this.headLabel.Text = "Tỷ lệ khung hình video";
            // 
            // infoLabel
            // 
            this.infoLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.infoLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(173)))), ((int)(((byte)(146)))));
            this.infoLabel.Location = new System.Drawing.Point(468, 62);
            this.infoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(463, 39);
            this.infoLabel.TabIndex = 2;
            this.infoLabel.Text = "ếu hình ảnh video không được hiển thị theo đúng tỷ lệ khung hình, bạn có thể đặt " +
    "tỷ lệ khung hình chính xác tại đây, ví dụ: 16: 9 cho màn hình rộng HD.";
            // 
            // widthBox
            // 
            this.widthBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.widthBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.widthBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.widthBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.widthBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(173)))), ((int)(((byte)(146)))));
            this.errorProvider1.SetIconAlignment(this.widthBox, System.Windows.Forms.ErrorIconAlignment.MiddleLeft);
            this.widthBox.Location = new System.Drawing.Point(593, 204);
            this.widthBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.widthBox.MaxLength = 5;
            this.widthBox.Name = "widthBox";
            this.widthBox.Size = new System.Drawing.Size(74, 26);
            this.widthBox.TabIndex = 9;
            this.widthBox.Text = "16";
            this.widthBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.widthBox.Enter += new System.EventHandler(this.TextBox_Enter);
            this.widthBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            this.widthBox.Validating += new System.ComponentModel.CancelEventHandler(this.WidthBox_Validating);
            // 
            // heightBox
            // 
            this.heightBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.heightBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.heightBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.heightBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.heightBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(173)))), ((int)(((byte)(146)))));
            this.heightBox.Location = new System.Drawing.Point(691, 204);
            this.heightBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.heightBox.MaxLength = 5;
            this.heightBox.Name = "heightBox";
            this.heightBox.Size = new System.Drawing.Size(74, 26);
            this.heightBox.TabIndex = 11;
            this.heightBox.Text = "9";
            this.heightBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.heightBox.Enter += new System.EventHandler(this.TextBox_Enter);
            this.heightBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            this.heightBox.Validating += new System.ComponentModel.CancelEventHandler(this.HeightBox_Validating);
            // 
            // colonLabel
            // 
            this.colonLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.colonLabel.AutoSize = true;
            this.colonLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(173)))), ((int)(((byte)(146)))));
            this.colonLabel.Location = new System.Drawing.Point(673, 209);
            this.colonLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.colonLabel.Name = "colonLabel";
            this.colonLabel.Size = new System.Drawing.Size(12, 17);
            this.colonLabel.TabIndex = 10;
            this.colonLabel.Text = ":";
            // 
            // presetButton
            // 
            this.presetButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.presetButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.presetButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.presetButton.DropDown = this.presetRatesMenu;
            this.presetButton.Location = new System.Drawing.Point(785, 204);
            this.presetButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.presetButton.Name = "presetButton";
            this.presetButton.Size = new System.Drawing.Size(124, 27);
            this.presetButton.TabIndex = 12;
            this.presetButton.Text = "Đặt trước";
            this.presetButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.presetButton.UseVisualStyleBackColor = true;
            // 
            // presetRatesMenu
            // 
            this.presetRatesMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.presetRatesMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4,
            this.toolStripMenuItem5,
            this.toolStripMenuItem6,
            this.toolStripMenuItem7,
            this.toolStripMenuItem10,
            this.toolStripMenuItem8,
            this.toolStripMenuItem9,
            this.toolStripSeparator1,
            this.reversedMenuItem});
            this.presetRatesMenu.Name = "presetRatesMenu";
            this.presetRatesMenu.Size = new System.Drawing.Size(153, 250);
            this.presetRatesMenu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.PresetRatesMenu_ItemClicked);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(210, 24);
            this.toolStripMenuItem2.Text = "1:1";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(210, 24);
            this.toolStripMenuItem3.Text = "5:4";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(210, 24);
            this.toolStripMenuItem4.Text = "4:3";
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(210, 24);
            this.toolStripMenuItem5.Text = "16:10";
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(210, 24);
            this.toolStripMenuItem6.Text = "16:9";
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(210, 24);
            this.toolStripMenuItem7.Text = "1.85:1";
            // 
            // toolStripMenuItem10
            // 
            this.toolStripMenuItem10.Name = "toolStripMenuItem10";
            this.toolStripMenuItem10.Size = new System.Drawing.Size(210, 24);
            this.toolStripMenuItem10.Text = "2:1";
            // 
            // toolStripMenuItem8
            // 
            this.toolStripMenuItem8.Name = "toolStripMenuItem8";
            this.toolStripMenuItem8.Size = new System.Drawing.Size(210, 24);
            this.toolStripMenuItem8.Text = "2.35:1";
            // 
            // toolStripMenuItem9
            // 
            this.toolStripMenuItem9.Name = "toolStripMenuItem9";
            this.toolStripMenuItem9.Size = new System.Drawing.Size(210, 24);
            this.toolStripMenuItem9.Text = "2.39:1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(207, 6);
            // 
            // reversedMenuItem
            // 
            this.reversedMenuItem.Name = "reversedMenuItem";
            this.reversedMenuItem.Size = new System.Drawing.Size(210, 24);
            this.reversedMenuItem.Text = "Đảo ngược";
            // 
            // restoreCheckBox
            // 
            this.restoreCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.restoreCheckBox.AutoSize = true;
            this.restoreCheckBox.Location = new System.Drawing.Point(472, 264);
            this.restoreCheckBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.restoreCheckBox.Name = "restoreCheckBox";
            this.restoreCheckBox.Size = new System.Drawing.Size(463, 21);
            this.restoreCheckBox.TabIndex = 13;
            this.restoreCheckBox.Text = "Khôi phục về tỷ lệ khung hình ban đầu khi phương tiện đã phát xong.";
            this.restoreCheckBox.UseVisualStyleBackColor = true;
            // 
            // dvdCheckBox
            // 
            this.dvdCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dvdCheckBox.AutoSize = true;
            this.dvdCheckBox.Location = new System.Drawing.Point(455, 293);
            this.dvdCheckBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dvdCheckBox.Name = "dvdCheckBox";
            this.dvdCheckBox.Size = new System.Drawing.Size(487, 21);
            this.dvdCheckBox.TabIndex = 14;
            this.dvdCheckBox.Text = "Luôn đặt độ phân giải 704x567 và 720x576 thành tỷ lệ khung hình 16: 9.";
            this.dvdCheckBox.UseVisualStyleBackColor = true;
            this.dvdCheckBox.CheckedChanged += new System.EventHandler(this.DvdCheckBox_CheckedChanged);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // widthErrorPanel
            // 
            this.widthErrorPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.errorProvider1.SetIconAlignment(this.widthErrorPanel, System.Windows.Forms.ErrorIconAlignment.MiddleLeft);
            this.widthErrorPanel.Location = new System.Drawing.Point(641, 185);
            this.widthErrorPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.widthErrorPanel.Name = "widthErrorPanel";
            this.widthErrorPanel.Size = new System.Drawing.Size(23, 12);
            this.widthErrorPanel.TabIndex = 6;
            // 
            // heightErrorPanel
            // 
            this.heightErrorPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.errorProvider1.SetIconAlignment(this.heightErrorPanel, System.Windows.Forms.ErrorIconAlignment.MiddleLeft);
            this.heightErrorPanel.Location = new System.Drawing.Point(739, 185);
            this.heightErrorPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.heightErrorPanel.Name = "heightErrorPanel";
            this.heightErrorPanel.Size = new System.Drawing.Size(23, 12);
            this.heightErrorPanel.TabIndex = 7;
            // 
            // bottomPanel
            // 
            this.bottomPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bottomPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.bottomPanel.Controls.Add(this.updateButton);
            this.bottomPanel.Controls.Add(this.pvsPanel);
            this.bottomPanel.Controls.Add(this.cancelButton);
            this.bottomPanel.Controls.Add(this.okButton);
            this.bottomPanel.Location = new System.Drawing.Point(0, 331);
            this.bottomPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bottomPanel.Name = "bottomPanel";
            this.bottomPanel.Size = new System.Drawing.Size(949, 62);
            this.bottomPanel.TabIndex = 15;
            // 
            // updateButton
            // 
            this.updateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.updateButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.updateButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.updateButton.Enabled = false;
            this.updateButton.FocusBorder = true;
            this.updateButton.Location = new System.Drawing.Point(333, 17);
            this.updateButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(112, 28);
            this.updateButton.TabIndex = 1;
            this.updateButton.Text = "Cập nhật";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // pvsPanel
            // 
            this.pvsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pvsPanel.Location = new System.Drawing.Point(12, 11);
            this.pvsPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pvsPanel.Name = "pvsPanel";
            this.pvsPanel.Size = new System.Drawing.Size(56, 41);
            this.pvsPanel.TabIndex = 0;
            this.pvsPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.PvsPanel_Paint);
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.FocusBorder = true;
            this.cancelButton.Location = new System.Drawing.Point(820, 17);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(112, 28);
            this.cancelButton.TabIndex = 3;
            this.cancelButton.Text = "Hủy bỏ";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // okButton
            // 
            this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.okButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okButton.FocusBorder = true;
            this.okButton.Location = new System.Drawing.Point(696, 17);
            this.okButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(112, 28);
            this.okButton.TabIndex = 2;
            this.okButton.Text = "Xác nhận";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // useRatioCheckBox
            // 
            this.useRatioCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.useRatioCheckBox.AutoSize = true;
            this.useRatioCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.useRatioCheckBox.Location = new System.Drawing.Point(518, 206);
            this.useRatioCheckBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.useRatioCheckBox.Name = "useRatioCheckBox";
            this.useRatioCheckBox.Size = new System.Drawing.Size(63, 24);
            this.useRatioCheckBox.TabIndex = 8;
            this.useRatioCheckBox.Text = "Tỉ lệ";
            this.useRatioCheckBox.UseVisualStyleBackColor = true;
            this.useRatioCheckBox.CheckedChanged += new System.EventHandler(this.UseRatioCheckBox_CheckedChanged);
            // 
            // displayPanel
            // 
            this.displayPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.displayPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.displayPanel.Controls.Add(this.videoPanel);
            this.displayPanel.Location = new System.Drawing.Point(19, 17);
            this.displayPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.displayPanel.Name = "displayPanel";
            this.displayPanel.Size = new System.Drawing.Size(426, 295);
            this.displayPanel.TabIndex = 0;
            // 
            // videoPanel
            // 
            this.videoPanel.ContextMenuStrip = this.presetRatesMenu;
            this.videoPanel.Location = new System.Drawing.Point(0, 0);
            this.videoPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.videoPanel.Name = "videoPanel";
            this.videoPanel.Size = new System.Drawing.Size(427, 295);
            this.videoPanel.TabIndex = 0;
            // 
            // nameLabel
            // 
            this.nameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(173)))), ((int)(((byte)(146)))));
            this.nameLabel.Location = new System.Drawing.Point(468, 132);
            this.nameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(464, 17);
            this.nameLabel.TabIndex = 3;
            this.nameLabel.Text = "Tên";
            this.nameLabel.UseMnemonic = false;
            // 
            // sizeTitleLabel
            // 
            this.sizeTitleLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sizeTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sizeTitleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(173)))), ((int)(((byte)(146)))));
            this.sizeTitleLabel.Location = new System.Drawing.Point(468, 153);
            this.sizeTitleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sizeTitleLabel.Name = "sizeTitleLabel";
            this.sizeTitleLabel.Size = new System.Drawing.Size(92, 17);
            this.sizeTitleLabel.TabIndex = 4;
            this.sizeTitleLabel.Text = "Kích cỡ:";
            // 
            // sizeLabel
            // 
            this.sizeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sizeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sizeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(173)))), ((int)(((byte)(146)))));
            this.sizeLabel.Location = new System.Drawing.Point(553, 153);
            this.sizeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sizeLabel.Name = "sizeLabel";
            this.sizeLabel.Size = new System.Drawing.Size(367, 17);
            this.sizeLabel.TabIndex = 5;
            this.sizeLabel.Text = "Kích thước";
            // 
            // AspectRatioDialog
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(949, 393);
            this.Controls.Add(this.sizeLabel);
            this.Controls.Add(this.sizeTitleLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.heightErrorPanel);
            this.Controls.Add(this.widthErrorPanel);
            this.Controls.Add(this.displayPanel);
            this.Controls.Add(this.useRatioCheckBox);
            this.Controls.Add(this.bottomPanel);
            this.Controls.Add(this.dvdCheckBox);
            this.Controls.Add(this.restoreCheckBox);
            this.Controls.Add(this.presetButton);
            this.Controls.Add(this.colonLabel);
            this.Controls.Add(this.heightBox);
            this.Controls.Add(this.widthBox);
            this.Controls.Add(this.infoLabel);
            this.Controls.Add(this.headLabel);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(173)))), ((int)(((byte)(146)))));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(965, 430);
            this.Name = "AspectRatioDialog";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Tỷ lệ khung hình video - Xem trước";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AspectRatioDialog_FormClosing);
            this.Shown += new System.EventHandler(this.AspectRatioDialog_Shown);
            this.presetRatesMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.bottomPanel.ResumeLayout(false);
            this.displayPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headLabel;
        private System.Windows.Forms.Label infoLabel;
        private System.Windows.Forms.TextBox widthBox;
        private System.Windows.Forms.TextBox heightBox;
        private System.Windows.Forms.Label colonLabel;
        private DropDownButton presetButton;
        private System.Windows.Forms.CheckBox restoreCheckBox;
        private System.Windows.Forms.CheckBox dvdCheckBox;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Panel bottomPanel;
        private CustomButton cancelButton;
        private CustomButton okButton;
        private System.Windows.Forms.Panel pvsPanel;
        private System.Windows.Forms.CheckBox useRatioCheckBox;
        private System.Windows.Forms.Panel displayPanel;
        private CustomButton updateButton;
        private System.Windows.Forms.ContextMenuStrip presetRatesMenu;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem7;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem8;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem9;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem10;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem reversedMenuItem;
        private VideoPanel videoPanel;
        private System.Windows.Forms.Panel heightErrorPanel;
        private System.Windows.Forms.Panel widthErrorPanel;
        private System.Windows.Forms.Label sizeLabel;
        private System.Windows.Forms.Label sizeTitleLabel;
        private System.Windows.Forms.Label nameLabel;
    }
}