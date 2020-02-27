using System;
using System.Web.UI;
using System.Net;
using System.IO;
public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void GetButt_Click(object sender, EventArgs e)
    {
        try
        {
            HttpWebRequest req = (HttpWebRequest)HttpWebRequest.Create("http://localhost:8092/yyy.ndy?a=1&b=3");
            req.Method = "GET";
            HttpWebResponse res = (HttpWebResponse)req.GetResponse();
            StreamReader rdr = new StreamReader(res.GetResponseStream());
            Response.Write(rdr.ReadToEnd());
        }
        catch (WebException we)
        {
            Response.Write(we.Status);
            Response.Write("<br/>" + we.Message);
            Response.Write("<br/>" + we.TargetSite);
            Response.Write("<br/>" + we.Source);
        }
    }

    protected void PutButt_Click(object sender, EventArgs e)
    {
        try
        {
            HttpWebRequest req = (HttpWebRequest)HttpWebRequest.Create("http://localhost:8092/yyy.ndy?a=1&b=3");
            req.Method = "PUT";
            var Parameters = System.Text.Encoding.ASCII.GetBytes("a=1&b=2");
            req.MaximumResponseHeadersLength = 100;
            req.ContentLength = Parameters.Length;
            using (var stream = req.GetRequestStream())
            {
                stream.Write(Parameters, 0, Parameters.Length);
            }
            HttpWebResponse res = (HttpWebResponse)req.GetResponse();
            StreamReader rdr = new StreamReader(res.GetResponseStream());
            Response.Write(rdr.ReadToEnd());
        }
        catch(WebException we)
        {
            Response.Write(we.Status);
            Response.Write("<br/>" + we.Message);
            Response.Write("<br/>" + we.TargetSite);
            Response.Write("<br/>" + we.Source);
        }
    }

    protected void PostButt_Click(object sender, EventArgs e)
    {
        try
        {
            HttpWebRequest req = (HttpWebRequest)HttpWebRequest.Create("http://localhost:8092/yyy.ndy?a=1&b=3");
            req.Method = "POST";
            var Parameters = System.Text.Encoding.ASCII.GetBytes("a=1&b=2");
            req.MaximumResponseHeadersLength = 100;
            req.ContentLength = Parameters.Length;
            using (var stream = req.GetRequestStream())
            {
                stream.Write(Parameters, 0, Parameters.Length);
            }
            HttpWebResponse res = (HttpWebResponse)req.GetResponse();
            StreamReader rdr = new StreamReader(res.GetResponseStream());
            Response.Write(rdr.ReadToEnd());
        }
        catch (WebException we)
        {
            Response.Write(we.Status);
            Response.Write("<br/>" + we.Message);
            Response.Write("<br/>" + we.TargetSite);
            Response.Write("<br/>" + we.Source);
        }
    }
}