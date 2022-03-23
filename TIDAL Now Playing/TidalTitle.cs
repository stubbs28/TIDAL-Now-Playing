using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace TIDAL_Now_Playing
{
    public class TidalTitle
    {
        public static readonly string SONG = "$track";
        private static readonly string PROCESS = "TIDAL";
        private static readonly string EMPTY = "{empty}";

        public Settings settings { get; set; }

        private string _nowPlaying;
        public string nowPlaying { 
            get 
            {
                return _nowPlaying == "" ? EMPTY : _nowPlaying;
            } 
        }
        public string shortTrack { 
            get
            {
                return _nowPlaying.Length <= settings.textWidth ? nowPlaying : EMPTY;
            } 
        }
        public string longTrack
        {
            get
            {
                return _nowPlaying.Length > settings.textWidth ? nowPlaying : EMPTY;
            }
        }

        public TidalTitle()
        {
            _nowPlaying = "";
            settings = new();
        }

        public bool Update()
        {
            string newTrack = "";
            foreach (Process p in Process.GetProcessesByName(PROCESS))
            {
                try
                {
                    if (p.MainWindowTitle.Length > 0)
                    {
                        string song = p.MainWindowTitle.ToString();
                        if (song != PROCESS)
                        {
                            newTrack = settings.format.Replace(SONG, song);
                            break;
                        }
                    }
                }
                catch { }
            }
            bool updated = _nowPlaying != newTrack;
            _nowPlaying = newTrack;
            return updated;
        }

        public void Load(string path)
        {
            if (File.Exists(path))
            {
                string js = File.ReadAllText(path);
                settings = JsonSerializer.Deserialize<Settings>(js)!;
            }
        }

        public void Save(string path)
        {
            string js = JsonSerializer.Serialize(settings);
            File.WriteAllText(path, js);
        }
    }
}
