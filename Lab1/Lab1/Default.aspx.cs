using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        ClientScript.RegisterClientScriptBlock(this.GetType(), "alert", "alert('Page_Load')", true);
    }

    protected void Page_Init(object sender, EventArgs e)
    {
        ClientScript.RegisterClientScriptBlock(this.GetType(), "alert", "alert('Page_Init')", true);
    }
    protected void Page_Unload(object sender, EventArgs e)
    {
        ClientScript.RegisterClientScriptBlock(this.GetType(), "alert", "alert('Page_Unload')", true);

    }
    protected void Page_Prerender(object sender, EventArgs e)
    {
        ClientScript.RegisterClientScriptBlock(this.GetType(), "alert", "alert('Page_Prerender')", true);

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Label1.Text = TextBox1.Text;
    }

    protected void OnSelectedIndexChanged(object sender, EventArgs e)
    {
        string message = DropDownList1.SelectedItem.Text + " - " + DropDownList1.SelectedItem.Value;
        ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('" + message + "');", true);
    }
}