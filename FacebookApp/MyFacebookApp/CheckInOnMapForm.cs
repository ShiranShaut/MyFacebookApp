using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Threading;
using GMap.NET.WindowsForms;
using GMap.NET.MapProviders;
using GMap.NET;
using FacebookWrapper.ObjectModel;
using CheckInsController;

namespace MyFacebookApp
{
    public partial class CheckInOnMapForm : Form
    {
        private readonly List<CheckInWrapper> r_CheckInsOnForm = new List<CheckInWrapper>();
        private GMapOverlay m_MapMarkers = new GMapOverlay("markers");

        public FacebookObjectCollection<Checkin> UserCheckIns
        {
            get; set;
        }

        public CheckInOnMapForm()
        {
            InitializeComponent();
        }

        private void checkInOnMapForm_Load(object i_Sender, EventArgs i_EventArgs)
        {
            this.CenterToScreen();
            CheckInGMapControl.MapProvider = GoogleMapProvider.Instance;
            GMaps.Instance.Mode = AccessMode.ServerOnly;
            CheckInGMapControl.SetPositionByKeywords("Israel, Holon");
            CheckInGMapControl.RoutesEnabled = true;
            CheckInGMapControl.ShowCenter = false;
            CheckInGMapControl.DragButton = MouseButtons.Left;

            new Thread(updateInfo).Start();
        }

        private void updateInfo()
        {
            if (UserCheckIns.Count == 0)
            {
                MessageBox.Show("There isn't check ins to show", "Not regitered to check in");
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                foreach (Checkin curCheckIn in UserCheckIns)
                {
                    r_CheckInsOnForm.Add(new CheckInWrapper(curCheckIn));
                }

                if (!CheckInsListBox.InvokeRequired)
                {
                    checkInWrapperBindingSource.DataSource = r_CheckInsOnForm;
                }
                else
                {
                    CheckInsListBox.Invoke(new Action(() => checkInWrapperBindingSource.DataSource = r_CheckInsOnForm));
                }

                if (m_MapMarkers.Markers.Count == 0)
                {
                    setMarkers();
                }

                addMarkersToMap();
            }
        }

        private void setMarkers()
        {
            foreach (CheckInWrapper curCheckIn in r_CheckInsOnForm)
            {
                m_MapMarkers.Markers.Add(curCheckIn.CheckInMarkerOnMap);
            }
        }
        
        private void addMarkersToMap()
        {
            if (!CheckInGMapControl.InvokeRequired)
            {
                CheckInGMapControl.Overlays.Add(m_MapMarkers); // add markers to map
                CheckInGMapControl.Zoom = 11.5;
            }
            else
            {
                CheckInGMapControl.Invoke(new Action(() =>
                {
                    CheckInGMapControl.Overlays.Add(m_MapMarkers);
                    CheckInGMapControl.Zoom = 11.5;
                }));
            }
        }
  
        private void checkInOnMapForm_FormClosing(object i_Sender, FormClosingEventArgs i_EventArgs)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void checkInLinkLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (!string.IsNullOrEmpty(CheckInLinkLinkLabel.Text))
            {
                Process linkedUrl = Process.Start(CheckInLinkLinkLabel.Text);

                linkedUrl.WaitForExit();
            }
        }
    }
}