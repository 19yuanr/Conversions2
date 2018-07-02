using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Conversions2.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Conversions2.Controllers
{
    public class CentToInchController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }
        public ActionResult CentToInch()
        {
            CentToInchViewModel tom = new CentToInchViewModel();
            tom.Cent = 0.0;
            tom.Inch = 0.0;
            return View(viewName: "CentToInch", model: tom);
        }

        [HttpPost]
        public ActionResult sayCentToInch(double cent, double inch)
        {
            CentToInchViewModel bob = new CentToInchViewModel();
            if (cent == 0.0)
            {
                bob.Cent = inch * 2.54;
                bob.Inch = inch;
            }
            if (inch == 0.0)
            {
                bob.Inch = cent / 2.54;
                bob.Cent = cent;
            }
            return View(viewName: "CentToInch", model: bob);
        }
    }
}
