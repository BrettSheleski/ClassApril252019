using System;
using System.Collections.Generic;
using System.Text;

namespace MarathonApp
{
    public class RaceResult
    {
        public int id { get; set; }
        public int race_id { get; set; }
        public int placement { get; set; }
        public string name { get; set; }

        public string state { get; set; }

        public TimeSpan time { get; set; }

        public string timeString
        {
            get
            {
                return $"{time.Hours} hours {time.Minutes} minutes {time.Seconds} seconds";
            }
        }

    }
}
