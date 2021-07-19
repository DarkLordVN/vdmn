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
    internal class SQLite
    {
        SQLiteConnection _con = new SQLiteConnection();
        public void createConection()
        {
            string _strConnect = "Data Source=KCTECH.sqlite;Version=3;";
            _con.ConnectionString = _strConnect;
            _con.Open();
        }
        public void closeConnection()
        {
            _con.Close();
        }
        public void initTable()
        {
            string sql = "CREATE TABLE IF NOT EXISTS videos ([video_id] INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT, [ke_khai_id] INTEGER, [file_path] nvarchar(300) ,[file_name] nvarchar(300) , [camera_name] nvarchar(100), [camera_id] nvarchar(100), [audio_name] nvarchar(100), [audio_id] nvarchar(100), [created_date] nvarchar(30), [tai_khoan_id] integer);";
            sql += "CREATE TABLE IF NOT EXISTS zipfile ([zip_id] INTEGER, [created_date] nvarchar(30), [tai_khoan_id] integer, [secret_key] nvarchar(1000), [last_burn] INTEGER);";
            sql += "CREATE TABLE IF NOT EXISTS lkvideozip ([zip_id] INTEGER, [video_id] INTEGER);";
            sql += "CREATE TABLE IF NOT EXISTS zipfiledetail ([zip_detail_id] INTEGER, [zip_id] INTEGER, [file_path] nvarchar(300) ,[file_name] nvarchar(300), [file_size] REAL , [is_burn] INTEGER);";
            sql += "CREATE TABLE IF NOT EXISTS kekhai ([ke_khai_id] INTEGER, [ten_dieu_tra] NVARCHAR(1000), [don_vi] NVARCHAR(2000), [ten_doi_tuong] NVARCHAR(1000), [dia_diem] NVARCHAR(4000), [ten_vu_an] NVARCHAR(500), [ghi_chu] NVARCHAR(4000), [giay_phep] NVARCHAR(500), [created_date] nvarchar(30)); ";
            if (!File.Exists("KCTECH.sqlite"))
                SQLiteConnection.CreateFile("KCTECH.sqlite");
            createConection();
            SQLiteCommand command = new SQLiteCommand(sql, _con);
            command.ExecuteNonQuery();
            closeConnection();
        }

        public DataSet SQLSelect(string sqlQuery)
        {
            DataSet ds = new DataSet();
            createConection();
            try
            {
                SQLiteDataAdapter da = new SQLiteDataAdapter(sqlQuery, _con);
                da.Fill(ds);
                closeConnection();
            }
            catch (Exception ex)
            {
                closeConnection();
            }
            finally
            {
                closeConnection();
            }
            return ds;
        }

        public bool SQLExcuteNonQuery(string strQuery)
        {
            var checkSuccess = false;
            createConection();
            try
            {
                SQLiteCommand cmd = new SQLiteCommand(strQuery, _con);
                cmd.ExecuteNonQuery();
                checkSuccess = true;
                closeConnection();
            }
            catch (Exception ex)
            {
                closeConnection();
            }
            finally
            {
                closeConnection();
            }
            return checkSuccess;
        }
    }

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
        public int KeKhaiId { get => _keKhaiId; set => _keKhaiId = value; }
        public string TenDieuTra { get => _tenDieuTra; set => _tenDieuTra = value; }
        public string DonVi { get => _donVi; set => _donVi = value; }
        public string TenDoiTuong { get => _tenDoiTuong; set => _tenDoiTuong = value; }
        public string DiaDiem { get => _diaDiem; set => _diaDiem = value; }
        public string TenVuAn { get => _tenVuAn; set => _tenVuAn = value; }
        public string GhiChu { get => _ghiChu; set => _ghiChu = value; }
        public string GiayPhep { get => _giayPhep; set => _giayPhep = value; }
        public string CreatedDate { get => _createdDate; set => _createdDate = value; }

        #endregion

        public KeKhaiObj()
        {
        }

        public KeKhaiObj(string tenDieuTra, string donVi, string tenDoiTuong, string diaDiem, string tenVuAn, string ghiChu, string giayPhep, string createdDate)
        {
            _tenDieuTra = tenDieuTra;
            _donVi = donVi;
            _tenDoiTuong = tenDoiTuong;
            _diaDiem = diaDiem;
            _tenVuAn = tenVuAn;
            _ghiChu = ghiChu;
            _giayPhep = giayPhep;
            _createdDate = createdDate;
        }
        public DataSet LoadList()
        {
            DataSet ds = new DataSet();
            var strQuery = "select * from kekhai";
            var sql = new SQLite();
            ds = sql.SQLSelect(strQuery);
            return ds;
        }

        public bool Insert()
        {
            var checkSuccess = false;
            string strInsert = string.Format("INSERT INTO kekhai (ten_dieu_tra	,don_vi	,ten_doi_tuong	,dia_diem	,ten_vu_an	,ghi_chu	,giay_phep	,created_date) VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}')", _tenDieuTra, _donVi, _tenDoiTuong, _diaDiem, _tenVuAn, _ghiChu, _giayPhep, DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));
            var sql = new SQLite();
            checkSuccess = sql.SQLExcuteNonQuery(strInsert);
            return checkSuccess;
        }
        public bool Update()
        {
            var checkSuccess = false;
            string strUpdate = string.Format("UPDATE kekhai SET ten_dieu_tra = '{0}', don_vi = '{1}', ten_doi_tuong = '{2}', dia_diem = '{3}', ten_vu_an = '{4}', ghi_chu = '{5}',giay_phep ='{6}'", _tenDieuTra, _donVi, _tenDoiTuong, _diaDiem, _tenVuAn, _ghiChu, _giayPhep);
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
