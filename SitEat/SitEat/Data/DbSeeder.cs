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
                    Name = "Family Place",
                    Description = "Lorem ipsum blah blah blah",
                    ImagePath = ""
                }
                );

            modelBuilder.Entity<Tag>().HasData(
                new Tag { Id = 1, Text = "Greek" },
                new Tag { Id = 2, Text = "Pizzeria" },
                new Tag { Id = 3, Text = "Vegetarian" },
                new Tag { Id = 4, Text = "Chinese" },
                new Tag { Id = 5, Text = "Vietnamese" }
                );

            modelBuilder.Entity<MenuItem>().HasData(
                new MenuItem { RestaurantId = 1, Name = "Item-R1-A", Price = 1.23M },
                new MenuItem { RestaurantId = 1, Name = "Item-R1-B", Price = 1.23M },
                new MenuItem { RestaurantId = 1, Name = "Item-R1-C", Price = 1.23M },
                new MenuItem { RestaurantId = 1, Name = "Item-R1-D", Price = 1.23M },
                new MenuItem { RestaurantId = 1, Name = "Item-R1-E", Price = 1.23M },
                new MenuItem { RestaurantId = 1, Name = "Item-R1-F", Price = 1.23M },
                new MenuItem { RestaurantId = 1, Name = "Item-R1-G", Price = 1.23M },
                new MenuItem { RestaurantId = 1, Name = "Item-R1-H", Price = 1.23M },

                new MenuItem { RestaurantId = 2, Name = "Item-R2-A", Price = 10.23M },
                new MenuItem { RestaurantId = 2, Name = "Item-R2-B", Price = 10.23M },
                new MenuItem { RestaurantId = 2, Name = "Item-R2-C", Price = 10.23M },
                new MenuItem { RestaurantId = 2, Name = "Item-R2-D", Price = 10.23M },
                new MenuItem { RestaurantId = 2, Name = "Item-R2-E", Price = 10.23M },
                new MenuItem { RestaurantId = 2, Name = "Item-R2-F", Price = 10.23M },
                new MenuItem { RestaurantId = 2, Name = "Item-R2-G", Price = 10.23M },
                new MenuItem { RestaurantId = 2, Name = "Item-R2-H", Price = 10.23M },

                new MenuItem { RestaurantId = 3, Name = "Item-R3-A", Price = 100.23M },
                new MenuItem { RestaurantId = 3, Name = "Item-R3-B", Price = 100.23M },
                new MenuItem { RestaurantId = 3, Name = "Item-R3-C", Price = 100.23M },
                new MenuItem { RestaurantId = 3, Name = "Item-R3-D", Price = 100.23M },
                new MenuItem { RestaurantId = 3, Name = "Item-R3-E", Price = 100.23M },
                new MenuItem { RestaurantId = 3, Name = "Item-R3-F", Price = 100.23M },
                new MenuItem { RestaurantId = 3, Name = "Item-R3-G", Price = 100.23M },
                new MenuItem { RestaurantId = 3, Name = "Item-R3-H", Price = 100.23M }
                );

            //modelBuilder.Entity<Review>().HasData(
            //    new Review { RestaurantId = 1, Author = "Arnold", Text = "It sucks!", Score = 1 },
            //    new Review { RestaurantId = 2, Author = "Arnold", Text = "It sucks!", Score = 1 }
            //    );

            //modelBuilder.Entity<Table>().HasData();
            //modelBuilder.Entity<Booking>().HasData();
                
        }
    }
}
