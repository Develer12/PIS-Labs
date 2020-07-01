using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using entity_VALIDATION.Models;
using entity_VALIDATION.ViewModel;

namespace entity_VALIDATION.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, entity_VALIDATION.Data.AppContext context)
        {
            context.Phones.Add(new Data.DbModel.Phone());
            _logger = logger;
        }

        public IActionResult Index()
        {

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult ValidationTesting()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Valid(PlanViewModel plan)
        {
            if(ModelState.IsValid)
            {
                return RedirectToAction("Index");
            }
            else
            {
                return View(plan);
            }
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
