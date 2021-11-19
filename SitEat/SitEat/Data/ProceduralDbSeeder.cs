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
        private static string[] reviewsPositive = new string[] { "This cozy restaurant has left the best impressions!", "Hospitable hosts, delicious dishes, beautiful presentation, wide wine list and wonderful dessert. I recommend to everyone!", "I would like to come back here again and again.", "First time in this restaurant and you have to go! It’s the cutest little spot with amazing food.", "The service we received was so amazing and we will definitely be back again. They made us feel welcomed and gave us an amazing experience.", "It’s a great experience.", "The ambiance is very welcoming and charming.", "Amazing food and service.", "This place is great! Atmosphere is chill and cool but the staff is also really friendly. They know what they’re doing and what they’re talking about, and you can tell making the customers happy is their main priority.", "Food is pretty good, and for their prices it’s 100% worth it.", "Do yourself a favor and visit this lovely restaurant.", "The service is unmatched. The staff truly cares about your experience. The food is absolutely amazing.", "Absolutely the best meal we had in a while. Highly recommend!", "This place never disappoints.", "From the starter to the dessert the quality and taste of everything was outstanding.", "It might have been the best meal I have ever been served.", "Service was delightful and very professional.", "I have to say, I enjoyed every single bite of the meal there.", "Considering the quality, the price is reasonable.", "Ideal for those who want a romantic night out.", "There is plenty of food.", "Excellent food. Menu is extensive and seasonal to a particularly high standard.", "Definitely fine dining. It can be expensive but worth it and they do different deals on different nights so it’s worth checking them out before you book. Highly recommended.", "The food is always fantastic and no matter what I order I am always delighted with my meal!", "Can’t wait to return and wouldn’t hesitate to recommend to anyone looking for a good meal.", "We are so fortunate to have this place just a few minutes drive away from home. Food is stunning, wine great and lovely selection of beers. Love this place and will continue to visit.", "Great service, food, and overall experience!", "Definitely a go-to place! Huge variety of delicious food.", "This spot gives extraordinary service and yummy meals. One of my favourite restaurants around town.", "The meals served rapidly and the rates were reasonable. Highly recommended.", "Delicious food, waiters are very attentive, and super nice atmosphere. Plus it’s all at an affordable price.", "Can totally recommend it and will definitely come back again.", "Amazing experience!", "You should skip several meals before visiting this amazing restaurant.", "Everything is so tasty, you cannot restraint yourself from having all of the dishes.", "Excellent, unassuming and wonderful.", "Great variety and fine value tasting menu. Exciting food with high quality presentation, service and inventiveness.", "Book to avoid disappointment it’s really worth it.", "Phenomenal experience. Top notch food, atmosphere, and wait staff. Have been here multiple times, and every time is an amazing experience all around.", "Loved this place. The atmosphere, food and most of the drinks were great.", "Great place to hangout, chill or go out on a date.", "Stopped in for dinner and had a great meal.", "Outstanding meal here. Can’t wait to come back!", "Amazing food! The whole experience from start to finish is great. The food can’t get better and the prices are fair for the portion size.", "Legitimately the best restaurant around.", "The food is exceptional! Very tasty and well prepared and you can chose among many menu options. I highly recommend this place.", "My partner and I visited and were amazed at not only the quality of food, but also the service. This is easily one of, if not the best meal we’ve ever eaten. I cannot recommend this place enough!", "Delicious high quality plates, selection of wines and great service.", "Everything was de-li-cious. Highly recommended.", "Absolutely amazing place to eat.", "I am definitely going back.", "The menu options are an excellent value. The dining experience overall is very pleasant. I highly recommend this restaurant.", "Everything about this restaurant was great. The place was clean and smelled good. The staff and greeter was very nice.", "The place is beautiful and staff are super friendly and the food is delicious. I am definitely going back." };
        private static string[] reviewsNegative = new string[] { "This awful place has left the worst impressions!", "Bland dishes, ugly presentation and expensive drinks. Go there only if forced.", "I wouldn't like to come back here again.", "My first and last time in this restaurant. It’s the worst place with yucky food.", "The service we received was worthless and we will definitely never be back again. They made us feel like trash.", "It’s a sub-par experience.", "The atmosphere could be much better.", "I wouldn't go there if I was starving.", "This place is overrated! Staff is bored and rude. Making fun of customers is their main priority.", "Food is decent, I guess.", "Do yourself a favor and never visit this restaurant.", "The service is disappointing.", "The staff truly hates you. The food is tolerable at best.", "This place always disappoints.", "Everything tasted like soap.", "It might have been the worst meal I have ever been served.", "They were trying to poison us.", "I have to say, I regret eating there. They should be closed.", "Considering the quality, the price is outrageous.", "Ideal for those who want to die early.", "There is plenty of room for improvement.", "Bad food. Menu is extensive and written in a very small font.", "Run for your life.", "The food is tolerable and no matter what I order I never get sick.", "Couldn't wait to write this review. It's a nasty restaurant full of nasty people and nasty food. Avoid.", "We are so sad to have this place in our neighbourhood. Food is unimpressive and staff is unprofessional. Will never go there again.", "Bad service, food, and overall experience!", "Definitely a no-go place. Huge variety of bland food.", "This spot has no good meals. One of my least favourite restaurants.", "The staff takes ages and the rates were scandalous. Very disappointed.", "Overcooked food, and dirty toilets. All this and more for only half of your wage.", "Can totally understand why it exists but it's not for everyone.", "The worst experience!", "You should write down your will before visiting this restaurant.", "Everything is so expensive, you have to wonder what they do with all the money.", "My dog hates this place.", "Little variety and little style. Go there only when starving.", "Book if you love being disappointed.", "A difficult experience. Good food but the staff is extremally incompetent.", "Hated this place. It didn't have pancakes.", "Great place to send your enemies to.", "Tried eating there once and choked on that gray thing they gave me.", "Spent a week in hospital after eating there. Might be unrelated.", "Don't go there! Don't go there if hungry, don't go there if starving.", "Legitimately the worst restaurant around.", "The food is decent. I don't recommend this place because of all the hair.", "My aunt and I visited this place and we were disappointed with the food. She had some kind of fish, a greenish-gray one, with one of its fins bent in a weird way.", "Dark and dirty place with little to offer.", "Everything was ok. Still wouldn't go there again because it smelled bad.", "Absolutely the worst place to eat.", "I am definitely not going back.", "The menu options are limited. The food can be eaten.", "Something about this restaurant was off. The place was alright, don't get me wrong, but something was off.", "If I had to choose between this restaurant and not eating at all, I would die of hunger." };
        private static string[] menuItemNames = new string[] { "Shephard’s Pie", "Pot Pie", "Meatloaf", "Pork chops", "Pan baked bell pepper, sausage, and potato", "Fish", "Kabobs", "Meatballs with rice or noodles", "Sloppy Joes", "Hot dogs or brats", "Burger", "Steak and sides", "Baked ham", "Grilled chicken breasts", "Roasted whole chicken or turkey", "Ribs and sides", "Pork Loin and sides", "Grilled or boiled shrimp and sides", "Chicken and rice casserole", "Scrumptious Mexican Food", "Tacos", "Tostadas", "Fajitas", "Nachos", "Enchiladas", "Burritos", "Taquitos", "Taco soup", "Stuffed peppers", "Black bean and rice bowls", "Quesadillas", "Manicotti", "Spaghetti and meatballs", "Lasagna", "Baked ravioli", "Tortellini", "Homemade mac and cheese", "Lasagna rolls", "Homemade pizza", "Chicken parmesan", "Beef stroganoff", "Garlicky shrimp zucchini pasta", "Chicken fettuccini alfredo", "Tuna casserole", "Butternut squash soup", "Chicken noodle soup", "Tomato soup", "Potato soup", "Taco soup", "Carrot soup", "Sweet potato soup", "White chicken chili", "Chili", "Minestrone soup", "Corn chowder", "Stew", "Chicken tortilla soup", "Brocolli cheddar soup", "Chicken potato soup", "Cobb salad", "Panini (on whole wheat bread)", "BBQ chicken salad", "Taco salad", "Grilled cheese sandwiches", "Meatball subs", "Spinach strawberry salad", "French dip sandwich", "Philly Sandwich", "Chicken salad sandwich", "Greek gyros", "Egg salad sandwich", "Wrap with an angry shrimp", "Chili", "Honey sesame chicken", "Pulled pork", "Beef and broccoli", "Pot roast", "Chicken tortilla soup", "Salsa chicken", "Fajitas", "Whole chicken in the crockpot", "Chicken potato soup", "Pork chops", "Taco soup/chili without the meat", "Spaghetti (with zucchini noodles)", "Asian fried rice", "Quesadillas", "Homemade pizza", "Soup and salad", "Rainbow stew", "Vegetarian lasagna", "Bean and veggie burritos", "Omelette", "Pesto noodles", "Crab cakes", "Rice and beans", "Loaded baked or sweet potatoes", "Family Dinner Ideas to Use Up What You Have", "Loaded baked or sweet potatoes", "Skillet hash or stirfry", "Snacky Dinner", "Breakfast for dinner (eggs, french toast, pancakes, sausage, quiche)", "Grilled/baked foil packets", "Homemade chicken nuggets", "Roasted veggies", "Mashed potatoes", "Baked potatoes or sweet potatoes", "Sautéed spinach", "Steamed broccoli", "Glazed carrots", "Sautéed green beans", "Zucchini or squash noodles", "Salad", "Baked brussel sprouts", "Sautéed apples or pears", "Fruit cobbler", "Fruit crisp", "Brownies", "Pudding", "Cake or cheesecake", "Cookies", "Fruit pizza", "Fruit dipped in chocolate", "Ice cream (or banana ice cream)", "Dole whip (pineapple and coconut milk)", "Pie", "Popsicles", "Chocolate fondue", "Coca Cola", "Fanta", "Sprite", "Nestea", "Mineral Water", "Espresso", "Cappuccino", "Latte Macchiato", "Black Coffee", "Hot Chocolate", "Iced Coffee", "Tonic Kinley", "Bitter Lemon", "Ginger Ale", "Cappy Apple", "Cappy Orange", "Cappy Lemon", "Red Bull", "Tea", "Tea With Milk", "Tea With Lemon", "Pilsner Urquell", "Krombacher", "Ballantines", "Chivas Regal", "Johnnie Walker", "Jack Daniels", "Hennessy", "Campari Bitter", "Cinzano Bianco", "Dubonnet", "Martini Extra Dry", "Jameson", "Tullamore dew", "Jim Beam" };
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

                Restaurant firstRestaurant = context.Restaurants.Include(r => r.Tags).First();
                if (firstRestaurant.Tags.Count == 0)
                {
                    GenerateTagsForRestaurants(context, random);
                }

            }
        }

        private static void GenerateTagsForRestaurants(SitEatContext context, Random random)
        {
            var restaurants = context.Restaurants.Include(r => r.Tags);
            var tags = context.Tags.ToList();
            foreach (var restaurant in restaurants)
            {
                foreach (var tag in tags)
                {
                    if (random.NextDouble() < 0.3)
                    {
                        restaurant.Tags.Add(tag);
                    }
                }
                // make sure that if no tags are chosen, a random one is added
                if (restaurant.Tags.Count == 0)
                {
                    restaurant.Tags.Add(tags[random.Next(tags.Count)]);
                }
            }
            context.Restaurants.UpdateRange(restaurants);
            context.SaveChanges();
        }

        private static void GenerateMenuItems(SitEatContext context, Random random)
        {
            var restaurants = context.Restaurants;
            var newMenuItems = new List<MenuItem>();
            foreach (var restaurant in restaurants)
            {
                int skipDistance = random.Next(2, 8);
                int itemCount = random.Next(6, 20);
                for (int item = 0; item < itemCount; item++)
                {
                    var menuItem = new MenuItem
                    {
                        RestaurantId = restaurant.Id,
                        Name = menuItemNames[(restaurant.Id * 40 + item * skipDistance) % menuItemNames.Length],
                        Price = (decimal)random.Next(5, 290) * 0.1m + (random.NextDouble() < 0.4 ? 0.09m : 0m)
                    };
                    newMenuItems.Add(menuItem);
                }
            }
            if (newMenuItems.Count > 0)
            {
                context.AddRange(newMenuItems);
                context.SaveChanges();
            }
        }

        private static void GenerateReviews(SitEatContext context, Random random)
        {
            var restaurants = context.Restaurants;
            var newReviews = new List<Review>();
            foreach (var restaurant in restaurants)
            {
                double positiveReviewProbability = random.NextDouble() * 0.6 + 0.3;
                int reviewCount = random.Next(4, 12);
                int skipDistance = random.Next(2, 5);
                for (int i = 0; i < reviewCount; i++)
                {
                    var review = new Review();
                    review.RestaurantId = restaurant.Id;
                    review.Author = names[random.Next(names.Length)];
                    if (random.NextDouble() < positiveReviewProbability)
                    {
                        review.Score = random.Next(4, 6);
                        review.Text = reviewsPositive[(restaurant.Id * 40 + i * skipDistance) % reviewsPositive.Length];
                    }
                    else
                    {
                        review.Score = random.Next(1, 4);
                        review.Text = reviewsNegative[(restaurant.Id * 40 + i * skipDistance) % reviewsNegative.Length];
                    }
                    newReviews.Add(review);
                }
            }
            if (newReviews.Count > 0)
            {
                context.AddRange(newReviews);
                context.SaveChanges();
            }
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
                        if (random.NextDouble() < 0.15 - (double)deltaDay * 0.01)
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
