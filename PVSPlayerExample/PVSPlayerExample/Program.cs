﻿using System;
using System.Windows.Forms;
using PVS.MediaPlayer;

namespace PVSPlayerExample
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            SQLite sqlLite = new SQLite();
            sqlLite.initTable();
            VideoObj obj = new VideoObj();
            obj.CameraName = "test 1";
            obj.CameraId = "12333";
            obj.Insert();
            obj.CameraName = "test 2";
            obj.CameraId = "123123";
            obj.Insert();
            obj.CameraName = "test 3";
            obj.CameraId = "321321";
            obj.Insert();
            //string sourcePath = @"C:\Users\lekha\OneDrive\Documents\VideoManagement";
            //string zipPath = @"C:\Users\lekha\OneDrive\Documents\VideoManagement\test4.zip";
            //string destinationPath = @"C:\Users\lekha\OneDrive\Documents\VideoManagement\unzip4";
            //ZipControl zipCtrl = new ZipControl();
            //zipCtrl.StartZipFile(sourcePath, zipPath);
            //zipCtrl.StartUnzip(zipPath, destinationPath);
            //start app
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //if (!Player.MFPresent)
            //{
            //    MessageBox.Show("Microsoft Media Foundation\r\n\r\n" + Player.MFPresent_ResultString,
            //        MainWindow.APPLICATION_NAME, MessageBoxButtons.OK, MessageBoxIcon.Stop);
            //}
            //else Application.Run(new FormMain());

            Application.Run(new FormMain());


        }
    }
}