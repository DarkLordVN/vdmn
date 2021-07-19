namespace PVSPlayerExample
{
    partial class FrmDSVideo
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearchKey = new System.Windows.Forms.TextBox();
            this.grvKeKhai = new System.Windows.Forms.DataGridView();
            this.btnTimKiem = new System.Windows.Forms.GroupBox();
            this.customButton1 = new PVSPlayerExample.CustomButton();
            this.btnCancel = new PVSPlayerExample.CustomButton();
            this.created_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.camera_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.audio_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.do_phan_giai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ghi_chu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thoi_gian_ghi_hinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kich_co = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grvKeKhai)).BeginInit();
            this.btnTimKiem.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Từ khóa";
            // 
            // txtSearchKey
            // 
            this.txtSearchKey.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearchKey.Location = new System.Drawing.Point(143, 26);
            this.txtSearchKey.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearchKey.Name = "txtSearchKey";
            this.txtSearchKey.Size = new System.Drawing.Size(545, 22);
            this.txtSearchKey.TabIndex = 0;
            // 
            // grvKeKhai
            // 
            this.grvKeKhai.AllowUserToAddRows = false;
            this.grvKeKhai.AllowUserToDeleteRows = false;
            this.grvKeKhai.AllowUserToOrderColumns = true;
            this.grvKeKhai.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grvKeKhai.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.grvKeKhai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvKeKhai.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.created_date,
            this.camera_name,
            this.audio_name,
            this.do_phan_giai,
            this.ghi_chu,
            this.thoi_gian_ghi_hinh,
            this.kich_co});
            this.grvKeKhai.Location = new System.Drawing.Point(17, 89);
            this.grvKeKhai.Margin = new System.Windows.Forms.Padding(4);
            this.grvKeKhai.Name = "grvKeKhai";
            this.grvKeKhai.ReadOnly = true;
            this.grvKeKhai.RowHeadersWidth = 51;
            this.grvKeKhai.Size = new System.Drawing.Size(829, 359);
            this.grvKeKhai.TabIndex = 4;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Controls.Add(this.customButton1);
            this.btnTimKiem.Controls.Add(this.label1);
            this.btnTimKiem.Controls.Add(this.txtSearchKey);
            this.btnTimKiem.Location = new System.Drawing.Point(17, 13);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(829, 69);
            this.btnTimKiem.TabIndex = 9;
            this.btnTimKiem.TabStop = false;
            this.btnTimKiem.Text = "Tìm kiếm";
            // 
            // customButton1
            // 
            this.customButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.customButton1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(200)))));
            this.customButton1.ForeColor = System.Drawing.Color.White;
            this.customButton1.Location = new System.Drawing.Point(707, 23);
            this.customButton1.Name = "customButton1";
            this.customButton1.Size = new System.Drawing.Size(85, 28);
            this.customButton1.TabIndex = 1;
            this.customButton1.Text = "Tìm kiếm";
            this.customButton1.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(200)))));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(761, 455);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(85, 28);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Đóng";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // created_date
            // 
            this.created_date.DataPropertyName = "created_date";
            this.created_date.HeaderText = "Ngày ghi hình";
            this.created_date.MinimumWidth = 6;
            this.created_date.Name = "created_date";
            this.created_date.ReadOnly = true;
            this.created_date.Width = 125;
            // 
            // camera_name
            // 
            this.camera_name.DataPropertyName = "camera_name";
            this.camera_name.HeaderText = "Thiết bị ghi hình";
            this.camera_name.MinimumWidth = 6;
            this.camera_name.Name = "camera_name";
            this.camera_name.ReadOnly = true;
            this.camera_name.Width = 125;
            // 
            // audio_name
            // 
            this.audio_name.DataPropertyName = "audio_name";
            this.audio_name.HeaderText = "Thiết bị ghi âm";
            this.audio_name.MinimumWidth = 6;
            this.audio_name.Name = "audio_name";
            this.audio_name.ReadOnly = true;
            this.audio_name.Width = 125;
            // 
            // do_phan_giai
            // 
            this.do_phan_giai.DataPropertyName = "do_phan_giai";
            this.do_phan_giai.HeaderText = "Độ phân giải";
            this.do_phan_giai.MinimumWidth = 6;
            this.do_phan_giai.Name = "do_phan_giai";
            this.do_phan_giai.ReadOnly = true;
            this.do_phan_giai.Width = 125;
            // 
            // ghi_chu
            // 
            this.ghi_chu.DataPropertyName = "ty_le_khung_hinh";
            this.ghi_chu.HeaderText = "Tỉ lệ khung hình";
            this.ghi_chu.MinimumWidth = 6;
            this.ghi_chu.Name = "ghi_chu";
            this.ghi_chu.ReadOnly = true;
            this.ghi_chu.Width = 125;
            // 
            // thoi_gian_ghi_hinh
            // 
            this.thoi_gian_ghi_hinh.DataPropertyName = "thoi_gian_ghi_hinh";
            this.thoi_gian_ghi_hinh.HeaderText = "Thời lượng ghi hình";
            this.thoi_gian_ghi_hinh.MinimumWidth = 6;
            this.thoi_gian_ghi_hinh.Name = "thoi_gian_ghi_hinh";
            this.thoi_gian_ghi_hinh.ReadOnly = true;
            this.thoi_gian_ghi_hinh.Width = 125;
            // 
            // kich_co
            // 
            this.kich_co.DataPropertyName = "kich_co";
            this.kich_co.HeaderText = "Kích cỡ tệp";
            this.kich_co.MinimumWidth = 6;
            this.kich_co.Name = "kich_co";
            this.kich_co.ReadOnly = true;
            this.kich_co.Width = 125;
            // 
            // FrmDSVideo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(863, 488);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.grvKeKhai);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmDSVideo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Danh sách video quản lý";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grvKeKhai)).EndInit();
            this.btnTimKiem.ResumeLayout(false);
            this.btnTimKiem.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearchKey;
        private System.Windows.Forms.GroupBox btnTimKiem;
        private CustomButton customButton1;
        private System.Windows.Forms.DataGridView grvKeKhai;
        private CustomButton btnCancel;
        private System.Windows.Forms.DataGridViewTextBoxColumn created_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn camera_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn audio_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn do_phan_giai;
        private System.Windows.Forms.DataGridViewTextBoxColumn ghi_chu;
        private System.Windows.Forms.DataGridViewTextBoxColumn thoi_gian_ghi_hinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn kich_co;
    }
}

