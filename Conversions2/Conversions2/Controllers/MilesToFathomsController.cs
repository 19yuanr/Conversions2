using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Conversions2.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Conversions2.Controllers
{
    public class MilesToFathomsController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        public ActionResult MilesToFathoms()
        {
            MilesToFathomsViewModel init = new MilesToFathomsViewModel();
            init.Miles = 0.0;
            init.Fathoms = 0.0;
            return View(viewName: "MilesToFathoms", model: init);
        }


        [HttpPost]
        public ActionResult SayMilesToFathoms(double miles, double fathoms)
        {
            MilesToFathomsViewModel temp = new MilesToFathomsViewModel();
            if (miles - 0.0 < .0000001)
            {
                temp.Miles = fathoms / 880;
                temp.Fathoms = fathoms;
            }
            if (fathoms - 0.0 < .0000001)
            {
                temp.Fathoms = miles * 880;
                temp.Miles = miles;
            }
            return View(viewName: "MilesToFathoms", model: temp);
        }





    }
}
