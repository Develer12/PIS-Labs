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

    //PART 1
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


    //PART 2
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
        RangeValidator2.MaximumValue = DateTime.Now.Date.ToString("dd/MM/yyyy");
        RangeValidator2.MinimumValue = DateTime.Now.Date.AddYears(-100).ToString("dd/MM/yyyy");
    }

    protected void ButtMV3_Click(object sender, EventArgs e)
    {
        if(this.MV1.ActiveViewIndex == 0)
        {
            this.MV1v2T.Text = this.MV1v1T.Text;
        }
        if (this.MV1.ActiveViewIndex == 1)
        {
            this.MV1v3T.Text = this.MV1v2T.Text;
        }
        if (this.MV1.ActiveViewIndex == 2)
        {
            this.MV1v1T.Text = this.MV1v3T.Text;
        }
        this.MV1.ActiveViewIndex = (this.MV1.ActiveViewIndex+1)%3;
    }


    //PART 3
    protected void AdButt_Click(object sender, EventArgs e)
    {
        string addCl = this.adR1.KeywordFilter;

        if (addCl == "")
        {
            this.adR1.KeywordFilter = "b1";
        }
        if(addCl == "b1")
        {
            this.adR1.KeywordFilter = "b2";
        }
        if(addCl == "b2")
        {
            this.adR1.KeywordFilter = "";
        }
        addCl = this.adR1.KeywordFilter;
        this.AdButt.Text = "-> " + addCl;
    }



    protected void Wizard1_OnNextButtonClick(object sender, WizardNavigationEventArgs e)
    {
        if (this.Wizard1.ActiveStepIndex + 1 == this.Wizard1.WizardSteps.Count - 1)
        {
            var text = "";

            text += "TextBox: " + this.WizardTextbox.Text + "<br/>";
            text += "RadioButtonList: " + this.WizardRadioButtonList.SelectedValue + " < br/>";

            text += "CheckBoxList: <br/>";
            foreach (ListItem lst in this.WizardCheckBoxList.Items)
            {
                if (lst.Selected)
                {
                    text += "Selected Item Text: " + lst.Text + "<br/>";
                }
            }

            text += "ListBox: " + this.WizardListBox.SelectedValue + " < br/>";
            text += this.WizardCalendar.SelectedDate.ToShortDateString() + "<br/>";

            text += "Selected dates: <br/>";
            for (var i = 0; i <= this.WizardCalendars.SelectedDates.Count - 1; i++)
            {
                text += this.WizardCalendars.SelectedDates[i].ToShortDateString() + "<br/>";
            }

            this.WizardResult.Text = text;
        }
    }

    public static List<DateTime> list = new List<DateTime>();

    protected void WizardCalendars_OnSelectionChanged(object sender, EventArgs e)
    {
        if (this.Session["SelectedDates"] != null)
        {
            var newList = (List<DateTime>)this.Session["SelectedDates"];
            foreach (var dt in newList)
            {
                this.WizardCalendars.SelectedDates.Add(dt);
            }

            list.Clear();
        }
    }

    protected void Calendars_DayRender(object sender, DayRenderEventArgs e)
    {
        if (e.Day.IsSelected)
        {
            list.Add(e.Day.Date);
        }

        this.Session["SelectedDates"] = list;
    }

    protected void TreeViewButton_OnClick(object sender, EventArgs e)
    {
        var nodes = this.TreeView.Nodes;
        foreach (TreeNode n in nodes)
        {
            this.GetNodeRecursive(n);

        }
        var text = "<br/>";
        foreach (var obj in this.SelectedNodes)
        {
            text += obj + "<br/>";
        }

        this.TreeViewResult.Text = text;
    }

    protected void TreeView_OnSelectedNodeChanged(object sender, EventArgs e)
    {
        var items = this.GetSelected(this.TreeView.SelectedNode);
        var text = "<br/>";
        foreach (var obj in items)
        {
            text += obj + "<br/>";
        }

        this.TreeViewResult.Text = text;
    }

    List<string> GetSelected(TreeNode tree)
    {
        var result = new List<string>();
        foreach (var obj in tree.ChildNodes)
        {
            if (!(obj is TreeNode temp))
            {
                continue;
            }

            if (temp.ChildNodes.Count != 0)
            {
                result.AddRange(this.GetSelected(temp));
            }

            if (temp.Checked)
            {
                result.AddRange(this.GetSelected(temp));
            }
        }

        return result;
    }
    private List<string> SelectedNodes = new List<string>();
    private void GetNodeRecursive(TreeNode treeNode)
    {
        if (treeNode.Checked)
        {
            this.SelectedNodes.Add(treeNode.Value);
        }
        foreach (TreeNode tn in treeNode.ChildNodes)
        {
            this.GetNodeRecursive(tn);
        }

    }

    protected void Menu_itemClick(object sender, MenuEventArgs e)
    {
        this.MenuResult.Text = ((Menu)sender).SelectedValue;
    }
}