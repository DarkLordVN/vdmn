using System;
using System.Collections.Generic;
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
            string sql = "CREATE TABLE IF NOT EXISTS videos ([video_id] INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT, ke_khai_id INTEGER, file_path nvarchar(300), camera_name nvarchar(100), camera_id nvarchar(100), audio_name nvarchar(100), audio_id nvarchar(100), created_date nvarchar(30), zip_date nvarchar(30), zip_count integer, is_sync integer, tai_khoan_id integer, secret_key nvarchar(100));";
            //if (!File.Exists("KCTECH.sqlite"))
                SQLiteConnection.CreateFile("KCTECH.sqlite");
            createConection();
            SQLiteCommand command = new SQLiteCommand(sql, _con);
            command.ExecuteNonQuery();
            closeConnection();
        }
    }
}
