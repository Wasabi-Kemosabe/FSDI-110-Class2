using System;
using System.Collections.Generic;
using CarRental.Models;
using Microsoft.AspNetCore.Mvc;

namespace CarRental.Controllers
{
    public class CatalogController : Controller
    {
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
            List<Car> cars = new List<Car>();

            Car c1 = new Car();
            c1.Color = "Red";
            c1.Cylinders = 6;
            c1.DailyPrice = 60;
            c1.Description = "The Toyota Supra is a sports car and grand tourer manufactured by Toyota Motor Corporation beginning in 1978.";
            c1.Doors = 2;
            c1.HP = 335;
            c1.Id = 1;
            c1.ImageURL = "https://cdn.motor1.com/images/mgl/AJ3vx/s1/2020-toyota-supra-launch-edition.jpg";
            c1.Make = "Toyota";
            c1.Mileage = 65000;
            c1.Model = "Supra";
            c1.Seats = 2;
            c1.Year = 2015;

            cars.Add(c1);

            return Json(cars);
        }

        [HttpPost]
        public IActionResult SaveCar([FromBody] Car carToRegister)
        {
            System.Console.WriteLine("*******************");
            System.Console.WriteLine("*******************");
            System.Console.WriteLine("Saving Object", carToRegister);
            System.Console.WriteLine("*******************");
            System.Console.WriteLine("*******************");
            return Json(carToRegister);
        }
    }
}