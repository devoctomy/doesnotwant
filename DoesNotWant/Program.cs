using devoctomy.DoesNotWant.IO;
using devoctomy.DoesNotWant.Configuration;
using devoctomy.DoesNotWant.Forms;
using devoctomy.DoesNotWant.Spotify;
using System;
using System.Windows.Forms;

namespace devoctomy.DoesNotWant
{
    static class Program
    {

        #region private delegates

        private delegate void TrackChangedDelegate(MonitorTrackChangedEventArgs iArgs);

        #endregion

        #region public properties

        public static frmMain MainForm { get; private set; }

        public static Monitor SpotifyMonitor { get; private set; }

        public static Boolean AllowClose { get; set; }

        #endregion

        #region public methods

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            String pStrDefaultsConfig = IOUtility.GetAppPath() + "config.json";
            String pStrConfigPath = IOUtility.GetAppDataPath() + "config.json";
            Config.Init(pStrDefaultsConfig, pStrConfigPath);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            MainForm = new frmMain();
            Application.Run(MainForm);
        }

        public static void StartMonitor()
        {
            SpotifyMonitor = Monitor.Current;
            SpotifyMonitor.Connected += SpotifyMonitor_Connected;
            SpotifyMonitor.Disconnected += SpotifyMonitor_Disconnected;
            SpotifyMonitor.TrackChanged += SpotifyMonitor_TrachChanged;
            SpotifyMonitor.MonitiorConnection();
        }

        #endregion

        #region object events

        private static void SpotifyMonitor_TrachChanged(object sender, MonitorTrackChangedEventArgs e)
        {
            TrackChangedDelegate pTCDDelegate = new TrackChangedDelegate(MainForm.TrackChanged);
            MainForm.Invoke(pTCDDelegate, e);
        }

        private static void SpotifyMonitor_Disconnected(object sender, EventArgs e)
        {
            MainForm.Invoke(new MethodInvoker(MainForm.Disconnected));
        }

        private static void SpotifyMonitor_Connected(object sender, EventArgs e)
        {
            MainForm.Invoke(new MethodInvoker(MainForm.Connected));
        }

        #endregion

    }
}
