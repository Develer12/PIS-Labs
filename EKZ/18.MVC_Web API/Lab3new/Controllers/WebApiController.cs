using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Web.Http;
using Newtonsoft.Json.Linq;

namespace Lab3new.Controllers
{
    public class WebApiController : ApiController
    {

        [HttpGet]
        public HttpResponseMessage Index()
        {
            HttpResponseMessage rm = new HttpResponseMessage();
            rm.Content = new StringContent("test", Encoding.UTF8, "text/plain");
            return rm;
        }
    }
}
