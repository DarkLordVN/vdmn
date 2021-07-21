using IMAPI2.MediaItem;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaKCTech
{
    public partial class FrmThietLapVideo : Form
    {

        private int _keKhaiId = 0;
        public FrmThietLapVideo()
        {
            InitializeComponent();
        }
        public FrmThietLapVideo(int keKhaiId)
        {
            InitializeComponent();
            _keKhaiId = keKhaiId;
        }

        private void FrmThietLapVideo_Load(object sender, EventArgs e)
        {
            loadDataToGrid();
            loadKeKhai();

        }
        public DataSet loadData()
        {
            VideoObj obj = new VideoObj();
            return obj.LoadListNew(_keKhaiId);
        }

        public void loadDataToGrid()
        {
            DataSet ds = loadData();
            if (ds != null && ds.Tables.Count > 0)
            {
                grvKeKhai.AutoGenerateColumns = false;
                grvKeKhai.DataSource = ds.Tables[0];
                setCheckedCheckbox();
            }
        }

        public void loadKeKhai()
        {
            if (_keKhaiId > 0)
            {
                KeKhaiObj obj = new KeKhaiObj(_keKhaiId);
                txtTenVuAn.Text = obj.TenVuAn;
                txtDiaDiem.Text = obj.DiaDiem;
                txtTenDoiTuong.Text = obj.TenDoiTuong;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var lstVideo = grvKeKhai.Rows;
            if (lstVideo != null && lstVideo.Count > 0)
            {
                var checkSuccess = true;
                for (int i = 0; i < lstVideo.Count; i++)
                {
                    DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)grvKeKhai.Rows[i].Cells[0];
                    var eVideo = grvKeKhai.Rows[i].Cells["video_id"];
                    var videoId = 0;
                    int.TryParse(eVideo.Value + "", out videoId);
                    var filePath = grvKeKhai.Rows[i].Cells["file_path"];
                    var fileName = grvKeKhai.Rows[i].Cells["file_name"];
                    var fullPath = "";
                    if (filePath != null && fileName != null && !string.IsNullOrEmpty(filePath.Value + "") && !string.IsNullOrEmpty(fileName.Value + ""))
                    {
                        fullPath = filePath.Value + "\\" + fileName.Value + ".mp4";
                    }
                    if (chk.Value == chk.TrueValue)
                    {
                        if (videoId > 0)
                        {
                            //Cap nhap video
                            VideoObj obj = new VideoObj(videoId);
                            if (obj != null)
                            {
                                var kichCo = grvKeKhai.Rows[i].Cells["kich_co"];
                                if (!string.IsNullOrEmpty(fullPath) && kichCo != null && (string.IsNullOrEmpty(kichCo.Value + "") || (kichCo.Value + "").Equals("0")))
                                {
                                    try
                                    {
                                        var fileItem = new FileItem(fullPath);
                                        if (fileItem != null)
                                        {
                                            obj.KichCo = fileItem.SizeOnDisc + "";
                                        }
                                    }
                                    catch (Exception ex)
                                    {
                                    }
                                }
                                obj.KeKhaiId = _keKhaiId;
                                obj.Update();
                            }
                            KeKhaiObj eKeKhai = new KeKhaiObj(_keKhaiId);
                            string folder = eKeKhai.FolderPath;
                            if (string.IsNullOrEmpty(folder))
                            {
                                //Move file
                                folder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "VideoManagement\\KeKhai\\" + _keKhaiId);
                                Directory.CreateDirectory(folder);
                                eKeKhai.FolderPath = folder;
                                eKeKhai.Update();
                            }
                            if (!string.IsNullOrEmpty(fullPath))
                            {
                                if (File.Exists(filePath.Value + "\\" + fileName.Value + ".mp4") && !File.Exists(folder + "\\" + fileName.Value + ".mp4"))
                                {
                                    File.Copy(filePath.Value + "\\" + fileName.Value + ".mp4", folder + "\\" + fileName.Value + ".mp4");
                                }
                                if (File.Exists(filePath.Value + "\\" + fileName.Value + "_video.mp4") && !File.Exists(folder + "\\" + fileName.Value + "_video.mp4"))
                                {
                                    File.Copy(filePath.Value + "\\" + fileName.Value + "_video.mp4", folder + "\\" + fileName.Value + "_video.mp4");
                                }
                                if (File.Exists(filePath.Value + "\\" + fileName.Value + "_audio.mp4") && !File.Exists(folder + "\\" + fileName.Value + "_audio.mp4"))
                                {
                                    File.Copy(filePath.Value + "\\" + fileName.Value + "_audio.mp4", folder + "\\" + fileName.Value + "_audio.mp4");
                                }
                            }

                        }
                    }
                    else
                    {
                        var keKhai = grvKeKhai.Rows[i].Cells["ke_khai_id"];
                        if (videoId > 0 && keKhai != null && !string.IsNullOrEmpty(keKhai.Value + "") && !(keKhai.Value + "").Equals("0"))
                        {
                            VideoObj obj = new VideoObj(videoId);
                            obj.KeKhaiId = 0;
                            obj.Update();
                        }
                    }
                }
                if(checkSuccess)
                {
                    MessageBox.Show("Thiết lập video thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Dispose();
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void grvKeKhai_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
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

        private void setCheckedCheckbox()
        {
            var lstVideo = grvKeKhai.Rows;
            if (lstVideo != null && lstVideo.Count > 0)
            {
                for (int i = 0; i < lstVideo.Count; i++)
                {
                    var keKhai = grvKeKhai.Rows[i].Cells["ke_khai_id"];
                    if (keKhai != null && !string.IsNullOrEmpty(keKhai.Value + "") && !(keKhai.Value + "").Equals("0"))
                    {
                        DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)grvKeKhai.Rows[i].Cells[0];
                        chk.Value = chk.TrueValue;
                    }
                }
            }
        }
    }
}
