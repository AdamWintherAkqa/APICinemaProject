using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APICinemaProject.DAL.Models
{
    class Order
    {
        public int OrderID { get; set; } //PK
        public DateTime Date { get; set; }
        //public int MovieID { get; set; } //FK
        //public int ProductID { get; set; } //FK
        //public int CustomerID { get; set; } //FK
        //public int CinemaID { get; set; } //FK
        public bool AgeCheck { get; set; }



    }
}
