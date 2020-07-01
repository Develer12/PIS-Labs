using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_22.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [Route("Ekz")]
        [Route("Home/Ekz")]
        public IActionResult Ekz()
        {
            return View();
        }
    }
}
