#region Usings

using PVS.MediaPlayer;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text;
using System.Windows.Forms;

#endregion

namespace PVSMediaPlayerHowTo
{
    public partial class Form1 : Form
    {
        /*
            PVS.MediaPlayer 1.4 Example Application - How To...

            This example application shows the use of some of the methods and properties of
            the PVS.MediaPlayer library.
   
            Contents:

             1. check if Microsoft Media Foundation and Windows 7 or higher are present

             2. change the shape of the player's video image or display window
             3. drag a form by dragging a player's display window
             4. automatically hide the mouse cursor during media playback

             5. add a display overlay
             5a.display overlay opacity with clones and copies
             6. make a display overlay always visible - from application start

             7. add one or more display clones

             8. get media ended information
             9. play (or repeat) only a part of a media file
            10. add a taskbar progress indicator

            11. continuously receive information about the playback position
            12. add a position slider controlled by the player

            13. set the audio output device used by the player
            14. select an audio or video track

            15. audio values: set and get audio volume and balance information
            16. audio sliders: add audio volume and balance sliders controlled by the player
            17. continuously receive information about the audio output levels

            18. get media subtitles
            19. get media metadata properties
            20. add a custom info label to any slider (trackbar)


            These options are initialized and commented in the constructor (method Main: Form1()) of this class.

            Many options in de PVS.MediaPlayer library are available even when no media is playing, they
            are 'Player settings' not 'Media settings', e.g.: Display settings (e.g. fullscreen),
            Audio settings (volume/balance), Start/EndPosition, Pause/Resume and others.

            Most settings are remembered by the player for as long as the player exists, so you don't have to repeat
            the setting every time. Examples include the display window of the player, the fullscreen mode and the
            selected audio output device.


            If you have questions about using the PVS.MediaPlayer library or this sample application, do not hesitate
            to ask a question in the PVS.MediaPlayer article's comments (at the bottom of the article) on CodeProject:
            https://www.codeproject.com/Articles/109714/PVS-MediaPlayer-Audio-and-Video-Player-Library


            June 2021, Peter Vegter

        */


        // **** Class Fields **************************************************************************

        #region Class Fields

        private Player          myPlayer;
        private Overlay         myOverlay;          // in file 'Overlay.cs'

        private int             shapeStatus;        // shapes - 0:none, 1:oval, 2:none, 3:rounded, 4:none, 5:star

        private InfoLabel       myInfoLabel;
        private StringBuilder   myInfoLabelText     = new StringBuilder(64);

        // used with drawing audio output levels
        // levelUnit is the size of 1 unit (of 32767) and 140 is the width of panel4 and panel5
        private double          levelUnit           = 140; // size of panel
        private int             leftLevel;
        private int             rightLevel;
        private Brush           levelBrush          = new HatchBrush(HatchStyle.LightVertical, Color.FromArgb(179,173,146));

        private Metadata        metaData;           // media metadata properties
        private OpenFileDialog  myOpenFileDlg;      // used with selection of media to play
        private const string    OPENMEDIA_DIALOG_FILTER =
            " Media Files (*.*)|*.3g2; *.3gp; *.3gp2; *.3gpp; *.aac; *.adts; *.asf; *.avi; *.m2ts; *.m4a; *.m4v; *.mkv; *.mov; *.mp3; *.mp4; *.mpeg; *.mpg; *.mts; *.sami; *.smi; *.vob; *.wav; *.webm; *.wma; *.wmv|" +
            " All Files|*.*";

        private bool            isDisposed;         // used with cleaning up

        #endregion


        // **** Main **********************************************************************************

        #region Main

        // The descriptions of the examples can be found here:

