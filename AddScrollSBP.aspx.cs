using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class AddScroll : System.Web.UI.Page
{
    properties p = new properties();
    downs d = new downs();
    SqlCommand cmd;
    SqlConnection conn;
    protected void Page_Load(object sender, EventArgs e)
    {
        pnl.Visible = false;
        pnlinsert.Visible = false;
        gvSearch.Visible = false;
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

        }
    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        conn = new SqlConnection();
        conn.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["kmcConnectionString"].ConnectionString;
        
            cmd = new SqlCommand("sp_insertscrolls", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@Consumer_no", SqlDbType.VarChar).Value = txtconsumer.Text;
            cmd.Parameters.Add("@Billing_Period", SqlDbType.VarChar).Value = txtbillingperiod.Value;
            cmd.Parameters.Add("@branch_code", SqlDbType.VarChar).Value = Convert.ToString(txtbranchcode.Text);
            cmd.Parameters.Add("@amount", SqlDbType.Decimal).Value = Convert.ToDecimal(txtamount.Text);
            cmd.Parameters.Add("@Payment_Date", SqlDbType.SmallDateTime).Value = Convert.ToDateTime(txtpaymentdate.Text); ;
            cmd.Parameters.Add("@Bank_Name", SqlDbType.VarChar).Value = "SINDH BANK";
            cmd.Parameters.Add("@createdby", SqlDbType.VarChar).Value = Session["UserID"].ToString();

            cmd.Parameters.Add("@FTP_Provided", SqlDbType.VarChar).Value = "NOT PROVIDED";
            cmd.Parameters.Add("@Scroll_Provided", SqlDbType.VarChar).Value = "PROVIDED";

       
       



        conn.Open();
        cmd.ExecuteNonQuery();
        conn.Close();
        txtconsumer.Text = "";
        txtamount.Text = "";
        txtbranchcode.Text = "";
        txtpaymentdate.Text = "";
        txtbillingperiod.Value = "";
        btnSubmit.Visible = false;
        btnsearch.Visible = true;
        gvSearch.Visible = false;

    }

    protected void btnsearch_Click(object sender, EventArgs e)
    {

            conn = new SqlConnection();
            conn.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["kmcConnectionString"].ConnectionString;

            cmd = new SqlCommand("sp_FetchScroll", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@Consumer_no", SqlDbType.VarChar).Value = txtconsumer.Text;
            cmd.Parameters.Add("@branch_code", SqlDbType.VarChar).Value = Convert.ToString(txtbranchcode.Text);
            cmd.Parameters.Add("@amount", SqlDbType.Decimal).Value = Convert.ToDecimal(txtamount.Text);
            cmd.Parameters.Add("@Payment_Date", SqlDbType.SmallDateTime).Value = Convert.ToDateTime(txtpaymentdate.Text);
            cmd.Parameters.Add("@Bank_Name", SqlDbType.VarChar).Value = "SINDH BANK";
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();


            SqlDataAdapter sda = new SqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        DataTable tb = new DataTable();
        sda.Fill(tb);
        sda.Fill(ds);

        gvSearch.DataSource = ds;
        gvSearch.DataBind();
        gvSearch.Visible = true;
        pnl.Visible = true;
        
        if (Convert.ToInt16(tb.Rows.Count) <= 0)
        {
            pnl.Visible = false;
            btnsearch.Visible = false;
            btnSubmit.Visible = true;
            pnlinsert.Visible = true;

        }
        cmd.Dispose();
    }
}