using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class SuspendBill : System.Web.UI.Page
{
    properties p = new properties();
    downs d = new downs();
    SqlCommand cmd;
    SqlConnection conn;
    protected void Page_Load(object sender, EventArgs e)
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
            bool verifiedStatus = SessionVerification.GetUserVerification(userID, password);
            if (verifiedStatus == false)
            {
                Server.Transfer("Login.aspx");
            }
            else
            {

            }
        }


        if (!IsPostBack)
        {
            ddltown.Enabled = false;
            ddldistrict.DataSource = downs.listZone();

            ddldistrict.DataTextField = "Text";
            ddldistrict.DataValueField = "Value";
            ddldistrict.DataBind();
            ddldistrict.Items.Insert(0, "Select Zone");

        }
    }

    protected void btnFindcon_Click(object sender, EventArgs e)
    {
        //try
        //{
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = getConnection.getconnection();
        cmd.CommandText = "select * from invoice where status !=6 and status !=7 and status !=11 and consumer_No = '" + txtConsumer.Text + "'";
        //cmd.CommandText = "Select userID as UserName,roleID as Role, requestStatus from users where RequestStatus=0";

        SqlDataAdapter sda = new SqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        DataTable tb = new DataTable();
        sda.Fill(tb);
        sda.Fill(ds);

        gvSearch.DataSource = ds;
        gvSearch.DataBind();
        gvSearch.Visible = true;
        pnl.Visible = true;
        ddldistrict.Visible = true;
        if (Convert.ToInt16(tb.Rows.Count) <= 0)
        {
            pnl.Visible = false;
            ddldistrict.Visible = false;
        }


        cmd.Dispose();
        //}
        //catch
        //{

        //}
    }

    protected void ddldistrict_SelectedIndexChanged(object sender, EventArgs e)
    {
        ddltown.Enabled = true;
        ddltown.DataSource = downs.SelectedTown(Convert.ToInt16(ddldistrict.SelectedValue));

        ddltown.DataTextField = "Text";
        ddltown.DataValueField = "Value";
        ddltown.DataBind();
        ddltown.Items.Insert(0, "Select Town");
    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        conn = new SqlConnection();
        conn.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["kmcConnectionString"].ConnectionString;

        cmd = new SqlCommand("sp_insertsearchingsheetsuspended", conn);
        cmd.CommandType = CommandType.StoredProcedure;

        cmd.Parameters.Add("@inword", SqlDbType.VarChar).Value = txtinword.Text;
        cmd.Parameters.Add("@consumer_no", SqlDbType.VarChar).Value = txtConsumer.Text;
        cmd.Parameters.Add("@department", SqlDbType.VarChar).Value = ddldept.SelectedValue.ToString();
        cmd.Parameters.Add("@zone", SqlDbType.VarChar).Value = ddldistrict.SelectedItem.ToString();
        cmd.Parameters.Add("@town", SqlDbType.VarChar).Value = ddltown.SelectedItem.ToString();
        cmd.Parameters.Add("@Createdby", SqlDbType.VarChar).Value = Session["UserID"];

        conn.Open();
        cmd.ExecuteNonQuery();
        conn.Close();
        ddldept.SelectedIndex = 0;
        txtConsumer.Text = "";
        ddltown.SelectedIndex = 0;
        ddldistrict.SelectedIndex = 0;
        pnl.Visible = false;
        ddldistrict.Visible = false;
        gvSearch.Visible = false;

    }
}