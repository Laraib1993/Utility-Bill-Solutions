using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

public partial class ModificationDeleteConsumer : System.Web.UI.Page
{
    properties p = new properties();
    uploading insert = new uploading();
    downs d = new downs();
    SqlCommand cmd;
    SqlConnection conn;
    SqlDataReader sdr;
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
        p.AdminInsertDeleteConsumer_Inwordno = txtInword.Text;
        p.AdminInsertDeleteConsumer_InwordnoForModifyImpact = txtInword.Text;
        p.AdminInsertDeleteConsumer_Consumerno = txtConsumerNo.Text;
        p.AdminInsertDeleteConsumer_ConsumernoDeleteConsumer = txtConsumerNo.Text;
        p.AdminInsertDeleteConsumer_ConsumernoConsumer = txtConsumerNo.Text;
        p.AdminInsertDeleteConsumer_ModificationStatus = "Delete ID";
        p.AdminInsertDeleteConsumer_ModificationStatusModifyImpact = "Delete ID";
        p.AdminInsertDeleteConsumer_Createdby = Convert.ToString(Session["UserID"]);
        p.AdminInsertDeleteConsumer_CreatedbyModifyImpact = Convert.ToString(Session["UserID"]);
        p.AdminInsertDeleteConsumer_Description = "Delete Consumer " + lbloldcategory.InnerText + "(" +
            lbloldkmccategory.InnerText + "), previously it was charged on " + lbloldarea.InnerText + " " +
            lblsqy_sqft.InnerText + " with (" +
            lblstorey.InnerText + ") storey, Update Approved by modifications committee for data of (MUCT) bearing Inword # " +
            txtInword.Text + " Dated " + txtinworddate.Text + ".";
        p.AdminInsertDeleteConsumer_DescriptionModifyImpact = "Delete Consumer "+lbloldcategory.InnerText+ "("+
            lbloldkmccategory.InnerText+ "), previously it was charged on "+lbloldarea.InnerText+" "+
            lblsqy_sqft.InnerText+" with ("+
            lblstorey.InnerText+") storey, Update Approved by modifications committee for data of (MUCT) bearing Inword # "+
            txtInword.Text+" Dated "+txtinworddate.Text+".";
        p.AdminInsertDeleteConsumer_Impact = ddlimpact.SelectedValue;

        insert.AdminInsertUpdateDeleteConsumer(p);
        ddlimpact.SelectedIndex = 0;
        txtConsumerNo.Text = null;
        txtInword.Text = null;
        txtinworddate.Text = null;
        btnModify.Visible = false;
    }

    protected void txtConsumerNo_TextChanged(object sender, EventArgs e)
    {
        using (conn = new SqlConnection())
        {
            using (cmd = new SqlCommand())
            {
                cmd.Connection = getConnection.getconnection();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "selectInvoice";
                cmd.Parameters.Add("@consumer_no", SqlDbType.VarChar).Value = txtConsumerNo.Text;
                sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    lbloldarea.InnerText = sdr[5].ToString();
                    lblsqy_sqft.InnerText = sdr[6].ToString();
                    lbloldcategory.InnerText = sdr[4].ToString();
                    lbloldkmccategory.InnerText = sdr[22].ToString();
                    lbloldouttanding.InnerText = sdr[17].ToString();
                    lblstorey.InnerText = sdr[7].ToString();

                }
                sdr.Dispose();
            }
        }
    }

    protected void btnReset_Click(object sender, EventArgs e)
    {
        ddlimpact.SelectedIndex = 0;
        txtConsumerNo.Text = null;
        txtInword.Text = null;
        txtinworddate.Text = null;
        btnModify.Visible = true;
    }
}