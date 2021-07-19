
namespace PVSPlayerExample
{
    partial class FrmThietLapVideo
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTenVuAn = new System.Windows.Forms.TextBox();
            this.smoothLabel5 = new PVSPlayerExample.SmoothLabel();
            this.txtDiaDiem = new System.Windows.Forms.TextBox();
            this.smoothLabel4 = new PVSPlayerExample.SmoothLabel();
            this.txtTenDoiTuong = new System.Windows.Forms.TextBox();
            this.smoothLabel3 = new PVSPlayerExample.SmoothLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCancel = new PVSPlayerExample.CustomButton();
            this.btnAdd = new PVSPlayerExample.CustomButton();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.grvKeKhai = new System.Windows.Forms.DataGridView();
            this.created_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.camera_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.audio_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.do_phan_giai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ghi_chu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thoi_gian_ghi_hinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kich_co = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvKeKhai)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox1.Controls.Add(this.txtTenVuAn);
            this.groupBox1.Controls.Add(this.smoothLabel5);
            this.groupBox1.Controls.Add(this.txtDiaDiem);
            this.groupBox1.Controls.Add(this.smoothLabel4);
            this.groupBox1.Controls.Add(this.txtTenDoiTuong);
            this.groupBox1.Controls.Add(this.smoothLabel3);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(344, 425);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kê khai thông tin";
            // 
            // txtTenVuAn
            // 
            this.txtTenVuAn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTenVuAn.Location = new System.Drawing.Point(19, 47);
            this.txtTenVuAn.Name = "txtTenVuAn";
            this.txtTenVuAn.Size = new System.Drawing.Size(312, 22);
            this.txtTenVuAn.TabIndex = 9;
            // 
            // smoothLabel5
            // 
            this.smoothLabel5.AutoSize = true;
            this.smoothLabel5.Location = new System.Drawing.Point(16, 27);
            this.smoothLabel5.Name = "smoothLabel5";
            this.smoothLabel5.Size = new System.Drawing.Size(128, 17);
            this.smoothLabel5.TabIndex = 8;
            this.smoothLabel5.Text = "Tên vụ án / vụ việc";
            this.smoothLabel5.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            // 
            // txtDiaDiem
            // 
            this.txtDiaDiem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDiaDiem.Location = new System.Drawing.Point(19, 167);
            this.txtDiaDiem.Name = "txtDiaDiem";
            this.txtDiaDiem.Size = new System.Drawing.Size(312, 22);
            this.txtDiaDiem.TabIndex = 7;
            // 
            // smoothLabel4
            // 
            this.smoothLabel4.AutoSize = true;
            this.smoothLabel4.Location = new System.Drawing.Point(16, 147);
            this.smoothLabel4.Name = "smoothLabel4";
            this.smoothLabel4.Size = new System.Drawing.Size(108, 17);
            this.smoothLabel4.TabIndex = 6;
            this.smoothLabel4.Text = "Địa điểm xét hỏi";
            this.smoothLabel4.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            // 
            // txtTenDoiTuong
            // 
            this.txtTenDoiTuong.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTenDoiTuong.Location = new System.Drawing.Point(19, 107);
            this.txtTenDoiTuong.Name = "txtTenDoiTuong";
            this.txtTenDoiTuong.Size = new System.Drawing.Size(312, 22);
            this.txtTenDoiTuong.TabIndex = 5;
            // 
            // smoothLabel3
            // 
            this.smoothLabel3.AutoSize = true;
            this.smoothLabel3.Location = new System.Drawing.Point(16, 87);
            this.smoothLabel3.Name = "smoothLabel3";
            this.smoothLabel3.Size = new System.Drawing.Size(96, 17);
            this.smoothLabel3.TabIndex = 4;
            this.smoothLabel3.Text = "Tên đối tượng";
            this.smoothLabel3.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Location = new System.Drawing.Point(12, 446);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1050, 51);
            this.panel1.TabIndex = 2;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(200)))));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(969, 10);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 28);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Hủy bỏ";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(200)))));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(888, 10);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 28);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Xác nhận";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(12, 12);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer1.Size = new System.Drawing.Size(1050, 428);
            this.splitContainer1.SplitterDistance = 350;
            this.splitContainer1.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox2.Controls.Add(this.grvKeKhai);
            this.groupBox2.Location = new System.Drawing.Point(-1, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(697, 428);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách video mới";
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
            this.grvKeKhai.Location = new System.Drawing.Point(0, 26);
            this.grvKeKhai.Margin = new System.Windows.Forms.Padding(4);
            this.grvKeKhai.Name = "grvKeKhai";
            this.grvKeKhai.ReadOnly = true;
            this.grvKeKhai.RowHeadersWidth = 51;
            this.grvKeKhai.Size = new System.Drawing.Size(697, 402);
            this.grvKeKhai.TabIndex = 5;
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
            // FrmThietLapVideo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1077, 509);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panel1);
            this.Name = "FrmThietLapVideo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Phân vùng video ghi đĩa";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grvKeKhai)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTenVuAn;
        private SmoothLabel smoothLabel5;
        private System.Windows.Forms.TextBox txtDiaDiem;
        private SmoothLabel smoothLabel4;
        private System.Windows.Forms.TextBox txtTenDoiTuong;
        private SmoothLabel smoothLabel3;
        private System.Windows.Forms.Panel panel1;
        private CustomButton btnCancel;
        private CustomButton btnAdd;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView grvKeKhai;
        private System.Windows.Forms.DataGridViewTextBoxColumn created_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn camera_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn audio_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn do_phan_giai;
        private System.Windows.Forms.DataGridViewTextBoxColumn ghi_chu;
        private System.Windows.Forms.DataGridViewTextBoxColumn thoi_gian_ghi_hinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn kich_co;
    }
}