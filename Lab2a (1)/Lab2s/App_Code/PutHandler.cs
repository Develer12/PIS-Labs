using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Сводное описание для PutHandler
/// </summary>
public class PutHandler : IHttpHandler
{
    public void ProcessRequest(HttpContext context)
    {
        HttpRequest req = context.Request;
        HttpResponse res = context.Response;
        string a = req.Params.Get("a");
        string b = req.Params.Get("b");

        res.Write("PutHandler: " + a + " " + b);
    }
    public bool IsReusable
    {
        get { return false; }
    }
}