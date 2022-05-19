using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APICinemaProject.DAL.Models
{
    public class Hall
    {
        [Key]
        public int HallID { get; set; } //Pk
        public int MovieID { get; set; } //FK
        public int AmountOfSeats { get; set; }
    }
}
