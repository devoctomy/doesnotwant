using Newtonsoft.Json.Linq;
using System;

namespace devoctomy.DoesNotWant.Filters
{

    public class ArtistFilter : FilterBase
    {

        #region public enums

        public enum FilterField
        {
            none = 0,
            uri = 1,
            name = 2
        }

        #endregion

        #region public properties

        public override String _Type
        {
            get
            {
                return ("Artist");
            }
        }

        public FilterField Field { get; set; }

        public String Value { get; set; }

        #endregion

        #region constructor / destructor

        private ArtistFilter()
        {

        }

        public ArtistFilter(FilterField iField, String iValue)
        {
            Field = iField;
            Value = iValue;
        }

        #endregion

        #region public methods

        public override JObject ToJSON()
        {
            JObject pJOtJSON = BaseToJSON();

            pJOtJSON.Add("Field", new JValue(Field.ToString()));
            pJOtJSON.Add("Value", new JValue(Value));

            return (pJOtJSON);
        }

        public new static FilterBase FromJSON(JObject iJSON)
        {
            ArtistFilter pAFrFilter = new ArtistFilter();
                        
            FilterBase.LoadBase(iJSON, pAFrFilter);
            pAFrFilter.Value = iJSON["Value"].Value<String>();
            pAFrFilter.Field = (FilterField)Enum.Parse(typeof(FilterField), iJSON["Field"].Value<String>());

            return (pAFrFilter);
        }

        #endregion

    }

}
