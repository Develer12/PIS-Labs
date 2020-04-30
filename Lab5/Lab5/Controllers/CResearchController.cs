using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab5.Controllers
{
    public class CResearchController : Controller
    {
        public string Index()
        {
            string body;
            string method = Request.HttpMethod;
            string header = Request.Headers.ToString();
            string uri = Request.Url.AbsoluteUri;
            string param = Request.QueryString["param"];

            using (StreamReader reader = new StreamReader(Request.InputStream))
            {
                body = reader.ReadToEnd();
            }
            return $"body: {body}; " +
                $"header: {header}; " +
                $"method: {method}; " +
                $"uri: {uri}; " +
                $"params: {param}; ";
        }

        public string C01()
        {
            string body;
            string method = Request.HttpMethod;
            string header = Request.Headers.ToString();
            string uri = Request.Url.AbsoluteUri;
            string param = Request.QueryString["param"];

            using (StreamReader reader = new StreamReader(Request.InputStream))
            {
                body = reader.ReadToEnd();
            }
            return $"body: {body}; " +
                $"header: {header}; " +
                $"method: {method}; " +
                $"uri: {uri}; " +
                $"params: {param}; ";
        }

        public string C02()
        {
            string body;
            string status = HttpContext.Response.StatusCode.ToString();
            string header = Request.Headers.ToString();

            using (StreamReader reader = new StreamReader(Request.InputStream))
            {
                body = reader.ReadToEnd();
            }
            return $"body: {body};" +
                $"header: {header};" +
                $"status: {status}";
        }
    }
}