using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaKCTech
{
    public partial class FrmKeKhai : Form
    {
        public FrmKeKhai()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (checkValidate())
            {
                KeKhaiObj obj = new KeKhaiObj();
                obj.TenDieuTra = txtDieuTraVien.Text;
                obj.DonVi = txtDonVi.Text;
                obj.TenDoiTuong = txtTenDoiTuong.Text;
                obj.DiaDiem = txtDiaDiem.Text;
                obj.TenVuAn = txtTenVuAn.Text;
                obj.GhiChu = txtGhiChu.Text;
                var check = obj.Insert();
                if (check)
                {
                    this.Dispose();
                    MessageBox.Show("Thêm mới thông tin kê khai thành công", "Thêm mới", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private bool checkValidate()
        {
            return true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDiaDiem.Text = txtDieuTraVien.Text = txtDonVi.Text = txtGhiChu.Text = txtTenDoiTuong.Text = txtTenVuAn.Text = "";   
        }
    }
}
