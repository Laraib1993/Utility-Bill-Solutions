using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class paymentReflect : System.Web.UI.Page
{
    SqlCommand cmd;
    SqlDataReader sdr;
    SqlConnection conn;
    properties p = new properties();
    downs d = new downs();

    string consumer_no, consumer_name, consumer_fname, consumer_cnic, consumer_mobile, consumer_address;
    string inword,rebatestatus;
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


        conn = new SqlConnection();
        conn.ConnectionString = ConfigurationManager.ConnectionStrings["kmcConnectionString"].ConnectionString;
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
        try {

            cmd = new SqlCommand("sp_select_modify_impact", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@consumer_no", SqlDbType.VarChar).Value = txtConsumerNo.Text;
            conn.Open();
            sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                inword = sdr[0].ToString();
                lblName.Text = sdr[2].ToString();
                lblAddress.Text = sdr[3].ToString();
                lblCategory.Text = sdr[4].ToString();
                lblArea.Text = sdr[5].ToString();
                lblStorey.Text = sdr[6].ToString();
                lblCurrentAmount.Text = sdr[7].ToString();
                lbloutArrears.Text = sdr[8].ToString();  //Before Rebate Arrears
                lblafterreflection.Text = sdr[9].ToString();
                lblpercent.Text = sdr[11].ToString();
                lblrebatestatus.Text = sdr[12].ToString();
                lblrebateamount.Text = sdr[10].ToString();
                lbloutstanding.Text = sdr[13].ToString();
                

            }
            sdr.Dispose();
            cmd.Dispose();
            conn.Close();

            double x;
            x = Math.Round(Convert.ToDouble(lbloutstanding.Text) + Convert.ToDouble(lblrebateamount.Text));


            lblcal.Text = x.ToString();


            if (lblrebatestatus.Text == "0")
            {
                btnSubmit.Visible = false;
                lblmessage.Text = "This consumer has not taken rebate.";
                lblmessage.ForeColor = System.Drawing.Color.Red;
            }

            else if (lblrebatestatus.Text == null)
            {
                btnSubmit.Visible = false;
                lblmessage.Text = "This consumer has not taken rebate.";
                lblmessage.ForeColor = System.Drawing.Color.Red;
            }

        }
        catch (Exception ex) { }
        
       

    }



    protected void btnSubmit_Click(object sender, EventArgs e)
    {

        try
        {
            if (lblrebatestatus.Text == "1")
            {
                if (txtConsumerNo.Text != "")
                {

                    cmd = new SqlCommand("sp_cancling_rebate", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@consumer_no", SqlDbType.VarChar).Value = txtConsumerNo.Text;
                    cmd.Parameters.Add("@beforarrears", SqlDbType.Decimal).Value = Convert.ToDouble(lblcal.Text);
                    cmd.Parameters.Add("@cancleby", SqlDbType.VarChar).Value = Session["UserID"];

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();

                  
                    btnSubmit.Visible = false;
                    lblmessage.Text = "Rebate Cancled Successfully";

                }
                else
                {
                    lblmessage.Text = "Please Entry Fields";
                    lblmessage.ForeColor = System.Drawing.Color.Red;
                }
        }



            else
            {
                lblmessage.Text = "This consumer has not taken rebate.";
                lblmessage.ForeColor = System.Drawing.Color.Red;
            }
        }

        catch
        {
			lblmessage.Text = "Issue in Service";
            lblmessage.ForeColor = System.Drawing.Color.Red;
        }




    }



    protected void ddlper_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void btnverify_Click(object sender, EventArgs e)
    {
        try
        {
            cmd = new SqlCommand("sp_select_modify_impact", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@consumer_no", SqlDbType.VarChar).Value = txtConsumerNo.Text;
            conn.Open();
            sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                inword = sdr[0].ToString();
                lblName.Text = sdr[2].ToString();
                lblAddress.Text = sdr[3].ToString();
                lblCategory.Text = sdr[4].ToString();
                lblArea.Text = sdr[5].ToString();
                lblStorey.Text = sdr[6].ToString();
                lblCurrentAmount.Text = sdr[7].ToString();
                lbloutArrears.Text = sdr[8].ToString();
                lblafterreflection.Text = sdr[9].ToString();
                lblpercent.Text = sdr[11].ToString();
                lblrebatestatus.Text = sdr[12].ToString();
                lblrebateamount.Text = sdr[10].ToString();
                lbloutstanding.Text = sdr[13].ToString();





            }
            sdr.Dispose();
            cmd.Dispose();
            conn.Close();


            double x;
            x = Math.Round(Convert.ToDouble(lbloutstanding.Text) + Convert.ToDouble(lblrebateamount.Text));


            lblcal.Text = x.ToString();

            if (lblrebatestatus.Text == "0")
            {
                btnSubmit.Visible = false;
                lblmessage.Text = "This consumer has not taken rebate.";
                lblmessage.ForeColor = System.Drawing.Color.Red;
            }

            else if (lblrebatestatus.Text == null)
            {
                btnSubmit.Visible = false;
                lblmessage.Text = "This consumer has not taken rebate.";
                lblmessage.ForeColor = System.Drawing.Color.Red;
            }
        }

        catch (Exception ex) { }
        
    }

    protected void btnReset_Click(object sender, EventArgs e)
    {
        Response.Redirect("RebateCancle.aspx");
    }
}