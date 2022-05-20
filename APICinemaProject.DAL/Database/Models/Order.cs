using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APICinemaProject.DAL.Models
{
    public class Order
    {
        [Key]
        public int OrderID { get; set; } //PK
        public DateTime Date { get; set; }
        public int MovieID { get; set; } //FK
        public int ProductID { get; set; } //FK
        public int CustomerID { get; set; } //FK
        public bool AgeCheck { get; set; }

        public virtual ICollection<Seat> Seats { get; set; }
        public virtual ICollection<CandyShop> CandyShops { get; set; }
    }
}
