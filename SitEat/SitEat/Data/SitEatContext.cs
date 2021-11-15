using Microsoft.EntityFrameworkCore;
using SitEat.Models;

namespace SitEat.Data
{
    public class SitEatContext : DbContext
    {
        public SitEatContext(DbContextOptions<SitEatContext> options)
            : base(options)
        {
        }

        public DbSet<Restaurant> Restaurant { get; set; }

        public DbSet<Table> Table { get; set; }

        public DbSet<Review> Review { get; set; }

        public DbSet<MenuItem> MenuItem { get; set; }

        public DbSet<Booking> Booking { get; set; }
    }
}
