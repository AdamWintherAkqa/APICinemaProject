using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APICinemaProject.DAL.Models
{
    public class LoyaltyProgram
    {
        public int LoyaltyID { get; set; } // PK
        public int OrderID { get; set; }
        public int CustomerID { get; set; }
    }
}
