﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APICinemaProject.DAL.Models
{
    class Hall
    { 
        public int HallID { get; set; } //Pk
        public int MovieID { get; set; } //FK
        public int CinemaID { get; set; } //FK
        public int AmountOfSeats { get; set; }
    }
}
