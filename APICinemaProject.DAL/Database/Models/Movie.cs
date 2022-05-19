using APICinemaProject.DAL.Database.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APICinemaProject.DAL.Models
{
    public class Movie
    {
        [Key]
        public int MovieID { get; set; } // PK
        public int MoviePlayTime { get; set; }
        public int MovieAgeLimit { get; set; }
        public int InstructorID { get; set; } // FK

        public virtual ICollection<MovieGenre> MovieGenres { get; set; }
        public virtual ICollection<Actor> Actors { get; set; }
    }
}
