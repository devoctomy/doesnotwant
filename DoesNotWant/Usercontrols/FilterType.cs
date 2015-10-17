using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace devoctomy.DoesNotWant.Usercontrols
{
    public partial class FilterType : UserControl
    {

        #region public events

        public event EventHandler<EventArgs> TrackClicked;
        public event EventHandler<EventArgs> ArtistClicked;

        #endregion

        #region constructor / destructor

        public FilterType()
        {
            InitializeComponent();
        }

        #endregion

        #region object events

        private void butTrack_Click(object sender, EventArgs e)
        {
            if(TrackClicked != null)
            {
                TrackClicked(this, EventArgs.Empty);
            }
        }

        private void butArtist_Click(object sender, EventArgs e)
        {
            if (ArtistClicked != null)
            {
                ArtistClicked(this, EventArgs.Empty);
            }
        }

        #endregion

    }
}
