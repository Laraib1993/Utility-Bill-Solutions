using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ModifyConsumer : System.Web.UI.Page
{
    SqlCommand cmd;
    SqlDataReader sdr;
    SqlConnection conn;
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

    }

    protected void txtConsumerNo_TextChanged(object sender, EventArgs e)
    {
        cmd = new SqlCommand("sp_selectconsumser", conn);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.Add("@consumer_no", SqlDbType.VarChar).Value = txtConsumerNo.Text;
        conn.Open();
        sdr = cmd.ExecuteReader();
        while (sdr.Read())
        {
            txtConsumerName.Text = sdr[1].ToString();
            txtFatherName.Text = sdr[2].ToString();
            txtCNIC.Text = sdr[3].ToString();
            txtMobile.Text = sdr[4].ToString();
            txtAddress.Text = sdr[5].ToString();
            //lblCurrentAmount.Text = sdr[8].ToString();
            ////txtTown.Text = sdr[9].ToString();
            //lblArears.Text = sdr[9].ToString();
            ////txtArears.Text = sdr[6].ToString();
            //lblTotalAmount.Text = sdr[11].ToString();
            //lblPermonth.Text = sdr[12].ToString();

            
            lbltmpName.Text = txtConsumerName.Text;
            lbltmpfname.Text = txtFatherName.Text;
            lbltmpadress.Text = txtAddress.Text;
            lbltmpcnic.Text = txtCNIC.Text;
            lbltmpmobile.Text = txtMobile.Text;
            


        }
        sdr.Dispose();
        cmd.Dispose();
        conn.Close();
     
    }



    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        
        

        if(ddlModify.SelectedValue == "3")
        {
            cmd = new SqlCommand("sp_insertmodifyconsumer", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@inword_no", SqlDbType.VarChar).Value = txtInword.Text;
            cmd.Parameters.Add("@modification_status", SqlDbType.VarChar).Value = ddlModify.SelectedItem.Text;
            cmd.Parameters.Add("@consumer_no", SqlDbType.VarChar).Value = txtConsumerNo.Text;
            cmd.Parameters.Add("@consumer_name", SqlDbType.VarChar).Value = txtConsumerName.Text;
            cmd.Parameters.Add("@consumer_address", SqlDbType.VarChar).Value = txtAddress.Text;
            cmd.Parameters.Add("@consumer_fname", SqlDbType.VarChar).Value = txtFatherName.Text;
            cmd.Parameters.Add("@consumer_cnic", SqlDbType.VarChar).Value = txtCNIC.Text;
            cmd.Parameters.Add("@consumer_mobile", SqlDbType.VarChar).Value = txtMobile.Text;
            cmd.Parameters.Add("@description", SqlDbType.VarChar).Value = txtDescription.Text;
            cmd.Parameters.Add("@createdby", SqlDbType.VarChar).Value = Session["UserID"];

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

            cmd = new SqlCommand("sp_updateconsumer", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@consumer_no", SqlDbType.VarChar).Value = txtConsumerNo.Text;
            cmd.Parameters.Add("@consumer_name", SqlDbType.VarChar).Value = txtConsumerName.Text;
            cmd.Parameters.Add("@consumer_fname", SqlDbType.VarChar).Value = txtFatherName.Text;
            cmd.Parameters.Add("@consumer_cnic", SqlDbType.VarChar).Value = txtCNIC.Text;
            cmd.Parameters.Add("@consumer_mobile", SqlDbType.VarChar).Value = txtMobile.Text;
            cmd.Parameters.Add("@consumer_address", SqlDbType.VarChar).Value = txtAddress.Text;

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

            cmd = new SqlCommand("sp_modifyinvoice", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@consumer_no", SqlDbType.VarChar).Value = txtConsumerNo.Text;
            cmd.Parameters.Add("@consumer_name", SqlDbType.VarChar).Value = txtConsumerName.Text;
            cmd.Parameters.Add("@consumer_address", SqlDbType.VarChar).Value = txtAddress.Text;

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            btnSubmit.Visible = false;
            lblmessage.Text = "Add Successfully";
        }
        else if(ddlModify.SelectedValue == "2")
        {
            cmd = new SqlCommand("sp_modifyconsumer_add", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@inword_no", SqlDbType.VarChar).Value = txtInword.Text;
            cmd.Parameters.Add("@modification_status", SqlDbType.VarChar).Value = ddlModify.SelectedItem.Text;
            cmd.Parameters.Add("@consumer_no", SqlDbType.VarChar).Value = txtConsumerNo.Text;
            cmd.Parameters.Add("@consumer_address", SqlDbType.VarChar).Value = txtAddress.Text;
            cmd.Parameters.Add("@consumer_fname", SqlDbType.VarChar).Value = txtFatherName.Text;
            cmd.Parameters.Add("@consumer_cnic", SqlDbType.VarChar).Value = txtCNIC.Text;
            cmd.Parameters.Add("@consumer_mobile", SqlDbType.VarChar).Value = txtMobile.Text;
            cmd.Parameters.Add("@description", SqlDbType.VarChar).Value = txtDescription.Text;
            cmd.Parameters.Add("@createdby", SqlDbType.VarChar).Value = Session["UserID"];

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

            cmd = new SqlCommand("sp_updateconsumer", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@consumer_no", SqlDbType.VarChar).Value = txtConsumerNo.Text;
            cmd.Parameters.Add("@consumer_name", SqlDbType.VarChar).Value = txtConsumerName.Text;
            cmd.Parameters.Add("@consumer_fname", SqlDbType.VarChar).Value = txtFatherName.Text;
            cmd.Parameters.Add("@consumer_cnic", SqlDbType.VarChar).Value = txtCNIC.Text;
            cmd.Parameters.Add("@consumer_mobile", SqlDbType.VarChar).Value = txtMobile.Text;
            cmd.Parameters.Add("@consumer_address", SqlDbType.VarChar).Value = txtAddress.Text;

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

            cmd = new SqlCommand("sp_modifyinvoice", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@consumer_no", SqlDbType.VarChar).Value = txtConsumerNo.Text;
            cmd.Parameters.Add("@consumer_name", SqlDbType.VarChar).Value = txtConsumerName.Text;
            cmd.Parameters.Add("@consumer_address", SqlDbType.VarChar).Value = txtAddress.Text;

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

            btnSubmit.Visible = false;
            lblmessage.Text = "Add Successfully";
        }
        else if (ddlModify.SelectedValue == "1")
        {
            cmd = new SqlCommand("sp_modifyconsumer_name", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@inword_no", SqlDbType.VarChar).Value = txtInword.Text;
            cmd.Parameters.Add("@modification_status", SqlDbType.VarChar).Value = ddlModify.SelectedItem.Text;
            cmd.Parameters.Add("@consumer_no", SqlDbType.VarChar).Value = txtConsumerNo.Text;
            cmd.Parameters.Add("@consumer_name", SqlDbType.VarChar).Value = txtConsumerName.Text;
            cmd.Parameters.Add("@consumer_fname", SqlDbType.VarChar).Value = txtFatherName.Text;
            cmd.Parameters.Add("@consumer_cnic", SqlDbType.VarChar).Value = txtCNIC.Text;
            cmd.Parameters.Add("@consumer_mobile", SqlDbType.VarChar).Value = txtMobile.Text;
            cmd.Parameters.Add("@description", SqlDbType.VarChar).Value = txtDescription.Text;
            cmd.Parameters.Add("@createdby", SqlDbType.VarChar).Value = Session["UserID"];

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

            cmd = new SqlCommand("sp_updateconsumer", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@consumer_no", SqlDbType.VarChar).Value = txtConsumerNo.Text;
            cmd.Parameters.Add("@consumer_name", SqlDbType.VarChar).Value = txtConsumerName.Text;
            cmd.Parameters.Add("@consumer_fname", SqlDbType.VarChar).Value = txtFatherName.Text;
            cmd.Parameters.Add("@consumer_cnic", SqlDbType.VarChar).Value = txtCNIC.Text;
            cmd.Parameters.Add("@consumer_mobile", SqlDbType.VarChar).Value = txtMobile.Text;
            cmd.Parameters.Add("@consumer_address", SqlDbType.VarChar).Value = txtAddress.Text;

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

            cmd = new SqlCommand("sp_modifyinvoice", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@consumer_no", SqlDbType.VarChar).Value = txtConsumerNo.Text;
            cmd.Parameters.Add("@consumer_name", SqlDbType.VarChar).Value = txtConsumerName.Text;
            cmd.Parameters.Add("@consumer_address", SqlDbType.VarChar).Value = txtAddress.Text;

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

            btnSubmit.Visible = false;
            lblmessage.Text = "Add Successfully";
        }
        else
        {
            lblmessage.Text = "Please select Status";
        }



    }

    protected void ddlModify_SelectedIndexChanged(object sender, EventArgs e)
    {
        if(ddlModify.SelectedValue == "3")
        {
            txtAddress.ReadOnly = false;
            txtConsumerName.ReadOnly = false;
        }
        else if(ddlModify.SelectedValue == "2")
        {
            txtAddress.ReadOnly = false;
            txtConsumerName.ReadOnly = true;
        }
        else if (ddlModify.SelectedValue == "1")
        {
            txtAddress.ReadOnly = true;
        }
    }
}