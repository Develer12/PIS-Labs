using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

public class PostHandler : IHttpHandler
{
    public void ProcessRequest(HttpContext context)
    {
        HttpRequest req = context.Request;
        HttpResponse res = context.Response;
        res.AppendHeader("Access-Control-Allow-Origin", "*");
        res.AppendHeader("Access-Control-Allow-Credentials", "true");
        int a = Convert.ToInt32(req.Params.Get("a"));
        int b = Convert.ToInt32(req.Params.Get("b"));
        res.Write("PostHandler: " + (a + b));
    }
    public bool IsReusable
    {
        get { return false; }
    }
}