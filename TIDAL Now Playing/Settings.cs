using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TIDAL_Now_Playing
{
    [Serializable]
    public class Settings
    {
        public static readonly decimal DEFAULT_TRACK_WIDTH = 25;
        public string format { get; set; }
        public decimal textWidth { get; set; }
        public Settings()
        {
            format = TidalTitle.SONG;
            textWidth = DEFAULT_TRACK_WIDTH;
        }
    }
}
