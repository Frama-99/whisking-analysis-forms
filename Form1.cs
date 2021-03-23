using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using NorPix.HermesNET;

namespace WhiskingAnalysis
{
    public partial class MainForm : Form
    {
        private Grabber SampleGrabber;
        private Viewer SampleViewer;
        private Sequence SampleSequence;
        private bool SequenceReady;

        private OnImageNotificationDelegate OnImageReceivedCallback;
        
        private HermesImage LastImage;
        private int YOffset;

        public MainForm()
        {
            InitializeComponent();

            System.Diagnostics.Trace.WriteLine("WhiskingAnalysis - starting");

            YOffset = MainMenu.Size.Height; //To draw the image below the menu bar

            SequenceReady = false;
            SampleSequence = new Sequence();

            SampleGrabber = new Grabber();
            OnImageReceivedCallback = new OnImageNotificationDelegate(OnImageReceived); 
            
            SampleViewer = new Viewer();
        }

        private void DemoGrabForm_Shown(object sender, EventArgs e)
        {
            GrabberDlg dlg = new GrabberDlg(SampleGrabber);

            if(dlg.ShowDialog() != DialogResult.OK)
            {
                Application.Exit();
                return;
            }

            SampleGrabber.SetCallbackOnImageReceived(OnImageReceivedCallback);
            SampleGrabber.StartStreaming();
        }

        private void DemoGrabForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(SampleGrabber.IsStreaming())
                SampleGrabber.StopStreaming();

            SampleGrabber.Unload();
            SampleSequence.Close();

            System.Diagnostics.Trace.WriteLine("WhiskingAnalysis - stopping");
        }

        public void OnImageReceived(HermesImage image, int userData, IntPtr userPtr)
        {
            //System.Diagnostics.Trace.WriteLine("WhiskingAnalysis - OnImageReceived");
            LastImage = image;

            if(SequenceReady)
                SampleSequence.Write(image);
            
            Invalidate(false);
        }

        private void DemoGrabForm_Paint(object sender, PaintEventArgs e)
        {
            try
            {
                SampleViewer.ShowImage(e.Graphics.GetHdc(), LastImage, 0, YOffset);
            }

            catch(System.Exception ex)
            {
                System.Diagnostics.Trace.WriteLine("WhiskingAnalysis - Paint failed (" + ex.ToString() + ")");
            }

            finally
            {
                e.Graphics.ReleaseHdc();
            }
        }

        
        private void OnMenuExit(object sender, EventArgs e)
        {
            Application.Exit(); //Quit
        }

        private void OnMenuLive(object sender, EventArgs e)
        {
            MenuLive.Checked = !MenuLive.Checked;

            if(SampleGrabber.IsStreaming() && !MenuLive.Checked)
                SampleGrabber.StopStreaming();

            else if(!SampleGrabber.IsStreaming() && MenuLive.Checked)
                SampleGrabber.StartStreaming();
        }

        private void OnMenuPropertyPages(object sender, EventArgs e)
        {
            //Some property pages aren't shown if you are in live. (such as the one 
            //allowing to set a new image size)  Stop the live then select the
            //"Property Pages" menu item to see them.
            SampleGrabber.ShowProperties(Handle);
        }

        private void OnMenuImageInfo(object sender, EventArgs e)
        {
            HEnums.ImageFormat format = SampleGrabber.GetImageFormat();
            String type = HermesUtils.ImageFormatToString(format);
            
            String info = "Image Format : " + type 
                + "\nImage Width : " + SampleGrabber.GetImageWidth() 
                + "\nImage Height : " + SampleGrabber.GetImageHeight()
                + "\nBit Depth : " + SampleGrabber.GetImageBitDepth()
                + "\nTrue Bit Depth : " + SampleGrabber.GetImageBitDepthReal() 
                + "\nImage Size : " + SampleGrabber.GetImageSizeBytes() + " bytes";

            MessageBox.Show(info, "Image Information");
        }

