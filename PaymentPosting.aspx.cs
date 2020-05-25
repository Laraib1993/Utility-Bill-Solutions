using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class PaymentPosting : System.Web.UI.Page
{
    properties p = new properties();
    downs d = new downs();

    protected void Page_Load(object sender, EventArgs e)
    {
        try
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
                bool verifiedStatus = SessionVerification.GetSpecificVerification(userID, password);
                if (verifiedStatus == false)
                {
                    Server.Transfer("Login.aspx");
                }
                else
                {

                }
            }
        }
        catch
        {

        }


        if (!IsPostBack)
        {

           

        }



    }

    protected void btnFindcon_Click(object sender, EventArgs e)
    {
        try
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = getConnection.getconnection();
            cmd.CommandText = "select * from posting_voucher where Consumer_no = '" + txtFindConsumer.Text + "'";

            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sda.Fill(ds);

            gvSearch.DataSource = ds;
            gvSearch.DataBind();
            gvSearch.Visible = true;

            cmd.Dispose();
        }
        catch
        {

        }
    }


    
    

    

    
   

}