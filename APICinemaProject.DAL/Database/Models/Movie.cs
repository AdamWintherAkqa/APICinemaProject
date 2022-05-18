using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APICinemaProject.DAL
{
    public class Movie
    {
        public int MovieID { get; set; } // PK
        public int MoviePlayTime { get; set; }

        public int MovieAgeLimit { get; set; }
    }
}
