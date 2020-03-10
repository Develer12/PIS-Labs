using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

public partial class _Default : Page
{
    protected global::System.Web.UI.HtmlControls.HtmlForm form1;
    HtmlTable t = new HtmlTable();
    HtmlTableRow tr;
    HtmlTableCell tc;

    protected void Page_Load(object sender, EventArgs e)
    {
        t.Border = 1;
        t.CellPadding = 5;
        t.CellSpacing = 4;
        t.Align = "center";
        t.ID = "Table1";
        HtmlTableRow tr;
        HtmlTableCell tc;
        tr = new HtmlTableRow();
        tc = new HtmlTableCell();

        tc = new HtmlTableCell(); tc.InnerHtml = "Control"; tr.Cells.Add(tc);
        tc = new HtmlTableCell(); tc.InnerHtml = "onclick"; tr.Cells.Add(tc);
        tc = new HtmlTableCell(); tc.InnerHtml = "onchange"; tr.Cells.Add(tc);
        t.Rows.Add(tr);
        tr = new HtmlTableRow();
        tc = new HtmlTableCell(); tc.InnerHtml = "Control"; tr.Cells.Add(tc);
        tc = new HtmlTableCell(); tc.InnerHtml = "Control"; tr.Cells.Add(tc);
        tc = new HtmlTableCell(); tc.InnerHtml = "Control"; tr.Cells.Add(tc);
        t.Rows.Add(tr);
        this.Controls.Add(t);
    }


    protected void Serv_Click(object sender, System.EventArgs e)
    {
        tr = new HtmlTableRow();
        tc = new HtmlTableCell(); tc.InnerHtml = ((Control)sender).ID; tr.Cells.Add(tc);
        tc = new HtmlTableCell(); tc.InnerHtml = "Yes"; tr.Cells.Add(tc);
        tc = new HtmlTableCell(); tc.InnerHtml = "No"; tr.Cells.Add(tc);
        t.Controls.Add(tr);
        //Response.Write("dfsgdhjkh"+((Control)sender).ID);
    }
    protected void Serv_Change(object sender, System.EventArgs e)
    {
        tr = new HtmlTableRow();
        tc = new HtmlTableCell(); tc.InnerHtml = ((Control)sender).ID; tr.Cells.Add(tc);
        tc = new HtmlTableCell(); tc.InnerHtml = "No"; tr.Cells.Add(tc);
        tc = new HtmlTableCell(); tc.InnerHtml = "Yes"; tr.Cells.Add(tc);
        t.Controls.Add(tr);
        //Response.Write("dfsgdhjkh"+((Control)sender).ID);
    }


    protected void servH(object sender, ServerValidateEventArgs args)
    {
        try
        {
            int val = Convert.ToInt32(args.Value);

            int nod = 0;
            int count = 1;

            for (int j = 1; j <= val; j++)
            {
                if (val % j == 0)
                {
                    if (Math.Floor(Convert.ToDecimal(val / j)) != 1 || Math.Floor(Convert.ToDecimal(val / j)) != val)
                    {
                        nod++;
                    }
                }

                if (nod > 2)
                {
                    count--;
                    break;
                }
            }
            args.IsValid = (count == 1);
        }
        catch
        {
            args.IsValid = false;
        }
    }

    protected void Page_PreRender(object sender, EventArgs e)
    {
        RangeValidator2.MaximumValue = DateTime.Now.Date.ToString("MM/dd/yyyy");
        RangeValidator2.MinimumValue = DateTime.Now.Date.AddYears(-100).ToString("MM/dd/yyyy");

    }
}