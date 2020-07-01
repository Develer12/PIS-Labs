using Microsoft.AspNetCore.Mvc;
using MVC_contrl_23;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCcontrl23.Controllers
{
    public class CDIController : Controller
    {
        private CDI cdi;
        
        public CDIController(CDI cdi)
        {
            this.cdi = cdi;
        }
        //  URI: CDI/index
        public IActionResult Index()
        {
            return Content("Index: " + cdi.Get());
        }
        //  URI: CDI/get
        public IActionResult Get()
        {
            return Content("Get: " + cdi.Get());
        }
        //  URI: CDI/set?s=xxx
        public IActionResult Set(string s)
        {
            return Content("Set: " + cdi.Set(s));
        }
    }
}
