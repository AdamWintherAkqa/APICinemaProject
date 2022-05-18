using APICinemaProject.DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APICinemaProject.DAL.Database
{
    public class AbContext : DbContext
    {
        public AbContext() { }
        public AbContext(DbContextOptions<AbContext> options) : base(options) { }

        //skal udkommenteres hvis repository tests skal virke
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=EGC29749\H2SQLSOMMER;Database=CinemaProject;Trusted_Connection=True;");
        }

        public DbSet<CandyShop> candyShops { get; set; }
        public DbSet<Customer> customers { get; set; }
        public DbSet<Genre> genres { get; set; }
        public DbSet<Hall> halls { get; set; }
        public DbSet<LoyaltyProgram> loyaltyPrograms { get; set; }
        public DbSet<Merchandise> merchandises { get; set; }
        public DbSet<Movie> movies { get; set; }
        public DbSet<MovieGenre> movieGenres { get; set; }
        public DbSet<Order> orders { get; set; }
        public DbSet<Seat> seats { get; set; }
    }
}
