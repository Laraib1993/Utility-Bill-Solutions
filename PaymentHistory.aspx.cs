using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class PaymentHistory : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        if (Session["UserID"] == null)
        {
            Response.Redirect("Login.aspx");
        }


    }

    protected void btnFindcon_Click(object sender, EventArgs e)
    {
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = getConnection.getconnection();
        cmd.CommandText = "select * from payment_history_Main where consumer_No = '" + txtFindConsumer.Text + "' order by report_id";
        cmd.CommandTimeout = 60;
        //cmd.CommandText = "Select userID as UserName,roleID as Role, requestStatus from users where RequestStatus=0";

        SqlDataAdapter sda = new SqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        sda.Fill(ds);

        gvSearch.DataSource = ds;
        gvSearch.DataBind();
        gvSearch.Visible = true;
        
        cmd.Dispose();
    }


  
}