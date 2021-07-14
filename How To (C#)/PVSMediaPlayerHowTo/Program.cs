using System;
using System.Windows.Forms;
using PVS.MediaPlayer;

namespace PVSMediaPlayerHowTo
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Check if Media Foundation is installed - you can use this anywhere in your application
            if (!Player.MFPresent)
            {
                // Media Foundation is not installed - show a message and exit the application
                MessageBox.Show ("PVS.MediaPlayer cannot be used on this computer.\r\n\r\n" + Player.MFPresent_ResultString + ".",
                    "PVS.MediaPlayer How To ...", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                // Media Foundation is installed - run the application
                Application.Run(new Form1());
            }
        }
    }
}
