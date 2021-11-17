using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SitEat.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SitEat.Data
{
    public static class ProceduralDbSeeder
    {
        private static string[] names = new string[] { "James", "Robert", "John", "Michael", "William", "David", "Richard", "Joseph", "Thomas", "Charles", "Christopher", "Daniel", "Matthew", "Anthony", "Mark", "Donald", "Steven", "Paul", "Andrew", "Joshua", "Kenneth", "Kevin", "Brian", "George", "Edward", "Ronald", "Timothy", "Jason", "Jeffrey", "Ryan", "Jacob", "Gary", "Nicholas", "Eric", "Jonathan", "Stephen", "Larry", "Justin", "Scott", "Brandon", "Benjamin", "Samuel", "Gregory", "Frank", "Alexander", "Raymond", "Patrick", "Jack", "Dennis", "Jerry", "Tyler", "Aaron", "Jose", "Adam", "Henry", "Nathan", "Douglas", "Zachary", "Peter", "Kyle", "Walter", "Ethan", "Jeremy", "Harold", "Keith", "Christian", "Roger", "Noah", "Gerald", "Carl", "Terry", "Sean", "Austin", "Arthur", "Lawrence", "Jesse", "Dylan", "Bryan", "Joe", "Jordan", "Billy", "Bruce", "Albert", "Willie", "Gabriel", "Logan", "Alan", "Juan", "Wayne", "Roy", "Ralph", "Randy", "Eugene", "Vincent", "Russell", "Elijah", "Louis", "Bobby", "Philip", "Johnny", "Mary", "Patricia", "Jennifer", "Linda", "Elizabeth", "Barbara", "Susan", "Jessica", "Sarah", "Karen", "Nancy", "Lisa", "Betty", "Margaret", "Sandra", "Ashley", "Kimberly", "Emily", "Donna", "Michelle", "Dorothy", "Carol", "Amanda", "Melissa", "Deborah", "Stephanie", "Rebecca", "Sharon", "Laura", "Cynthia", "Kathleen", "Amy", "Shirley", "Angela", "Helen", "Anna", "Brenda", "Pamela", "Nicole", "Emma", "Samantha", "Katherine", "Christine", "Debra", "Rachel", "Catherine", "Carolyn", "Janet", "Ruth", "Maria", "Heather", "Diane", "Virginia", "Julie", "Joyce", "Victoria", "Olivia", "Kelly", "Christina", "Lauren", "Joan", "Evelyn", "Judith", "Megan", "Cheryl", "Andrea", "Hannah", "Martha", "Jacqueline", "Frances", "Gloria", "Ann", "Teresa", "Kathryn", "Sara", "Janice", "Jean", "Alice", "Madison", "Doris", "Abigail", "Julia", "Judy", "Grace", "Denise", "Amber", "Marilyn", "Beverly", "Danielle", "Theresa", "Sophia", "Marie", "Diana", "Brittany", "Natalie", "Isabella", "Charlotte", "Rose", "Alexis", "Kayla" };
        public static void Seed(IServiceProvider serviceProvider)
        {
            Random random = new Random();

            using (var context = new SitEatContext(
                serviceProvider.GetRequiredService<DbContextOptions<SitEatContext>>()))
            {
                if (context.Tables.Count() == 0)
                {
                    GenerateTables(context, random);
                }

                if (context.Bookings.Count() == 0)
                {
                    GenerateBookings(context, random);
                }

                if (context.Reviews.Count() == 0)
                {
                    GenerateReviews(context, random);
                }

                if (context.MenuItems.Count() == 0)
                {
                    GenerateMenuItems(context, random);
                }

            }
        }

        private static void GenerateMenuItems(SitEatContext context, Random random)
        {
            
        }

        private static void GenerateReviews(SitEatContext context, Random random)
        {
            
        }

        private static void GenerateBookings(SitEatContext context, Random random)
        {
            var tables = context.Tables;
            var newBookings = new List<Booking>();
            foreach (var table in tables)
            {
                for (int deltaDay = 0; deltaDay < 7; deltaDay++)
                {
                    var day = DateTime.Today.AddDays(deltaDay);
                    bool isWeekend = day.DayOfWeek == DayOfWeek.Saturday || day.DayOfWeek == DayOfWeek.Sunday;
                    int openingHour = isWeekend ? 12 : 7;
                    int closingHour = isWeekend ? 23 : 21;
                    for (int hour = openingHour; hour <= closingHour; hour++)
                    {
                        if (random.NextDouble() < 0.15 - (double)deltaDay*0.01)
                        {
                            var booking = new Booking
                            {
                                TableId = table.Id,
                                Date = day,
                                TimeStart = hour,
                                Name = names[random.Next(names.Length)],
                                Telephone = (1_000_000_000 - random.Next(1, 900_000_000)).ToString()
                            };
                            newBookings.Add(booking);
                        }
                    }
                }
            }
            if (newBookings.Count > 0)
            {
                context.AddRange(newBookings);
                context.SaveChanges();
            }
        }

        private static void GenerateTables(SitEatContext context, Random random)
        {
            var restaurants = context.Restaurants;
            var newTables = new List<Table>();
            foreach (var restaurant in restaurants)
            {
                int rowDensity = random.Next(2, 4);
                int rowShift = random.Next(0, rowDensity - 1);
                int colDensity = random.Next(2, 4);
                int colShift = random.Next(0, colDensity - 1);
                const int restaurantSize = 8;

                for (int x = 0; x < restaurantSize; x++)
                {
                    for (int y = 0; y < restaurantSize; y++)
                    {
                        double probability = 0.0;
                        if (x % colDensity == colShift && y % rowDensity == rowShift)
                        {
                            probability = 0.1;
                        }
                        else
                        {
                            probability = 0.8;
                        }

                        if (random.NextDouble() < probability)
                        {
                            var table = new Table
                            {
                                RestaurantId = restaurant.Id,
                                PositionX = x,
                                PositionY = y,
                                NumberOfSits = random.Next(1, 16)
                            };
                            newTables.Add(table);
                        }
                    }
                }
                
            }
            if (newTables.Count > 0)
            {
                context.AddRange(newTables);
                context.SaveChanges();
            }
        }
    }
}
