using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APICinemaProject.DAL.Models
{
    public class MovieTime
    {
        [Key]
        public int MovieTimeID { get; set; } //PK
        public int HallID { get; set; } //FK
        public Hall hall { get; set; }
        public int MovieID { get; set; } //FK
        public Movie movie { get; set; }
        public DateTime Time { get; set; } //The time when the movie runs.
    }
}
