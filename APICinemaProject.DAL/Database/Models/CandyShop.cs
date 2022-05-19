using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using APICinemaProject;

namespace APICinemaProject.DAL.Models
{
    public class CandyShop
    {
        [Key]
        public int CandyID { get; set; } //PK
        public string CandyName { get; set; }
        public int CandyPrice { get; set; }
        public string CandyType { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}
