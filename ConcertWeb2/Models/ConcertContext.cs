using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
namespace ConcertWeb2.Models
{
    public class ConcertContext: DbContext
    {

        public virtual DbSet<Artist> Artists { get; set; }
        public virtual DbSet<City> Cities { get; set; }
        public virtual DbSet<Concert> Concerts { get; set; }
        public virtual DbSet<Perfomance> Perfomances { get; set; }
        public virtual DbSet<Ticket> Tickets { get; set; }
        public virtual DbSet<Venue> Venues { get; set; }
        public ConcertContext(DbContextOptions<ConcertContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
