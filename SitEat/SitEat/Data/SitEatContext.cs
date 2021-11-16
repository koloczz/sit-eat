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

        public DbSet<Restaurant> Restaurants { get; set; }

        public DbSet<Table> Tables { get; set; }

        public DbSet<Review> Reviews { get; set; }

        public DbSet<MenuItem> MenuItems { get; set; }

        public DbSet<Booking> Bookings { get; set; }

        public DbSet<Tag> Tags { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Seed();
        }
    }
}
