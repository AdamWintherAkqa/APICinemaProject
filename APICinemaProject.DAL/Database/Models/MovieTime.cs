using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APICinemaProject.DAL.Models
{
    public class MovieTime
    {
        public int MovieTimeID { get; set; } //PK
        public int HallID { get; set; } //FK
        public int MovieID { get; set; } //FK
        public DateTime Time { get; set; } //The time when the movie runs.
    }
}
