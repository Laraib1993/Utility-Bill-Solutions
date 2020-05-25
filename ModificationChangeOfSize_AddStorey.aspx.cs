using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

public partial class ModificationChangeOfSize_AddStorey : System.Web.UI.Page
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
        
        p.AdminInsertChangeSizeAddStorey_Inword = txtInword.Text;
        p.AdminInsertChangeSizeAddStorey_InwordModifyImpact = txtInword.Text;
        p.AdminInsertChangeSizeAddStorey_ConsumerNo = txtConsumerNo.Text;
        p.AdminInsertChangeSizeAddStorey_ConsumernoConsumer = txtConsumerNo.Text;
        p.AdminInsertChangeSizeAddStorey_ConsumernoInvoice = txtConsumerNo.Text;
        p.AdminInsertChangeSizeAddStorey_ModificationStatus = "Change Of Size and Storey";
        p.AdminInsertChangeSizeAddStorey_ModificationStatusModifyImpact = "Change Of Size and Storey";
        p.AdminInsertChangeSizeAddStorey_NewArea = Convert.ToDecimal(txtNewArea.Text);
        p.AdminInsertChangeSizeAddStorey_AreaForConsumer = Convert.ToDecimal(txtNewArea.Text);
        p.AdminInsertChangeSizeAddStorey_NewStorey = Convert.ToInt32(txtNewStorey.Text);
        p.AdminInsertChangeSizeAddStorey_NewCurrentCharge = (Convert.ToDecimal(txtNewCurrent.Text))*2;
        p.AdminInsertChangeSizeAddStorey_NewOutstandingArrears = Convert.ToDecimal(txtNewOutstanding.Text);
        p.AdminInsertChangeSizeAddStorey_Createdby = Convert.ToString(Session["UserID"]);
        p.AdminInsertChangeSizeAddStorey_CreatedbyModifyImpact = Convert.ToString(Session["UserID"]);

        p.AdminInsertChangeSizeAddStorey_Description = ""+ddlsizetype.SelectedValue+" Size to "+txtNewArea.Text+" ("+ 
            lblsqy_sqft.InnerText + ") & Change of storey to ("+txtNewStorey.Text+ ") Storey, previously it was charged on "+
            lbloldarea.InnerText+" ("+lblsqy_sqft.InnerText+") with the storey of ("+
            lblstorey.InnerText+"), Update approved by modifications committee for data of MUCT (KMC) bearing Inword # "+
            txtInword.Text+" Dated "+txtinworddate.Text+".";

        p.AdminInsertChangeSizeAddStorey_DescriptionModifyImpact = "" + ddlsizetype.SelectedValue + " Size to " + txtNewArea.Text + " (" +
            lblsqy_sqft.InnerText + ") & Change of storey to (" + txtNewStorey.Text + ") Storey, previously it was charged on " +
            lbloldarea.InnerText + " (" + lblsqy_sqft.InnerText + ") with the storey of (" +
            lblstorey.InnerText + "), Update approved by modifications committee for data of MUCT (KMC) bearing Inword # " +
            txtInword.Text + " Dated " + txtinworddate.Text + ".";

        difference = Convert.ToDecimal(lbloldouttanding.InnerText) - Convert.ToDecimal(txtNewOutstanding.Text);
        p.AdminInsertChangeSizeAddStorey_Difference = Convert.ToDecimal(difference);
        p.AdminInsertChangeSizeAddStorey_Impact = ddlimpact.SelectedValue;
        p.AdminInsertChangeSizeAddStorey_sqydft = lblsqy_sqft.InnerText;
        if (lblsqy_sqft.InnerText == "Sq.Yd")
        {
            p.AdminInsertChangeSizeAddStorey_sqft = Convert.ToDecimal(0);
            p.AdminInsertChangeSizeAddStorey_sqyd = Convert.ToDecimal(txtNewArea.Text);
        }

        else if (lblsqy_sqft.InnerText == "Sq.Ft")
        {
            p.AdminInsertChangeSizeAddStorey_sqft = Convert.ToDecimal(txtNewArea.Text);
            p.AdminInsertChangeSizeAddStorey_sqyd = Convert.ToDecimal(0);
        }

        


    insert.AdminInsertUpdateChangeSizeAddStorey(p);

        lbldescription.InnerText = p.AdminInsertChangeSizeAddStorey_DescriptionModifyImpact;

        txtConsumerNo.Text = null;
        txtInword.Text = null;
        txtinworddate.Text = null;
        txtNewArea.Text = null;
        txtNewCurrent.Text = null;
        txtNewOutstanding.Text = null;
        txtNewStorey.Text = null;
        ddlimpact.SelectedIndex = 0;
        ddlsizetype.SelectedIndex = 0;
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
                    if (sdr[4].ToString() == "Flat" || sdr[4].ToString() == "Shop")
                    {
                        lbloldarea.InnerText = null;
                        lblsqy_sqft.InnerText = null;
                        lblstorey.InnerText = null;
                        lbloldouttanding.InnerText = null;
                        btnModify.Visible = false;
                        lblMessage.Text = sdr[4].ToString() + " can not have storey";


                    }
                    else
                    {
                        lbloldarea.InnerText = sdr[5].ToString();
                        lblsqy_sqft.InnerText = sdr[6].ToString();
                        lblstorey.InnerText = sdr[7].ToString();
                        lbloldouttanding.InnerText = sdr[17].ToString();
                        lblMessage.Text = "";
                    }
                }
                sdr.Dispose();
            }
        }
    }

    protected void btnReset_Click(object sender, EventArgs e)
    {
        txtConsumerNo.Text = null;
        txtInword.Text = null;
        txtinworddate.Text = null;
        txtNewArea.Text = null;
        txtNewCurrent.Text = null;
        txtNewOutstanding.Text = null;
        txtNewStorey.Text = null;
        ddlimpact.SelectedIndex = 0;
        ddlsizetype.SelectedIndex = 0;
        btnModify.Visible = true;
    }
}