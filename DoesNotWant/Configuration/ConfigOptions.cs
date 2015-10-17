using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace devoctomy.DoesNotWant.Configuration
{

    public class ConfigOptions
    {

        #region public properties

        public Boolean Enabled { get; set; }

        #endregion

        #region public methods

        public static ConfigOptions FromJSON(JObject iJSON)
        {
            ConfigOptions pCOsOptions = new ConfigOptions();

            pCOsOptions.Enabled = iJSON["Enabled"].Value<Boolean>();

            return (pCOsOptions);
        }

        public JObject ToJSON()
        {
            JObject pJOtJSON = new JObject();

            pJOtJSON.Add("Enabled", new JValue(Enabled));

            return (pJOtJSON);
        }

        #endregion

    }

}
