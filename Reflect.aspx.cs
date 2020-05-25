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

            txtarrears.Text = sdr[7].ToString();




        }
        sdr.Dispose();
        cmd.Dispose();
        conn.Close();

    }



    protected void btnSubmit_Click(object sender, EventArgs e)
    {

        //try
        //{
            if (ddlModify.SelectedValue == "1")
            {
                if (txtInword.Text !="" && txtreflect.Text != "" && txtDescription.Text != "" && ddlper.SelectedValue != "0" && ddlModify.SelectedValue != "0" && ddlreflectiobperiod.SelectedValue != "0" && txttodate.Text != "")
                {

                    cmd = new SqlCommand("sp_payment_reflection", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@inword_no", SqlDbType.VarChar).Value = txtInword.Text;
                    cmd.Parameters.Add("@modification_status", SqlDbType.VarChar).Value = ddlModify.SelectedItem.Text;
                    cmd.Parameters.Add("@consumer_no", SqlDbType.VarChar).Value = txtConsumerNo.Text;
                    cmd.Parameters.Add("@arrears", SqlDbType.Decimal).Value = Convert.ToDouble(lblafterreflection.Text);
                    cmd.Parameters.Add("@difference", SqlDbType.Decimal).Value = Convert.ToDouble(txtreflect.Text);
                    cmd.Parameters.Add("@per", SqlDbType.Decimal).Value = Convert.ToDouble(lblpercent.Text);
                    cmd.Parameters.Add("@curr_arrear", SqlDbType.Decimal).Value = Convert.ToDouble(ddlper.SelectedValue);
                    cmd.Parameters.Add("@description", SqlDbType.VarChar).Value = txtDescription.Text;
                    cmd.Parameters.Add("@createdby", SqlDbType.VarChar).Value = Session["UserID"];

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();

                    cmd = new SqlCommand("sp_upate_payment_history", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@consumer_no", SqlDbType.VarChar).Value = txtConsumerNo.Text;
                    cmd.Parameters.Add("@amount", SqlDbType.Decimal).Value = Convert.ToDouble(txtreflect.Text);
                    cmd.Parameters.Add("@date", SqlDbType.DateTime).Value = Convert.ToDateTime(txttodate.Text);
                    cmd.Parameters.Add("@period", SqlDbType.VarChar).Value = ddlreflectiobperiod.SelectedItem.Text;


                    conn.Open();
                    cmd.CommandTimeout = 150;
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

            else if (ddlModify.SelectedValue == "2")
            {
                if (txtInword.Text != "" && txtreflect.Text != "" && txtDescription.Text != "" && ddlper.SelectedValue != "0" && ddlModify.SelectedValue != "0")
                {

                    cmd = new SqlCommand("sp_payment_reflection", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@inword_no", SqlDbType.VarChar).Value = txtInword.Text;
                    cmd.Parameters.Add("@modification_status", SqlDbType.VarChar).Value = ddlModify.SelectedItem.Text;
                    cmd.Parameters.Add("@consumer_no", SqlDbType.VarChar).Value = txtConsumerNo.Text;
                    cmd.Parameters.Add("@arrears", SqlDbType.Decimal).Value = Convert.ToDouble(lblafterreflection.Text);
                    cmd.Parameters.Add("@difference", SqlDbType.Decimal).Value = Convert.ToDouble(txtreflect.Text);
                    cmd.Parameters.Add("@per", SqlDbType.Decimal).Value = Convert.ToDouble(lblpercent.Text);
                    cmd.Parameters.Add("@curr_arrear", SqlDbType.Decimal).Value = Convert.ToDouble(ddlper.SelectedValue);
                    cmd.Parameters.Add("@description", SqlDbType.VarChar).Value = txtDescription.Text;
                    cmd.Parameters.Add("@createdby", SqlDbType.VarChar).Value = Session["UserID"];

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
        //}

        //catch
        //{
        //    lblmessage.Text = "Issue in Service";
        //    lblmessage.ForeColor = System.Drawing.Color.Red;
        //}




    }



    protected void ddlper_SelectedIndexChanged(object sender, EventArgs e)
    {
        double x, y;
        x = (Convert.ToDouble(lbloutArrears.Text) - Convert.ToDouble(txtreflect.Text)) - (Convert.ToDouble(lblCurrentAmount.Text) * 0.10);
        y = Math.Round((Convert.ToDouble(txtreflect.Text) * 100) / Convert.ToDouble(lbloutArrears.Text));

        lblpercent.Text = y.ToString();
        lblafterreflection.Text = x.ToString();
    }
}