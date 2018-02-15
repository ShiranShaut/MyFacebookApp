using System;
using System.Text;
using System.Drawing;
using System.Net;
using System.IO;
using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using FacebookWrapper.ObjectModel;

namespace CheckInsController
{
    public class CheckInWrapper
    {
        private readonly Checkin r_RealCheckIn;
        private readonly PointLatLng r_CheckInLocation;
        private readonly GMapMarker r_CheckInMarkerOnMap;

        public string Name
        {
            get;
            set;
        }

        public string PhotoUrl
        {
            get;
            set;
        }

        public string Link
        {
            get;
            set;
        }

        public DateTime CreatedTime
        {
            get;
            set;
        }

        public string Description
        {
            get;
            set;
        }

        public Image CheckInImage
        {
            get;
            set;
        }

        public FacebookObjectCollection<User> LikedBy
        {
            get { return r_RealCheckIn.LikedBy; }
        }

        public FacebookObjectCollection<User> TaggedUsers
        {
            get { return r_RealCheckIn.TaggedUsers; }
        }

        public GMapMarker CheckInMarkerOnMap
        {
            get { return r_CheckInMarkerOnMap; }
        }

        public CheckInWrapper(Checkin i_RealCheckIn)
        {
            r_RealCheckIn = i_RealCheckIn;
            r_CheckInLocation = new PointLatLng((double)r_RealCheckIn.Place.Location.Latitude, (double)r_RealCheckIn.Place.Location.Longitude);
            updateProperties();

            StringBuilder descriptionToToolTip = new StringBuilder();
            descriptionToToolTip.AppendLine("Name: " + Name);
            descriptionToToolTip.AppendLine("You Been there on: " + CreatedTime.ToString());

            r_CheckInMarkerOnMap = new GMarkerGoogle(r_CheckInLocation, GMarkerGoogleType.pink);
            r_CheckInMarkerOnMap.ToolTipText = descriptionToToolTip.ToString();
        }

        private void updateProperties()
        {
            Name = (r_RealCheckIn.Place.Name == null) ? "[No Name]" : r_RealCheckIn.Place.Name;
            PhotoUrl = (r_RealCheckIn.PictureURL == null) ? string.Empty : r_RealCheckIn.PictureURL;
            Link = (r_RealCheckIn.Link == null) ? string.Empty : r_RealCheckIn.Link;
            CreatedTime = ((DateTime)r_RealCheckIn.CreatedTime == null) ? new DateTime(1, 1, 1) : (DateTime)r_RealCheckIn.CreatedTime;
            Description = (r_RealCheckIn.Description == null) ? string.Empty : r_RealCheckIn.Description;
            Description = (Description == string.Empty) ? "This Check in dosen't contain description" : Description;

            if (!string.IsNullOrEmpty(PhotoUrl))
            {
                WebClient webClient = new WebClient();
                byte[] bytes = webClient.DownloadData(PhotoUrl);
                MemoryStream stream = new MemoryStream(bytes);
                CheckInImage = Image.FromStream(stream);
            }
        }
    }
}