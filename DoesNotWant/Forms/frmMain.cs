using devoctomy.DoesNotWant.Configuration;
using devoctomy.DoesNotWant.Spotify;
using devoctomy.DoesNotWant.Usercontrols;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace devoctomy.DoesNotWant.Forms
{
    public partial class frmMain : Form
    {

        #region constructor / destructor

        public frmMain()
        {
            InitializeComponent();
            Disconnected();             //Set as disconnected
            Program.StartMonitor();     //Start monitoring

            Filter arse = new Filter();
            arse.Size = new Size(flpFilters.Width - 32, panCurrentlyPlaying.Height);
            flpFilters.Controls.Add(arse);

            arse = new Filter();
            arse.Size = new Size(flpFilters.Width - 32, panCurrentlyPlaying.Height);
            flpFilters.Controls.Add(arse);

            arse = new Filter();
            arse.Size = new Size(flpFilters.Width - 32, panCurrentlyPlaying.Height);
            flpFilters.Controls.Add(arse);

            arse = new Filter();
            arse.Size = new Size(flpFilters.Width - 32, panCurrentlyPlaying.Height);
            flpFilters.Controls.Add(arse);

            arse = new Filter();
            arse.Size = new Size(flpFilters.Width - 32, panCurrentlyPlaying.Height);
            flpFilters.Controls.Add(arse);


        }

        #endregion

        #region public methods

        public void Connected()
        {
            panCurrentlyPlaying.Visible = true;
            ncdNotConnected.Visible = false;
            panFilters.Visible = true;
            trkTrack.CurrentTrack = Program.SpotifyMonitor.CurrentlyPlaying;
        }

        public void Disconnected()
        {
            panCurrentlyPlaying.Visible = false;
            ncdNotConnected.Visible = true;
            panFilters.Visible = false;
        }

        public void TrackChanged(MonitorTrackChangedEventArgs iArgs)
        {
            if(Config.Current().IsFiltered(iArgs.CurrentTrack))
            {
                iArgs.Skip = true;
            }
            
            if(!iArgs.Skip)
            {
                trkTrack.CurrentTrack = iArgs.CurrentTrack;
            }
        }

        #endregion

        #region private methods

        #endregion

        #region object events

        private void trkTrack_FilterClicked(object sender, System.EventArgs e)
        {
            using (frmCreateFilter pFrmCreateFilter = new frmCreateFilter())
            {
                Usercontrols.Track pTrkTrack = (Usercontrols.Track)sender;
                SpotifyAPI.Local.Models.Track pTrkCurrentlyPlaying = pTrkTrack.CurrentTrack;
                if (!pTrkCurrentlyPlaying.IsAd())
                {
                    pFrmCreateFilter.FilterTrack = pTrkCurrentlyPlaying;
                    if (pFrmCreateFilter.ShowDialog() == DialogResult.OK)
                    {
                        Config.Current().AddFilter(pFrmCreateFilter.Filter);
                        Program.SpotifyMonitor.Skip();
                    }
                }
            }
        }

        private void butOK_Click(object sender, EventArgs e)
        {
            //Hide();
        }

        #endregion

    }
}
