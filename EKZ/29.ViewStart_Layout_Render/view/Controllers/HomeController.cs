using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using view.Models;

namespace view.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.x = 1;
            return View();
        }
    }
}
