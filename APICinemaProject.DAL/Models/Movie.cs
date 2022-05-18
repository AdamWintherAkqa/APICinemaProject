using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APICinemaProject.DAL
{
    class Movie
    {
        public int MovieID { get; set; } // PK
        //public int CinemaID { get; set; } // FK
        public int MoviePlayTime { get; set; }

        public int MovieAgeLimit { get; set; }
    }
}
