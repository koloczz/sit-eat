using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SitEat.Data;
using SitEat.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SitEat.Controllers
{
    public class RestaurantController : Controller
    {
        private readonly SitEatContext _sitEatContext;

        public RestaurantController(SitEatContext sitEatContext)
        {
            _sitEatContext = sitEatContext;
        }
        public IActionResult Index(int id)
        {
            var restaurantDetails = new RestaurantDetailsViewModel();
            Restaurant currentRestaurant = _sitEatContext.Restaurants
                .Include(r => r.Tags)
                .Include(r => r.MenuItems)
                .Include(r => r.Reviews)
                .Include(r => r.Tables)
                .ThenInclude(t => t.Bookings)
                .SingleOrDefault<Restaurant>(r => r.Id == id);
            restaurantDetails.Name = currentRestaurant.Name;
            restaurantDetails.ImagePath = currentRestaurant.ImagePath;
            restaurantDetails.Rating = currentRestaurant.Reviews.Average(rev => rev.Score);
            restaurantDetails.OpeningTimes = currentRestaurant.OpeningTimes;
            restaurantDetails.MenuItems = currentRestaurant.MenuItems;
            restaurantDetails.Reviews = currentRestaurant.Reviews;
            restaurantDetails.Tags = currentRestaurant.Tags;
            restaurantDetails.Tables = currentRestaurant.Tables;

            return View(restaurantDetails);
        }
    }
}
