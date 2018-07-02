using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Conversions2.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Conversions2.Controllers
{
    public class MetersToFeetController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        public ActionResult MetersToFeet()
        {
            MetersToFeetViewModel init = new MetersToFeetViewModel();
            init.Meters = 0.0;
            init.Feet = 0.0;
            return View(viewName: "MetersToFeet", model: init);
        }


        [HttpPost]
        public ActionResult SayMetersToFeet(double Meters, double Feet)
        {
            MetersToFeetViewModel temp = new MetersToFeetViewModel();
            if (Meters - 0.0 < .0000001)
            {
                temp.Meters = Feet / 3.28;
                temp.Feet = Feet;
            }
            if (Feet - 0.0 < .0000001)
            {
                temp.Feet = Meters * 3.28;
                temp.Meters = Meters;
            }
            return View(viewName: "MetersToFeet", model: temp);
        }





    }
}
