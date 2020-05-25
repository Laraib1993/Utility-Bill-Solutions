using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class reconcile : System.Web.UI.Page
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

            ddlbank.DataSource = downs.listpostingvoucherqtrbank();

            ddlbank.DataTextField = "Text";
            ddlbank.DataValueField = "Value";
            ddlbank.DataBind();
            ddlbank.Items.Insert(0, "Select Bank");

        }
    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        conn = new SqlConnection();
        conn.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["kmcConnectionString"].ConnectionString;

        cmd = new SqlCommand("sp_ReconcileInsert", conn);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.Add("@Consumer_no", SqlDbType.VarChar).Value = txtconsumer.Text;
        cmd.Parameters.Add("@branch_code", SqlDbType.VarChar).Value = txtbranchcode.Text;
        cmd.Parameters.Add("@amount", SqlDbType.Decimal).Value = Convert.ToDecimal(txtamount.Text);
        cmd.Parameters.Add("@Payment_Date", SqlDbType.SmallDateTime).Value = Convert.ToDateTime(txtpaymentdate.Text);
        cmd.Parameters.Add("@Bank_Name", SqlDbType.VarChar).Value = ddlbank.SelectedItem.Text.ToString();
        if (ddlbank.SelectedItem.Text == "HABIB BANK")
        {
            cmd.Parameters.Add("@FTP_Provided", SqlDbType.VarChar).Value = "PROVIDED";
            cmd.Parameters.Add("@Scroll_Provided", SqlDbType.VarChar).Value = "PROVIDED";
        }

        else if (ddlbank.SelectedItem.Text == "NATIONAL BANK")
        {
            cmd.Parameters.Add("@FTP_Provided", SqlDbType.VarChar).Value = "NOT ON FTP";
            cmd.Parameters.Add("@Scroll_Provided", SqlDbType.VarChar).Value = "PROVIDED";
        }

        cmd.Parameters.Add("@createdby", SqlDbType.VarChar).Value = Session["UserID"].ToString();

        
        

        conn.Open();
        cmd.ExecuteNonQuery();
        conn.Close();
        txtconsumer.Text = "";
        txtamount.Text = "";
        txtbranchcode.Text = "";
        txtpaymentdate.Text = "";
        ddlbank.SelectedIndex = 0;
        btnSubmit.Visible = false;
        gvSearch.Visible = false;

    }

    protected void btnsearch_Click(object sender, EventArgs e)
    {
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = getConnection.getconnection();
        cmd.CommandText = "select Consumer_no,Billing_Period,branch_code,amount,Payment_Date,Bank_Name from posting_voucher_qtr where Consumer_no ='"+txtconsumer.Text+"' and branch_code='"+txtbranchcode.Text+"' and amount="+Convert.ToDecimal(txtamount.Text)+" and Payment_Date='"+ Convert.ToDateTime(txtpaymentdate.Text)+"' and Bank_Name = '"+ddlbank.SelectedItem.Text+"'";
        

        SqlDataAdapter sda = new SqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        DataTable tb = new DataTable();
        sda.Fill(tb);
        sda.Fill(ds);

        gvSearch.DataSource = ds;
        gvSearch.DataBind();
        gvSearch.Visible = true;
        pnl.Visible = true;
        btnSubmit.Visible = true;
        if (Convert.ToInt16(tb.Rows.Count) <= 0)
        {
            pnl.Visible = false;
            btnsearch.Visible = false;

        }



        cmd.Dispose();
    }
}