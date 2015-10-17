using System;
using System.Windows.Forms;

namespace devoctomy.DoesNotWant.Usercontrols
{

    public partial class Filter : UserControl
    {

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

    }

}
