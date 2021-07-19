using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PVSPlayerExample
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
                    MessageBox.Show("Thêm mới", "Thêm mới thông tin kê khai thành công");
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
    }
}
