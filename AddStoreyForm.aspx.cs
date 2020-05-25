using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

public partial class AddStoreyForm : System.Web.UI.Page
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


                //ddlZone.DataSource = downs.listZone();
                //ddlZone.DataTextField = "Text";
                //ddlZone.DataValueField = "Value";
                //ddlZone.DataBind();
                //ddlZone.Items.Insert(0, "Select Zone");

                ////ddlTown.DataSource = downs.fetchingcarmodeldropdown();
                ////ddTown.DataBind();
                ////ddlType.DataSource = downs.fetchingcartypedropdown();
                ////ddlType.DataBind();
                ////ddluserid.DataSource = downs.fetchinguserinfodropdown();
                ////ddluserid.DataBind();
                //txtTariff.Enabled = false;
                //ddlTown.Enabled = false;
                //ddlBlock.Enabled = false;
                //ddlUC.Enabled = false;
                //txtStorey.Enabled = false;
                //txtSqyard.Enabled = false;
                //ddlpropertyType.Enabled = false;


            }
            conn = new SqlConnection();
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["kmcConnectionString"].ConnectionString;



        }
    }

    protected void btnModify_Click(object sender, EventArgs e)
    {
        p.AdminInsertAddStorey_Inwordno = txtInword.Text;
        p.AdminInsertAddStorey_InwordModifyimpact = txtInword.Text;
        p.AdminInsertAddStorey_Consumerno = txtConsumerNo.Text;
        p.AdminInsertAddStorey_ConsumernoInvoice = txtConsumerNo.Text;
        p.AdminInsertAddStorey_ConsumernoConsumer = txtConsumerNo.Text;
        p.AdminInsertAddStorey_ModificationStatus = "Add Storey";
        p.AdminInsertAddStorey_ModificationStatusModifyImpact = "Add Storey";
        p.AdminInsertAddStorey_NewStorey = Convert.ToInt32(txtNewStorey.Text);
        p.AdminInsertAddStorey_NewCurrentCharge = (Convert.ToDecimal(txtNewCurrent.Text))*2;
        p.AdminInsertAddStorey_NewOutstandingArrears = Convert.ToDecimal(txtNewOutstanding.Text);
        p.AdminInsertAddStorey_Createdby = Convert.ToString(Session["UserID"]);
        p.AdminInsertAddStorey_CreatedbyModifyimpact = Convert.ToString(Session["UserID"]);
        p.AdminInsertAddStorey_Description = "Add storeys "+"("+txtNewStorey.Text+ "Story)"+" , Update approved by modifications committee for data of MUCT (KMC) bearing Inword # " + txtInword.Text + " Dated " + txtDescription.Text + ".";
        p.AdminInsertAddStorey_DescriptionModifyImpact = "Add storeys " + "(" + txtNewStorey.Text + "Story)" + " , Update approved by modifications committee for data of MUCT (KMC) bearing Inword # " + txtInword.Text + " Dated " + txtDescription.Text + ".";
        p.AdminInsertAddStorey_Difference = Convert.ToDecimal(txtDifference.Text);
        p.AdminInsertAddStorey_Impact = txtImpact.SelectedValue.ToString();

        insert.AdminInsertUpdateAddStorey(p);
        txtConsumerNo.Text = "";
        txtDescription.Text = "";
        txtDifference.Text = "";
        txtImpact.Text = "";
        txtInword.Text = "";
        txtNewCurrent.Text = "";
        txtNewOutstanding.Text = "";
        txtNewStorey.Text = "";
        
    }
}