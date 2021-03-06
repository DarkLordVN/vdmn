using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaKCTech
{
    internal class KeKhaiObj
    {
        #region Fields

        int _keKhaiId;
        string _tenDieuTra;
        string _donVi;
        string _tenDoiTuong;
        string _diaDiem;
        string _tenVuAn;
        string _ghiChu;
        string _giayPhep;
        string _createdDate;
        string _taiKhoanId;
        string _secretKey;
        string _lastBurn;
        string _folderPath;
        string _zipPath;
        public int KeKhaiId { get => _keKhaiId; set => _keKhaiId = value; }
        public string TenDieuTra { get => _tenDieuTra; set => _tenDieuTra = value; }
        public string DonVi { get => _donVi; set => _donVi = value; }
        public string TenDoiTuong { get => _tenDoiTuong; set => _tenDoiTuong = value; }
        public string DiaDiem { get => _diaDiem; set => _diaDiem = value; }
        public string TenVuAn { get => _tenVuAn; set => _tenVuAn = value; }
        public string GhiChu { get => _ghiChu; set => _ghiChu = value; }
        public string GiayPhep { get => _giayPhep; set => _giayPhep = value; }
        public string CreatedDate { get => _createdDate; set => _createdDate = value; }
        public string TaiKhoanId { get => _taiKhoanId; set => _taiKhoanId = value; }
        public string SecretKey { get => _secretKey; set => _secretKey = value; }
        public string LastBurn { get => _lastBurn; set => _lastBurn = value; }
        public string FolderPath { get => _folderPath; set => _folderPath = value; }
        public string ZipPath { get => _zipPath; set => _zipPath = value; }

        #endregion

        public KeKhaiObj()
        {
        }

        public KeKhaiObj(int keKhaiId)
        {
            GetById(keKhaiId);
        }

        public DataSet LoadList()
        {
            DataSet ds = new DataSet();
            var strQuery = "select * from kekhai";
            var sql = new SQLite();
            ds = sql.SQLSelect(strQuery);
            return ds;
        }

        public KeKhaiObj GetById(int id)
        {
            var strQuery = string.Format("select * from kekhai where ke_khai_id = '{0}'", id);
            var sql = new SQLite();
            var ds = sql.SQLSelect(strQuery);
            if(ds != null)
            {
                if(ds.Tables != null && ds.Tables[0] != null && ds.Tables[0].Rows.Count > 0)
                {
                    var keKhaiId = 0;
                    int.TryParse(ds.Tables[0].Rows[0].ItemArray[0] + "", out keKhaiId);
                    if(keKhaiId > 0)
                    {
                        this.KeKhaiId = keKhaiId;
                        this.TenDieuTra = ds.Tables[0].Rows[0].ItemArray[1] + "";
                        this.DonVi = ds.Tables[0].Rows[0].ItemArray[2] + "";
                        this.TenDoiTuong = ds.Tables[0].Rows[0].ItemArray[3] + "";
                        this.DiaDiem = ds.Tables[0].Rows[0].ItemArray[4] + "";
                        this.TenVuAn = ds.Tables[0].Rows[0].ItemArray[5] + "";
                        this.GhiChu = ds.Tables[0].Rows[0].ItemArray[6] + "";
                        this.GiayPhep = ds.Tables[0].Rows[0].ItemArray[7] + "";
                        this.CreatedDate = ds.Tables[0].Rows[0].ItemArray[8] + "";
                    }
                }
            }
            return null;
        }

        public bool Insert()
        {
            var checkSuccess = false;
            string strInsert = string.Format("INSERT INTO kekhai (ten_dieu_tra	,don_vi	,ten_doi_tuong	,dia_diem	,ten_vu_an	,ghi_chu	,giay_phep	,created_date, tai_khoan_id, secret_key, last_burn, folder_path, zip_path) VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}')", _tenDieuTra, _donVi, _tenDoiTuong, _diaDiem, _tenVuAn, _ghiChu, _giayPhep, DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"), _taiKhoanId, _secretKey, _lastBurn, _folderPath, _zipPath);
            var sql = new SQLite();
            checkSuccess = sql.SQLExcuteNonQuery(strInsert);
            return checkSuccess;
        }
        public bool Update()
        {
            var checkSuccess = false;
            string strUpdate = string.Format("UPDATE kekhai SET ten_dieu_tra = '{0}', don_vi = '{1}', ten_doi_tuong = '{2}', dia_diem = '{3}', ten_vu_an = '{4}', ghi_chu = '{5}',giay_phep ='{6}', tai_khoan_id = '{8}', secret_key = '{9}', last_burn = '{10}', folder_path = '{11}', zip_path = '{12}' WHERE ke_khai_id = '{7}'", _tenDieuTra, _donVi, _tenDoiTuong, _diaDiem, _tenVuAn, _ghiChu, _giayPhep, _keKhaiId, _taiKhoanId, _secretKey, _lastBurn, _folderPath, _zipPath);
            var sql = new SQLite();
            checkSuccess = sql.SQLExcuteNonQuery(strUpdate);
            return checkSuccess;
        }

        public bool Delete(int id)
        {
            var checkSuccess = false;
            string strUpdate = string.Format("DELETE FROM kekhai WHERE ke_khai_id='{0}'", id);
            var sql = new SQLite();
            checkSuccess = sql.SQLExcuteNonQuery(strUpdate);
            return checkSuccess;
        }
    }

}
