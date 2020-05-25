using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class billing_search : System.Web.UI.Page
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
        cmd.CommandText = "SELECT  Consumer_No, Category, createdby, zone, bill_type,convert(varchar(20), createdon,106) as createdon FROM duplicatebill_history where consumer_No = '" + txtFindConsumer.Text + "'"; 
        //cmd.CommandText = "Select userID as UserName,roleID as Role, requestStatus from users where RequestStatus=0";

        SqlDataAdapter sda = new SqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        sda.Fill(ds);

        gvSearch.DataSource = ds;
        gvSearch.DataBind();
        gvSearch.Visible = true;
        
        cmd.Dispose();
    }

    protected void btnFindImpact_Click(object sender, EventArgs e)
    {

        SqlCommand cmd = new SqlCommand();
        cmd.Connection = getConnection.getconnection();
        cmd.CommandText = "SELECT  Consumer_No, Category, createdby, zone, bill_type,convert(varchar(20), createdon,106) as createdon FROM duplicatebill_history where zone = '" + txtImapct.Text + "'";
        //cmd.CommandText = "Select userID as UserName,roleID as Role, requestStatus from users where RequestStatus=0";

        SqlDataAdapter sda = new SqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        sda.Fill(ds);

        gvSearch.DataSource = ds;
        gvSearch.DataBind();
        gvSearch.Visible = true;

        cmd.Dispose();
    }




    protected void btnFindInword_Click(object sender, EventArgs e)
    {
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = getConnection.getconnection();
        cmd.CommandText = "SELECT  Consumer_No, Category, createdby, zone, bill_type,convert(varchar(20), createdon,106) as createdon FROM duplicatebill_history where createdby = '" + txtInwordNo.Text + "'";
        //cmd.CommandText = "Select userID as UserName,roleID as Role, requestStatus from users where RequestStatus=0";

        SqlDataAdapter sda = new SqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        sda.Fill(ds);

        gvSearch.DataSource = ds;
        gvSearch.DataBind();
        gvSearch.Visible = true;

        cmd.Dispose();
    }

    protected void btnListFind_Click(object sender, EventArgs e)
    {

        string date = txtfromdate.Text;
        string date1 = txttodate.Text;
        DateTime dt = Convert.ToDateTime(date);
        DateTime dt1 = Convert.ToDateTime(date1);


        SqlCommand cmd = new SqlCommand();
        cmd.Connection = getConnection.getconnection();
        cmd.CommandText = "SELECT  Consumer_No, Category, createdby, zone, bill_type,convert(varchar(20), createdon,106) as createdon FROM duplicatebill_history where createdon between '" + dt + "' and '" + dt1 + "'";
         //cmd.CommandText = "Select userID as UserName,roleID as Role, requestStatus from users where RequestStatus=0";

         SqlDataAdapter sda = new SqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        sda.Fill(ds);

        gvSearch.DataSource = ds;
        gvSearch.DataBind();
        gvSearch.Visible = true;

        cmd.Dispose();

    }
	
	protected void btnDate_Click(object sender, EventArgs e)
    {

        string date = txtdate.Text;
      
        DateTime dt = Convert.ToDateTime(txtdate.Text);
        


        SqlCommand cmd = new SqlCommand();
        cmd.Connection = getConnection.getconnection();
        cmd.CommandText = "SELECT  Consumer_No, Category, createdby, zone, bill_type,convert(varchar(20), createdon,106) as createdon FROM duplicatebill_history where createdon = '" + dt +"'";
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