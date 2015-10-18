using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Threading.Tasks;

namespace devoctomy.DoesNotWant.Extensions
{

    public static class BitmapExtensions
    {

        #region private methods

        private static ImageCodecInfo GetEncoder(ImageFormat iFormat)
        {
            ImageCodecInfo[] pICICodecs = ImageCodecInfo.GetImageDecoders();
            foreach (ImageCodecInfo curCodec in pICICodecs)
            {
                if (curCodec.FormatID == iFormat.Guid)
                {
                    return(curCodec);
                }
            }
            return null;
        }

        #endregion

        #region public methods

        public async static Task<String> ToBase64String(this Bitmap iBitmap)
        {
            using (MemoryStream pMSmOutput = new MemoryStream())
            {
                using (EncoderParameters pEPsParams = new EncoderParameters(1))
                {
                    EncoderParameter pEPrParam = new EncoderParameter(Encoder.Quality, 100L);
                    pEPsParams.Param[0] = pEPrParam;
                    using (Bitmap pBmpCopy = new Bitmap(iBitmap))
                    {
                        pBmpCopy.Save(pMSmOutput, GetEncoder(ImageFormat.Jpeg), pEPsParams);
                    }
                    await pMSmOutput.FlushAsync();

                    String pStrBase64 = Convert.ToBase64String(pMSmOutput.ToArray());
                    return (pStrBase64);
                }
            }
        }

        #endregion

    }

}
