using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class SelectiveSearch : System.Web.UI.Page
{
    properties p = new properties();
    downs d = new downs();

    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            if (Session["UserID"] == null)
            {
                Response.Redirect("Login.aspx");
            }
            else
            {
                string userID = Session["userID"].ToString();
                string password = Session["password"].ToString();
                int roleID = Convert.ToInt16(Session["roleID"]);
                bool verifiedStatus = SessionVerification.GetSpecificVerification(userID, password);
                if (verifiedStatus == false)
                {
                    Server.Transfer("Login.aspx");
                }
                else
                {

                }
            }
        }
        catch
        {

        }


        if (!IsPostBack)
        {

            ddlTown.DataSource = downs.listTown();

            ddlTown.DataTextField = "Text";
            ddlTown.DataValueField = "Value";
            ddlTown.DataBind();
            ddlTown.Items.Insert(0, "Select Town");

        }



    }

    protected void btnFindcon_Click(object sender, EventArgs e)
    {
        try
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = getConnection.getconnection();
            cmd.CommandText = "select * from invoice where consumer_No = '" + txtFindConsumer.Text + "'";
            //cmd.CommandText = "Select userID as UserName,roleID as Role, requestStatus from users where RequestStatus=0";

            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sda.Fill(ds);

            gvSearch.DataSource = ds;
            gvSearch.DataBind();
            gvSearch.Visible = true;

            cmd.Dispose();
        }
        catch
        {

        }
    }


    protected void btnFindadd_Click(object sender, EventArgs e)
    {
        try
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = getConnection.getconnection();
            cmd.CommandText = "select * from invoice where consumer_address like '%" + txtFindBlock.Text + "%'";
            //cmd.CommandText = "Select userID as UserName,roleID as Role, requestStatus from users where RequestStatus=0";

            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sda.Fill(ds);

            gvSearch.DataSource = ds;
            gvSearch.DataBind();
            gvSearch.Visible = true;

            cmd.Dispose();
        }
        catch
        {

        }
    }

    protected void btnFindName_Click(object sender, EventArgs e)
    {
        try
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = getConnection.getconnection();
            cmd.CommandText = "select * from invoice where consumer_name like '%" + txtConsumerName.Text + "%'";
            //cmd.CommandText = "Select userID as UserName,roleID as Role, requestStatus from users where RequestStatus=0";

            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sda.Fill(ds);

            gvSearch.DataSource = ds;
            gvSearch.DataBind();
            gvSearch.Visible = true;

            cmd.Dispose();
        }
        catch
        {

        }
    }

    //protected void ddlZone_SelectedIndexChanged(object sender, EventArgs e)
    //{
    //    ddlTown.Enabled = true;
    //    ddlTown.DataSource = downs.SelectedTown(Convert.ToInt16(ddlZone.SelectedValue));

    //    ddlTown.DataTextField = "Text";
    //    ddlTown.DataValueField = "Value";
    //    ddlTown.DataBind();
    //    ddlTown.Items.Insert(0, "Select Town");

    //}

    //protected void ddlUC_SelectedIndexChanged(object sender, EventArgs e)
    //{
    //    ddlBlock.Enabled = true;
    //    ddlBlock.DataSource = downs.SelectedBlock(Convert.ToInt16(ddlUC.SelectedValue), Convert.ToInt16(ddlTown.SelectedValue));
    //    ddlBlock.DataTextField = "Text";
    //    ddlBlock.DataValueField = "Value";
    //    ddlBlock.DataBind();
    //    ddlBlock.Items.Insert(0, "Select Block");
    //}

    //protected void ddlTown_SelectedIndexChanged(object sender, EventArgs e)
    //{
    //    ddlUC.Enabled = true;
    //    ddlUC.DataSource = downs.SelectedUC(Convert.ToInt16(ddlTown.SelectedValue));
    //    ddlUC.DataTextField = "Text";
    //    ddlUC.DataValueField = "Value";
    //    ddlUC.DataBind();
    //    ddlUC.Items.Insert(0, "Select UC");
    //}

    //protected void ddlBlock_SelectedIndexChanged(object sender, EventArgs e)
    //{
    //    ddlpropertyType.Enabled = true;
    //    ddlpropertyType.DataSource = downs.propertytype(Convert.ToInt16(ddlBlock.SelectedValue));
    //    ddlpropertyType.DataTextField = "Text";
    //    ddlpropertyType.DataValueField = "Value";
    //    ddlpropertyType.DataBind();
    //    ddlpropertyType.Items.Insert(0, "Select Property Type");
    //    //properties p = new properties();
    //    //lblSurchange.Text = p.Propertycode;



    //}

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        try
        {
            if (ddlTown.SelectedValue != "0" && txtCName.Text == "" && txtAddress.Text != null)
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = getConnection.getconnection();
                cmd.CommandText = "select * from invoice where town = '" + ddlTown.SelectedItem + "' and consumer_address like '%" + txtAddress.Text + "%'";

                //cmd.CommandText = "Select userID as UserName,roleID as Role, requestStatus from users where RequestStatus=0";

                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);

                gvSearch.DataSource = ds;
                gvSearch.DataBind();
                gvSearch.Visible = true;
                cmd.Dispose();
            }
            else if (ddlTown.SelectedValue != "0" && txtCName.Text != null && txtAddress.Text == "" )
            {

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = getConnection.getconnection();
                cmd.CommandText = "select * from invoice where town = '" + ddlTown.SelectedItem + "' and consumer_name like '%" + txtCName.Text + "%'";

                //cmd.CommandText = "Select userID as UserName,roleID as Role, requestStatus from users where RequestStatus=0";

                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);

                gvSearch.DataSource = ds;
                gvSearch.DataBind();
                gvSearch.Visible = true;
                cmd.Dispose();
                
            }
            else if (ddlTown.SelectedValue != "0" && txtCName.Text != null && txtAddress.Text != null)
            {
                lblmessage.Text = "Please Select Town with Name or Address";
                lblmessage.ForeColor = System.Drawing.Color.Red;
            }

            else if (txtCName.Text != null && txtAddress.Text != null)
            {
                lblmessage.Text = "Please Entry 1 Field at a time";
                lblmessage.ForeColor = System.Drawing.Color.Red;
            }
        }
        catch
        {

        }

        //if (ddlZone.SelectedValue != "0" && ddlTown.SelectedValue != "0")
        //{
        //if ( ddlpropertyType.SelectedValue == "" && ddlUC.SelectedValue == "0" && ddlBlock.SelectedValue == "")
        //{
        //SqlCommand cmd = new SqlCommand();
        //cmd.Connection = getConnection.getconnection();
        //cmd.CommandText = "select * from invoice where town = '" + ddlTown.SelectedItem + "' and consumer_address like '%"+txtAddress.Text +"%'";

        ////cmd.CommandText = "Select userID as UserName,roleID as Role, requestStatus from users where RequestStatus=0";

        //SqlDataAdapter sda = new SqlDataAdapter(cmd);
        //DataSet ds = new DataSet();
        //sda.Fill(ds);

        //gvSearch.DataSource = ds;
        //gvSearch.DataBind();
        //gvSearch.Visible = true;
        //cmd.Dispose();
        //}
        //else if (ddlUC.SelectedValue != "0" && ddlBlock.SelectedValue == "0")
        //{
        //    SqlCommand cmd = new SqlCommand();
        //    cmd.Connection = getConnection.getconnection();
        //    cmd.CommandText = "select * from invoice where zone = '" + ddlZone.SelectedItem + "' and town = '" + ddlTown.SelectedItem + "' and uc_name = '" + ddlUC.SelectedItem + "'";
        //    cmd.CommandTimeout = 250;
        //    //cmd.CommandText = "Select userID as UserName,roleID as Role, requestStatus from users where RequestStatus=0";

        //    SqlDataAdapter sda = new SqlDataAdapter(cmd);
        //    DataSet ds = new DataSet();
        //    sda.Fill(ds);

        //    gvSearch.DataSource = ds;
        //    gvSearch.DataBind();
        //    gvSearch.Visible = true;
        //    cmd.Dispose();
        //}
        //}



    }
    protected void btnReset_Click(object sender, EventArgs e)
    {
        Response.Redirect(Request.Url.ToString());
    }

}