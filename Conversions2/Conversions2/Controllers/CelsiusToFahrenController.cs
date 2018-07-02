using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Conversions2.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Conversions2.Controllers
{
    public class CelsiusToFahrenController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }
        public ActionResult CelsiusToFahren()
        {
            CelsiusToFahrenViewModel tom = new CelsiusToFahrenViewModel();
            tom.Celsius = 0.0;
            tom.Fahrenheit = 0.0;
            return View(viewName: "CelsiusToFahren", model: tom);
        }

        [HttpPost]

        public ActionResult sayCelsiusToFahren(double celsius, double fahrenheit)
        {
            CelsiusToFahrenViewModel bob = new CelsiusToFahrenViewModel();
            if (celsius == 0.0)
            {
                bob.Celsius = (fahrenheit - 32) * 0.5556;
                bob.Fahrenheit = fahrenheit;
            }
            if (fahrenheit == 0.0)
            {
                bob.Fahrenheit = (celsius * 1.8) + 32;
                bob.Celsius = celsius;

            }
            return View(viewName: "CelsiusToFahren", model: bob);
        }
    }
}
