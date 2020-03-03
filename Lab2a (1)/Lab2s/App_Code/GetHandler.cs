using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Routing;


public class GetHandler: IHttpHandler
{
    public void ProcessRequest(HttpContext context)
    {
        HttpRequest req = context.Request;
        HttpResponse res = context.Response;
        string a = req.Params.Get("a");
        string b = req.Params.Get("b");

        res.Write("GetHandler: " + a + " " + b);
    }
    public bool IsReusable
    {
        get { return false; }
    }
}