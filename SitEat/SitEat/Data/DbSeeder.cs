using Microsoft.EntityFrameworkCore;
using SitEat.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SitEat.Data
{
    public static class DbSeeder
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Restaurant>().HasData(
                new Restaurant
                {
                    Id = 1,
                    Name = "Marco Polo",
                    Description = "Lorem ipsum blah blah blah",
                    ImagePath = ""
                },
                new Restaurant
                {
                    Id = 2,
                    Name = "Restaurant number 2",
                    Description = "Lorem ipsum blah blah blah",
                    ImagePath = ""
                },
                new Restaurant
                {
                    Id = 3,
                    Name = "Marco Polo",
                    Description = "Lorem ipsum blah blah blah",
                    ImagePath = ""
                }
                );
        }
    }
}
