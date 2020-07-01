using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MVCcontrl23.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCcontrl23.Controllers
{
    public class HomeController : Controller
    {
        [ActionContext]
        public ActionContext actx { get; set; }

        public HttpContext httpContext => actx.HttpContext;
        
        public IActionResult Index()
        {
            
            return Content("Path: "+httpContext.Request.Path + "\nMethod: " + httpContext.Request.Method);
        }

        public IActionResult Util()
        {
            return new HtmlResult("<h1>Action Result</h1>");
        }

    }
}
