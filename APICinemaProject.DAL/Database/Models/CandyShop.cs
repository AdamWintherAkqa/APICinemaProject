using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APICinemaProject.DAL.Models
{
    public class CandyShop
    {
        public int CandyID { get; set; } //PK
        public string CandyName { get; set; }
        public int CandyPrice { get; set; }
        public string CandyType { get; set; }
    }
}