        private void OnMenuDirectSettings(object sender, EventArgs e)
        {
            String msg = ""; 

            //Enumerate every available settings
            int settingsCount = 0;

            SampleGrabber.GetSettingsCount(ref settingsCount);

            //Enumerate every settings
            for(int index = 0; index < settingsCount; index++)
            {
                String featureName = "";
                int featureID = 0;
                SampleGrabber.GetSettingsCaps(index, ref featureName, ref featureID);

                msg += "\n- ";
                msg += featureName;
                msg += " -\n";

                //Enumerate every possible value
                int valuesCount = 0;
                SampleGrabber.GetValuesCount(featureID, ref valuesCount);
    
                int currentValue = 0;
                SampleGrabber.GetCurrentValues(featureID, ref currentValue);

                for(int i = 0; i < valuesCount; i++)
                {
                    String valueName = "";
                    int valueID = 0;

                    SampleGrabber.GetValuesCaps(featureID, i, ref valueName, ref valueID);
                    msg += valueName;
        
                    if(valueID == currentValue)
                        msg += " <-\n";
                    else
                        msg += "\n";
                }
            } 

            MessageBox.Show(msg, "Grabber Settings");
        }

        private void OnMenuDirectAdjustments(object sender, EventArgs e)
        {
            String msg = "";
            String temp = "";

            //Enumerate every available settings
            int adjCount = 0;
            
            SampleGrabber.GetAdjustmentCount(ref adjCount);

            //Enumerate every settings
            for(int index = 0; index < adjCount; index++)
            {
                String featureName = "";
                int featureID = 0;
                int min = 0;
                int max = 0;
                double dMin = 0;
                double dMax = 0;
                bool integer = true;
                bool logSlider = false;
                bool manual = true;
                bool automatic = false;
                bool oneShot = false;

                SampleGrabber.GetAdjustmentCaps(index, ref featureID, ref featureName, ref min, ref max,
                    ref dMin, ref dMax, ref integer, ref logSlider, ref manual, ref automatic, ref oneShot);
                
                if(integer)
                {
                    //Get the current value
                    int current = 0;
                    SampleGrabber.GetIntegerAdjustment(featureID, ref current);

                    temp = index + " - Feature Name : " + featureName + " (ID:" + featureID
                        + ")\nRange [" + min + "," + max + "], Current : " + current + "\n"
                        + (logSlider ? "Log slider" : "Standard slider") + "\n"
                        + (manual ? "Support manual" : "Don't support manual") + "\n"
                        + (automatic ? "Support automatic" : "Don't support automatic") + "\n"
                        + (oneShot ? "Support One Shot" : "Don't support One Shot") + "\n\n";
                }

                else
                {
                    //Get the current value
                    double current = 0;
                    SampleGrabber.GetDoubleAdjustment(featureID, ref current);

                    temp = index + " - Feature Name : " + featureName + " (ID:" + featureID
                        + ")\nRange [" + dMin + "," + dMax + "], Current : " + current + "\n"
                        + (logSlider ? "Log slider" : "Standard slider") + "\n"
                        + (manual ? "Support manual" : "Don't support manual") + "\n"
                        + (automatic ? "Support automatic" : "Don't support automatic") + "\n"
                        + (oneShot ? "Support One Shot" : "Don't support One Shot") + "\n\n";
                }

                msg += temp;
            }

            MessageBox.Show(msg, "Grabber Adjustments");
        }

        private void OnMenuNewSequence(object sender, EventArgs e)
        {
            System.Diagnostics.Trace.WriteLine("WhiskingAnalysis - Creating the sequence");

            SaveFileDialog fd = new SaveFileDialog();

            fd.FileName = "sequence";
            fd.DefaultExt = "seq";
            fd.Filter = "Norpix Sequence File (*.seq)|*.seq||";
            fd.RestoreDirectory = true;

            if(fd.ShowDialog() != DialogResult.OK)
                return; //user clicked [Cancel]

            if(SampleSequence.Create(fd.FileName, HEnums.Compression.H_COMPRESSION_NONE, 0, 100))
                SequenceReady = true;
        }

        private void OnUpdateMenuNewSequence(object sender, PaintEventArgs e)
        {
            NewSequenceItem.Enabled = !SequenceReady;
        }

        private void OnMenuCloseSequence(object sender, EventArgs e)
        {
            if(!SequenceReady)
                return;

            System.Diagnostics.Trace.WriteLine("WhiskingAnalysis - Closing the sequence");
            SequenceReady = false;
            SampleSequence.Close();
        }

        private void OnUpdateMenuCloseSequence(object sender, PaintEventArgs e)
        {
            CloseSequenceItem.Enabled = SequenceReady;
        }
    }
}



