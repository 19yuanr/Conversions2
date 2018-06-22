using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Conversions2.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Conversions2.Controllers
{
    public class FirstController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }
        public ActionResult CelsiusToFahren(){
            CelsiusToFahrenViewModel tom = new CelsiusToFahrenViewModel();
            return View(viewName: "CelsiusToFahren", model: tom);
        }


        public ActionResult CelsiusToFahren2(){
            var bob = new CelsiusToFahrenViewModel();
            bob.Celsius = 0.0;
            bob.Fahrenheit = 0.0;
            return View(viewName: "CelsiusToFahren", model: bob);
        }

        [HttpPost]

        public ActionResult CelsiusToFahren2(double celsius, double fahrenheit){
            CelsiusToFahrenViewModel bob = new CelsiusToFahrenViewModel();
            if(celsius == 0){
                bob.Celsius = (bob.Fahrenheit-32)*0.5556;
                bob.Fahrenheit = fahrenheit;
            }
            if (fahrenheit == 0)
            {
                bob.Fahrenheit = (bob.Celsius * 1.8) + 16;
                bob.Celsius = celsius;

            }
            return View(viewName: "CelsiusToFahren", model: bob);
            }

        }
        
    }

