using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APICinemaProject.DAL.Models
{
    public class Seat
    {
        public int SeatID { get; set; } // PK
        public int HallID { get; set; } // FK
        public int SeatNumber { get; set; }
        public string SeatRowLetter { get; set; } 
    }
}
