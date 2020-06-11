using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Reflect : System.Web.UI.Page
{
    SqlCommand cmd;
    SqlDataReader sdr;
    SqlConnection conn;
    properties p = new properties();
    downs d = new downs();

    string consumer_no,old_outstanding_arrears, consumer_mobile, consumer_address,billingPeriod;
    protected void Page_Load(object sender, EventArgs e)
    {
        //if (Session["UserID"] == null)
        //{
        //    Response.Redirect("Login.aspx");
        //}
        //else
        //{
        //    string userID = Session["userID"].ToString();
        //    string password = Session["password"].ToString();
        //    int roleID = Convert.ToInt16(Session["roleID"]);
        //    bool verifiedStatus = SessionVerification.GetUserVerification(userID, password);
        //    if (verifiedStatus == false)
        //    {
        //        Server.Transfer("Login.aspx");
        //    }
        //    else
        //    {

        //    }
        //}


        //conn = new SqlConnection();
        //conn.ConnectionString = ConfigurationManager.ConnectionStrings["kmcConnectionString"].ConnectionString;
        //if (!IsPostBack)
        //{
        //    ddlreflectiobperiod.DataSource = downs.listbillingperiod();
        //    ddlreflectiobperiod.DataTextField = "Text";
        //    ddlreflectiobperiod.DataValueField = "Value";
        //    ddlreflectiobperiod.DataBind();
        //    ddlreflectiobperiod.Items.Insert(0, "Select Billing Period");
        //}

    }
    protected void txtConsumerNo_TextChanged(object sender, EventArgs e)
    {
        //cmd = new SqlCommand("sp_select_inovice", conn);
        //cmd.CommandType = CommandType.StoredProcedure;
        //cmd.Parameters.Add("@consumer_no", SqlDbType.VarChar).Value = txtConsumerNo.Text;
        //conn.Open();
        //sdr = cmd.ExecuteReader();
        //while (sdr.Read())
        //{
        //    lblName.Text = sdr[1].ToString();
        //    lblAddress.Text = sdr[2].ToString();
        //    lblCategory.Text = sdr[3].ToString();
        //    lblArea.Text = sdr[4].ToString();
        //    lblStorey.Text = sdr[5].ToString();
        //    lblCurrentAmount.Text = sdr[6].ToString();
        //    lbloutArrears.Text = sdr[7].ToString();

        //    txtarrears.Text = sdr[7].ToString();




        //}
        //sdr.Dispose();
        //cmd.Dispose();
        //conn.Close();

    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
    }
    protected void ddlper_SelectedIndexChanged(object sender, EventArgs e)
    {
       
    }
    protected void btnverifypostingvoucher_Click(object sender, EventArgs e)
    {
        //try
        //{
            conn = new SqlConnection();
            conn.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["kmcConnectionString"].ConnectionString;

            cmd = new SqlCommand("sp_FetchScroll", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@Consumer_no", SqlDbType.VarChar).Value = txtConsumerNo.Text;
            cmd.Parameters.Add("@branch_code", SqlDbType.VarChar).Value = Convert.ToString(txtbranchcode.Text);
            cmd.Parameters.Add("@amount", SqlDbType.Decimal).Value = Convert.ToDecimal(txtpaymentamount.Text);
            cmd.Parameters.Add("@Payment_Date", SqlDbType.SmallDateTime).Value = Convert.ToDateTime(txtpaymentdate.Text);
            cmd.Parameters.Add("@Bank_Name", SqlDbType.VarChar).Value = ddlbank.SelectedValue.ToString();
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();


            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            DataTable tb = new DataTable();
            sda.Fill(tb);
            sda.Fill(ds);
        gvposting.Visible = false;

            cmd = new SqlCommand("sp_select_inovice", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@consumer_no", SqlDbType.VarChar).Value = txtConsumerNo.Text;
            conn.Open();
            sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
            lblName.Text = sdr[1].ToString();
            lblAddress.Text = sdr[2].ToString();
            lblCategory.Text = sdr[3].ToString();
            lblArea.Text = sdr[4].ToString();
            lblStorey.Text = sdr[5].ToString();
            lblCurrentAmount.Text = sdr[6].ToString();
            lbloutArrears.Text = sdr[7].ToString();
            }
            sdr.Dispose();
            cmd.Dispose();
            conn.Close();

        if (Convert.ToInt16(tb.Rows.Count) > 0)
        {
            billingPeriod = tb.Rows[0][1].ToString();
            gvSearch.DataSource = ds;
            gvSearch.DataBind();
            gvSearch.Visible = true;
            pnlcheckrebate.Visible = true;
        }


        else if (Convert.ToInt16(tb.Rows.Count) <= 0)
            {
                gvSearch.DataSource = null;
                gvSearch.DataBind();
                gvSearch.Visible = false;
                pnlcheckrebate.Visible = true;

            }
        else if (lbloutArrears.Text == null)
        {
            txtbranchcode.Text = null;
            txtpaymentdate.Text = null;
            ddlbank.SelectedValue = "0";
            txtpaymentamount.Text = null;
            txtConsumerNo.Text = null;
            gvSearch.DataSource = null;
            gvSearch.DataBind();
            gvSearch.Visible = false;
            pnlcheckrebate.Visible = false;
        }
            cmd.Dispose();
        //}
        //catch
        //{

        //}
    }

    protected void btnReset_Click(object sender, EventArgs e)
    {
        // Verify Consumer Reset
        txtpaymentamount.Text = null;
        txtConsumerNo.Text = null;
        gvSearch.DataSource = null;
        gvSearch.DataBind();
        gvSearch.Visible = false;
        pnlcheckrebate.Visible = false;
        pnlpostingvoucher.Visible = false;
        pnlreflect.Visible = false;
        pnlreflect2.Visible = false;
    }

    protected void txtcheckcanclerebate_Click(object sender, EventArgs e)
    {
        try
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = getConnection.getconnection();
                cmd.CommandText = "select inwordno,consumer_no,pervious_outstanding,after_rebate_outstanding,difference,cancledby,cast(cancledon as date) as cancledon from Rebate_cancle_history where Consumer_no = '" + txtConsumerNo.Text + "'";

                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                DataTable tb = new DataTable();
                sda.Fill(tb);
                sda.Fill(ds);

                gvcheckrebate.DataSource = ds;
                gvcheckrebate.DataBind();
                gvcheckrebate.Visible = true;
                pnlcheckrebate.Visible = true;
                pnlreflect.Visible = true;
                pnlreflect2.Visible = false;
                pnlpostingvoucher.Visible = true;

                if (Convert.ToInt16(tb.Rows.Count) <= 0)
                {
                    pnlpostingvoucher.Visible = true;
                    pnlreflect2.Visible = true;
                    pnlreflect.Visible = false;
                    lblrebateerror.Text = "No Record In Rebate Cancled History";
                    lblrebateerror.Visible = true;
                }

                cmd.Dispose();
            }

            
        }
        catch
        {

        }
    }

    protected void txtcheckrebate_Click(object sender, EventArgs e)
    {
        //try
        //{
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = getConnection.getconnection();
            cmd.CommandText = "select consumer_no,consumer_name,outstanding_Arrears,after_rebate,createdby,createdon from consumer_rebate where consumer_no = '" + txtConsumerNo.Text + "'";

            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            DataTable tb = new DataTable();
            sda.Fill(tb);
            sda.Fill(ds);

            gvcheckrebate2.DataSource = ds;
            gvcheckrebate2.DataBind();
            gvcheckrebate2.Visible = true;
            gvcheckrebate.Visible = false;
            pnlcheckrebate.Visible = true;
            pnlreflect.Visible = true;
            pnlreflect2.Visible = false;
            pnlpostingvoucher.Visible = true;
            if (Convert.ToInt16(tb.Rows.Count) <= 0)
            {
                pnlreflect2.Visible = true;
                pnlreflect.Visible = false;
                lblrebateerror.Text = "No Record In Rebate Issued History";
                lblrebateerror.Visible = true;
                pnlpostingvoucher.Visible = true;
        }

            cmd.Dispose();
        //}
        //catch
        //{

        //}
    }

    protected void btnsubmit_Click(object sender, EventArgs e)
    {
        conn = new SqlConnection();
        conn.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["kmcConnectionString"].ConnectionString;

        cmd = new SqlCommand("sp_payment_reflection_new", conn);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.Add("@consumer_no", SqlDbType.VarChar).Value = txtConsumerNo.Text;
        cmd.Parameters.Add("@arrears", SqlDbType.Decimal).Value = 0;
        cmd.Parameters.Add("@createdby", SqlDbType.VarChar).Value = "aa";
        cmd.Parameters.Add("@rebate_status", SqlDbType.VarChar).Value = 1;
        conn.Open();
        cmd.ExecuteNonQuery();
        conn.Close();


        //cmd = new SqlCommand("sp_upate_payment_history", conn);

        //cmd.CommandType = CommandType.StoredProcedure;
        //cmd.Parameters.Add("@consumer_no", SqlDbType.VarChar).Value = txtConsumerNo.Text;
        //cmd.Parameters.Add("@amount", SqlDbType.Decimal).Value = Convert.ToDouble(txtpaymentamount.Text);
        //cmd.Parameters.Add("@date", SqlDbType.DateTime).Value = Convert.ToDateTime(txtpaymentdate.Text);
        //cmd.Parameters.Add("@period", SqlDbType.VarChar).Value = "APRIL,2019";
        //conn.Open();
        //cmd.ExecuteNonQuery();
        //conn.Close();
        
        cmd.Dispose();



    }

    protected void btncancle_Click(object sender, EventArgs e)
    {
        conn = new SqlConnection();
        conn.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["kmcConnectionString"].ConnectionString;

        cmd = new SqlCommand("sp_payment_reflection_new", conn);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.Add("@consumer_no", SqlDbType.VarChar).Value = txtConsumerNo.Text;
        cmd.Parameters.Add("@arrears", SqlDbType.Decimal).Value = (Convert.ToDecimal(lbloutArrears.Text) - Convert.ToDecimal(txtpaymentamount.Text)) + Convert.ToDecimal(8);
        cmd.Parameters.Add("@createdby", SqlDbType.VarChar).Value = "aa";
        cmd.Parameters.Add("@rebate_status", SqlDbType.VarChar).Value = 0;
        conn.Open();
        cmd.ExecuteNonQuery();
        conn.Close();



        //cmd = new SqlCommand("sp_upate_payment_history", conn);

        //cmd.CommandType = CommandType.StoredProcedure;
        //cmd.Parameters.Add("@consumer_no", SqlDbType.VarChar).Value = txtConsumerNo.Text;
        //cmd.Parameters.Add("@amount", SqlDbType.Decimal).Value = Convert.ToDouble(txtpaymentamount.Text);
        //cmd.Parameters.Add("@date", SqlDbType.DateTime).Value = Convert.ToDateTime(txtpaymentdate.Text);
        //cmd.Parameters.Add("@period", SqlDbType.VarChar).Value = "APRIL,2019";
        //conn.Open();
        //cmd.ExecuteNonQuery();
        //conn.Close();

    }

    protected void btnpostingvoucher_Click(object sender, EventArgs e)
    {
        gvposting.Visible = false;
        conn = new SqlConnection();
        conn.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["kmcConnectionString"].ConnectionString;

        cmd = new SqlCommand("sp_insertscrolls2", conn);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.Add("@Consumer_no", SqlDbType.VarChar).Value = txtConsumerNo.Text;
        cmd.Parameters.Add("@Billing_Period", SqlDbType.VarChar).Value = txtbillingperiod.Text;
        cmd.Parameters.Add("@branch_code", SqlDbType.VarChar).Value = Convert.ToString(txtbranchcode.Text);
        cmd.Parameters.Add("@amount", SqlDbType.Decimal).Value = Convert.ToDecimal(txtpaymentamount.Text);
        cmd.Parameters.Add("@Payment_Date", SqlDbType.SmallDateTime).Value = Convert.ToDateTime(txtpaymentdate.Text); ;
        cmd.Parameters.Add("@Bank_Name", SqlDbType.VarChar).Value = ddlbank.SelectedValue.ToString();
        cmd.Parameters.Add("@createdby", SqlDbType.VarChar).Value = "aa";

        cmd.Parameters.Add("@FTP_Provided", SqlDbType.VarChar).Value = "NOT PROVIDED";
        cmd.Parameters.Add("@Scroll_Provided", SqlDbType.VarChar).Value = "BANK SCROLL PROVIDED BY CONSUMER";
        conn.Open();
        cmd.ExecuteNonQuery();
        conn.Close();


        cmd = new SqlCommand("sp_FetchScroll", conn);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.Add("@Consumer_no", SqlDbType.VarChar).Value = txtConsumerNo.Text;
        cmd.Parameters.Add("@branch_code", SqlDbType.VarChar).Value = Convert.ToString(txtbranchcode.Text);
        cmd.Parameters.Add("@amount", SqlDbType.Decimal).Value = Convert.ToDecimal(txtpaymentamount.Text);
        cmd.Parameters.Add("@Payment_Date", SqlDbType.SmallDateTime).Value = Convert.ToDateTime(txtpaymentdate.Text);
        cmd.Parameters.Add("@Bank_Name", SqlDbType.VarChar).Value = ddlbank.SelectedValue.ToString();
        conn.Open();
        cmd.ExecuteNonQuery();
        conn.Close();


        SqlDataAdapter sda = new SqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        DataTable tb = new DataTable();
        sda.Fill(tb);
        sda.Fill(ds);
        gvposting.DataSource = ds;
        gvposting.DataBind();
        gvposting.Visible = true;

    }
}