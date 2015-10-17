using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace devoctomy.DoesNotWant.Usercontrols
{

    public partial class NotConnected : UserControl
    {

        #region constructor / destructor

        public NotConnected()
        {
            InitializeComponent();
        }

        #endregion

        #region base class events

        private void NotConnected_Resize(object sender, EventArgs e)
        {
            panDisconnected.Location = new Point((ClientRectangle.Width / 2) - (panDisconnected.Width / 2),
                (ClientRectangle.Height / 2) - (panDisconnected.Height / 2));
        }

        #endregion

    }

}
