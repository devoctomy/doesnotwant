using Newtonsoft.Json.Linq;
using System;

namespace devoctomy.DoesNotWant.Filters
{

    public class FilterBase
    {

        #region public properties

        public virtual String _Type
        {
            get
            {
                return ("Base");
            }
        }

        public Boolean Enabled { get; set; }

        #endregion

        #region protected methods

        protected JObject BaseToJSON()
        {
            JObject pJOtBase = new JObject();

            pJOtBase.Add("Type", new JValue(_Type));
            pJOtBase.Add("Enabled", new JValue(Enabled));

            return (pJOtBase);
        }

        protected static void LoadBase(JObject iJSON, FilterBase iFilter)
        {
            iFilter.Enabled = iJSON["Enabled"].Value<Boolean>();
        }

        #endregion

        #region public methods

        public virtual JObject ToJSON()
        {
            throw new NotImplementedException();
        }

        public static FilterBase FromJSON(JObject iJSON)
        {
            FilterBase pFBeFilter = null;
            String pStrType = iJSON["Type"].Value<String>();
            switch(pStrType.ToLower())
            {
                case "artist":
                    {
                        pFBeFilter = ArtistFilter.FromJSON(iJSON);
                        break;
                    }
                case "track":
                    {
                        pFBeFilter = TrackFilter.FromJSON(iJSON);
                        break;
                    }
            }
            return (pFBeFilter);
        }

        #endregion

    }

}
