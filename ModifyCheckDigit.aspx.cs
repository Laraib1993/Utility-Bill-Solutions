using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ModifyCheckDigit : System.Web.UI.Page
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

   



    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        
      try 
        {
         
            cmd = new SqlCommand("sp_update_checkDigit", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@consumer_no", SqlDbType.VarChar).Value = txtConsumerNo.Text;
            

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

            btnSubmit.Visible = false;
            lblmessage.Text = "Update Successfully";
        }
        catch
        {
            lblmessage.Text = "Issue in Updation";
        }



    }



    protected void btnReset_Click(object sender, EventArgs e)
    {
        Response.Redirect(Request.Url.ToString());
    }
}