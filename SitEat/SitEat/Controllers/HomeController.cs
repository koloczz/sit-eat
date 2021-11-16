using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using SitEat.Data;
using SitEat.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace SitEat.Controllers
{
    public class HomeController : Controller
    {
        private readonly SitEatContext _sitEatContext;

        public HomeController(SitEatContext sitEatContext)
        {
            _sitEatContext = sitEatContext;
        }

        public IActionResult Index()
        {
            var list = new List<RestaurantTagReviewViewModel>();
            var restaurants = _sitEatContext.Restaurants
                .Include(r => r.Tags)
                .Include(r => r.Reviews)
                .OrderByDescending(x => x.Id)
                .ToList();
            foreach (var restaurant in restaurants)
            {
                var viewModel = new RestaurantTagReviewViewModel();
                viewModel.Id = restaurant.Id;
                viewModel.Name = restaurant.Name;
                viewModel.ImagePath = restaurant.ImagePath;
                viewModel.Rating = (double?)Math.Round((decimal)restaurant.Reviews.Average(rev => rev.Score), 2);
                viewModel.OpeningTimes = restaurant.OpeningTimes;
                viewModel.Tags = new();
                foreach (var tag in restaurant.Tags)
                {
                    viewModel.Tags.Add(tag.Text);
                }
                list.Add(viewModel);
            }
            return View(list);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
