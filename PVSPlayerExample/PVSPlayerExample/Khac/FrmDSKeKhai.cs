using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.IO;

namespace PVSPlayerExample
{
    public partial class FrmDSKeKhai : Form
    {
        SQLiteConnection _con = new SQLiteConnection();
        public void createConection()
        {
            string _strConnect = "Data Source=MyDatabase.sqlite;Version=3;";
            _con.ConnectionString = _strConnect;
            _con.Open();
        }

        public void closeConnection()
        {
            _con.Close();
        }

        public void createTable()
        {
            string sql = "CREATE TABLE IF NOT EXISTS tbl_students ([id] INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT, fullname nvarchar(50), birthday varchar(15), email varchar(30), address nvarchar(100), phone varchar(11))";
            if (!File.Exists("KCTECH.sqlite"))
                SQLiteConnection.CreateFile("KCTECH.sqlite");
            createConection();
            SQLiteCommand command = new SQLiteCommand(sql, _con);
            command.ExecuteNonQuery();
            closeConnection();
        }
        public FrmDSKeKhai()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loadDataToGrid();
        }

        public DataSet loadData()
        {
            KeKhaiObj obj = new KeKhaiObj();
            return obj.LoadList();
        }

        public void loadDataToGrid()
        {
            DataSet ds = loadData();
            if(ds != null && ds.Tables.Count > 0)
            {
                grvKeKhai.AutoGenerateColumns = false;
                grvKeKhai.DataSource = ds.Tables[0];
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnAddKeKhai_Click(object sender, EventArgs e)
        {
            FrmKeKhai frm = new FrmKeKhai();
            frm.ShowDialog();
            if (frm.IsDisposed)
            {
                loadDataToGrid();
            }
        }

        private void btnThietLapVideo_Click(object sender, EventArgs e)
        {
            FrmThietLapVideo frm = new FrmThietLapVideo();
            frm.ShowDialog();
        }

        private void btnGhiDia1_Click(object sender, EventArgs e)
        {
            var rowSelected = grvKeKhai.SelectedRows;
            if(rowSelected != null && rowSelected.Count > 0)
            {
                var idSelected = rowSelected[0].Cells["ke_khai_id"];
                if(idSelected != null && idSelected.Value != null)
                {
                    var keKhaiId = 0;
                    int.TryParse(idSelected.Value + "", out keKhaiId);
                    if(keKhaiId > 0)
                    {
                        BurnDVD frm = new BurnDVD(keKhaiId);
                        frm.ShowDialog();
                    }
                }
            }
            else
            {
                MessageBox.Show("Chưa chọn thông tin kê khai!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnGhiDia2_Click(object sender, EventArgs e)
        {
            BurnMedia frm = new BurnMedia();
            frm.ShowDialog();
        }
    }
}
