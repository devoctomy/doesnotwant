using devoctomy.DoesNotWant.Filters;
using devoctomy.DoesNotWant.Usercontrols;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace devoctomy.DoesNotWant.Forms
{

    public partial class frmCreateFilter : Form
    {

        #region private objects

        private Dictionary<String, UserControl> cDicControls;
        private Boolean cBlnArtist = false;

        #endregion

        #region public properties

        public SpotifyAPI.Local.Models.Track FilterTrack { get; set; }

        public FilterBase Filter { get; private set; }

        #endregion

        #region constructor / destructor

        public frmCreateFilter()
        {
            InitializeComponent();
            Init();
        }

        #endregion

        #region private methods

        private void Init()
        {
            cDicControls = new Dictionary<String, UserControl>();

            FilterType pFTeType = new FilterType();
            pFTeType.Dock = DockStyle.Fill;
            pFTeType.TrackClicked += PFTeType_TrackClicked;
            pFTeType.ArtistClicked += PFTeType_ArtistClicked;
            Controls.Add(pFTeType);
            pFTeType.BringToFront();
            pFTeType.Show();
            cDicControls.Add("filtertype", pFTeType);

            ArtistFilterConfig pAFCArtistFilterConfig = new ArtistFilterConfig();
            pAFCArtistFilterConfig.Dock = DockStyle.Fill;
            pAFCArtistFilterConfig.InvalidInput += PAFCArtistFilterConfig_InvalidInput;
            pAFCArtistFilterConfig.ValidInput += PAFCArtistFilterConfig_ValidInput;
            Controls.Add(pAFCArtistFilterConfig);
            pAFCArtistFilterConfig.BringToFront();
            pAFCArtistFilterConfig.Hide();
            cDicControls.Add("artistfilterconfig", pAFCArtistFilterConfig);

            panButtons.Hide();
        }


        #endregion

        #region object events

        private void PFTeType_ArtistClicked(object sender, EventArgs e)
        {
            cBlnArtist = true;
            cDicControls["filtertype"].Hide();
            ((ArtistFilterConfig)cDicControls["artistfilterconfig"]).FilterTrack = FilterTrack;
            cDicControls["artistfilterconfig"].Show();
            panButtons.Show();
            butOK.Enabled = ((ArtistFilterConfig)cDicControls["artistfilterconfig"]).IsValidInput;
        }

        private async void PFTeType_TrackClicked(object sender, EventArgs e)
        {
            Filter = new TrackFilter(FilterTrack.TrackResource.Uri, 
                await FilterTrack.GetAlbumArtAsync(SpotifyAPI.Local.Enums.AlbumArtSize.Size160),
                String.Format("{0}|{1}", FilterTrack.ArtistResource.Name, FilterTrack.TrackResource.Name));
            DialogResult = DialogResult.OK;
        }

        private void PAFCArtistFilterConfig_ValidInput(object sender, EventArgs e)
        {
            if(cBlnArtist)
            {
                butOK.Enabled = true;
            }
        }

        private void PAFCArtistFilterConfig_InvalidInput(object sender, EventArgs e)
        {
            if (cBlnArtist)
            {
                butOK.Enabled = false;
            }
        }

        private async void butOK_Click(object sender, EventArgs e)
        {
            ArtistFilterConfig pAFCConfig = (ArtistFilterConfig)cDicControls["artistfilterconfig"];
            Filter = new ArtistFilter(pAFCConfig.Field,
                pAFCConfig.Value,
                await FilterTrack.GetAlbumArtAsync(SpotifyAPI.Local.Enums.AlbumArtSize.Size160),
                FilterTrack.ArtistResource.Name);
            DialogResult = DialogResult.OK;
        }

        #endregion

    }

}
