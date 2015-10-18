using devoctomy.DoesNotWant.Configuration;
using devoctomy.DoesNotWant.Filters;
using devoctomy.DoesNotWant.Spotify;
using devoctomy.DoesNotWant.Usercontrols;
using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace devoctomy.DoesNotWant.Forms
{
    public partial class frmMain : Form
    {

        #region constructor / destructor

        public frmMain()
        {
            InitializeComponent();
            DisplayFilters();           //Display all filters
            Disconnected();             //Set as disconnected
            Program.StartMonitor();     //Start monitoring
        }

        #endregion

        #region base class events

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = !Program.AllowClose;
            ninMain.Visible = !e.Cancel;
            Hide();
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

        private async Task CreateFilter(Track iTrack)
        {
            using (frmCreateFilter pFrmCreateFilter = new frmCreateFilter())
            {
                SpotifyAPI.Local.Models.Track pTrkCurrentlyPlaying = iTrack.CurrentTrack;
                if (!pTrkCurrentlyPlaying.IsAd())
                {
                    pFrmCreateFilter.FilterTrack = pTrkCurrentlyPlaying;
                    if (pFrmCreateFilter.ShowDialog() == DialogResult.OK)
                    {
                        await Config.Current().AddFilter(pFrmCreateFilter.Filter);
                        DisplayFilter(pFrmCreateFilter.Filter);
                        Program.SpotifyMonitor.Skip();
                    }
                }
            }
        }

        private void DisplayFilter(FilterBase iFilter)
        {
            Filter pFilFilter = new Filter();
            pFilFilter._Filter = iFilter;
            pFilFilter.Size = new Size(flpFilters.Width - 32, 64);
            pFilFilter.LikeClicked += PFilFilter_LikeClicked;
            flpFilters.Controls.Add(pFilFilter);
            pFilFilter.Show();
        }

        private void DisplayFilters()
        {
            flpFilters.Controls.Clear();

            foreach (FilterBase curFilter in Config.Current().AllFilters)
            {
                DisplayFilter(curFilter);
            }
        }

        #endregion

        #region object events

        private async void PFilFilter_LikeClicked(object sender, EventArgs e)
        {
            Filter pFilFilter = (Filter)sender;
            await Config.Current().RemoveFilter(pFilFilter._Filter);
            flpFilters.Controls.Remove(pFilFilter);
        }

        private async void trkTrack_FilterClicked(object sender, System.EventArgs e)
        {
            await CreateFilter((Track)sender);
        }

        private void butOK_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void ninMain_DoubleClick_1(object sender, EventArgs e)
        {
            Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.AllowClose = true;
            Close();
        }

        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Show();
        }

        private async void createFilterFromCurrentlyPlayingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            await CreateFilter(trkTrack);
        }

        private void butExit_Click(object sender, EventArgs e)
        {
            Program.AllowClose = true;
            Close();
        }

        #endregion

    }
}
