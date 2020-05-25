using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

public partial class ModificationDeleteStorey : System.Web.UI.Page
{
    properties p = new properties();
    uploading insert = new uploading();
    downs d = new downs();
    SqlCommand cmd;
    SqlConnection conn;
    SqlDataReader sdr;
    int storeydiff;
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
        p.AdminInsertDeleteStorey_InwordNo = txtInword.Text;
        p.AdminInsertDeleteStorey_InwordNoModifyImpact = txtInword.Text;
        p.AdminInsertDeleteStorey_ConsumerNo = txtConsumerNo.Text;
        p.AdminInsertDeleteStorey_ConsumernoConsumer = txtConsumerNo.Text;
        p.AdminInsertDeleteStorey_ConsumernoInvoice = txtConsumerNo.Text;
        p.AdminInsertDeleteStorey_ModificationStatus = "Delete Storey";
        p.AdminInsertDeleteStorey_ModificatioStatusModifyImpact = "Delete Storey";
        p.AdminInsertDeleteStorey_NewStorey = Convert.ToInt32(txtNewStorey.Text);
        p.AdminInsertDeleteStorey_NewCurrentCharge = (Convert.ToDecimal(txtNewCurrent.Text))*2;
        p.AdminInsertDeleteStorey_NewOutstandingArrears = Convert.ToDecimal(txtNewOutstanding.Text);
        p.AdminInsertDeleteStorey_Createdby = Convert.ToString(Session["UserID"]);
        p.AdminInsertDeleteStorey_CreatedbyModifyImpact = Convert.ToString(Session["UserID"]);
        storeydiff = Convert.ToInt16(lblstorey.InnerText) - Convert.ToInt16(txtNewStorey.Text);
        p.AdminInsertDeleteStorey_Description = "Deleted ("+storeydiff+") storey,previously it was charged on ("+lblstorey.InnerText+") Storey, Update approved by modifications committee for data of MUCT (KMC) bearing Inword # " + txtInword.Text+" Dated "+txtinworddate.Text+".";
        p.AdminInsertDeleteStorey_DescriptionModifyImpact = "Deleted (" + storeydiff + ") storey,previously it was charged on (" + lblstorey.InnerText + ") Storey, Update approved by modifications committee for data of MUCT (KMC) bearing Inword # " + txtInword.Text + " Dated " + txtinworddate.Text + ".";
        difference = Convert.ToDecimal(lbloldouttanding.InnerText) - Convert.ToDecimal(txtNewOutstanding.Text);
        p.AdminInsertDeleteStorey_Difference = Convert.ToDecimal(difference);
        p.AdminInsertDeleteStorey_Impact = ddlimpact.SelectedValue;
        insert.AdminInsertUpdateDeleteStorey(p);
        btnModify.Visible = false;
        txtConsumerNo.Text = null;
        txtInword.Text = null;
        txtinworddate.Text = null;
        txtNewCurrent.Text = null;
        txtNewOutstanding.Text = null;
        txtNewStorey.Text = null;

    }

    protected void btnReset_Click(object sender, EventArgs e)
    {
        btnModify.Visible = true;
        txtConsumerNo.Text = null;
        txtInword.Text = null;
        txtinworddate.Text = null;
        txtNewCurrent.Text = null;
        txtNewOutstanding.Text = null;
        txtNewStorey.Text = null;
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
                        lblstorey.InnerText = sdr[7].ToString();
                        lbloldouttanding.InnerText = sdr[17].ToString();
                }
                sdr.Dispose();
            }
        }
    }
}