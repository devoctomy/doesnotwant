using devoctomy.DoesNotWant.Filters;
using System;
using System.Windows.Forms;

namespace devoctomy.DoesNotWant.Usercontrols
{

    public partial class Filter : UserControl
    {

        #region public events

        public event EventHandler<EventArgs> LikeClicked;

        #endregion

        #region private objects

        private FilterBase cFBeFilter;

        #endregion

        #region public properties

        public FilterBase _Filter
        {
            get
            {
                return (cFBeFilter);
            }
            set
            {
                cFBeFilter = value;
                DisplayFilter();
            }
        }

        #endregion

        #region constructor / destructor

        public Filter()
        {
            InitializeComponent();
        }

        #endregion

        #region base class events

        private void Filter_Resize(object sender, EventArgs e)
        {
            picImage.Width = Height;
        }

        #endregion

        #region private methods

        private void DisplayFilter()
        {
            if (cFBeFilter != null)
            {
                if(_Filter is ArtistFilter)
                {
                    ArtistFilter pAFrFiler = _Filter.ToArtistFilter();
                    lblFilterType.Text = "Artist Filter";
                    picImage.Image = pAFrFiler.Artwork;
                    switch (pAFrFiler.Field)
                    {
                        case ArtistFilter.FilterField.uri:
                            {
                                lblFilterField.Text = "Exact Match";
                                lblFilterValue.Text = pAFrFiler.ExInfo;

                                break;
                            }
                        case ArtistFilter.FilterField.name:
                            {
                                lblFilterField.Text = "Name Match";
                                lblFilterValue.Text = pAFrFiler.Value;

                                break;
                            }
                    }

                }
                else if(_Filter is TrackFilter)
                {
                    TrackFilter pTFrFiler = _Filter.ToTrackFilter();
                    lblFilterType.Text = "Track Filter";
                    picImage.Image = pTFrFiler.Artwork;
                    String[] pStrExInfoParts = pTFrFiler.ExInfo.Split('|');
                    lblFilterField.Text = pStrExInfoParts[0];
                    lblFilterValue.Text = pStrExInfoParts[1];
                }
            }
            else
            {
                picImage.Image = null;
            }
        }

        private void butUnFilter_Click(object sender, EventArgs e)
        {
            if (LikeClicked != null)
            {
                LikeClicked(this, EventArgs.Empty);
            }
        }

        #endregion

    }

}
