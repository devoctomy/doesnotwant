using System;
using System.Windows.Forms;

namespace devoctomy.DoesNotWant.Usercontrols
{

    public partial class Track : UserControl
    {

        #region public events

        public event EventHandler<EventArgs> FilterClicked;

        #endregion

        #region private objects

        private SpotifyAPI.Local.Models.Track cDTkTrack;

        #endregion

        #region public properties

        public SpotifyAPI.Local.Models.Track CurrentTrack
        {
            get
            {
                return (cDTkTrack);
            }
            set
            {
                cDTkTrack = value;
                DisplayTrack();
            }
        }

        #endregion

        #region constructor / destructor

        public Track()
        {
            InitializeComponent();
        }

        #endregion

        #region base class events

        private void Track_Resize(object sender, EventArgs e)
        {
            picImage.Width = Height;
        }

        #endregion

        #region private methods

        private void DisplayTrack()
        {
            if(cDTkTrack != null)
            {
                picImage.Image = cDTkTrack.GetAlbumArt(SpotifyAPI.Local.Enums.AlbumArtSize.Size640);
                lblArtistName.Text = cDTkTrack.ArtistResource.Name;
                lblTrackTitle.Text = cDTkTrack.TrackResource.Name;
                butFilter.Visible = !cDTkTrack.IsAd();
            }
            else
            {
                picImage.Image = null;
                lblArtistName.Text = String.Empty;
                lblTrackTitle.Text = String.Empty;
                butFilter.Visible = false;
            }
        }

        #endregion

        #region object events

        private void butFilter_Click(object sender, EventArgs e)
        {
            if(FilterClicked != null)
            {
                FilterClicked(this, EventArgs.Empty);
            }
        }

        #endregion

    }

}
