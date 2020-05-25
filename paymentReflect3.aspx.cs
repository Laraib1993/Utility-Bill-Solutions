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
    string surcharge;
    string consumer_no, consumer_name, consumer_fname, consumer_cnic, consumer_mobile, consumer_address;
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
        if (!IsPostBack)
        {
            ddlreflectiobperiod.DataSource = downs.listbillingperiod();
            ddlreflectiobperiod.DataTextField = "Text";
            ddlreflectiobperiod.DataValueField = "Value";
            ddlreflectiobperiod.DataBind();
            ddlreflectiobperiod.Items.Insert(0, "Select Billing Period");
        }

    }

    protected void txtConsumerNo_TextChanged(object sender, EventArgs e)
    {
        
        cmd = new SqlCommand("sp_select_inovice2", conn);
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
            surcharge = sdr[10].ToString();
            txtarrears.Text = sdr[7].ToString();




        }
        sdr.Dispose();
        cmd.Dispose();
        conn.Close();

    }



    protected void btnSubmit_Click(object sender, EventArgs e)
    {

        try
        {
            if (ddlModify.SelectedValue == "1")
            {
                if (txtConsumerNo.Text != "" && txtreflect.Text != ""  && ddlper.SelectedValue != "0" && ddlModify.SelectedValue != "0" && ddlreflectiobperiod.SelectedValue != "0" && txttodate.Text != "")
                {


                    if (ddlreflectiobperiod.SelectedItem.Text == "Oct-Mar, 2019" || ddlreflectiobperiod.SelectedItem.Text == "Apr-Sep, 2018" || ddlreflectiobperiod.SelectedItem.Text == "Jul-Dec, 2016")
                    {
                        decimal doublesurcharge = (Convert.ToDecimal(surcharge)*2);
                        decimal paymentamount = Convert.ToDecimal(txtreflect.Text);
                        decimal amountwithsurcharge = paymentamount + doublesurcharge;
                        decimal newarrears = Convert.ToDecimal(lbloutArrears.Text) - amountwithsurcharge;


                        cmd = new SqlCommand("sp_payment_reflection2", conn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("@consumer_no", SqlDbType.VarChar).Value = txtConsumerNo.Text;
                        cmd.Parameters.Add("@arrears", SqlDbType.Decimal).Value = newarrears;
                        cmd.Parameters.Add("@curr_arrear", SqlDbType.Decimal).Value = Convert.ToDecimal(ddlper.SelectedValue);


                        //            conn.Open();
                        //          cmd.ExecuteNonQuery();
                        //        conn.Close();

                        cmd = new SqlCommand("sp_upate_payment_history", conn);
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.Add("@consumer_no", SqlDbType.VarChar).Value = txtConsumerNo.Text;
                        cmd.Parameters.Add("@amount", SqlDbType.Decimal).Value = Convert.ToDecimal(txtreflect.Text);
                        cmd.Parameters.Add("@date", SqlDbType.DateTime).Value = Convert.ToDateTime(txttodate.Text);
                        cmd.Parameters.Add("@period", SqlDbType.VarChar).Value = ddlreflectiobperiod.SelectedItem.Text;


                    }

                    else
                    {
                        cmd = new SqlCommand("sp_payment_reflection2", conn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("@consumer_no", SqlDbType.VarChar).Value = txtConsumerNo.Text;
                        cmd.Parameters.Add("@arrears", SqlDbType.Decimal).Value = Convert.ToDecimal(lblafterreflection.Text);
                        cmd.Parameters.Add("@curr_arrear", SqlDbType.Decimal).Value = Convert.ToDecimal(ddlper.SelectedValue);


                        //            conn.Open();
                        //          cmd.ExecuteNonQuery();
                        //        conn.Close();

                        cmd = new SqlCommand("sp_upate_payment_history", conn);
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.Add("@consumer_no", SqlDbType.VarChar).Value = txtConsumerNo.Text;
                        cmd.Parameters.Add("@amount", SqlDbType.Decimal).Value = Convert.ToDecimal(txtreflect.Text);
                        cmd.Parameters.Add("@date", SqlDbType.DateTime).Value = Convert.ToDateTime(txttodate.Text);
                        cmd.Parameters.Add("@period", SqlDbType.VarChar).Value = ddlreflectiobperiod.SelectedItem.Text;


                        //       conn.Open();
                        //     cmd.CommandTimeout = 150;
                        //   cmd.ExecuteNonQuery();
                        // conn.Close();

                    }



                    btnSubmit.Visible = false;
                    lblmessage.Text = "Add Successfully";

                }
                else
                {
                    lblmessage.Text = "Please Entry Fields";
                    lblmessage.ForeColor = System.Drawing.Color.Red;
                }
            }

            else if (ddlModify.SelectedValue == "2")
            {
                if (txtConsumerNo.Text != ""  && txtreflect.Text != "" && ddlper.SelectedValue != "0" && ddlModify.SelectedValue != "0")
                {

                    cmd = new SqlCommand("sp_payment_reflection2", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@consumer_no", SqlDbType.VarChar).Value = txtConsumerNo.Text;
                    cmd.Parameters.Add("@arrears", SqlDbType.Decimal).Value = Convert.ToDouble(lblafterreflection.Text);
                    cmd.Parameters.Add("@curr_arrear", SqlDbType.Decimal).Value = Convert.ToDouble(ddlper.SelectedValue);


                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();

                    btnSubmit.Visible = false;
                    lblmessage.Text = "Add Successfully";

                }
                else
                {
                    lblmessage.Text = "Please Entry Fields";
                    lblmessage.ForeColor = System.Drawing.Color.Red;
                }
            }

            else
            {
                lblmessage.Text = "Please select Status";
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
		if (txtConsumerNo.Text != "" && txtreflect.Text != ""  && ddlModify.SelectedValue != "0")
                {
        double x, y;
        x = (Convert.ToDouble(lbloutArrears.Text) - Convert.ToDouble(txtreflect.Text)) - (Convert.ToDouble(lblCurrentAmount.Text) * 0.05);
        y = Math.Round((Convert.ToDouble(txtreflect.Text) * 100) / Convert.ToDouble(lbloutArrears.Text));

        lblpercent.Text = y.ToString();
        lblafterreflection.Text = x.ToString();
				}
				else{
					lblmessage.Text = "Please Entry Fields";
                    lblmessage.ForeColor = System.Drawing.Color.Red;
				}
    }
}