using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;
using System.Web.Mvc;

namespace Lab5.Controllers
{
    public class MResearchController : Controller
    {
        //ERROR
        public string MXX()
        {
            return "MXX";
        }

        //M01
        public string Index()
        {
            return "GET:M01";
        }

        public string M01()
        {
            return "GET:M01";
        }

        [Route("V2/MResearch/M01")]
        public string V2_M01()
        {
            return "GET:M01";
        }

        [Route("V3/MResearch/{X:maxlength(1)}/M01")]
        public string V3_X_M01()
        {
            return "GET:M01";
        }


        //M02
        public string M02()
        {
            return "GET:M02";
        }

        [Route("V2")]
        public string V2()
        {
            return "GET:M02";
        }

        [Route("V2/MResearch/M02")]
        public string V2_M02()
        {
            return "GET:M02";
        }

        [Route("V2/MResearch")]
        public string V2_M020()
        {
            return "GET:M02";
        }

        [Route("V3/MResearch/{X:maxlength(1)}/M02")]
        public string V3_X_M02()
        {
            return "GET:M01";
        }

        //M03
        [Route("V3")]
        public string V3()
        {
            return "GET:M02";
        }
        [Route("V3/MResearch/{X:maxlength(1)}/M03")]
        public string V3_X_M03()
        {
            return "GET:M01";
        }
        [Route("V3/MResearch/{X:maxlength(1)}")]
        public string V3_X_M030()
        {
            return "GET:M01";
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


        [Route("it/{email:regex(^([\\w-\\.]+)@((\\[[0-9]{1,3}\\.[0-9]{1,3}\\.[0-9]{1,3}\\.)|(([\\w-]+\\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\\]?)$)}")]
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