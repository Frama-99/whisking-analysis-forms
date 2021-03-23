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
    public partial class GrabberDlg : Form
    {
        Grabber SampleGrabber;

        public GrabberDlg(Grabber sampleGrabber)
        {
            SampleGrabber = sampleGrabber; 
            InitializeComponent();
        }

        private void GrabberDlg_Load(object sender, EventArgs e)
        {
            //Query the grab module to know how much grabbers are availables
            int driverCount = (int)SampleGrabber.GetDriverCount();

            //Fill the ListBox with all the available cards
            HEnums.SupportedGrabber id = HEnums.SupportedGrabber.H_NORPIX_VIRTUAL;

            GrabberList.BeginUpdate();
            
            for(int index = 0; index < driverCount; index++)
                GrabberList.Items.Add(SampleGrabber.GetDriverInfo(index, ref id));

            GrabberList.EndUpdate();

            //Set a default selection
            GrabberList.SetSelected(0, true);
        }

        private void LaunchButton_Click(object sender, EventArgs e)
        {
            //Retreive the identifier of the selected grabber
            HEnums.SupportedGrabber driverID = HEnums.SupportedGrabber.H_NORPIX_VIRTUAL;

            if(SampleGrabber.GetDriverInfo(GrabberList.SelectedIndex, ref driverID) == "")
            {
                DialogResult = System.Windows.Forms.DialogResult.Cancel;
                Close();
                return;
            }

            //Try to load the selected grabber
            if(!SampleGrabber.Load(driverID, "DemoGrabNet", false))
            {
                //retreive the error code
                //eHErrorCode error = GrabModule->GetLastError();

                //Display the error message
                //AfxMessageBox(HErrorManager::GetErrorString(error));

                //Grabber could not be loaded
                DialogResult = System.Windows.Forms.DialogResult.Cancel;
                Close();
                return;
            }

            MessageBox.Show("Grabber successfully loaded", "WhiskingAnalysis");
            Close();
        }
    }
}