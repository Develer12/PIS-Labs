using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_26.Controllers
{
    public class HomeController : Controller
    {
        public class City {
            public List<string> CityName { get; set; }
        }
        [Route("city")]
        public IActionResult Page()
        {
            City city = new City()
            {
                CityName = new List<string>() 
            };
            return View("Page", city);
        }

        [Route("/")]
        public IActionResult Index()
        {
            ViewBag.Title = "Представления";
            List<string> City = new List<string>() { "Минск", "Брест", "Гомель", "Могилев", "Гродно" };
            return View("Index", City);
        }
    }
}
