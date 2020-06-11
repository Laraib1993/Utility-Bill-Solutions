using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

public partial class RefineNullAddress : System.Web.UI.Page
{
    properties p = new properties();
    uploading insert = new uploading();
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

            if (!IsPostBack)
            {
            }
            conn = new SqlConnection();
        conn.ConnectionString = ConfigurationManager.ConnectionStrings["kmcConnectionString"].ConnectionString;



    }
    }

    protected void btnModify_Click(object sender, EventArgs e)
    {
       
        
        using (cmd = new SqlCommand())
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_UpdateNullAddressinvoice";
            cmd.Connection = getConnection.getconnection();
            cmd.Parameters.AddWithValue("@consumer_address", lblkwsbaddress.InnerText);
            cmd.Parameters.AddWithValue("@consumer_no", txtFindConsumer.Text);
            cmd.Parameters.AddWithValue("@createdby", Session["UserID"].ToString());
            cmd.ExecuteNonQuery();
            lblverifyconsumer.Visible = true;
            lblverifyconsumer.Text = "Following Address ('"+lblkwsbaddress.InnerText+"') Refined From KWSB Record" ;
            lblkwsbaddress.Visible = false;
            pnladdress.Visible = false;
            btnSubmit.Enabled = false;
            btnSubmit.Visible = false;
        }
    }

    protected void btnFindadd_Click(object sender, EventArgs e)
    {
        using (SqlCommand cmd = new SqlCommand())
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_UpdateNullAddressKWSB";
            cmd.Connection = getConnection.getconnection();
            cmd.Parameters.AddWithValue("@consumer_no", txtFindConsumer.Text);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sda.Fill(ds);

            using (SqlDataReader sdr = cmd.ExecuteReader())
            {
                if (sdr.HasRows)
                {
                    while (sdr.Read())
                    {
                        lblkwsbaddress.InnerText = sdr[0] + sdr[1].ToString();
                        lblkwsbaddress.Visible = true;
                    }
                }
                else
                {
                    lblkwsbaddress.InnerText = "Consumer Not Found In KWSB Record";
                    lblkwsbaddress.Visible = true;
                    gvSearch.Visible = false;
                    lblverifyconsumer.Visible = false;
                    btnSubmit.Enabled = false;
                    btnSubmit.Visible = false;

                }
            }
        }
    }

    protected void btnReset_Click(object sender, EventArgs e)
    {
        txtFindConsumer.Text = "";
        pnladdress.Visible = false;
        lblkwsbaddress.Visible = false;
        gvSearch.Visible = false;
        lblverifyconsumer.Visible = false;
    }

    protected void btnFindcon_Click(object sender, EventArgs e)
    {
        using (SqlCommand cmd = new SqlCommand())
        {
            
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_UpdateNullAddress";
            cmd.Connection = getConnection.getconnection();
            cmd.Parameters.AddWithValue("@consumer_no", txtFindConsumer.Text);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            
            using (SqlDataReader sdr = cmd.ExecuteReader())
            {
                if (sdr.HasRows)
                {
                    while (sdr.Read())
                    {

                        if (sdr[2].ToString() == "")
                        {
                            lblverifyconsumer.Visible = true;
                            lblverifyconsumer.Text = "Consumer Verified";
                            gvSearch.DataSource = ds;
                            gvSearch.DataBind();
                            gvSearch.Visible = true;
                            pnladdress.Visible = true;
                            lblkwsbaddress.Visible = false;
                            
                        }

                        else if (sdr[2].ToString() != null)
                        {
                            lblverifyconsumer.Visible = true;
                            lblverifyconsumer.Text = "Consumer Verified";
                            gvSearch.DataSource = ds;
                            gvSearch.DataBind();
                            gvSearch.Visible =true;
                            pnladdress.Visible = true;
                        }
                    }
                }
                else
                {
                    lblverifyconsumer.Visible = true;
                    lblverifyconsumer.Text = "Consumer Not Verified";
                    gvSearch.Visible = false;
                    pnladdress.Visible = false;


                }
            }
        }
        
    }
}