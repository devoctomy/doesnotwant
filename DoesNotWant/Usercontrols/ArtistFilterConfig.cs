using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using devoctomy.DoesNotWant.Filters;

namespace devoctomy.DoesNotWant.Usercontrols
{

    public partial class ArtistFilterConfig : UserControl
    {

        #region public methods

        public event EventHandler<EventArgs> InvalidInput;
        public event EventHandler<EventArgs> ValidInput;

        #endregion

        #region private objects

        private SpotifyAPI.Local.Models.Track cFTkFilterTrack;
        private Boolean cBlnIsValidInput;

        #endregion

        #region public properties

        public SpotifyAPI.Local.Models.Track FilterTrack
        {
            get
            {
                return (cFTkFilterTrack);
            }
            set
            {
                cFTkFilterTrack = value;
                Default();
            }
        }

        public Boolean IsValidInput
        {
            get { return (cBlnIsValidInput); }
        }

        public ArtistFilter.FilterField Field
        {
            get
            {
                if(rbnArtistURI.Checked)
                {
                    return (ArtistFilter.FilterField.uri);
                }
                else
                {
                    return (ArtistFilter.FilterField.name);
                }
            }
        }

        public String Value
        {
            get
            {
                if (rbnArtistURI.Checked)
                {
                    return (FilterTrack.ArtistResource.Uri);
                }
                else
                {
                    return (txtArtistName.Text);
                }
            }
        }

        #endregion

        #region constructor / destructor

        public ArtistFilterConfig()
        {
            InitializeComponent();
        }

        #endregion

        #region private methods

        private void Default()
        {
            txtArtistName.Text = FilterTrack.ArtistResource.Name;
            rbnArtistName.Checked = true;
            CheckInput();
        }

        private void CheckInput()
        {
            cBlnIsValidInput = false;
            if(rbnArtistURI.Checked)
            {
                cBlnIsValidInput = true;
            }
            else if(rbnArtistName.Checked)
            {
                cBlnIsValidInput = !String.IsNullOrEmpty(txtArtistName.Text);
            }
            if (cBlnIsValidInput)
            {
                if(InvalidInput != null)
                {
                    InvalidInput(this, EventArgs.Empty);
                }
            }
            else
            {
                if (ValidInput != null)
                {
                    ValidInput(this, EventArgs.Empty);
                }
            }
        }

        #endregion

    }

}
