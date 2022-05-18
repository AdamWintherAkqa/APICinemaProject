using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APICinemaProject.DAL.Models
{
    public class Order
    {
        public int OrderID { get; set; } //PK
        public DateTime Date { get; set; }
        public int movieid { get; set; } //FK
        public int productid { get; set; } //FK
        public int customerid { get; set; } //FK
        public bool AgeCheck { get; set; }

        public virtual ICollection<Seat> Seats { get; set; }
        public virtual ICollection<CandyShop> CandyShops { get; set; }




    }
}
