using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_24.Controllers
{
    public class HomeController : Controller
    {
        private string txt = "";
        public override void OnActionExecuting(ActionExecutingContext filterContext) // до
        {
            Console.WriteLine(this.txt += "- OnActionExecuting ");
        }
        public override void OnActionExecuted(ActionExecutedContext filterContext) // после
        {
            Console.WriteLine(this.txt += "-  OnActionExecuted ");
        }

        [Route("on1")]
        public IActionResult Action1()
        {
            Console.WriteLine(this.txt += "- Action 1");
            return Content("Action: Action1");
        }
        [Route("on2")]
        public IActionResult Action2()
        {
            Console.WriteLine(this.txt += "- Action 2");
            return Content("Action: Action2");
        }
        [HttpGet]
        [Route("get")]
        public IActionResult Get()
        {
            Console.WriteLine("Get");
            return Content("Get");
        }
        [HttpPost]
        [Route("post")]
        public IActionResult Post()
        {
            
            Console.WriteLine("Post");
            return Content("Post");
        }

        [AcceptVerbs("Get", "Post")]
        [Route("getpost")]
        public IActionResult GetAndPost()
        {

            Console.WriteLine("Get and Post");
            return Content("Get and Post");
        }

        [AcceptVerbs("Get", Route ="parm")]
        public IActionResult Param(string s)
        {
            Console.WriteLine("Parm: " + s);
            return Content("Parm: " + s);
        }
        [AcceptVerbs("Get")]

        // param/123
        [Route("{param}/{s:int}")]
        public IActionResult Param(int s)
        {
            Console.WriteLine("Parm: " + s);
            return Content("Parm: " + s);
        }

    }
}
