using SpotifyAPI.Local.Models;
using System;

namespace devoctomy.DoesNotWant.Spotify
{

    public class MonitorTrackChangedEventArgs : EventArgs
    {

        #region public properties

        public Track CurrentTrack { get; set; }

        public Boolean Skip { get; set; }

        #endregion

    }

}
