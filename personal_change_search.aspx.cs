using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class personal_change_search : System.Web.UI.Page
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
        cmd.CommandText = "select * from modify_consumer where consumer_No = '" + txtFindConsumer.Text + "'"; 
        //cmd.CommandText = "Select userID as UserName,roleID as Role, requestStatus from users where RequestStatus=0";

        SqlDataAdapter sda = new SqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        sda.Fill(ds);

        gvSearch.DataSource = ds;
        gvSearch.DataBind();
        gvSearch.Visible = true;
        
        cmd.Dispose();
    }

    protected void btnFindAddress_Click(object sender, EventArgs e)
    {

        SqlCommand cmd = new SqlCommand();
        cmd.Connection = getConnection.getconnection();
        cmd.CommandText = "select * from modify_consumer where new_address like '%" + txtAddress.Text + "%'";
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
        cmd.CommandText = "select * from modify_consumer where inword_no = '" + txtInwordNo.Text + "'";
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

        string date = txtfromdate.Text;
        string date1 = txttodate.Text;
        DateTime dt = Convert.ToDateTime(date);
        DateTime dt1 = Convert.ToDateTime(date1);
        


        SqlCommand cmd = new SqlCommand();
        cmd.Connection = getConnection.getconnection();
        cmd.CommandText = "SELECT  * FROM modify_consumer where createdon between '" + dt + "' and '" + dt1 + "'";
        
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