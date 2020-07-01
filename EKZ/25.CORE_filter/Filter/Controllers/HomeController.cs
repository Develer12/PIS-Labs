using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Filter.Filters;
using Filter.Models;

namespace Filter.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [DateTimeExecutionFilter]
        public IActionResult Index()
        {
            return View();
        }
        //[Authorize]
        //[IEFilter]
        [Whitespace]
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        [CustomExceptionFilter]
        public IActionResult Err()
        {
            int x = 0;
            int y = 8 / x;
            return Content("qwe");
        }
    }
}
