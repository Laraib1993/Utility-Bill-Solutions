using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

public partial class ChangeInSize : System.Web.UI.Page
{
    properties p = new properties();
    uploading insert = new uploading();
    downs d = new downs();
    SqlCommand cmd;
    SqlConnection conn;
    SqlDataReader sdr;
    decimal difference;
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
        if (lblsqy_sqft.InnerText == "Sq.Ft")
        {
            p.AdminInsertChangeInSize_Sqyd = Convert.ToDecimal(0);
            p.AdminInsertChangeInSize_Sqft = Convert.ToDecimal(txtNewArea.Text);
        }
        else if (lblsqy_sqft.InnerText == "Sq.Yd")
        {
            p.AdminInsertChangeInSize_Sqyd = Convert.ToDecimal(txtNewArea.Text);
            p.AdminInsertChangeInSize_Sqft = Convert.ToDecimal(0);
        }
        p.AdminInsertChangeInSize_InwordNo = txtInwordNo.Text;
        p.AdminInsertChangeInSize_InwordmodifyImpact = txtInwordNo.Text;
        p.AdminInsertChangeInSize_Consumerno = txtConsumerNo.Text;
        p.AdminInsertChangeInSize_ConsumernoInvoice = txtConsumerNo.Text;
        p.AdminInsertChangeInSize_ConsumernoConsumer = txtConsumerNo.Text;
        p.AdminInsertChangeInSize_ModificationStatus = "Change of size";
        p.AdminInsertChangeInSize_ModificationStatusModifyimpact = "Change of size";
        p.AdminInsertChangeInSize_NewArea = Convert.ToDecimal(txtNewArea.Text);
        p.AdminInsertChangeInSize_AreaForConsumer = Convert.ToDecimal(txtNewArea.Text);
        p.AdminInsertChangeInSize_NewCurrentCharge = (Convert.ToDecimal(txtNewCurrent.Text))*2;
        p.AdminInsertChangeInSize_NewOutstandingArrears = Convert.ToDecimal(txtNewOutstanding.Text);
        p.AdminInsertChangeInSize_Createdby = Convert.ToString(Session["UserID"]);
        p.AdminInsertChangeInSize_CreatedbyModifyImpact = Convert.ToString(Session["UserID"]);
        p.AdminInsertChangeInSize_Description = ""+ddlsizetype.SelectedValue+" Size to "+txtNewArea.Text+" "+ lblsqy_sqft.InnerText + ", previously it was charged on "+lbloldarea.InnerText+" " + lblsqy_sqft.InnerText + ", Update as Approved by modifications committee for data of (MUCT) bearing Inword # " + txtInwordNo.Text+" Dated "+txtinworddate.Text+".";
        p.AdminInsertChangeInSize_DescriptionModifyImpact = "" + ddlsizetype.SelectedValue + " Size to " + txtNewArea.Text + " " + lblsqy_sqft.InnerText + ", previously it was charged on " + lbloldarea.InnerText + " " + lblsqy_sqft.InnerText + ", Update as Approved by modifications committee for data of (MUCT) bearing Inword # " + txtInwordNo.Text + " Dated " + txtinworddate.Text + ".";
        difference = Convert.ToDecimal(lbloldouttanding.InnerText) - Convert.ToDecimal(txtNewOutstanding.Text);
        p.AdminInsertChangeInSize_Difference = Convert.ToDecimal(difference);
        p.AdminInsertChangeInSize_Impact = ddlimpact.SelectedValue;
        insert.AdminInsertUpdateChangeInSize(p);
        btnModify.Visible = false;
        txtConsumerNo.Text = null;
        txtinworddate.Text = null;
        txtInwordNo.Text = null;
        txtNewArea.Text = null;
        txtNewCurrent.Text = null;
        txtNewOutstanding.Text = null;
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
                }
                sdr.Dispose();
            }
        }
    }

    protected void btnReset_Click(object sender, EventArgs e)
    {

    }
}