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
            string sql = "CREATE TABLE IF NOT EXISTS videos ([video_id] INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT, [ke_khai_id] INTEGER, [file_path] nvarchar(300) ,[file_name] nvarchar(300) , [camera_name] nvarchar(100), [camera_id] nvarchar(100), [audio_name] nvarchar(100), [audio_id] nvarchar(100), [created_date] nvarchar(30), [tai_khoan_id] integer, [thoi_gian_ghi_hinh] nvarchar(100), [kich_co] REAL, [do_phan_giai] nvarchar(100), [ti_le_khung_hinh] nvarchar(100));";
            sql += "CREATE TABLE IF NOT EXISTS lkvideokekhai ([ke_khai_id] INTEGER, [video_id] INTEGER);";
            sql += "CREATE TABLE IF NOT EXISTS zipfiledetail ([zip_detail_id] INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT, [ke_khai_id] INTEGER, [file_path] nvarchar(300) ,[file_name] nvarchar(300), [file_size] REAL , [is_burn] INTEGER);";
            sql += "CREATE TABLE IF NOT EXISTS kekhai ([ke_khai_id] INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT, [ten_dieu_tra] NVARCHAR(1000), [don_vi] NVARCHAR(2000), [ten_doi_tuong] NVARCHAR(1000), [dia_diem] NVARCHAR(4000), [ten_vu_an] NVARCHAR(500), [ghi_chu] NVARCHAR(4000), [giay_phep] NVARCHAR(500), [created_date] nvarchar(30), [tai_khoan_id] integer, [secret_key] nvarchar(1000), [last_burn] INTEGER); ";
            //if (!File.Exists("KCTECH.sqlite"))
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
}
