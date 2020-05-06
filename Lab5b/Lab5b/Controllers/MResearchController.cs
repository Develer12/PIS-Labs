using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;
using System.Web.Mvc;

namespace Lab5b.Controllers
{
    public class MResearchController : Controller
    {
        //ERROR
        public string MXX()
        {
            return "MXX";
        }

        //B part
        [Route("it/{n:int}/{str}")]
        [HttpGet]
        public string Bintstr(int n, string str)
        {
            return $"GET:M01:/{n}/{str}";
        }

        [Route("it/{b:bool}/{letters:alpha}")]
        [AcceptVerbs(HttpVerbs.Get | HttpVerbs.Post)]
        public string Bboolstr(bool b, string letters)
        {
            return $"{Request.HttpMethod}:M02:/{b}/{letters}";
        }

        [Route("it/{f:float}/{str:length(2,5)}")]
        [AcceptVerbs(HttpVerbs.Get | HttpVerbs.Delete)]
        public string Bflstr(float f, string str)
        {
            return $"{Request.HttpMethod}:M03:/{f}/{str}";
        }

        [Route("it/{letters:length(3,4)}/{n:range(100,200)}")]
        [HttpPut]
        public string Bstrint(string letters, int n)
        {
            return $"{Request.HttpMethod}:M04:/{letters}/{n}";
        }

        //sda@sdacom - without dot [.]
        [Route("it/{email:length(3,50)}")]
        [HttpPost]
        public string Bemail(string email)
        {
            try
            {
                MailAddress m = new MailAddress(email);

                return $"{Request.HttpMethod}:M05:/{email}";
            }
            catch (FormatException)
            {
                return $"{Request.HttpMethod}:M05:not valid E-mail";
            }
        }
    }
}