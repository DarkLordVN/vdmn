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
    public partial class FrmThietLapVideo : Form
    {
        public FrmThietLapVideo()
        {
            InitializeComponent();
        }

        private void FrmThietLapVideo_Load(object sender, EventArgs e)
        {
            loadDataToGrid();
        }
        public DataSet loadData()
        {
            VideoObj obj = new VideoObj();
            return obj.LoadListNew();
        }

        public void loadDataToGrid()
        {
            DataSet ds = loadData();
            if (ds != null && ds.Tables.Count > 0)
            {
                grvKeKhai.AutoGenerateColumns = false;
                grvKeKhai.DataSource = ds.Tables[0];
            }
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
        }

        private bool checkValidate()
        {
            return true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void grvKeKhai_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 0)
            {
                DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)grvKeKhai.Rows[e.RowIndex].Cells[0];
                if (chk.Value == chk.TrueValue)
                {
                    chk.Value = chk.FalseValue;
                }
                else
                {
                    chk.Value = chk.TrueValue;
                }
            }
        }
    }
}
