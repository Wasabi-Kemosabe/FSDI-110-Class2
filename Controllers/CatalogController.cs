using System;
using System.Collections.Generic;
using CarRental.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace CarRental.Controllers
{
    public class CatalogController : Controller
    {
        private DataContext db { get; set; }
        public CatalogController(DataContext context)
        {
            this.db = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpGet]
        // Endpoint to get the list of cars to show on catalog page
        public IActionResult GetCatalog()
        {
            List<Car> cars = db.Cars.ToList();
            return Json(cars);
        }

        [HttpPost]
        public IActionResult SaveCar([FromBody] Car carToRegister)
        {
            db.Cars.Add(carToRegister); // Add car (on memory only)
            db.SaveChanges(); // Submit changes to DB
            return Json(carToRegister);
        }
    }
}