        public Form1()
        {
            InitializeComponent();                      // this call is required by the designer

            myPlayer                = new Player();     // create a player
            myPlayer.Display.Window = panel1;           // and set its display to panel1
            myPlayer.Repeat         = true;             // repeat media playback when finished

            myPlayer.SleepDisabled  = true;             // prevent the computer from entering sleep mode

            myOpenFileDlg = new OpenFileDialog()        // create a file selector
            {
                Title       = "Play Media",
                Filter      = OPENMEDIA_DIALOG_FILTER,
                FilterIndex = 1                         // 1 = media files
            };

            // mouse down eventhandlers to switch between stretch and zoom of clone displays
            panel2.MouseDown += Clone_MouseClick;
            panel3.MouseDown += Clone_MouseClick;


            // You may want to add one or more of the following options to your player:


            // **** 1. CHECK IF MICROSOFT MEDIA FOUNDATION AND WINDOWS 7 OR HIGHER ARE PRESENT ********

            // Check if Media Foundation is installed - PVS.MediaPlayer cannot be used without.

            // For example: bool isInstalled = Player.MFPresent;

            // MFPresent is a static method that can be used without first creating a player.
            // This method also checks if Windows 7 or higher, which is also required, is installed.

            // See code in file Program.cs



            // **** 2. CHANGE THE SHAPE OF THE PLAYER'S VIDEO IMAGE OR DISPLAY WINDOW *****************

            // The shape of a player's video or display can be changed from the usual rectangular shape to
            // to one of the preset shapes provided by the player with the Player.Display.SetShape method.

            // For example:
            // myPlayer.Display.SetShape(DisplayShape.Oval);

            // To restore the original display shape, use:
            // myPlayer.Display.SetShape(DisplayShape.Normal);

            // You can choose whether the shape applies to the video image or the entire display window and
            // whether display overlays are also shown in the same shape using the method overload:
            // myPlayer.Display.SetShape(DisplayShape.Oval, true, false);
            // The default setting is video shape and no overlay shape.


            // **** Custom Shape

            // You can also create a custom shape by using a graphics path:
            // GraphicsPath myGraphicsPath = new GraphicsPath();

            // add items to the graphics path, for example an oval shape:
            // myGraphicsPath.AddEllipse(myGraphicsPath.GetBounds());

            // then set the custom shape of the player (not yet that of the display):
            // myPlayer.Display.CustomShape = myGraphicsPath;

            // dispose the graphics path after the player's custom shape has been set:
            // myGraphicsPath.Dispose();

            // After you have created the custom shape, you can select it just like any other shape:
            // myPlayer.Display.SetShape(DisplayShape.Custom); or myPlayer.Display.Shape = DisplayShape.Custom;



            // **** 3. DRAG A FORM BY DRAGGING A PLAYER'S DISPLAY WINDOW ******************************

            // In some cases it may be convenient to drag a form not only by its title bar but also by a
            // player's display window on the form. You can enable this option with:

            myPlayer.Display.DragEnabled = true;

            // You can specify the mouse cursor being used while dragging the form/display window, for
            // example:

            myPlayer.Display.DragCursor = Cursors.SizeAll; // 'SizeAll' is also the default drag cursor


            // **** Drag The Player's Parent Form With Another Control

            // You can also drag the form that contains the player's display window by dragging another
            // control (even if it's not on the same form, for example a display overlay) if you use the
            // Player.Display.Drag_MouseDown event handler for that control's mousedown event, for example:

            panel2.MouseDown += myPlayer.Display.Drag_MouseDown;
            panel3.MouseDown += myPlayer.Display.Drag_MouseDown;



            // **** 4. AUTOMATICALLY HIDE THE MOUSE CURSOR DURING MEDIA PLAYBACK **********************

            // If you want to keep the mouse cursor 'out of the way' when a movie (or any other media)
            // is playing, you can use the "Player.CursorHide" methods of the player.

            // By specifying the form(s) on which the cursor is to be hidden, the player automatically
            // hides the cursor on those forms (when in the foreground) when media is played and the mouse
            // has not been used for a while, for example on this form:

            myPlayer.CursorHide.Add(this);

            // You can add as many "cursor hiding" forms to the player as you like, for example forms
            // that contain a display clone of the player or even forms that are not directly related
            // to the player.

            // You can change the number of seconds to wait before hiding a non-active mouse with, for
            // example:

            myPlayer.CursorHide.Delay = 3; // 3 seconds is also the default waiting time


            // **** Temporarily Disable Mouse Hiding

            // Sometimes you may want to temporarily disable hiding the cursor, for example when choosing
            // an option from a menu. You can do this by using for example:
            // myPlayer.CursorHide.Enabled = false; - and enable again with: myPlayer.CursorHide.Enabled = true;
            // For example, you can use these instructions in the opening and closing event handlers of a menu.



            // **** 5. ADD A DISPLAY OVERLAY **********************************************************

            // A display overlay is a form that allows you to display items on top of a movie.
            // The sample overlay 'Overlay' is created with the Visual Studio designer.

            myOverlay = new Overlay(myPlayer);     // create (an instance of) the overlay
            myPlayer.Overlay.Window = myOverlay;   // and attach it to the player

            // To remove a display overlay from the player set the overlay window to another overlay
            // or to null: myPlayer.Overlay.Window = null; (or myPlayer.Overlay.Remove();)

            // The use of display overlays is explained in more detail in the file Overlay.cs



            // **** 5A. DISPLAY OVERLAY OPACITY WITH CLONES AND COPIES ********************************

            // To have the same opacity of display overlays on the player's display clones and with
            // certain screen copies, you can use, for example:

            myPlayer.Overlay.Blend = OverlayBlend.Transparent;

            // This option is not activated by default because it does not work well with with some
            // standard interface items such as buttons, labels and panels. See the file Overlay.cs



            // **** 6. MAKE A DISPLAY OVERLAY ALWAYS VISIBLE - FROM APPLICATION START *****************

            // A display overlay is usually only shown when media is playing, but if you want to always
            // show the overlay you can use: myPlayer.Overlay.Hold = true;

            // The player's display has to be created and visible for this, so if you want
            // to show the overlay right from the start of your application (without media playing) you
            // have to put the 'Overlay.Hold' instruction in the Form1.Shown event handler (see below).



            // **** 7. ADD ONE OR MORE DISPLAY CLONES *************************************************

            // For special purposes you can create one or more player display clones (display copies).
            // Display clones require sufficient computing (CPU) power and may slow some computers:

            myPlayer.DisplayClones.AddRange(new Control[] { panel2, panel3 });

            // CPU load can be reduced by lowering the framerate, quality or size of the clones.

            // Display clones use a CloneProperties data structure to get or set its properties,
            // for example to set the 'stretch' option for a display clone:

            CloneProperties props = myPlayer.DisplayClones.GetProperties(panel2);
            props.Layout = CloneLayout.Stretch;
            myPlayer.DisplayClones.SetProperties(panel2, props);

            // Display clones can now also have a custom shape, just like the player's display window, for example:
            // myPlayer.DisplayClones.SetProperties(panel2, new CloneProperties { Shape = DisplayShape.Oval });

            // To remove display clones from the player use one of the clones remove methods, for example:
            // myPlayer.DisplayClones.Remove(panel2);



            // **** 8. GET MEDIA ENDED INFORMATION ****************************************************

            // You may want to know when media has finished playing to play other (next) media and/or
            // stop certain processes (e.g. animation on a display overlay).
            // To detect that media has finished playing just subscribe to the MediaEnded event:

            myPlayer.Events.MediaEnded += MyPlayer_MediaEnded;  // see eventhandler below

            // You don't want to start playing next media from the MediaEnded event before all processes
            // have been notified that the previous media has finished playing, so there's another event:

            myPlayer.Events.MediaEndedNotice += MyPlayer_MediaEndedNotice;  // see eventhandler below

            // you can use this event to just stop any active processes (and not start any new media).
            // (With the MediaStarted event you can (re)start processes when new media starts playing.)

            // The MediaEnded(Notice) EndedEventArgs provide the following information:
            // void MyPlayer_MediaEnded(object sender, EndedEventArgs e)
            // {
            //     // e.MediaName - the name of the media that has stopped, for example the file name
            //     // e.SourceType - the type of the media that has stoped, for example a file or a webcam
            //     // e.StopReason - the reason the media has stopped:
            //
            //     switch (e.StopReason)
            //     {
            //         case StopReason.Finished:
            //             // media has finished playing
            //             break;
            //
            //         case StopReason.AutoStop:
            //             // media is stopped by the player to play next media
            //             break;
            //
            //         case StopReason.UserStop:
            //             // media is stopped with the Player.Stop method
            //             break;
            //
            //         case StopReason.Error:
            //             // media has stopped because an error has occurred
            //             break;
            //     }
            // }

            // To unsubscribe from the event you can use, for example:
            // myPlayer.Events.MediaEnded -= MyPlayer_MediaEnded;



            // **** 9. PLAY (OR REPEAT) ONLY PART OF A MEDIA FILE *************************************

            // N.B. 'Begin' and 'End' is used to indicate the natural begin and end of media
            //      'Start' and 'Stop' is used to indicate the actual start and stop times of media
            //      If not changed, 'Start' and 'Stop' values are the same as 'Begin' and 'End' values.

            // You can play (or repeat) only a part of a media file by specifying the start- and/or stop time:

            // a. to start playing media from a certain time just use the Play method, for instance:
            // myPlayer.Play(fileName, TimeSpan.FromSeconds(30), TimeSpan.Zero);

            // b. to start repeating a certain part of the media (for example 10 seconds), for instance:
            // myPlayer.Play(fileName, TimeSpan.FromSeconds(30), TimeSpan.FromSeconds(40), true);

            // c. while media is playing, for example, finish in 10 minutes from the current position:
            // myPlayer.Media.StopTime = myPlayer.Position.FromBegin + TimeSpan.FromMinutes(10);

            // d. to stop repeating (playing) media, use:
            // myPlayer.Repeat = false;



            // **** 10. ADD A TASKBAR PROGRESS INDICATOR **********************************************

            // To add a progress indicator in the taskbar button of a form, all you have to do is instruct
            // the player to do so by specifying the form:

            myPlayer.TaskbarProgress.Add(this);

            // You can specify any form you like (not just the form the display of the player is on) and use
            // multiple and/or duplicate forms.

            // You can specify the mode of the progress indicator (progress (default) or track (= 'begin to end')):

            myPlayer.TaskbarProgress.Mode = TaskbarProgressMode.Track;

            // You can remove a progress indicator with, for example: myPlayer.TaskbarProgress.Remove(this);



            // **** 11. CONTINUOUSLY RECEIVE INFORMATION ABOUT THE PLAYBACK POSITION ******************

            // If you want to display the elapsed and/or remaining media playback time (or use your
            // 'own' position slider) you can get continuous media playback positions information with:

            myPlayer.Events.MediaPositionChanged += MyPlayer_MediaPositionChanged; // see handler below

            // The information is sent by the player every 100 milliseconds (10 times a second)
            // This interval (and other timings) can be changed with the property myPlayer.TimerInterval

            // To unsubscribe from the event you can use:
            // myPlayer.Events.MediaPositionChanged -= MyPlayer_MediaPositionChanged;



            // **** 12. ADD A POSITION SLIDER CONTROLLED BY THE PLAYER ********************************

            // The player can control your media playback position slider (trackbar) with:

            myPlayer.Sliders.Position.TrackBar = trackBar1;

            // The position slider controlled by the player is only for input by the user. The value of
            // the slider should not be set from code. If you want to change the playback position (and
            // the slider value), use the position methods of the player, for example:
            // myPlayer.Position.FromBegin = TimeSpan.FromSeconds(30).

            // There are various options available for the position slider, for example:
            // myPlayer.Sliders.Position.LiveUpdate = true;

            // To remove a slider from the player set the slider to null:
            // myPlayer.Sliders.Position.TrackBar = null;



            // **** 13. SET THE AUDIO OUTPUT DEVICE USED BY THE PLAYER ********************************

            // By default, the player uses the system's default audio output device (if any), but this
            // can be changed using the Player.Audio.Device property.

            // This property uses an 'AudioDevice' data structure that contains the following 3 fields:
            // Id - the identifier of the audio device - this is actually used to set the output device
            // Name - the name of the device, for instance "Speakers"
            // Adapter - the name of the adapter of the device, for instance "XYZ Audio Adapter"

            // The AudioDevice data structures of the system's enabled audio devices can be retrieved with:
            // AudioDevice[] devices = myPlayer.Audio.GetDevices();
            // If there are no enabled audio output devices this method returns null.

            // To select one of the devices retrieved from GetDevices (usually selected from a menu) use:
            // myPlayer.Audio.Device = devices[index]; // where index represents a device in the list

            // To get the system's default audio device you can use:
            // AudioDevice defaultDevice = myPlayer.Audio.GetDefaultDevice();

            // To restore the use of the system's default audio device use myPlayer.Audio.Device = null;
            // This property also returns null if the player uses the system's default audio device.

            // To be informed of changes in the system's audio devices, subscribe to the devices event:
            // myPlayer.Events.MediaSystemAudioDevicesChanged += MyPlayer_SystemAudioDevicesChanged;

            // There's also an event for when the player's audio device has changed:
            // myPlayer.Events.MediaAudioDeviceChanged += MyPlayer_AudioDeviceChanged;

            // ****************************************************************************************
            // Note: PVS.MediaPlayer handles all audio devices and related events. This includes any changes
            // to the system audio devices and, for example, peak level information. You only need to use
            // the audio device events to update a user interface (for example, a devices menu).
            // ****************************************************************************************

            // If the audio device used by the player is disabled or removed (with the system's sound
            // control panel), the sound is output through the (new) standard audio device.

            // For a small but complete system of handling audio devices see the source code of the main
            // sample application PVSPlayerExample.



            // **** 14. SELECT AN AUDIO OR VIDEO TRACK ************************************************

            // A media file can contain multiple audio and video tracks. The media starts playing the
            // standard selected tracks, but these can easily be changed. For example, you can display
            // the tracks in a menu and let the user select one of the tracks.

            // For example, to select another audio track use:
            // myPlayer.Audio.Track = 1; // select the second audio track (if present)

            // Information about the available audio tracks can be obtained with:
            // int count = myPlayer.Media.AudioTrackCount; // gets the number of audio tracks
            // AudioTrack[] tracks = myPlayer.Media.GetAudioTracks(); // gets information about each track
            // If there are no audio tracks in the media, this function returns null.

            // The information can be used to display properties of the track, for example in a menu:
            // myMenu.Items.Add(tracks[0].Name + " " + tracks[0].Language);


            // Another video track can be selected in the same way:
            // myPlayer.Video.Track = 0; // select the first video track (if present)

            // Information about the available video tracks can be obtained with:
            // int count = myPlayer.Media.VideoTrackCount; // gets the number of video tracks
            // VideoTrack[] tracks = myPlayer.Media.GetVideoTracks(); // gets information about each track
            // If there are no video tracks in the media, this function returns null.



            // **** 15. AUDIO VALUES ******************************************************************

            // The audio volume and balance values of the player can be set with, for example:
            // myPlayer.Audio.Volume  = 0.5f;
            // myPlayer.Audio.Balance = -0.5f;

            // If the playing media contains more than 2 audio channels and you have a suitable audio set
            // connected to your computer, you can also set the volume of each channel:

            // You can check the number of audio channels in the playing media with:
            // int channelCount = myPlayer.Audio.ChannelCount;

            // You can get the audio volumes for each channel with:
            // float[] channelVolumes = myPlayer.Audio.ChannelVolumes;

            // To change the volume of, for example, the right (or 2nd) channel, use:
            // channelVolumes[1] = 0.7f;
            // myPlayer.Audio.ChannelVolumes = channelVolumes;


            // To get the changed values of the player's audio volume and balance use these events:
            myPlayer.Events.MediaAudioVolumeChanged += MyPlayer_MediaAudioVolumeChanged; // see handler below
            myPlayer.Events.MediaAudioBalanceChanged += MyPlayer_MediaAudioBalanceChanged; // see below

            // To unsubscribe from the event you can use:
            // myPlayer.Events.MediaAudioVolumeChanged -= MyPlayer_MediaAudioVolumeChanged;



            // **** 16. AUDIO SLIDERS *****************************************************************

            // The player can also control your audio sliders (trackbars) with:

            myPlayer.Sliders.AudioVolume  = trackBar2;    // audio volume slider
            myPlayer.Sliders.AudioBalance = trackBar3;    // audio balance slider

            // The audio sliders controlled by the player are only for input by the user. The values of
            // the sliders should not be set from code. If you want to change the audio properties (and
            // the sliders values) of the player, use the audio methods of the player, for example:
            // myPlayer.Audio.Volume = 0.5f;

            // To remove a slider from the player set the slider to null:
            // myPlayer.Sliders.AudioVolume = null;



            // **** 17. AUDIO OUTPUT PEAK LEVELS ******************************************************

            // Audio output levels can be used to display the peak levels of the player's audio output
            // device (for instance 'speakers') in a numeric or graphical (for example level/vu meters)
            // form or for other purposes.

            // To get the audio peak values from the audio device used by the player you can use the
            // MediaPeakLevelChanged event of the player:

            myPlayer.Events.MediaPeakLevelChanged += MyPlayer_MediaPeakLevelChanged; // see handler below

            // check if there is an audio device with:
            // if (myPlayer.LastError) { /* not supported */ }

            // The values received in the eventhandler are between 0.0 and 1.0 (inclusive) or -1 when media
            // playback has paused, stopped or ended - for every audio channel (usually 2 for stereo).

            // To unsubscribe from the event you can use:
            // myPlayer.Events.MediaPeakLevelChanged -= MyPlayer_MediaPeakLevelChanged;


            
            // **** 18. MEDIA SUBTITLES ***************************************************************

            // You can get the SubRip (.srt) subtitles (if any) of the playing media by subscribing to
            // the MediaSubtitleChanged event:

            myPlayer.Events.MediaSubtitleChanged += MyPlayer_MediaSubtitleChanged; // see eventhandler below

            // By default the subtitles file should be in the same folder and with the same name (but
            // with the .srt extension) as the media file, or one of its containing folders. You can
            // specify to search in any containing folders with (0 = media file 'base' folder):

            myPlayer.Subtitles.DirectoryDepth = 1; // search base folder and containing folders 1 level deep

            // If the subtitles file is located somewhere else or it has another name, you can specify
            // where to search with the myPlayer.Subtitles.Directory and/or myPlayer.Subtitles.FileName functions.
            // The Folder depth search applies also to this location.

            // There are some more convenient subtitles functions, e.g. to synchronize subtitles (TimeShift).

            // To unsubscribe from the event you can use:
            // myPlayer.Events.MediaSubtitleChanged -= MyPlayer_MediaSubtitleChanged;



            // **** 19. MEDIA METADATA PROPERTIES *****************************************************

            // You can get media metadata properties (like mp3 tags) with, for example:

            // Metadata data = myPlayer.Media.GetMetadata();

            // If no information is available for a specific item, the value of that item is null.
            // Use for example: if (string.IsNullOrEmpty(data.Artist)) ...

            // You can also extract this information from any (non-playing) file by specifying the file name.

            // See the methods PlayMedia, myPlayer_MediaEnded, myPlayer_MediaStopped and
            // DisposeMetadata for an example of the use of the media metadata properties option.



            // **** 20. ADD AN INFO LABEL TO THE PLAYER'S POSITION SLIDER *****************************

            // An Info Label is a kind of custom ToolTip that can be used with sliders (trackbars) to
            // show the current value when scrolling the slider, but can also be used in any other
            // situation where a short info / help text should be displayed.

            // Displaying slider information with an info label is made easy with the slider methods:
            // 'myPlayer.Sliders.ValueToPoint' gives the x/y-coordinate of a value on the slider and
            // 'myPlayer.Sliders.PointToValue' gives the value of the slider at a certain x/y-coordinate.
            // These methods can be used for any .net trackbar (not just the PVS.MediaPlayer sliders).
            // (Without a player you can use: SliderValue.ToPoint or SliderValue.FromPoint)

            // Info Labels can be used 'everywhere', not just with sliders as in this example.
            // Just use the info label Show method to display an info label wherever you want.

            // The location of the info label is determined by the specified location in the Show method
            // and the Align (e.g. TopCenter (default)) and AlignOffset settings.
            // The size of the info label is determined by font, bordersize, etc. but the 'additional' size
            // is set with the TextMargin (or TextSize for a fixed size info label) option.

            // Most options will probably be clear, but here's some tips:
            // - border and other brushes: first set the full size of the info label (e.g. fontsize,
            // bordersize etc. etc. and, in most cases, also a 'dummy' text) then create the brush
            // - setting a fixed size info label, same as with brushes and then use:
            // myInfoLabel.TextSize = myInfoLabel.TextSize; // this sets the current size and autosize to false
            // - the order in which the settings are made can be important.

            // Create an info label for use with all sliders in this application:
            myInfoLabel = new InfoLabel
            {
                RoundedCorners  = true,                     // use rounded corners
                FontSize        = 9.75f,                    // set font size (same as main window)
                TextMargin      = new Padding(2, 0, 2, 0),  // fine tuning inner spacing
                AlignOffset     = new Point(0, 7)           // move closer to slider thumb
            };


            // Here are some more examples (uncomment one at a time):

            // for the background any type of brush can be used (uncomment only this one to use):
            LinearGradientBrush myBackBrush = new LinearGradientBrush(new Rectangle(new Point(0, 0), myInfoLabel.Size), SystemColors.ButtonHighlight, SystemColors.ButtonShadow, LinearGradientMode.Vertical);
            myInfoLabel.BackBrush = myBackBrush;

            //or maybe no background at all(uncomment only this one to use):
            //myInfoLabel.ForeColor = Color.Red;
            //myInfoLabel.BackColor = Color.OrangeRed; // reduce visible edges around the text (anti-aliasing on transparent background)
            //myInfoLabel.BorderThickness = new Padding(0);
            //myInfoLabel.FontSize = 36;
            //myInfoLabel.Transparent = true;

            //here's a fixed size info label with a background picture (uncomment only this one to use):
            //myInfoLabel.TextMargin = new Padding(10, 70, 10, 10); // make 'room' for background image
            //myInfoLabel.ForeColor = Color.White;
            //myInfoLabel.Text = "Balance: Right 10.0"; // set size with the 'longest' possible text
            //myInfoLabel.TextSize = myInfoLabel.TextSize;  // set size + autosize off
            //myInfoLabel.BackImage = Image.FromFile(@"C:\Users\Public\Pictures\Sample Pictures\Desert.jpg");


            // Display an info label above the position slider's thumb using the slider's scroll event:
            trackBar1.Scroll += TrackBar1_Scroll;   // see eventhandler below

            // Same for the audio volume and balance sliders:
            trackBar2.Scroll += TrackBar2_Scroll;   // see eventhandler below
            trackBar3.Scroll += TrackBar3_Scroll;   // see eventhandler below

        }

