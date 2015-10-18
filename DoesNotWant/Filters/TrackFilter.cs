using devoctomy.DoesNotWant.Drawing;
using devoctomy.DoesNotWant.Extensions;
using Newtonsoft.Json.Linq;
using System;
using System.Drawing;
using System.Threading.Tasks;

namespace devoctomy.DoesNotWant.Filters
{

    public class TrackFilter : FilterBase
    {

        #region public properties

        public override String _Type
        {
            get
            {
                return ("Track");
            }
        }

        public String URI { get; set; }

        public Bitmap Artwork { get; set; }

        public String ExInfo { get; set; }

        #endregion

        #region construtor / destructor

        private TrackFilter()
        {

        }

        public TrackFilter(String iURI, 
            Bitmap iArtwork,
            String iExInfo)
        {
            URI = iURI;
            Artwork = iArtwork;
            ExInfo = iExInfo;
        }

        #endregion

        #region public methods

        public override async Task<JObject> ToJSON()
        {
            JObject pJOtJSON = BaseToJSON();

            pJOtJSON.Add("URI", new JValue(URI));
            pJOtJSON.Add("Artwork", new JValue(await Artwork.ToBase64String()));
            pJOtJSON.Add("ExInfo", new JValue(ExInfo));

            return (pJOtJSON);
        }

        public new static FilterBase FromJSON(JObject iJSON)
        {
            TrackFilter pTFrFilter = new TrackFilter();

            FilterBase.LoadBase(iJSON, pTFrFilter);
            pTFrFilter.URI = iJSON["URI"].Value<String>();
            pTFrFilter.Artwork = DrawingUtility.LoadFromBase64String(iJSON["Artwork"].Value<String>());
            pTFrFilter.ExInfo = iJSON["ExInfo"].Value<String>();

            return (pTFrFilter);
        }

        #endregion

    }

}
