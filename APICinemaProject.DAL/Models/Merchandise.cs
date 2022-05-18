using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APICinemaProject.DAL.Models
{
    public class Merchandise
    {
        public int MerchandiseID { get; set; }
        public string MerchandiseType { get; set; }
        public string MerchandiseName { get; set; }
        public string MerchandiseColor { get; set; }
        public int MerchandisePrice { get; set; }
        public string MerchandiseSize { get; set; }
        
    }
}
