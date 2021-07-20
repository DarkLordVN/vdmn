using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PVSPlayerExample
{
    internal class VideoObj
    {
        #region Fields

        int _videoId;
        int _keKhaiId;
        string _filePath;
        string _fileName;
        string _cameraName;
        string _cameraId;
        string _audioName;
        string _audioId;
        string _createdDate;
        int _taiKhoanId;
        string _thoiGianGhiHinh;
        string _kichCo;
        string _doPhanGiai;
        string _tiLeKhungHinh;

        public int VideoId { get => _videoId; set => _videoId = value; }
        public int KeKhaiId { get => _keKhaiId; set => _keKhaiId = value; }
        public string FilePath { get => _filePath; set => _filePath = value; }
        public string FileName { get => _fileName; set => _fileName = value; }
        public string CameraName { get => _cameraName; set => _cameraName = value; }
        public string CameraId { get => _cameraId; set => _cameraId = value; }
        public string AudioName { get => _audioName; set => _audioName = value; }
        public string AudioId { get => _audioId; set => _audioId = value; }
        public string CreatedDate { get => _createdDate; set => _createdDate = value; }
        public int TaiKhoanId { get => _taiKhoanId; set => _taiKhoanId = value; }
        public string ThoiGianGhiHinh { get => _thoiGianGhiHinh; set => _thoiGianGhiHinh = value; }
        public string KichCo { get => _kichCo; set => _kichCo = value; }
        public string DoPhanGiai { get => _doPhanGiai; set => _doPhanGiai = value; }
        public string TiLeKhungHinh { get => _tiLeKhungHinh; set => _tiLeKhungHinh = value; }
        #endregion

        public VideoObj()
        {
        }

        public DataSet LoadList()
        {
            var strQuery = "select * from videos ORDER BY video_id desc";
            var sql = new SQLite();
            return sql.SQLSelect(strQuery);
        }
        public DataSet LoadListNew()
        {
            var strQuery = "select * from videos WHERE ke_khai_id IS NULL OR ke_khai_id = 0 OR ke_khai_id NOT IN (SELECT ke_khai_id FROM kekhai) ORDER BY video_id desc";
            var sql = new SQLite();
            return sql.SQLSelect(strQuery);
        }

        public VideoObj GetById(int id)
        {
            var strQuery = string.Format("select * from videos where video_id = '{0}'", id);
            var sql = new SQLite();
            var ds = sql.SQLSelect(strQuery);
            if (ds != null)
            {
                if (ds.Tables != null && ds.Tables[0] != null && ds.Tables[0].Rows.Count > 0)
                {
                    var videoId = 0;
                    int.TryParse(ds.Tables[0].Rows[0].ItemArray[0] + "", out videoId);
                    if (videoId > 0)
                    {
                        this.VideoId = videoId;
                        var keKhaiId = 0;
                        int.TryParse(ds.Tables[0].Rows[0].ItemArray[1] + "", out keKhaiId);
                        this.KeKhaiId = keKhaiId;
                        this.FilePath = ds.Tables[0].Rows[0].ItemArray[2] + "";
                        this.FileName = ds.Tables[0].Rows[0].ItemArray[3] + "";
                        this.CameraName = ds.Tables[0].Rows[0].ItemArray[4] + "";
                        this.CameraId = ds.Tables[0].Rows[0].ItemArray[5] + "";
                        this.AudioName = ds.Tables[0].Rows[0].ItemArray[6] + "";
                        this.AudioId = ds.Tables[0].Rows[0].ItemArray[7] + "";
                        this.CreatedDate = ds.Tables[0].Rows[0].ItemArray[8] + "";

                        var taiKhoanId = 0;
                        int.TryParse(ds.Tables[0].Rows[0].ItemArray[9] + "", out taiKhoanId);
                        this.TaiKhoanId = taiKhoanId;

                        this.ThoiGianGhiHinh = ds.Tables[0].Rows[0].ItemArray[10] + "";
                        this.KichCo = ds.Tables[0].Rows[0].ItemArray[11] + "";
                        this.DoPhanGiai = ds.Tables[0].Rows[0].ItemArray[12] + "";
                        this.TiLeKhungHinh = ds.Tables[0].Rows[0].ItemArray[13] + "";
                    }
                }
            }
            return null;
        }

        public bool Insert()
        {
            var checkSuccess = false;
            string strInsert = string.Format("INSERT INTO videos(ke_khai_id ,file_path ,file_name ,camera_name ,camera_id ,audio_name ,audio_id ,created_date ,tai_khoan_id ,thoi_gian_ghi_hinh ,kich_co ,do_phan_giai ,ti_le_khung_hinh) VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}')", _keKhaiId, _filePath, _fileName, _cameraName, _cameraId, _audioName, _audioId, DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"), _taiKhoanId, _thoiGianGhiHinh, _kichCo, _doPhanGiai, _tiLeKhungHinh);
            var sql = new SQLite();
            checkSuccess = sql.SQLExcuteNonQuery(strInsert);
            return checkSuccess;
        }
        public bool Update()
        {
            var checkSuccess = false;
            string strUpdate = string.Format("UPDATE videos SET ke_khai_id ='{0}', file_path ='{1}', file_name ='{2}', camera_name ='{3}', camera_id ='{4}', audio_name ='{5}', audio_id ='{6}', created_date ='{7}', tai_khoan_id ='{8}', thoi_gian_ghi_hinh ='{9}', kich_co ='{10}', do_phan_giai ='{11}', ti_le_khung_hinh ='{12}' WHERE video_id ='{13}'", _keKhaiId, _filePath, _fileName, _cameraName, _cameraId, _audioName, _audioId, _createdDate, _taiKhoanId, _thoiGianGhiHinh, _kichCo, _doPhanGiai, _tiLeKhungHinh, _videoId);
            var sql = new SQLite();
            checkSuccess = sql.SQLExcuteNonQuery(strUpdate);
            return checkSuccess;
        }

        public bool Delete(int id)
        {
            var checkSuccess = false;
            string strDel = string.Format("DELETE FROM videos WHERE video_id='{0}'", id);
            var sql = new SQLite();
            checkSuccess = sql.SQLExcuteNonQuery(strDel);
            return checkSuccess;
        }
    }


}
