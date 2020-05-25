using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

public partial class ModificationChangeOfCategory_DecreaseOfSize : System.Web.UI.Page
{
    properties p = new properties();
    uploading insert = new uploading();
    downs d = new downs();
    SqlCommand cmd;
    SqlConnection conn;
    SqlDataReader sdr;
    string lblsqyard;
    
    decimal difference;
    string areadiff;
    string description;
    protected void Page_Load(object sender, EventArgs e)
    {

        //conn = new SqlConnection();
        //conn.ConnectionString = ConfigurationManager.ConnectionStrings["kmcConnectionString"].ConnectionString;
        if (Session["UserID"] == null)
        {
            Response.Redirect("Login.aspx");
        }

        else
        {

            if (!IsPostBack)
            {

                ddlpropertyType.DataSource = downs.propertytypemodification();
                ddlpropertyType.DataTextField = "Text";
                ddlpropertyType.DataValueField = "Value";
                ddlpropertyType.DataBind();
                ddlpropertyType.Items.Insert(0, "Select New Property Type");
            }
            conn = new SqlConnection();
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["kmcConnectionString"].ConnectionString;
        }
    }

    protected void btnModify_Click(object sender, EventArgs e)
    {
        if (ddlpropertyType.SelectedItem.Text == "Flat" || ddlpropertyType.SelectedItem.Text == "Commercial" || ddlpropertyType.SelectedItem.Text == "Office" || ddlpropertyType.SelectedItem.Text == "Shop")
        {
            lblsqyard = "Sq.Ft";
            p.AdminInsertChangeCategoryDecreaseSize_SQFT = Convert.ToDecimal(txtNewArea.Text);
            p.AdminInsertChangeCategoryDecreaseSize_SQYD = Convert.ToDecimal(0);
        }
        else
        {
            lblsqyard = "Sq.Yd";
            p.AdminInsertChangeCategoryDecreaseSize_SQFT = Convert.ToDecimal(0);
            p.AdminInsertChangeCategoryDecreaseSize_SQYD = Convert.ToDecimal(txtNewArea.Text);
        }

        p.AdminInsertChangeCategoryDecreaseSize_Inword = txtInword.Text;
        p.AdminInsertChangeCategoryDecreaseSize_InwordModifyImpact = txtInword.Text;
        p.AdminInsertChangeCategoryDecreaseSize_ConsumerNo = txtConsumerNo.Text;
        p.AdminInsertChangeCategoryDecreaseSize_ConsumernoConsumer = txtConsumerNo.Text;
        p.AdminInsertChangeCategoryDecreaseSize_ConsumernoInvoice = txtConsumerNo.Text;
        p.AdminInsertChangeCategoryDecreaseSize_ModificationStatus = "Change of Category and Size";
        p.AdminInsertChangeCategoryDecreaseSize_ModificationStatusModifyImpact = "Change of Category and Size";
        p.AdminInsertChangeCategoryDecreaseSize_NewCategory = ddlpropertyType.SelectedItem.ToString();
        p.AdminInsertChangeCategoryDecreaseSize_KMCCategory = ddlpropertyType.SelectedValue;
        p.AdminInsertChangeCategoryDecreaseSize_NewCategoryForConsumer = ddlpropertyType.SelectedItem.ToString();
        p.AdminInsertChangeCategoryDecreaseSize_NewArea = Convert.ToDecimal(txtNewArea.Text);
        p.AdminInsertChangeCategoryDecreaseSize_AreaForConsumer = Convert.ToDecimal(txtNewArea.Text);
        p.AdminInsertChangeCategoryDecreaseSize_NewCurrentCharge = (Convert.ToDecimal(txtNewCurrent.Text))*2;
        p.AdminInsertChangeCategoryDecreaseSize_NewOutstandingArrears = Convert.ToDecimal(txtNewOutstanding.Text);
        p.AdminInsertChangeCategoryDecreaseSize_Createdby = Convert.ToString(Session["UserID"]);
        p.AdminInsertChangeCategoryDecreaseSize_CreatedbyModifyImpact = Convert.ToString(Session["UserID"]);
        p.AdminInsertChangeCategoryDecreaseSize_Description = "" + ddlsizetype.SelectedValue + " Size to " + txtNewArea.Text + " " + lblsqyard 
       + " and Change of Category to " + ddlpropertyType.SelectedItem + " (" + ddlpropertyType.SelectedValue + "), previously it was charged on " + 
       lbloldarea.InnerText + " " + lblsqy_sqft.InnerText + " with the category of " + lbloldcategory.InnerText 
       + " (" + lbloldkmccategory.InnerText + "), Updated as Approved by modifications committee for data of (MUCT) bearing Inword # " + 
       txtInword.Text + " Dated " + txtinworddate.Text + ".";
        p.AdminInsertChangeCategoryDecreaseSize_DescriptionModifyImpact = "" + ddlsizetype.SelectedValue + " Size to " + txtNewArea.Text + " " + lblsqyard
       + " and Change of Category to " + ddlpropertyType.SelectedItem + " (" + ddlpropertyType.SelectedValue + "), previously it was charged on " +
       lbloldarea.InnerText + " " + lblsqy_sqft.InnerText + " with the category of " + lbloldcategory.InnerText
       + " (" + lbloldkmccategory.InnerText + "), Updated as Approved by modifications committee for data of (MUCT) bearing Inword # " +
       txtInword.Text + " Dated " + txtinworddate.Text + ".";
        difference = Convert.ToDecimal(lbloldouttanding.InnerText) - Convert.ToDecimal(txtNewOutstanding.Text);
        p.AdminInsertChangeCategoryDecreaseSize_Difference = Convert.ToDecimal(difference);
        p.AdminInsertChangeCategoryDecreaseSize_Impact = ddlimpact.SelectedValue;
        p.AdminInsertChangeSqYd_SqFt = lblsqyard.ToString();

        insert.AdminInsertUpdateChangeCategoryDecreaseSize(p);

        btnModify.Visible = false;

        lbldescription.InnerText = "" + ddlsizetype.SelectedValue + " Size to " + txtNewArea.Text + " " + lblsqyard
       + " and Change of Category to " + ddlpropertyType.SelectedItem + " (" + ddlpropertyType.SelectedValue + "), previously it was charged on " +
       lbloldarea.InnerText + " " + lblsqy_sqft.InnerText + " with the category of " + lbloldcategory.InnerText
       + " (" + lbloldkmccategory.InnerText + "), Updated as Approved by modifications committee for data of (MUCT) bearing Inword # " +
       txtInword.Text + " Dated " + txtinworddate.Text + ".";

        txtConsumerNo.Text = null;
        txtInword.Text = null;
        txtinworddate.Text = null;
        txtNewArea.Text = null;
        txtNewCurrent.Text = null;
        txtNewOutstanding.Text = null;
        ddlimpact.SelectedIndex = 0;
        ddlpropertyType.SelectedIndex = 0;
        ddlsizetype.SelectedIndex = 0;
        
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
}