        // Show display overlay at start up
        private void Form1_Shown(object sender, System.EventArgs e)
        {
            // show the display overlay at the start of the application (even if no movie is playing):
            // this instruction is put here because the player's display has to be 'created and visible'
            // to show the overlay:
            myPlayer.Overlay.Hold = true;
        }

        // Cleaning up - this is moved here from the 'Form1.Designer.cs' file and appended:
        protected override void Dispose(bool disposing)
        {
            if (!isDisposed)
            {
                isDisposed = true;
                if (disposing)
                {
                    // disposing a player also stops its overlay, display clones, eventhandlers etc.
                    if (myPlayer != null)       myPlayer.Dispose();         // stop and dispose the player
                    if (myOverlay != null)      myOverlay.Dispose();        // dispose the display overlay
                    if (myOpenFileDlg != null)  myOpenFileDlg.Dispose();    // dispose the file selector
                    if (myInfoLabel != null)    myInfoLabel.Dispose();      // dispose the info label
                    if (levelBrush != null)     levelBrush.Dispose();       // dispose the paint brush
                    if (metaData != null)       metaData.Dispose();         // dispose media metadata properties

                    // used by the designer - clean up:
                    if (components != null) components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        // Dispose metadata properties
        private void DisposeMetadata()
        {
            if (metaData != null)
            {
                myOverlay.subtitlesLabel.Text = string.Empty;
                panel1.BackgroundImage = null;
                metaData.Dispose(); // this also disposes the image (used with panel1.BackgroundImage)
                metaData = null;
            }
        }

        #endregion

        // **** Media Play / Pause - Resume / Stop ****************************************************

        #region Media Play / Pause - Resume / Stop

        private void PlayMedia()
        {
            if (myOpenFileDlg.ShowDialog() == DialogResult.OK)
            {
                myPlayer.Play(myOpenFileDlg.FileName);
                if (myPlayer.LastError)
                {
                    MessageBox.Show(myPlayer.LastErrorString);
                }
                else
                {
                    // Show media metadata properties (here for audio media only)
                    if (myPlayer.Has.AudioOnly)
                    {
                        metaData = myPlayer.Media.GetMetadata();

                        panel1.BackgroundImageLayout = ImageLayout.Zoom;
                        panel1.BackgroundImage = metaData.Image;

                        myOverlay.subtitlesLabel.Text = metaData.Artist + "\r\n" + metaData.Title;
                    }
                }
            }
        }

        private void PauseMedia()
        {
            myPlayer.Paused = !myPlayer.Paused;
            if (myPlayer.Paused) button2.Text = "Resume";
            else button2.Text = "Pause";
        }

        private void StopMedia()
        {
            myPlayer.Stop();
        }

        #endregion

        // **** Player Eventhandlers ******************************************************************

        #region Player Eventhandlers

        // Show changed audio volume value
        private void MyPlayer_MediaAudioVolumeChanged(object sender, System.EventArgs e)
        {
            label3.Text = (myPlayer.Audio.Volume).ToString("0.00");
        }

        // Show changed audio balance value
        private void MyPlayer_MediaAudioBalanceChanged(object sender, System.EventArgs e)
        {
            label4.Text = (myPlayer.Audio.Balance).ToString("0.00");
        }

        // Display the elapsed and remaining playback time
        private void MyPlayer_MediaPositionChanged(object sender, PositionEventArgs e)
        {
            // all lengths are in 'ticks' - 10000 ticks = 1 millisecond - use TimeSpan.FromTicks:

            label1.Text = TimeSpan.FromTicks(e.FromStart).ToString(@"hh\:mm\:ss");
            label2.Text = TimeSpan.FromTicks(e.ToStop).ToString(@"hh\:mm\:ss");
        }

        // Handle media audio output levels - calculate the values and paint the level displays
        private void MyPlayer_MediaPeakLevelChanged(object sender, PeakLevelEventArgs e)
        {
            // you could add some 'logic' here to make the movements of the indicators less 'jumpy'

            if (e.MasterPeakValue == -1) // media playback has stopped, paused or ended
            {
                // graphical presentation:
                leftLevel = rightLevel = 0;

                // value display:
                label5.Text = "0.00"; // same format as below
                label6.Text = "0.00";
            }
            else
            {
                // check e.ChannelCount for more than 2 (= stereo) channels
                // if you want to display the peak levels of all audio channels

                // graphical presentation:
                leftLevel = (int)(e.ChannelsValues[0] * levelUnit); // levelUnit is just the width of panel 4 and 5
                rightLevel = (int)(e.ChannelsValues[1] * levelUnit);

                // value display (use string format because of float rounding errors - zero can become a small value):
                label5.Text = e.ChannelsValues[0].ToString("0.00");
                label6.Text = e.ChannelsValues[1].ToString("0.00");
            }
            panel4.Invalidate();
            panel5.Invalidate();
        }

        // Paint the left channel audio output level display
        private void Panel4_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillRectangle(levelBrush, 0, 0, leftLevel, panel4.ClientRectangle.Height);
        }

        // Paint the right channel audio output level display
        private void Panel5_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillRectangle(levelBrush, 0, 0, rightLevel, panel5.ClientRectangle.Height);
        }

        // Mouse clicked on player display
        private void MyPlayer_MouseClick(object sender, MouseEventArgs e)
        {
            //MessageBox.Show(e.Button.ToString() + " mouse button clicked on player display.", "PVS.MediaPlayer How To...", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (myPlayer.Display.Mode == DisplayMode.Stretch) myPlayer.Display.Mode = DisplayMode.ZoomCenter;
            else myPlayer.Display.Mode = DisplayMode.Stretch;
        }

        // Mouse clicked on player display clone
        private void Clone_MouseClick(object sender, MouseEventArgs e)
        {
            //MessageBox.Show(e.Button.ToString() + " mouse button clicked on player display clone.", "PVS.MediaPlayer How To...", MessageBoxButtons.OK, MessageBoxIcon.Information);
            CloneProperties props = myPlayer.DisplayClones.GetProperties((Control)sender);
            if (props.Layout == CloneLayout.Stretch) props.Layout = CloneLayout.Zoom;
            else props.Layout = CloneLayout.Stretch;
            myPlayer.DisplayClones.SetProperties((Control)sender, props);
        }

        // Media has finished or stopped playing (1)
        private void MyPlayer_MediaEndedNotice(object sender, EndedEventArgs e)
        {
            // you can just stop any processes (and not starting new media) from the
            // MediaEndedNotice eventhandler that is fired just before the MediaEnded event.
        }

        // Media has finished or stopped playing (2)
        private void MyPlayer_MediaEnded(object sender, EndedEventArgs e)
        {
            DisposeMetadata();
        }

        // Get media subtitles / media subtitle has changed
        private void MyPlayer_MediaSubtitleChanged(object sender, SubtitleEventArgs e)
        {
            // In this example the subtitle's text is shown in a label on a display overlay
            myOverlay.subtitlesLabel.Text = e.Subtitle;
        }

        // Show an info label on the position slider of the player when scrolled
        private void TrackBar1_Scroll(object sender, System.EventArgs e)
        {
            // Get the position slider's x-coordinate of the current position (= thumb location)
            // (myInfoLabel.AlignOffset has been set to 0, 7)
            Point myInfoLabelLocation = myPlayer.Sliders.ValueToPoint(trackBar1, trackBar1.Value);

            // Show the infolabel
            myInfoLabel.Show(myPlayer.Position.FromStart.ToString(@"hh\:mm\:ss"), trackBar1, myInfoLabelLocation);
        }

        // Show an info label on the audio volume slider of the player when scrolled
        private void TrackBar2_Scroll(object sender, System.EventArgs e)
        {
            // Get the audio volume slider's x-coordinate of the current volume (= thumb location)
            // (myInfoLabel.AlignOffset has been set to 0, 7)
            Point myInfoLabelLocation = myPlayer.Sliders.ValueToPoint(trackBar2, trackBar2.Value);

            // Show the infolabel
            myInfoLabel.Show("Volume: " + (myPlayer.Audio.Volume).ToString("0.00"), trackBar2, myInfoLabelLocation);
        }

        // Show an info label on the audio balance slider of the player when scrolled
        private void TrackBar3_Scroll(object sender, System.EventArgs e)
        {
            // Get the audio balance slider's x-coordinate of the current balance (= thumb location)
            // (myInfoLabel.AlignOffset has been set to 0, 7)
            Point myInfoLabelLocation = myPlayer.Sliders.ValueToPoint(trackBar3, trackBar3.Value);

            // Calculate balance display value
            float val = myPlayer.Audio.Balance;

            // Set the text for the info label (using StringBuilder)
            myInfoLabelText.Length = 0;
            if (val == 0) myInfoLabelText.Append("Balance: Center");
            else
            {
                if (val < 0) myInfoLabelText.Append("Balance: Left ").Append((-val).ToString("0.00"));
                else myInfoLabelText.Append("Balance: Right ").Append((val).ToString("0.00"));
            }

            // Show the info label
            myInfoLabel.Show(myInfoLabelText.ToString(), trackBar3, myInfoLabelLocation);
        }

        #endregion

        // **** Controls Handling *********************************************************************

        #region CheckBoxes

        // Set player display overlay
        private void CheckBox1_CheckedChanged(object sender, System.EventArgs e)
        {
            if (checkBox1.Checked) myPlayer.Overlay.Window = myOverlay;
            else myPlayer.Overlay.Window = null;
        }

        // Set player display clones overlay
        private void CheckBox2_CheckedChanged(object sender, System.EventArgs e)
        {
            myPlayer.DisplayClones.ShowOverlay = checkBox2.Checked;
        }

        // Set position slider live update
        private void CheckBox3_CheckedChanged(object sender, System.EventArgs e)
        {
            myPlayer.Sliders.Position.LiveUpdate = checkBox3.Checked;
        }

        // Set taskbar progress indicator
        private void TaskbarBox_CheckedChanged(object sender, System.EventArgs e)
        {
            if (taskbarBox.Checked) myPlayer.TaskbarProgress.Add(this);
            else myPlayer.TaskbarProgress.Remove(this);
        }

        // Set display shape - using the preset display shapes
        private void CheckBox4_CheckedChanged(object sender, System.EventArgs e)
        {
            if (++shapeStatus > 5) shapeStatus = 0;

            switch (shapeStatus)
            {
                case 1: // oval shaped video and overlay
                    myPlayer.Display.SetShape(DisplayShape.Oval, true, true);
                    panel2.BackColor = this.BackColor;
                    panel3.BackColor = this.BackColor;
                    break;

                case 3: // rounded rectangle shaped video and overlay
                    panel1.BorderStyle = BorderStyle.None;
                    myPlayer.Display.SetShape(DisplayShape.Rounded, true, true);
                    panel2.BackColor = this.BackColor;
                    panel3.BackColor = this.BackColor;
                    break;

                case 5: // star shaped video and overlay
                    myPlayer.Display.SetShape(DisplayShape.Star, true, true);
                    panel2.BackColor = this.BackColor;
                    panel3.BackColor = this.BackColor;
                    break;

                default:
                    // normal shaped display and overlay
                    panel1.BorderStyle = BorderStyle.FixedSingle;
                    myPlayer.Display.SetShape(DisplayShape.Normal);
                    panel2.BackColor = Color.FromArgb(32, 32, 32);
                    panel3.BackColor = Color.FromArgb(32, 32, 32);
                    break;
            }
        }

        #endregion

        #region Buttons

        // Play
        private void Button1_Click(object sender, System.EventArgs e)
        {
            PlayMedia();
        }

        // Pause / Resume
        private void Button2_Click(object sender, System.EventArgs e)
        {
            PauseMedia();
        }

        // Stop
        private void Button3_Click(object sender, System.EventArgs e)
        {
            StopMedia();
        }

        // Quit
        private void Button5_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }

        #endregion

    }
}
