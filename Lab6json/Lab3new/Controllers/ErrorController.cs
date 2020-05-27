using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab3new.Controllers
{
    public class ErrorController : Controller
    {
        public ActionResult NotFound()
        {
            string uri = Request.Url.ToString().Split(';')[1];
            string method = Request.HttpMethod;
            Response.StatusCode = 404;
            ViewBag.uri = uri;
            ViewBag.method = method;
            return View();
        }
    }
}