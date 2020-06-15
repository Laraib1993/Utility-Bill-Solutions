using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
public partial class ModificationChangeinCategory_Storey : System.Web.UI.Page
{
    properties p = new properties();
    uploading insert = new uploading();
    downs d = new downs();
    SqlCommand cmd;
    SqlConnection conn;
    SqlDataReader sdr;
    string lblsqyard;

    decimal difference;
    decimal differenceperc;
    string areadiff;
    string description;
   
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["UserID"] == null)
        {
            Response.Redirect("Login.aspx");
           
        }

        else
        {
            //Response.Redirect("Login.aspx");
            if (!IsPostBack)
            {
                //Response.Redirect("Login.aspx");
                ddlpropertyType.DataSource = downs.propertytypemodification();
                ddlpropertyType.DataTextField = "Text";
                ddlpropertyType.DataValueField = "Value";
                ddlpropertyType.DataBind();
                ddlpropertyType.Items.Insert(0, "Select New Property Type");
            }
            //conn = new SqlConnection();
            //conn.ConnectionString = ConfigurationManager.ConnectionStrings["kmcConnectionString"].ConnectionString;
        }
    }

    protected void btnModify_Click(object sender, EventArgs e)
    {
    if (ddlpropertyType.SelectedItem.Text == "Flat" || ddlpropertyType.SelectedItem.Text == "Commercial" || ddlpropertyType.SelectedItem.Text == "Office" || ddlpropertyType.SelectedItem.Text == "Shop")
    {
            if (lblsqy_sqft.InnerText == "Sq.Ft")
            {
                lblsqyard = "Sq.Ft";
                p.AdminInsertModificationForm_ChangeOfCategoryAndSize_sqft = Convert.ToDecimal(lbloldarea.InnerText);
                p.AdminInsertModificationForm_ChangeOfCategoryAndSize_sqyd = Convert.ToDecimal(0);
                p.AdminInsertModificationForm_ChangeOfCategoryAndSize_area = Convert.ToDecimal(lbloldarea.InnerText);
            }

            else if (lblsqy_sqft.InnerText == "Sq.Yd")
            {
                lblsqyard = "Sq.Ft";
                p.AdminInsertModificationForm_ChangeOfCategoryAndSize_sqft = Convert.ToDecimal(lbloldarea.InnerText) * 9;
                p.AdminInsertModificationForm_ChangeOfCategoryAndSize_sqyd = Convert.ToDecimal(0);
                p.AdminInsertModificationForm_ChangeOfCategoryAndSize_area = Convert.ToDecimal(lbloldarea.InnerText) * 9;
            }

        }
    else
    {

            if (lblsqy_sqft.InnerText == "Sq.Yd")
            {
                lblsqyard = "Sq.Yd";
                p.AdminInsertModificationForm_ChangeOfCategoryAndSize_sqft = Convert.ToDecimal(0);
                p.AdminInsertModificationForm_ChangeOfCategoryAndSize_sqyd = Convert.ToDecimal(lbloldarea.InnerText);
                p.AdminInsertModificationForm_ChangeOfCategoryAndSize_area = Convert.ToDecimal(lbloldarea.InnerText);
            }

            else if (lblsqy_sqft.InnerText == "Sq.Ft")
            {
                lblsqyard = "Sq.Yd";
                p.AdminInsertModificationForm_ChangeOfCategoryAndSize_sqft = Convert.ToDecimal(lbloldarea.InnerText) / 9;
                p.AdminInsertModificationForm_ChangeOfCategoryAndSize_sqyd = Convert.ToDecimal(0);
                p.AdminInsertModificationForm_ChangeOfCategoryAndSize_area = Convert.ToDecimal(lbloldarea.InnerText) / 9;
            }

        }

        p.AdminInsertModificationForm_ChangeOfCategoryAndSize_Inword = txtInword.Text;
        p.AdminInsertModificationForm_ChangeOfCategoryAndSize_category = ddlpropertyType.SelectedItem.ToString();
        p.AdminInsertModificationForm_ChangeOfCategoryAndSize_kmccategory = ddlpropertyType.SelectedValue;
        p.AdminInsertModificationForm_ChangeOfCategoryAndSize_description = "Change of Category to " + ddlpropertyType.SelectedItem + " (" + ddlpropertyType.SelectedValue + ") and "+ddlsizetype.SelectedValue+" in Storey to Ground + "+txtnewstorey.Text+" , previously it was charged on category of " + lbloldcategory.InnerText
       + " (" + lbloldkmccategory.InnerText + ") and storey of Ground + "+ lbloldstorey.InnerText+ ", Updated as Approved by modifications committee for data of (MUCT) bearing Inword # " + txtInword.Text+" Dated "+txtinworddate.Text+".";


        p.AdminInsertModificationForm_ChangeOfCategoryAndSize_storey = Convert.ToInt32(txtnewstorey.Text);
        p.AdminInsertModificationForm_ChangeOfCategoryAndSize_currentcharges = Convert.ToDecimal(txtNewCurrent.Text)*2;
        p.AdminInsertModificationForm_ChangeOfCategoryAndSize_outstandingarrears = Convert.ToDecimal(txtNewOutstanding.Text);
        difference = Convert.ToDecimal(lbloldouttanding.InnerText) - Convert.ToDecimal(txtNewOutstanding.Text);
        
        if (Convert.ToDecimal(0) == Convert.ToDecimal(lbloldouttanding.InnerText))
        {
            differenceperc = 0;
        }

        else
        {
            differenceperc = difference / Convert.ToDecimal(lbloldouttanding.InnerText) * 100;
        }


        p.AdminInsertModificationForm_ChangeOfCategoryAndSize_difference = difference;
        p.AdminInsertModificationForm_ChangeOfCategoryAndSize_diffpercentage = differenceperc;
        p.AdminInsertModificationForm_ChangeOfCategoryAndSize_createdby = Convert.ToString(Session["UserID"]);
        p.AdminInsertModificationForm_ChangeOfCategoryAndSize_impact = ddlimpact.SelectedValue;
        p.AdminInsertModificationForm_ChangeOfCategoryAndSize_consumerno = txtConsumerNo.Text;
        p.AdminInsertModificationForm_ChangeOfCategoryAndSize_sqft_sqyd = lblsqyard;
        insert.AdminInsertUpdateChangeCategoryAddStorey(p);

        txtConsumerNo.Text = null;
        txtInword.Text = null;
        txtinworddate.Text = null;
        txtnewstorey.Text = null;
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
                    lbloldstorey.InnerText = sdr[7].ToString();
                    lbloldcategory.InnerText = sdr[4].ToString();
                    lbloldkmccategory.InnerText = sdr[22].ToString();
                    lbloldouttanding.InnerText = sdr[17].ToString();
                    lbloldcurrent.InnerText = sdr[16].ToString();
                }
                sdr.Dispose();
            }
        }
    }
}