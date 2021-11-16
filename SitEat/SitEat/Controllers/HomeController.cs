using Microsoft.AspNetCore.Mvc;
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
            var restaurants = _sitEatContext.Restaurant.OrderByDescending(x => x.Id).ToList();
            foreach (var restaurant in restaurants)
            {
                var viewModel = new RestaurantTagReviewViewModel();
                viewModel.Name = restaurant.Name;
                viewModel.ImagePath = restaurant.ImagePath;
                viewModel.OpeningTimes = restaurant.OpeningTimes;
                //foreach (var tag in restaurant.Tags)
                //{
                //    viewModel.Tags.Add(tag.Text);
                //}
                //viewModel.Score = _sitEatContext.Review.Where(x => x.RestaurantId == restaurant.Id).FirstOrDefault().Score;
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
