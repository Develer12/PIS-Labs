using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HttpHandlers
{
    public partial class Default : System.Web.UI.Page
    {
        private object aaa;
        private object bbb;

        protected void Page_Load(object sender, EventArgs e)
        {
            aaa = this.parmA.Text;
            bbb = this.parmB.Text;
        }

        //https://localhost:44335/Default.aspx/qwerty.get?parma=3&parmb=5 либо через форму (ПОРТ!!!)
        protected void buttonGet_Click1(object sender, EventArgs e)
        {
            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create($"http://localhost:52468/qwerty.get?parma={aaa}&parmb={bbb}");
                request.Method = "GET";
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                StreamReader reader = new StreamReader(response.GetResponseStream());

                this.labelResult.Text = reader.ReadToEnd();
            }
            catch (WebException ex)
            {
                Response.Write(ex.Status);
                Response.Write("<br/>" + ex.Message);
            }
        }
    }
}