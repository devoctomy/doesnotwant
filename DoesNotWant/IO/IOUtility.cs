using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace devoctomy.DoesNotWant.IO
{

    public static class IOUtility
    {

        #region public methods

        public static String GetAppPath()
        {
            String pStrCodeBase = Assembly.GetExecutingAssembly().CodeBase;
            UriBuilder uri = new UriBuilder(pStrCodeBase);
            String pStrPath = Uri.UnescapeDataString(uri.Path);
            pStrPath = Path.GetDirectoryName(pStrPath);
            if (!pStrPath.EndsWith("\\")) pStrPath += "\\";
            return (pStrPath);
        }

        public static String GetAppDataPath()
        {
            String pStrPath = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData);
            if (!pStrPath.EndsWith("\\"))
                pStrPath += "\\";
            pStrPath = String.Format("{0}devoctomy\\DouchebagFilter\\", pStrPath);
            if (!Directory.Exists(pStrPath))
                Directory.CreateDirectory(pStrPath);
            return (pStrPath);
        }

        #endregion

    }

}
