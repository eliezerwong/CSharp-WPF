using System;
using System.Collections.Generic;
using System.Text;

namespace Problem2
{
    public class Big12
    {
        //University|Football stadium|Capacity|Logo
        public string University { get; set; }
        public string FootballStadium { get; set; }
        public int Capacity { get; set; }
        public string Logo { get; set; }

        public Big12()
        {
            University = string.Empty;
            FootballStadium = string.Empty;
            Capacity = 0;
            Logo = string.Empty;

        }


    }
}
