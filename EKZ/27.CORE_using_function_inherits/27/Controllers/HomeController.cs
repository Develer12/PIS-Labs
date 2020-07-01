using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Razor;
using _28.Models;


namespace _27.Controllers
{
    public class HomeController : Controller
    {

       

        public abstract class CustomRazorPage<TModel> : RazorPage<TModel>
        {
            public string CustomText { get; } =
                "Hello world";
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Using()
        {
            return View();
        }

        public IActionResult Function()
        {
            return View();
        }

        public IActionResult Inherits()
        {
            return View();
        }

    }
}
