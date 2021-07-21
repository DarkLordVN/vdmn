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

namespace MediaKCTech
{
    public partial class FrmDSVideo : Form
    {
        FormMain _mainForm;
        public FrmDSVideo(FormMain mainForm)
        {
            InitializeComponent();
            _mainForm = mainForm;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loadDataToGrid();
        }

        public DataSet loadData()
        {
            VideoObj obj = new VideoObj();
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

        private void grvKeKhai_DoubleClick(object sender, EventArgs e)
        {
            var rowSelected = grvKeKhai.SelectedRows;
            if (rowSelected != null && rowSelected.Count > 0)
            {
                var fullPath = "";
                var filePath = rowSelected[0].Cells["file_path"];
                var fileName = rowSelected[0].Cells["file_name"];
                if (filePath != null && fileName != null && !string.IsNullOrEmpty(filePath.Value + "") && !string.IsNullOrEmpty(fileName.Value + ""))
                {
                    fullPath = filePath.Value + "\\" + fileName.Value + ".mp4";
                }
                _mainForm.showMainWindow(fullPath);
                //_mainForm._pathVideo = fullPath;
                //_mainForm.AddToPlaylist(fullPath)
                this.Dispose();
            }
        }
    }
}
