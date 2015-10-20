using SpotifyAPI.Local;
using SpotifyAPI.Local.Models;
using SpotifyAPI.Web;
using SpotifyAPI.Web.Models;
using System;
using System.Threading;

namespace devoctomy.DoesNotWant.Spotify
{

    public class Monitor
    {

        #region public events

        public event EventHandler<EventArgs> Connected;
        public event EventHandler<EventArgs> Disconnected;
        public event EventHandler<MonitorTrackChangedEventArgs> TrackChanged;

        #endregion

        #region private objects

        private static Monitor cMonCurrent;

        private SpotifyLocalAPI cSLlLocalAPI;
        private Track cTrkCurrentlyPlaying;
        private Thread cTrdConnection;
        private Boolean cBlnConnected;
        private ManualResetEvent cMRERunning;
        private ManualResetEvent cMREStop;
        private ManualResetEvent cMREReady;

        #endregion

        #region public properties

        public static Monitor Current
        {
            get
            {
                if(cMonCurrent == null)
                {
                    cMonCurrent = new Monitor();
                }
                return (cMonCurrent);
            }
        }

        public Track CurrentlyPlaying
        {
            get { return (cTrkCurrentlyPlaying); }
        }

        public Boolean IsConnected
        {
            get { return (cBlnConnected); }
        }

        #endregion

        #region constructor / destructor

        public Monitor()
        {
            cSLlLocalAPI = new SpotifyLocalAPI();
            cSLlLocalAPI.OnPlayStateChange += CSLlLocalAPI_OnPlayStateChange;
            cSLlLocalAPI.OnTrackChange += CSLlLocalAPI_OnTrackChange;
            cMRERunning = new ManualResetEvent(false);
            cMREStop = new ManualResetEvent(false);
            cMREReady = new ManualResetEvent(true);
        }

        #endregion

        #region public methods

        public void MonitiorConnection()
        {
            if (!cMRERunning.WaitOne(100))
            {
                cTrdConnection = new Thread(cTrdConnection_Callback);
                cTrdConnection.Start();
            }
        }

        public void Stop()
        {
            if (cMRERunning.WaitOne(100))
            {
                cMREStop.Set();
                cMREReady.WaitOne();
            }
        }

        public void Skip()
        {
            if(IsConnected)
            {
                cSLlLocalAPI.Skip();
            }
        }

        #endregion

        #region private method

        private Boolean Connect()
        {
            if (!SpotifyLocalAPI.IsSpotifyRunning())
            {
                return(false);
            }
            if (!SpotifyLocalAPI.IsSpotifyWebHelperRunning())
            {
                return(false);
            }

            Boolean pBlnConnected = cSLlLocalAPI.Connect();
            if (pBlnConnected)
            {
                cSLlLocalAPI.ListenForEvents = true;
                return (true);
            }
            else
            {
                return (false);
            }
        }

        #endregion

        #region object events

        private void cTrdConnection_Callback()
        {
            try
            {
                cMREReady.Reset();
                cMRERunning.Set();
                while (!cMREStop.WaitOne(100))
                {
                    if(!cBlnConnected)
                    {
                        cBlnConnected = Connect();
                        if(cBlnConnected)
                        {
                            StatusResponse pSReStatus = cSLlLocalAPI.GetStatus();
                            cTrkCurrentlyPlaying = pSReStatus.Track;
                            if (Connected != null)
                            {
                                Connected(this, EventArgs.Empty);
                            }
                        }
                        Thread.Sleep(1000);
                    }
                    else
                    {
                        StatusResponse pSReStatus = cSLlLocalAPI.GetStatus();
                        cBlnConnected = (pSReStatus != null);
                        if (!cBlnConnected)
                        {
                            if (Disconnected != null)
                            {
                                Disconnected(this, EventArgs.Empty);
                            }
                        }
                        Thread.Sleep(2000);
                    }
                }
            }
            catch(Exception ex)
            {
                //An error occurred
            }
            finally
            {
                cMREStop.Reset();
                cMRERunning.Reset();
                cMREReady.Set();
            }
        }

        private void CSLlLocalAPI_OnTrackChange(TrackChangeEventArgs e)
        {
            cTrkCurrentlyPlaying = e.NewTrack;
            MonitorTrackChangedEventArgs pArgArgs = new MonitorTrackChangedEventArgs()
            {
                CurrentTrack = cTrkCurrentlyPlaying,
                Skip = false
            };
            if(TrackChanged != null)
            {
                TrackChanged(this, pArgArgs);
            }

            if (pArgArgs.Skip)
            {              
                cSLlLocalAPI.Skip();
            }
        }

        private void CSLlLocalAPI_OnPlayStateChange(PlayStateEventArgs e)
        {
            if (e.Playing)
            {
                StatusResponse pSReStatus = cSLlLocalAPI.GetStatus();
                if(pSReStatus!= null)
                {
                    cTrkCurrentlyPlaying = pSReStatus.Track;
                    MonitorTrackChangedEventArgs pArgArgs = new MonitorTrackChangedEventArgs()
                    {
                        CurrentTrack = cTrkCurrentlyPlaying,
                        Skip = false
                    };
                    if (TrackChanged != null)
                    {
                        TrackChanged(this, pArgArgs);
                    }

                    if (pArgArgs.Skip)
                    {
                        cSLlLocalAPI.Skip();
                    }
                }
            }
        }

        #endregion

    }

}
