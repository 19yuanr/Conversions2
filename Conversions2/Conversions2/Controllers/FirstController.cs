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

       
    }
}
