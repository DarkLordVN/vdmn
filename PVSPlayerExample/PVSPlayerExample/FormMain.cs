using System;
using System.Data;
using System.Data.SQLite;
using System.IO;
using System.Windows.Forms;

namespace PVSPlayerExample
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            showMainWindow();
        }

        private void heThongMenuItem_Click(object sender, EventArgs e)
        {
            showMainWindow();
        }

        void showMainWindow()
        {
            MainWindow frmMainWindows = new MainWindow();
            frmMainWindows.TopLevel = false;
            this.pnlDisplayContainer.Controls.Add(frmMainWindows);
            frmMainWindows.FormBorderStyle = FormBorderStyle.None;
            frmMainWindows.Dock = DockStyle.Fill;
            frmMainWindows.Show();
        }
    }
}
