using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

//ASP.NET CORE: MVC-представление, вспомогательные 
//методы представления(хелперы). Пример.
namespace WebApplication1.Helpers
{
    public static class Smw01
    {
        public static IHtmlContent Customer(this IHtmlHelper helper, string action = null, string controller = null, object parm = null)
        {
            string pa = action, pc = controller, hmethod = "POST";
            if (controller == null)
            {
                pc = (string)helper.ViewContext.RouteData.Values["controller"] ?? "Error";
                pa = (string)helper.ViewContext.RouteData.Values["action"] ?? "Error";
            }

            if (parm != null)
            {
                hmethod = parm.GetPropValue<string>("method");
            }

            TagBuilder hform = new TagBuilder("form");
            hform.MergeAttribute("method", hmethod);
            hform.MergeAttribute("action", $"/{pc}/{pa}");

            TagBuilder hfirstname = new TagBuilder("input");
            hfirstname.MergeAttribute("type", "text");
            hfirstname.MergeAttribute("name", "firstname");
            hform.InnerHtml.AppendHtml(hfirstname);

            TagBuilder hsubmit = new TagBuilder("input");
            hsubmit.MergeAttribute("type", "submit");
            hsubmit.MergeAttribute("type", "submit");
            hsubmit.MergeAttribute("value", "OK");
            hform.InnerHtml.AppendHtml(hsubmit);

            TagBuilder hcancel = new TagBuilder("input");
            hcancel.MergeAttribute("type", "submit");
            hcancel.MergeAttribute("type", "submit");
            hcancel.MergeAttribute("value", "Cancel");
            hform.InnerHtml.AppendHtml(hcancel);

            return hform;
        }

        // Reflection
        static T GetPropValue<T>(this Object obj, String name)
        {
            T rc = (obj != null ? (T)GetPropValue(obj, name) : default(T));
            return rc;
        }

        static Object GetPropValue(this Object obj, String name)
        {
            return obj?.GetType()?.GetProperty(name)?.GetValue(obj, null);
        }

        public static string PhotoURI(this IUrlHelper helper, string fname)
        {
            string pa = (string)helper.ActionContext.RouteData.Values["action"] ?? "Error";
            string pc = (string)helper.ActionContext.RouteData.Values["controller"] ?? "Error";
            string pf = fname ?? "Error";
            string scheme = helper.ActionContext.HttpContext.Request.Scheme;
            string hname = helper.ActionContext.HttpContext.Request.Host.Value;

            return $"{scheme}://{hname}/Photos/{pc}/{pa}/{pf}";
        }
    }
}
