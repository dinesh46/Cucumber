using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Cucumber.Models;
using Cucumber.Helpers;

namespace Cucumber.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Result(PersonModel person)
        {
            var number = person.Money.ToString(); 

            var isNegative = string.Empty;
            var result = string.Empty;

            if (number.Contains("-")) 
            { 
                isNegative = "Minus "; 
                number = number.Substring(1, number.Length - 1); 
            } 
            if (number == "0") 
            { 
                result = "The number in currency fomat is <br>Zero Only"; 
            } 
            else 
            { 
                result = $"The number in currency fomat is <br>{isNegative} {DecimalToCurrencyConvertor.ConvertToWords(number)}"; 
            }

            person.MoneyInWords = result;
            return View(person);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
