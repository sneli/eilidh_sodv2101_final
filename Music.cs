using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eilidh_finalproject
{
    public class Music
    {
        public int SongID { get; set; }
        public string SongName { get; set; }
        public string Artist { get; set; }
        public string Duration { get; set; }
        public Stream SongFile { get; set; }

        public int GetDurationInSeconds()
        {
            if (TimeSpan.TryParse("00:" + Duration, out TimeSpan timeSpan))
            {
                return (int)timeSpan.TotalSeconds;
            }
            else
            {
                throw new FormatException($"Invalid duration format: {Duration}");
            }
        }
    }
}
