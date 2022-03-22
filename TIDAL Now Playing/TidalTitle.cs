using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;

namespace TIDAL_Now_Playing
{
    public class TidalTitle
    {
        public static readonly string SONG = "$track";
        private static readonly string PROCESS = "TIDAL";
        public string NowPlaying(string format) {
            if (!format.Contains(SONG))
            {
                return format;
            }
            foreach (Process p in Process.GetProcessesByName(PROCESS))
            {
                try
                {
                    if (p.MainWindowTitle.Length > 0)
                    {
                        string song = p.MainWindowTitle.ToString();
                        if (song != PROCESS)
                        {
                            return format.Replace(SONG, song);
                        }
                    }
                }
                catch { }
            }
            return "";
        }
    }
}
