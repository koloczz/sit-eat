using Microsoft.AspNetCore.Mvc;
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


            return View(restaurantDetails);
        }
    }
}
