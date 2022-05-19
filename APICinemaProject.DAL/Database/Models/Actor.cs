using APICinemaProject.DAL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APICinemaProject.DAL.Database.Models
{
    public class Actor
    {
        [Key]
        public int ActorID { get; set; } //PK
        public string ActorName { get; set; }
        public int MovieID { get; set; } //FK
        public virtual ICollection<Movie> Movies { get; set; }
    }
}
