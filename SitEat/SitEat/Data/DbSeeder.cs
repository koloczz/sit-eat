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
                new MenuItem { Id = 1, RestaurantId = 1, Name = "Item-R1-A", Price = 1.23M },
                new MenuItem { Id = 2,  RestaurantId = 1, Name = "Item-R1-B", Price = 1.23M },
                new MenuItem { Id = 3,  RestaurantId = 1, Name = "Item-R1-C", Price = 1.23M },
                new MenuItem { Id = 4,  RestaurantId = 1, Name = "Item-R1-D", Price = 1.23M },
                new MenuItem { Id = 5,  RestaurantId = 1, Name = "Item-R1-E", Price = 1.23M },
                new MenuItem { Id = 6,  RestaurantId = 1, Name = "Item-R1-F", Price = 1.23M },
                new MenuItem { Id = 7,  RestaurantId = 1, Name = "Item-R1-G", Price = 1.23M },
                new MenuItem { Id = 8, RestaurantId = 1, Name = "Item-R1-H", Price = 1.23M },

                new MenuItem {  Id = 9, RestaurantId = 2, Name = "Item-R2-A", Price = 10.23M },
                new MenuItem {  Id = 10, RestaurantId = 2, Name = "Item-R2-B", Price = 10.23M },
                new MenuItem {  Id = 11, RestaurantId = 2, Name = "Item-R2-C", Price = 10.23M },
                new MenuItem {  Id = 12, RestaurantId = 2, Name = "Item-R2-D", Price = 10.23M },
                new MenuItem {  Id = 13, RestaurantId = 2, Name = "Item-R2-E", Price = 10.23M },
                new MenuItem {  Id = 14, RestaurantId = 2, Name = "Item-R2-F", Price = 10.23M },
                new MenuItem {  Id = 15, RestaurantId = 2, Name = "Item-R2-G", Price = 10.23M },
                new MenuItem { Id = 16, RestaurantId = 2, Name = "Item-R2-H", Price = 10.23M },

                new MenuItem {  Id = 17, RestaurantId = 3, Name = "Item-R3-A", Price = 100.23M },
                new MenuItem {  Id = 18, RestaurantId = 3, Name = "Item-R3-B", Price = 100.23M },
                new MenuItem {  Id = 19, RestaurantId = 3, Name = "Item-R3-C", Price = 100.23M },
                new MenuItem {  Id = 20, RestaurantId = 3, Name = "Item-R3-D", Price = 100.23M },
                new MenuItem {  Id = 21, RestaurantId = 3, Name = "Item-R3-E", Price = 100.23M },
                new MenuItem {  Id = 22, RestaurantId = 3, Name = "Item-R3-F", Price = 100.23M },
                new MenuItem {  Id = 23, RestaurantId = 3, Name = "Item-R3-G", Price = 100.23M },
                new MenuItem { Id = 24, RestaurantId = 3, Name = "Item-R3-H", Price = 100.23M }
                );

            modelBuilder.Entity<Review>().HasData(
                new Review { Id = 1, RestaurantId = 1, Author = "Arnold", Text = "It sucks!", Score = 1 },
                new Review { Id = 2, RestaurantId = 1, Author = "Bernard", Text = "Great place, would certainly eat at again.", Score = 5 },
                new Review { Id = 3, RestaurantId = 1, Author = "Ciril", Text = "If only they had more variety. The quality is decent but I got bored of their food already.", Score = 3 },
                new Review { Id = 4, RestaurantId = 1, Author = "Dionisius", Text = "Meh.", Score = 2 },
                new Review { Id = 5, RestaurantId = 1, Author = "Ergon", Text = "I love this place! <3", Score = 5 },
                new Review { Id = 6, RestaurantId = 1, Author = "Fred", Text = "Decent food. Pretty cheap too.", Score = 4 },

                new Review { Id = 7, RestaurantId = 2, Author = "Gregory", Text = "Just wonderful!", Score = 5 },
                new Review { Id = 8, RestaurantId = 2, Author = "Helga", Text = "I'm not saying that this place sells s***, but I wouldn't eat it again.", Score = 1 },
                new Review { Id = 9, RestaurantId = 2, Author = "Ian", Text = "Not great, not terrible", Score = 3 },
                new Review { Id = 10, RestaurantId = 2, Author = "Jeremy", Text = "Truly amazing place, never ate such good food", Score = 5 },
                new Review { Id = 11, RestaurantId = 2, Author = "Karol", Text = "I enjoyed every bit of it!", Score = 5 }

                
                );

            //modelBuilder.Entity<Table>().HasData(                );
            //modelBuilder.Entity<Booking>().HasData();

        }
    }
}
