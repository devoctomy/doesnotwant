using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace devoctomy.DoesNotWant.Drawing
{

    public static class DrawingUtility
    {

        #region public methods

        public static Bitmap LoadFromBase64String(String iBase64String)
        {
            using (MemoryStream pMSmInput = new MemoryStream(Convert.FromBase64String(iBase64String)))
            {
                Bitmap pBmpBitmap = (Bitmap)Bitmap.FromStream(pMSmInput);
                return (pBmpBitmap);
            }
        }

        #endregion

    }

}
