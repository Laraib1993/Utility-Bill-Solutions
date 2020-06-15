using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class ModificationChangeInCategory : System.Web.UI.Page
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
            conn = new SqlConnection();
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["kmcConnectionString"].ConnectionString;
        }
    }

    protected void btnModify_Click(object sender, EventArgs e)
    {

        if (ddlpropertyType.SelectedItem.Text == "Flat" || ddlpropertyType.SelectedItem.Text == "Commercial" || ddlpropertyType.SelectedItem.Text == "Office" || ddlpropertyType.SelectedItem.Text == "Shop")
        {
            if (lblsqy_sqft.InnerText == "Sq.Ft")
            {
                lblsqyard = "Sq.Ft";
                p.AdminInsertModificationForm_ChangeOfCategory_sqft = Convert.ToDecimal(lbloldarea.InnerText);
                p.AdminInsertModificationForm_ChangeOfCategory_sqyd = Convert.ToDecimal(0);
                p.AdminInsertModificationForm_ChangeOfCategory_area = Convert.ToDecimal(lbloldarea.InnerText);
            }

            else if (lblsqy_sqft.InnerText == "Sq.Yd")
            {
                lblsqyard = "Sq.Ft";
                p.AdminInsertModificationForm_ChangeOfCategory_sqft = Convert.ToDecimal(lbloldarea.InnerText) * 9;
                p.AdminInsertModificationForm_ChangeOfCategory_sqyd = Convert.ToDecimal(0);
                p.AdminInsertModificationForm_ChangeOfCategory_area = Convert.ToDecimal(lbloldarea.InnerText) * 9;
            }

        }
        else
        {

            if (lblsqy_sqft.InnerText == "Sq.Yd")
            {
                lblsqyard = "Sq.Yd";
                p.AdminInsertModificationForm_ChangeOfCategory_sqft = Convert.ToDecimal(0);
                p.AdminInsertModificationForm_ChangeOfCategory_sqyd = Convert.ToDecimal(lbloldarea.InnerText);
                p.AdminInsertModificationForm_ChangeOfCategory_area = Convert.ToDecimal(lbloldarea.InnerText);
            }

            else if (lblsqy_sqft.InnerText == "Sq.Ft")
            {
                lblsqyard = "Sq.Yd";
                p.AdminInsertModificationForm_ChangeOfCategory_sqft = Convert.ToDecimal(lbloldarea.InnerText) / 9;
                p.AdminInsertModificationForm_ChangeOfCategory_sqyd = Convert.ToDecimal(0);
                p.AdminInsertModificationForm_ChangeOfCategory_area = Convert.ToDecimal(lbloldarea.InnerText) / 9;
            }



        }

        p.AdminInsertModificationForm_ChangeOfCategory_Inword = txtInword.Text;
        p.AdminInsertModificationForm_ChangeOfCategory_consumerno = txtConsumerNo.Text;
        p.AdminInsertModificationForm_ChangeOfCategory_category = ddlpropertyType.SelectedItem.ToString();
        p.AdminInsertModificationForm_ChangeOfCategory_kmccategory = ddlpropertyType.SelectedValue;
        p.AdminInsertModificationForm_ChangeOfCategory_currentcharges = Convert.ToDecimal(txtNewCurrent.Text) * 2;
        p.AdminInsertModificationForm_ChangeOfCategory_outstandingarrears = Convert.ToDecimal(txtNewOutstanding.Text);
        p.AdminInsertModificationForm_ChangeOfCategory_createdby = Convert.ToString(Session["UserID"]);
        p.AdminInsertModificationForm_ChangeOfCategory_discription = "Change of Category to " + ddlpropertyType.SelectedItem + " (" + ddlpropertyType.SelectedValue + ") , previously it was charged on category of " + lbloldcategory.InnerText
         + " (" + lbloldkmccategory.InnerText + "), Updated as Approved by modifications committee for data of (MUCT) bearing Inword # " + txtInword.Text + " Dated " + txtinworddate.Text + ".";
        p.AdminInsertModificationForm_ChangeOfCategory_impact = ddlimpact.SelectedValue;
        difference = Convert.ToDecimal(lbloldouttanding.InnerText) - Convert.ToDecimal(txtNewOutstanding.Text);

        if (Convert.ToDecimal(0) == Convert.ToDecimal(lbloldouttanding.InnerText))
        {
            differenceperc = 0;
        }

        else
        {
            differenceperc = difference / Convert.ToDecimal(lbloldouttanding.InnerText) * 100;
        }


        p.AdminInsertModificationForm_ChangeOfCategory_difference = difference;
        p.AdminInsertModificationForm_ChangeOfCategory_differencepercentage = differenceperc;
        p.AdminInsertModificationForm_ChangeOfCategory_sqft_sqyd = lblsqyard;
        insert.AdminInsertUpdateChangeCategory(p);

        txtConsumerNo.Text = null;
        txtInword.Text = null;
        txtinworddate.Text = null;
        txtNewCurrent.Text = null;
        txtNewOutstanding.Text = null;
        ddlimpact.SelectedIndex = 0;
        ddlpropertyType.SelectedIndex = 0;
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
                    lbloldcurrent.InnerText = sdr[16].ToString();
                }
                sdr.Dispose();
            }
        }
    }
}