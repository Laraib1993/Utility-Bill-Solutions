using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class SearchByAll : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }



    protected void ListView1_ItemCommand(object sender, ListViewCommandEventArgs e)
    {
        if (e.CommandName == "Insert")
        {
        }
        else if (e.CommandName == "Update")
        {
            Label txtId = (Label)e.Item.FindControl("employeeIDLabel");
            Label txtLname = (Label)e.Item.FindControl("AccountStatusLabel");
            if (txtLname.Text == "Active")
            {
                //SqlDataSource1.UpdateCommand = listviewfunc.ifemployeeactive(txtId.Text);
            }



        }
    }
   }