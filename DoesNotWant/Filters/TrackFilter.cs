using Newtonsoft.Json.Linq;
using System;

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

        #endregion

        #region construtor / destructor

        private TrackFilter()
        {

        }

        public TrackFilter(String iURI)
        {
            URI = iURI;
        }

        #endregion

        #region public methods

        public override JObject ToJSON()
        {
            JObject pJOtJSON = BaseToJSON();

            pJOtJSON.Add("URI", new JValue(URI));

            return (pJOtJSON);
        }

        public new static FilterBase FromJSON(JObject iJSON)
        {
            TrackFilter pTFrFilter = new TrackFilter();

            FilterBase.LoadBase(iJSON, pTFrFilter);
            pTFrFilter.URI = iJSON["URI"].Value<String>();

            return (pTFrFilter);
        }

        #endregion

    }

}
