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

        private void KeKhaiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //showDSKeKhai();
        }

        private void dsKeKhaiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showDSKeKhai();
        }
        void showMainWindow()
        {
            this.pnlDisplayContainer.Controls.Clear();
            MainWindow frmMainWindows = new MainWindow();
            frmMainWindows.TopLevel = false;
            this.pnlDisplayContainer.Controls.Add(frmMainWindows);
            frmMainWindows.FormBorderStyle = FormBorderStyle.None;
            frmMainWindows.Dock = DockStyle.Fill;
            frmMainWindows.Show();
        }

        void showDSKeKhai()
        {
            this.pnlDisplayContainer.Controls.Clear();
            FrmDSKeKhai frm = new FrmDSKeKhai();
            frm.TopLevel = false;
            this.pnlDisplayContainer.Controls.Add(frm);
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }

        private void themMoiKeKhaiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmKeKhai frm = new FrmKeKhai();
            frm.ShowDialog();
        }

        private void videoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDSVideo frm = new FrmDSVideo();
            frm.ShowDialog();
        }
    }
}
