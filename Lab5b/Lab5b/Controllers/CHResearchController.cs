using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;
using System.Web.Mvc;

namespace Lab5b.Controllers
{
    public class CHResearchController : Controller
    {
        public ActionResult Index()
        {
            return Content("GET:/");
        }

        [OutputCache(Duration = 5)]
        [HttpGet]
        public ActionResult AD()
        {
            long t = DateTime.Now.ToBinary();
            return Content($"GET:/AD:{t}");
        }

        [OutputCache(Duration = 7)]
        [Route("CHResearch/AP/{param1}/{param2}")]
        [HttpPost]
        public ActionResult AP(string param1, string param2)
        {
            long t = DateTime.Now.ToBinary();
            return Content($"GET:/AP:{param1}:{param2}:{t}");
        }
    }
}