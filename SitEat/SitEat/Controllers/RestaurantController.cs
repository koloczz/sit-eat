﻿using Microsoft.AspNetCore.Mvc;
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
        private const int mapSize = 8;
        private readonly SitEatContext _sitEatContext;

        public RestaurantController(SitEatContext sitEatContext)
        {
            _sitEatContext = sitEatContext;
        }

        [HttpPost]
        public IActionResult Details(int id, int filterHour, DateTime filterDate, string postInput, string userName, string userTel)
        {
            // might want to validate data first

            int[] tableIds = postInput.Split().Select(s => int.Parse(s)).ToArray();
            var newBookings = new List<Booking>();

            foreach (var tableId in tableIds)
            {
                var newBooking = new Booking
                {
                    TableId = tableId,
                    Date = filterDate,
                    TimeStart = filterHour,
                    Name = userName,
                    Telephone = userTel
                };
                newBookings.Add(newBooking);
            }

            _sitEatContext.AddRange(newBookings);
            _sitEatContext.SaveChanges();
            return View();
        }

        public IActionResult Details(int id, int? filterHour, DateTime? filterDate, int? filterPeople, bool isInstantReservationChosen = false)
        {
            var restaurantDetails = new RestaurantDetailsViewModel();
            Restaurant currentRestaurant = _sitEatContext.Restaurants
                .Include(r => r.Tags)
                .Include(r => r.MenuItems)
                .Include(r => r.Reviews)
                .Include(r => r.Tables)
                .ThenInclude(t => t.Bookings)
                .SingleOrDefault<Restaurant>(r => r.Id == id);
            restaurantDetails.Id = currentRestaurant.Id;
            restaurantDetails.Name = currentRestaurant.Name;
            restaurantDetails.Description = currentRestaurant.Description;
            restaurantDetails.ImagePath = currentRestaurant.ImagePath;
            restaurantDetails.Rating = currentRestaurant.Reviews.Average(rev => rev.Score);
            restaurantDetails.OpeningTimes = currentRestaurant.OpeningTimes;
            restaurantDetails.MenuItems = currentRestaurant.MenuItems;
            restaurantDetails.Reviews = currentRestaurant.Reviews;
            restaurantDetails.Tags = currentRestaurant.Tags;
            restaurantDetails.TableInfos = new List<TableInfo>();
            for (int x = 0; x < mapSize; x++)
            {
                for (int y = 0; y < mapSize; y++)
                {
                    TableInfo tableInfo = new TableInfo();
                    if (currentRestaurant.Tables.Any(t => t.PositionX == x && t.PositionY == y))
                    {
                        var table = currentRestaurant.Tables.Single(t => t.PositionX == x && t.PositionY == y);
                        tableInfo.IsTable = true;
                        tableInfo.TableId = table.Id;
                        tableInfo.NumberOfSits = table.NumberOfSits;
                        tableInfo.PositionX = x;
                        tableInfo.PositionY = y;
                        var bookings = table.Bookings.ToArray();
                        tableInfo.IsBooked = table.Bookings.Any(b => b.Date == filterDate && b.TimeStart == filterHour);
                        
                    }
                    else
                    {
                        tableInfo.IsTable = false;
                        tableInfo.TableId = 0;
                        tableInfo.NumberOfSits = 0;
                        tableInfo.PositionX = x;
                        tableInfo.PositionY = y;
                        tableInfo.IsBooked = false;
                    }
                    restaurantDetails.TableInfos.Add(tableInfo);
                }
            }
            restaurantDetails.IsInstantReservationChosen = isInstantReservationChosen;
            restaurantDetails.FilterDate = (filterDate ?? DateTime.Today);
            restaurantDetails.FilterHour = (filterHour ?? 12);
            restaurantDetails.FilterPeople = (filterPeople ?? 1);
            return View(restaurantDetails);
        }
    }
}
