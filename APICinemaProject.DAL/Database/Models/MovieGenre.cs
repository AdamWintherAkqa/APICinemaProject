using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APICinemaProject.DAL.Models
{
    public class MovieGenre
    {
        [Key]
        public int GenreID { get; set; }
        public string GenreName { get; set; }

    }
}
