using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace CarRental.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Homework2()
        {
            // Practice lists
            /* List<string> names = new List<string>();

            names.Add("Angelo");
            names.Add("John");
            names.Add("Jane");
            names.Add("Mark");

            for (int i = 0; i < names.Count; i++)
            {
                System.Console.WriteLine(names[i]);
            } */

            int num = 10;
            List<int> dividends = new List<int>();

            // Your code here

            return Json(dividends);
        }

        private int CountAndPrintOdds(int[] numbers)
        {
            int count = 0;

            // Print the odd numbers inside the array
            for (int i = 0; i < numbers.Length; i++)
            {
                int num = numbers[i];

                // Decide if num is an odd number
                int res = num % 2;
                if (res != 0)
                {
                    System.Console.WriteLine(num);
                    count += 1;
                }
            }

            return count;
        }

        public IActionResult Homework()
        {
            int[] numbers = new int[200];
            for (int i = 0; i < 200; i++)
            {
                numbers[i] = i + 1;
            }
            int howMany = CountAndPrintOdds(numbers);
            System.Console.WriteLine(howMany);

            System.Console.WriteLine("*****************************");
            System.Console.WriteLine("Homework");
            System.Console.WriteLine("*****************************");
            return Content("123");
        }
    }
}