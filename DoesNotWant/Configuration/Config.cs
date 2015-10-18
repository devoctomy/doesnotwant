using devoctomy.DoesNotWant.Filters;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace devoctomy.DoesNotWant.Configuration
{

    public class Config
    {

        #region private objects

        private static Config cConCurrent;

        #endregion

        #region public properties

        public String FullPath { get; private set; }

        public ConfigOptions Options { get; private set; }

        public List<FilterBase> AllFilters { get; private set; }

        public Dictionary<String, TrackFilter> TrackFilters { get; private set; }

        public Dictionary<String, ArtistFilter> ArtistFilters { get; private set; }

        #endregion

        #region constructor / destructor

        public Config()
        {
            AllFilters = new List<FilterBase>();
            TrackFilters = new Dictionary<String, TrackFilter>();
            ArtistFilters = new Dictionary<String, ArtistFilter>();
        }

        #endregion

        #region private methods

        private static Config Load(String iFullPath)
        {
            String pStrConfig = File.ReadAllText(iFullPath);
            JObject pJOtConfig = JObject.Parse(pStrConfig);
            Config pConConfig = FromJSON(pJOtConfig);
            pConConfig.FullPath = iFullPath;
            return (pConConfig);
        }

        private static Config FromJSON(JObject iJSON)
        {
            Config pConConfig = new Config();

            pConConfig.Options = ConfigOptions.FromJSON(iJSON["Options"].Value<JObject>());

            JObject pJOtFilters = iJSON["Filters"].Value<JObject>();
            if(pJOtFilters != null)
            {
                JArray pJAyArtists = pJOtFilters["Artists"].Value<JArray>();
                foreach(JObject curArtistFilter in pJAyArtists)
                {
                    ArtistFilter pAFrArtistFilter = (ArtistFilter)FilterBase.FromJSON(curArtistFilter);
                    pConConfig.AllFilters.Add(pAFrArtistFilter);
                    pConConfig.ArtistFilters.Add(pAFrArtistFilter.Value, pAFrArtistFilter);
                }

                JArray pJAyTracks = pJOtFilters["Tracks"].Value<JArray>();
                foreach (JObject curTrackFilter in pJAyTracks)
                {
                    TrackFilter pTFrTrackFilter = (TrackFilter)FilterBase.FromJSON(curTrackFilter);
                    pConConfig.AllFilters.Add(pTFrTrackFilter);
                    pConConfig.TrackFilters.Add(pTFrTrackFilter.URI, pTFrTrackFilter);
                }
            }

            return (pConConfig);
        }

        #endregion

        #region public methods

        public static void Init(String iDefaultsFullPath, String iFullPath)
        {
            if(!File.Exists(iFullPath))
            {
                //restore all defaults
                String pStrDefaults = File.ReadAllText(iDefaultsFullPath);
                File.WriteAllText(iFullPath, pStrDefaults);
            }

            Config pConCurrent = Load(iFullPath);
            cConCurrent = pConCurrent;
        }

        public static Config Current()
        {
            if(cConCurrent == null)
            {
                throw new Exception("Config not yet initialised.");
            }
            else
            {
                return (cConCurrent);
            }
        }

        public async Task Save()
        {
            JObject pJOtConfig = new JObject();

            pJOtConfig.Add("Options", Options.ToJSON());

            JObject pJOtFilters = new JObject();
            JArray pJAyArtistsFilters = new JArray();
            foreach (ArtistFilter curFilter in ArtistFilters.Values)
            {
                pJAyArtistsFilters.Add(await curFilter.ToJSON());
            }
            pJOtFilters.Add("Artists", pJAyArtistsFilters);

            JArray pJAyTrackFilters = new JArray();
            foreach (TrackFilter curFilter in TrackFilters.Values)
            {
                pJAyTrackFilters.Add(await curFilter.ToJSON());
            }
            pJOtFilters.Add("Tracks", pJAyTrackFilters);
            pJOtConfig.Add("Filters", pJOtFilters);

            File.WriteAllText(FullPath, pJOtConfig.ToString());
        }

        public async Task AddFilter(FilterBase iFilter)
        {
            AllFilters.Add(iFilter);
            if(iFilter is ArtistFilter)
            {
                ArtistFilter pAFrFilter = (ArtistFilter)iFilter;
                ArtistFilters.Add(pAFrFilter.Value, pAFrFilter);
            }
            else if(iFilter is TrackFilter)
            {
                TrackFilter pTFrFilter = (TrackFilter)iFilter;
                TrackFilters.Add(pTFrFilter.URI, pTFrFilter);
            }
            await Save();
        }

        public async Task RemoveFilter(FilterBase iFilter)
        {
            AllFilters.Remove(iFilter);
            if(iFilter is ArtistFilter)
            {
                ArtistFilters.Remove(iFilter.ToArtistFilter().Value);
            }
            else if(iFilter is TrackFilter)
            {
                TrackFilters.Remove(iFilter.ToTrackFilter().URI);
            }
            await Save();
        }

        public Boolean IsFiltered(SpotifyAPI.Local.Models.Track iTrack)
        {
            if(TrackFilters.ContainsKey(iTrack.TrackResource.Uri))
            {
                return (true);
            }
            else
            {
                if(ArtistFilters.ContainsKey(iTrack.ArtistResource.Uri))
                {
                    return (true);
                }
                else
                {
                    foreach (ArtistFilter curArtistFilter in ArtistFilters.Values)
                    {
                        if(curArtistFilter.Field == ArtistFilter.FilterField.name)
                        {
                            if (iTrack.ArtistResource.Name.IndexOf(curArtistFilter.Value, StringComparison.InvariantCultureIgnoreCase) > -1)
                            {
                                return (true);
                            }
                        }
                    }
                }
            }
            return (false);
        }

        #endregion

    }

}
