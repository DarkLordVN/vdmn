namespace PVSPlayerExample
{
    partial class FrmDSKeKhai
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
            this.btnThietLapVideo = new PVSPlayerExample.CustomButton();
            this.btnGhiDia2 = new PVSPlayerExample.CustomButton();
            this.customButton5 = new PVSPlayerExample.CustomButton();
            this.customButton4 = new PVSPlayerExample.CustomButton();
            this.btnAddKeKhai = new PVSPlayerExample.CustomButton();
            this.btnCancel = new PVSPlayerExample.CustomButton();
            this.btnGhiDia1 = new PVSPlayerExample.CustomButton();
            this.ke_khai_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.don_vi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ten_dieu_tra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ten_doi_tuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dia_diem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ten_vu_an = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giay_phep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.created_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ghi_chu = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.ke_khai_id,
            this.don_vi,
            this.ten_dieu_tra,
            this.ten_doi_tuong,
            this.dia_diem,
            this.ten_vu_an,
            this.giay_phep,
            this.created_date,
            this.ghi_chu});
            this.grvKeKhai.Location = new System.Drawing.Point(17, 89);
            this.grvKeKhai.Margin = new System.Windows.Forms.Padding(4);
            this.grvKeKhai.Name = "grvKeKhai";
            this.grvKeKhai.ReadOnly = true;
            this.grvKeKhai.RowHeadersWidth = 51;
            this.grvKeKhai.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
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
            // btnThietLapVideo
            // 
            this.btnThietLapVideo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnThietLapVideo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(200)))));
            this.btnThietLapVideo.ForeColor = System.Drawing.Color.White;
            this.btnThietLapVideo.Location = new System.Drawing.Point(199, 455);
            this.btnThietLapVideo.Name = "btnThietLapVideo";
            this.btnThietLapVideo.Size = new System.Drawing.Size(115, 28);
            this.btnThietLapVideo.TabIndex = 14;
            this.btnThietLapVideo.Text = "Thiết lập video";
            this.btnThietLapVideo.UseVisualStyleBackColor = true;
            this.btnThietLapVideo.Click += new System.EventHandler(this.btnThietLapVideo_Click);
            // 
            // btnGhiDia2
            // 
            this.btnGhiDia2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnGhiDia2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(200)))));
            this.btnGhiDia2.ForeColor = System.Drawing.Color.White;
            this.btnGhiDia2.Location = new System.Drawing.Point(411, 455);
            this.btnGhiDia2.Name = "btnGhiDia2";
            this.btnGhiDia2.Size = new System.Drawing.Size(85, 28);
            this.btnGhiDia2.TabIndex = 13;
            this.btnGhiDia2.Text = "Ghi đĩa v2";
            this.btnGhiDia2.UseVisualStyleBackColor = true;
            this.btnGhiDia2.Click += new System.EventHandler(this.btnGhiDia2_Click);
            // 
            // customButton5
            // 
            this.customButton5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.customButton5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(200)))));
            this.customButton5.ForeColor = System.Drawing.Color.White;
            this.customButton5.Location = new System.Drawing.Point(502, 455);
            this.customButton5.Name = "customButton5";
            this.customButton5.Size = new System.Drawing.Size(85, 28);
            this.customButton5.TabIndex = 12;
            this.customButton5.Text = "Xóa";
            this.customButton5.UseVisualStyleBackColor = true;
            // 
            // customButton4
            // 
            this.customButton4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.customButton4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(200)))));
            this.customButton4.ForeColor = System.Drawing.Color.White;
            this.customButton4.Location = new System.Drawing.Point(108, 455);
            this.customButton4.Name = "customButton4";
            this.customButton4.Size = new System.Drawing.Size(85, 28);
            this.customButton4.TabIndex = 11;
            this.customButton4.Text = "Cập nhật";
            this.customButton4.UseVisualStyleBackColor = true;
            // 
            // btnAddKeKhai
            // 
            this.btnAddKeKhai.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAddKeKhai.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(200)))));
            this.btnAddKeKhai.ForeColor = System.Drawing.Color.White;
            this.btnAddKeKhai.Location = new System.Drawing.Point(17, 455);
            this.btnAddKeKhai.Name = "btnAddKeKhai";
            this.btnAddKeKhai.Size = new System.Drawing.Size(85, 28);
            this.btnAddKeKhai.TabIndex = 10;
            this.btnAddKeKhai.Text = "Thêm mới";
            this.btnAddKeKhai.UseVisualStyleBackColor = true;
            this.btnAddKeKhai.Click += new System.EventHandler(this.btnAddKeKhai_Click);
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
            // btnGhiDia1
            // 
            this.btnGhiDia1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnGhiDia1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(200)))));
            this.btnGhiDia1.ForeColor = System.Drawing.Color.White;
            this.btnGhiDia1.Location = new System.Drawing.Point(320, 455);
            this.btnGhiDia1.Name = "btnGhiDia1";
            this.btnGhiDia1.Size = new System.Drawing.Size(85, 28);
            this.btnGhiDia1.TabIndex = 15;
            this.btnGhiDia1.Text = "Ghi đĩa v1";
            this.btnGhiDia1.UseVisualStyleBackColor = true;
            this.btnGhiDia1.Click += new System.EventHandler(this.btnGhiDia1_Click);
            // 
            // ke_khai_id
            // 
            this.ke_khai_id.DataPropertyName = "ke_khai_id";
            this.ke_khai_id.HeaderText = "ke_khai_id";
            this.ke_khai_id.MinimumWidth = 6;
            this.ke_khai_id.Name = "ke_khai_id";
            this.ke_khai_id.ReadOnly = true;
            this.ke_khai_id.Visible = false;
            this.ke_khai_id.Width = 125;
            // 
            // don_vi
            // 
            this.don_vi.DataPropertyName = "don_vi";
            this.don_vi.HeaderText = "Đơn vị";
            this.don_vi.MinimumWidth = 6;
            this.don_vi.Name = "don_vi";
            this.don_vi.ReadOnly = true;
            this.don_vi.Width = 125;
            // 
            // ten_dieu_tra
            // 
            this.ten_dieu_tra.DataPropertyName = "ten_dieu_tra";
            this.ten_dieu_tra.HeaderText = "Điều tra viên";
            this.ten_dieu_tra.MinimumWidth = 6;
            this.ten_dieu_tra.Name = "ten_dieu_tra";
            this.ten_dieu_tra.ReadOnly = true;
            this.ten_dieu_tra.Width = 125;
            // 
            // ten_doi_tuong
            // 
            this.ten_doi_tuong.DataPropertyName = "ten_doi_tuong";
            this.ten_doi_tuong.HeaderText = "Tên đối tượng";
            this.ten_doi_tuong.MinimumWidth = 6;
            this.ten_doi_tuong.Name = "ten_doi_tuong";
            this.ten_doi_tuong.ReadOnly = true;
            this.ten_doi_tuong.Width = 125;
            // 
            // dia_diem
            // 
            this.dia_diem.DataPropertyName = "dia_diem";
            this.dia_diem.HeaderText = "Địa điểm";
            this.dia_diem.MinimumWidth = 6;
            this.dia_diem.Name = "dia_diem";
            this.dia_diem.ReadOnly = true;
            this.dia_diem.Width = 125;
            // 
            // ten_vu_an
            // 
            this.ten_vu_an.DataPropertyName = "ten_vu_an";
            this.ten_vu_an.HeaderText = "Tên vụ án / vụ việc";
            this.ten_vu_an.MinimumWidth = 6;
            this.ten_vu_an.Name = "ten_vu_an";
            this.ten_vu_an.ReadOnly = true;
            this.ten_vu_an.Width = 125;
            // 
            // giay_phep
            // 
            this.giay_phep.HeaderText = "Giấy phép";
            this.giay_phep.MinimumWidth = 6;
            this.giay_phep.Name = "giay_phep";
            this.giay_phep.ReadOnly = true;
            this.giay_phep.Width = 125;
            // 
            // created_date
            // 
            this.created_date.DataPropertyName = "created_date";
            this.created_date.HeaderText = "Ngày tạo";
            this.created_date.MinimumWidth = 6;
            this.created_date.Name = "created_date";
            this.created_date.ReadOnly = true;
            this.created_date.Width = 125;
            // 
            // ghi_chu
            // 
            this.ghi_chu.DataPropertyName = "ghi_chu";
            this.ghi_chu.HeaderText = "Ghi chú";
            this.ghi_chu.MinimumWidth = 6;
            this.ghi_chu.Name = "ghi_chu";
            this.ghi_chu.ReadOnly = true;
            this.ghi_chu.Width = 125;
            // 
            // FrmDSKeKhai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(863, 488);
            this.Controls.Add(this.btnGhiDia1);
            this.Controls.Add(this.btnThietLapVideo);
            this.Controls.Add(this.btnGhiDia2);
            this.Controls.Add(this.customButton5);
            this.Controls.Add(this.customButton4);
            this.Controls.Add(this.btnAddKeKhai);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.grvKeKhai);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmDSKeKhai";
            this.Text = "Danh sách kê khai thông tin hỏi cung";
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
        private CustomButton btnAddKeKhai;
        private CustomButton customButton4;
        private CustomButton customButton5;
        private CustomButton btnGhiDia2;
        private CustomButton btnThietLapVideo;
        private CustomButton btnGhiDia1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ke_khai_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn don_vi;
        private System.Windows.Forms.DataGridViewTextBoxColumn ten_dieu_tra;
        private System.Windows.Forms.DataGridViewTextBoxColumn ten_doi_tuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn dia_diem;
        private System.Windows.Forms.DataGridViewTextBoxColumn ten_vu_an;
        private System.Windows.Forms.DataGridViewTextBoxColumn giay_phep;
        private System.Windows.Forms.DataGridViewTextBoxColumn created_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn ghi_chu;
    }
}

