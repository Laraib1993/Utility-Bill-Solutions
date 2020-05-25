using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class rebate : System.Web.UI.Page
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
        btnSubmit.Visible = false;

        conn = new SqlConnection();
        conn.ConnectionString = ConfigurationManager.ConnectionStrings["kmcConnectionString"].ConnectionString;
       

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
            lblrebate.Text = sdr[9].ToString();
            txtarrears.Text = sdr[7].ToString();




        }
        sdr.Dispose();
        cmd.Dispose();
        conn.Close();

        double x, y, z;
        //x = Math.Round(Convert.ToDouble(lbloutArrears.Text) - (Convert.ToDouble(lbloutArrears.Text) * 0.25f));
        y = Math.Round((Convert.ToDouble(lbloutArrears.Text) * 0.15f));
        z = Math.Round((y * 100) / Convert.ToDouble(lbloutArrears.Text));

        lblrefected.Text = y.ToString();
        lblafterreflection.Text = x.ToString();
        lblpercent.Text = z.ToString();
        btnSubmit.Visible = false;
        btnVerify.Visible = true;
        //if (lblrebate.Text == "1")
        //{
        //    btnSubmit.Visible = false;
        //    lblmessage.Text = "Already Taken";
        //    lblmessage.ForeColor = System.Drawing.Color.Red;
        //}
        //else
        //{

        //}
    }



    protected void btnSubmit_Click(object sender, EventArgs e)
    {

        try
        {
                if (txtConsumerNo.Text != null && ddlper.SelectedValue != "0" && txtarrears.Text !="")
                {

                    cmd = new SqlCommand("sp_rebate", conn);
                    cmd.CommandType = CommandType.StoredProcedure;


                    cmd.Parameters.Add("@consumer_no", SqlDbType.VarChar).Value = txtConsumerNo.Text;
                    cmd.Parameters.Add("@after_rebate", SqlDbType.Decimal).Value = Convert.ToDouble(lblafterreflection.Text);
                    cmd.Parameters.Add("@createdby", SqlDbType.VarChar).Value = Session["UserID"];

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();


                    cmd = new SqlCommand("sp_rebate_reflect", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@consumer_no", SqlDbType.VarChar).Value = txtConsumerNo.Text;
                    cmd.Parameters.Add("@arrears", SqlDbType.Decimal).Value = Convert.ToDouble(lblafterreflection.Text);
                    cmd.Parameters.Add("@difference", SqlDbType.Decimal).Value = Convert.ToDouble(lblrefected.Text);
                    cmd.Parameters.Add("@per", SqlDbType.Decimal).Value = Convert.ToDouble(lblpercent.Text);
                    cmd.Parameters.Add("@curr_arrear", SqlDbType.Decimal).Value = Convert.ToDouble(ddlper.SelectedValue);
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
		

        catch
        {
            lblmessage.Text = "Issue in Service";
            lblmessage.ForeColor = System.Drawing.Color.Red;
        }
    }

    protected void btnReset_Click(object sender, EventArgs e)
    {
        Response.Redirect(Request.Url.ToString());
    }

    protected void btnVerify_Click(object sender, EventArgs e)
    {
        if (txtarrears.Text != "0.00")
        {
            if (lblrebate.Text == "1")
            {
                btnSubmit.Visible = false;
                lblmessage.Text = "Already Taken";
                lblmessage.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                btnSubmit.Visible = true;
            }
        }
        else
        {
            btnSubmit.Visible = false;
            lblmessage.Text = "Zero Arrears";
            lblmessage.ForeColor = System.Drawing.Color.Red;
        }
    }
}








    




   
