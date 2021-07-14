﻿#region Usings

using PVS.MediaPlayer;
using System;
using System.Drawing;
using System.Windows.Forms;

#endregion

namespace PVSMediaPlayerHowTo
{
    /*
        Please note:

        Public Partial Class Overlay : Form
            is replaced by
        Public Partial Class Overlay : OverlayForm

        OverlayForm is a Form defined in the PVS.MediaPlayer library
        that contains some logic to prevent unwanted activation of the overlay

        please also note the ClickThrough setting in the constructor
    */

    public partial class Overlay : OverlayForm
    {

        // This is a sample PVS.MediaPlayer display overlay:
        // it shows a label with the text "Display Overlay" on top of movies.
        // As an example of overlay 'animation' the text is made 'flashing'.

        // The text remains in the middle of the video image because
        // the label is 'anchored' on all sides of the form and the
        // text is centered (TextAlign MiddleCenter).

        // The display overlay (form) also contains a label
        // that is used to display subtitles.


        // Special items (optional but highly recommended - see code below):

        // A few options (ShowWithoutActivation and (overwrite) WndProc) are used to prevent 'flashing'
        // of the overlay when it is displayed or clicked on. These options are in version 1.3 or higher
        // available in a class that can be inherited by overlays: OverlayForm (see class definition above).

        // To use the player option to drag the display window, you must use a mousedown eventhandler
        // provided by the player (Player.Display.Drag_MouseDown) for the overlay and any control on it
        // (which must start dragging the display of the player when clicked).

        // The 'heart' of every display overlay is the VisibleChanged event handler. It is called when
        // the overlay is activated or deactivated.


        // About the transparency of display overlays:

        // PVS.MediaPlayer makes overlays transparent by setting the TransparencyKey property of the overlay
        // (form) to the same color as the background color of the overlay. You can set these colors yourself
        // if you want. The 'mouseclick transparency' of the overlay depends on the colors used. For example,
        // 'Green' makes mouse clicks 'fall through', but 'RosyBrown' does not.
        // See also "OverlayForm" above.


        // **** Class Fields **************************************************************************

        #region Class Fields

        private readonly Color  FOREGROUND_COLOR    = Color.Red; // = 255, 0, 0
        private const int       TIMER_INTERVAL      = 600;

        private Player          basePlayer;
        private Timer           flashTimer;         // the timer used for flashing text
        private bool            flashOn;            // the state of the flashing text
        private bool            isDisposed;         // used with cleaning up

        #endregion


        #region Main

        // **** Main **********************************************************************************

        // the display overlay constructor
        public Overlay(Player player)
        {
            InitializeComponent();

            ClickThrough = true; // no need For mouse interaction
            // this setting can be changed at any time 

            basePlayer = player;
            subtitlesLabel.Text = "";

            flashTimer          = new Timer();
            flashTimer.Interval = TIMER_INTERVAL;
            flashTimer.Tick     += FlashTimer_Tick;
        }

        // Don't activate form when shown
        protected override bool ShowWithoutActivation
        {
            get { return true; }
        }

        // Don't activate form with mouse click
        protected override void WndProc(ref Message m)
        {
            const int WM_MOUSEACTIVATE  = 0x0021;
            const int MA_NOACTIVATE     = 0x0003;

            if (m.Msg == WM_MOUSEACTIVATE) m.Result = (IntPtr)MA_NOACTIVATE;
            else base.WndProc(ref m);
        }

        // the animation (timer) is switched on/off when the form's visibility changes, the form's
        // visibility (among other) changes when the overlay is activated/deactivated by the player:
        private void Overlay_VisibleChanged(object sender, System.EventArgs e)
        {
            if (Visible)
            {
                flashOn = false;
                flashLabel.ForeColor = FOREGROUND_COLOR;
                flashTimer.Start();

                // enable dragging of the main display (if  enabled)
                MouseDown           += basePlayer.Display.Drag_MouseDown;
                flashLabel.MouseDown     += basePlayer.Display.Drag_MouseDown;
                subtitlesLabel.MouseDown += basePlayer.Display.Drag_MouseDown;
            }
            else
            {
                flashTimer.Stop();

                MouseDown           -= basePlayer.Display.Drag_MouseDown;
                flashLabel.MouseDown     -= basePlayer.Display.Drag_MouseDown;
                subtitlesLabel.MouseDown -= basePlayer.Display.Drag_MouseDown;
            }
        }

        // here the 'animation' (text flashing) is done
        private void FlashTimer_Tick(object sender, System.EventArgs e)
        {
            //if (flashOn) flashLabel.ForeColor = FOREGROUND_COLOR;
            //else flashLabel.ForeColor = BACKGROUND_COLOR;

            if (flashOn) flashLabel.Text = "Display Overlay";
            else flashLabel.Text = "";

            flashOn = !flashOn;
        }

        // clean up - this is moved here from the 'Overlay.Designer.cs' file and appended:
        protected override void Dispose(bool disposing)
        {
            if (!isDisposed)
            {
                isDisposed = true;
                if (disposing)
                {
                    if (flashTimer != null) flashTimer.Dispose();
                    // used by the designer - clean up:
                    if (components != null) components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        #endregion
    }

    #region BlendLabel

    // A replacement for the standard label to allow for overlay opacity on display clones and certain screen copies.
    // Just copy this class to your application and replace the standard labels on display overlays with a BlendLabel.

    class BlendLabel : Label
    {
        public BlendLabel()
        {
            UseCompatibleTextRendering = true;
		}

        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SingleBitPerPixelGridFit;
            base.OnPaint(e);
        }
    }

    #endregion
}
