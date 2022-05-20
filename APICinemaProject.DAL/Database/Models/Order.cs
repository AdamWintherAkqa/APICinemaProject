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
        public Movie movie { get; set; }
        //public int ProductID { get; set; } //FK
        public Order order { get; set; }
        public int CustomerID { get; set; } //FK
        public Customer customer { get; set; }
        public bool AgeCheck { get; set; }

        public virtual ICollection<Seat> Seats { get; set; }
        public virtual ICollection<CandyShop> CandyShops { get; set; }


    }
}
