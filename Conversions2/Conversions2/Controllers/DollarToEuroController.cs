using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Conversions2.Models;
using Microsoft.AspNetCore.Mvc;

namespace Conversions2.Controllers
{
    public class DollarToEuroController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public ActionResult DollarToEuro()
        {
            DollarToEuroViewModel init = new DollarToEuroViewModel();
            init.Dollars = 0.0;
            init.Euros = 0.0;
            return View(viewName: "DollarToEuro", model: init);
        }

        [HttpPost]
        public ActionResult ConvertDTE(double dollars, double euros)
        {
            DollarToEuroViewModel money = new DollarToEuroViewModel();
            if (dollars == 0.0)
            {
                double newDollar = euros * 1.16;
                money.Dollars = newDollar;
                money.Euros = euros;
            }
            if (euros == 0d)
            {
                double newEuro = dollars * 0.86;
                money.Dollars = dollars;
                money.Euros = newEuro;
            }
            return View(viewName: "DollarToEuro", model: money);
        }
    }
}