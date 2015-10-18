using devoctomy.DoesNotWant.Drawing;
using devoctomy.DoesNotWant.Extensions;
using Newtonsoft.Json.Linq;
using System;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;

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

        public Bitmap Artwork { get; set; }

        public String ExInfo { get; set; }

        #endregion

        #region constructor / destructor

        private ArtistFilter()
        {

        }

        public ArtistFilter(FilterField iField, 
            String iValue, 
            Bitmap iArtwork, 
            String iExInfo)
        {
            Field = iField;
            Value = iValue;
            Artwork = iArtwork;
            ExInfo = iExInfo;
        }

        #endregion

        #region public methods

        public override async Task<JObject> ToJSON()
        {
            JObject pJOtJSON = BaseToJSON();

            pJOtJSON.Add("Field", new JValue(Field.ToString()));
            pJOtJSON.Add("Value", new JValue(Value));
            pJOtJSON.Add("Artwork", new JValue(await Artwork.ToBase64String()));
            pJOtJSON.Add("ExInfo", new JValue(ExInfo));

            return (pJOtJSON);
        }

        public new static FilterBase FromJSON(JObject iJSON)
        {
            ArtistFilter pAFrFilter = new ArtistFilter();
                        
            FilterBase.LoadBase(iJSON, pAFrFilter);
            pAFrFilter.Value = iJSON["Value"].Value<String>();
            pAFrFilter.Field = (FilterField)Enum.Parse(typeof(FilterField), iJSON["Field"].Value<String>());
            pAFrFilter.Artwork = DrawingUtility.LoadFromBase64String(iJSON["Artwork"].Value<String>());
            pAFrFilter.ExInfo = iJSON["ExInfo"].Value<String>();

            return (pAFrFilter);
        }

        #endregion

    }

}
