using PVS.MediaPlayer;
using System;
using System.Data;
using System.Data.SQLite;
using System.IO;
using System.Windows.Forms;

namespace PVSPlayerExample
{
    public partial class FormMain : Form
    {
        internal Player myPlayer;
        // Webcam Devices
        private WebcamDevice[] _webcams;
        internal ContextMenuStrip playMenu;
        private ContextMenuStrip displayMenu;

        public FormMain()
        {
            InitializeComponent();
            showMainWindow();
            CheckMenuCamera();
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
            CheckMenuCamera();
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
            CheckMenuCamera();
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

        private void CheckMenuCamera()
        {
            // Create a player with a display
            myPlayer = new Player();
            WebcamDevice[] webcams = myPlayer.Webcam.GetDevices();
            if (webcams != null || _webcams != null)
            {
                if (webcams != null && _webcams != null && webcams.Length == _webcams.Length)
                {
                    // menu already exists
                }
                else
                {
                    webcamsMenuItem.DropDown.Items.Clear();
                    if (_webcams != null)
                    {
                        webcamsMenuItem.Enabled = false;
                        _webcams = null;
                        webcamsMenuItem.DropDown.ItemClicked -= WebcamMenu_ItemClicked;
                    }

                    if (webcams != null)
                    {
                        _webcams = webcams;
                        webcamsMenuItem.Enabled = true;
                        int i = 0;
                        for (; i < _webcams.Length; i++)
                        {
                            webcamsMenuItem.DropDown.Items.Add(_webcams[i].Name);
                            webcamsMenuItem.DropDown.Items[i].Enabled = true;
                        }

                        if (_webcams.Length > 1)
                        {
                            webcamsMenuItem.DropDown.Items.Add("-"); // separator
                            webcamsMenuItem.DropDown.Items[i++].Enabled = false;
                            webcamsMenuItem.DropDown.Items.Add("Play All Webcams");
                            ((ToolStripMenuItem)(webcamsMenuItem.DropDown.Items[i])).ShortcutKeys = Keys.Control | Keys.W;
                            webcamsMenuItem.DropDown.Items[i].Enabled = true;
                        }

                        webcamsMenuItem.DropDown.ItemClicked += WebcamMenu_ItemClicked;
                    }
                    else
                    {
                        webcamsMenuItem.DropDown.Items.Add("No Webcams");
                        webcamsMenuItem.DropDown.Items[0].Enabled = false;
                    }
                }
            }
        }


        private void WebcamMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            int item = webcamsMenuItem.DropDown.Items.IndexOf(e.ClickedItem);

            //playMenu.Close();
            //if (displayMenu.Visible) displayMenu.Close();

            if (_webcams != null)
            {
                if (item < _webcams.Length)
                {
                    WebcamMenu_PlayWebcam(item);
                }
                else
                {
                    for (int index = 0; index < _webcams.Length; index++)
                    {
                        WebcamMenu_PlayWebcam(index);
                    }
                }
            }
        }

        private void WebcamMenu_PlayWebcam(int index)
        {
            // check if already playing
            WebcamDevice webcam = _webcams[index];

            FormCollection forms = Application.OpenForms;
            int count = forms.Count;
            bool found = false;
            for (int i = 0; i < count; i++)
            {
                if (string.Compare(forms[i].Text, webcam.Name) == 0)
                {
                    count = i;
                    found = true;
                    break;
                }
            }

            if (found)
            {
                if (forms[count].WindowState == FormWindowState.Minimized) forms[count].WindowState = FormWindowState.Normal;
                else forms[count].BringToFront();
            }
            else
            {
                Webcam_Window webcamWindow = new Webcam_Window(webcam);
                webcamWindow.Show();
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            CheckMenuCamera();
        }
    }
}
