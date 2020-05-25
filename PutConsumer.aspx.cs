using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class PutConsumer : System.Web.UI.Page
{
    properties p = new properties();
    downs d = new downs();
    SqlCommand cmd;
    SqlConnection conn;
    string km, adDigit;
    
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
                

                ddlZone.DataSource = downs.listZone();
                ddlZone.DataTextField = "Text";
                ddlZone.DataValueField = "Value";
                ddlZone.DataBind();
                ddlZone.Items.Insert(0, "Select Zone");

                //ddlTown.DataSource = downs.fetchingcarmodeldropdown();
                //ddTown.DataBind();
                //ddlType.DataSource = downs.fetchingcartypedropdown();
                //ddlType.DataBind();
                //ddluserid.DataSource = downs.fetchinguserinfodropdown();
                //ddluserid.DataBind();
                txtTariff.Enabled = false;
                ddlTown.Enabled = false;
                ddlBlock.Enabled = false;
                ddlUC.Enabled = false;
                txtStorey.Enabled = false;
                txtSqyard.Enabled = false;
                ddlpropertyType.Enabled = false;
                

            }
            conn = new SqlConnection();
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["kmcConnectionString"].ConnectionString;
        }

    }

    protected void ddlZone_SelectedIndexChanged(object sender, EventArgs e)
    {
        //ddlTown.Enabled = true;
        //ddlTown.DataSource = downs.SelectedTown(Convert.ToInt16(ddlZone.SelectedValue));
        //ddlTown.DataMember = "select";
        //ddlTown.DataTextField = "Text";
        //ddlTown.DataValueField = "Value";
        //ddlTown.DataBind();
        //ddlTown.Items.Insert(0, "Select Town");

    }





    protected void ddlUC_SelectedIndexChanged(object sender, EventArgs e)
    {
        //ddlBlock.Enabled = true;
        //ddlBlock.DataSource = downs.SelectedBlock(Convert.ToInt16(ddlUC.SelectedValue), Convert.ToInt16(ddlTown.SelectedValue));
        //ddlBlock.DataTextField = "Text";
        //ddlBlock.DataValueField = "Value";
        //ddlBlock.DataBind();
        //ddlBlock.Items.Insert(0, "Select Block");
    }

    protected void ddlTown_SelectedIndexChanged(object sender, EventArgs e)
    {
        ddlUC.Enabled = true;
        ddlUC.DataSource = downs.SelectedUC(Convert.ToInt16(ddlTown.SelectedValue));
        ddlUC.DataTextField = "Text";
        ddlUC.DataValueField = "Value";
        ddlUC.DataBind();
        ddlUC.Items.Insert(0, "Select UC");
    }

    protected void ddlBlock_SelectedIndexChanged(object sender, EventArgs e)
    {
        //ddlpropertyType.Enabled = true;
        //ddlpropertyType.DataSource = downs.propertytype(Convert.ToInt16(ddlBlock.SelectedValue));
        //ddlpropertyType.DataTextField = "Text";
        //ddlpropertyType.DataValueField = "Value";
        //ddlpropertyType.DataBind();
        //ddlpropertyType.Items.Insert(0, "Select Property Type");
        ////properties p = new properties();
        ////lblSurchange.Text = p.Propertycode;
        //using (conn)
        //{

        //    string strqry = "select consumer_code from Block Where BlockID ='" + Convert.ToInt16(ddlBlock.SelectedValue) + "'";
        //    using (cmd = new SqlCommand(strqry, conn))
        //    {
        //        cmd.CommandType = CommandType.Text;
        //        conn.Open();
        //        SqlDataReader sdr = null;
        //        sdr = cmd.ExecuteReader();

        //        while (sdr.Read())
        //        {

        //            //lblcode.Text = sdr[0].ToString() + " " + "000";
        //            lblcode.Text = sdr[0].ToString();



        //        }
        //    }
        //}


    }

    protected void ddlTariff_SelectedIndexChanged(object sender, EventArgs e)
    {
       // txtStorey.Enabled = true;
      
    }

    protected void ddlpropertyType_SelectedIndexChanged(object sender, EventArgs e)
    {
        //txtSqyard.Enabled = true;
        ////lblPermonth.Text = ddlpropertyType.SelectedItem.Text;
        //if(ddlpropertyType.SelectedItem.Text == "Flat" || ddlpropertyType.SelectedItem.Text == "Commerical" || ddlpropertyType.SelectedItem.Text == "Office" || ddlpropertyType.SelectedItem.Text == "Shop")
        //{
        //    lblsqyard.Text = "Sq.Ft";
        //}
        //else
        //{
        //    lblsqyard.Text = "Sq.Yd";
        //}

        //using (conn)
        //{

        //    string strqry = "select  PropertyCode from PropertyType Where PropertyTypeName ='" + ddlpropertyType.SelectedItem.Text + "'";
        //    using (cmd = new SqlCommand(strqry, conn))
        //    {
        //        cmd.CommandType = CommandType.Text;



        //        conn.Open();
        //        SqlDataReader sdr = null;
        //        sdr = cmd.ExecuteReader();

        //        while (sdr.Read())
        //        {
        //            lblPropertyCode.Text = sdr[0].ToString();
        //        }
        //    }
        //}

        



    }

    protected void txtSqyard_TextChanged(object sender, EventArgs e)
    {
        //int a;
        ////lblPermonth.Text = ddlpropertyType.SelectedItem.Text;
        //p.Plot = txtSqyard.Text;
        ////int x= d.plot(Convert.ToInt16(ddlpropertyType.SelectedValue+1));
        
        //txtTariff.Enabled = true;
        //txtStorey.Enabled = true;
        //using (conn)
        //{

        //    string strqry = "select  Min,Max,Amount from PlotSize Where PropertyTypeID ='" + Convert.ToInt16( ddlpropertyType.SelectedValue) + "'";
        //    using (cmd = new SqlCommand(strqry, conn))
        //    {
        //        cmd.CommandType = CommandType.Text;

                
                
        //         conn.Open();
        //        SqlDataReader sdr = null;
        //        sdr = cmd.ExecuteReader();

        //        while (sdr.Read())
        //        {
        //            if (Convert.ToInt32(p.Plot) >= Convert.ToInt32(sdr[0].ToString()) && Convert.ToInt32(p.Plot) <= Convert.ToInt32(sdr[1].ToString()))
        //            {
        //                a = Convert.ToInt32(sdr[2].ToString());
        //                txtTariff.Text = a.ToString();
        //            }

        //            else
        //            {
        //                a = 0;
        //            }

        //        }
        //        conn.Close();
        //    }
        //}
        
    }

    public void Calc()
    {
  //      double x, y, z, sur,per,arears,tamount,amount,dueamount;
  //      if(txtTariff.Text == "1")
  //      {
  //           x = Convert.ToDouble(txtTariff.Text) * Convert.ToDouble(txtSqyard.Text) * 3;
  //      }
  //      else if(txtTariff.Text == "0")
  //      {
  //           x = (Convert.ToDouble(txtTariff.Text) + 1) * 3;
  //      }
  //      else
  //      {
  //          x = Convert.ToDouble(txtTariff.Text) * 3;
  //      }

        

  //      if(txtStorey.Text == "0")
  //      {
  //          z = x;
  //      }
  //      else if (ddlpropertyType.SelectedItem.Text == "Commerical" || ddlpropertyType.SelectedItem.Text == "Office")
  //      {
  //          y = ((Convert.ToDouble(txtSqyard.Text) / 2) * Convert.ToDouble(txtStorey.Text)) * 3;
  //          z = x + y;
  //      }
  //      else
  //      {
  //          y = ((Convert.ToDouble(txtTariff.Text) / 2) * Convert.ToDouble(txtStorey.Text)) * 3;
  //          z = x + y;
  //      }

        
  //      lblCurrentAmount.Text = z.ToString();
        
  //      //surcharge calculation
  //      per = 10f / 100f;
  //      sur = per * z;
  //      lblPermonth.Text = sur.ToString();

  //      //total surcharge calculation

  //      //totalsur = sur * Convert.ToDouble(txtSurchargeApply.Text);
  //      //lblSurchange.Text = totalsur.ToString();
  //      //outstanding arears
  //      amount = z * Convert.ToDouble(txtBillingQuarter.Text);
  //      arears = amount;
  //      lblArears.Text = arears.ToString();
		//lblCurrArrears.Text = Math.Round((arears * 0.05f)).ToString();

  //      //total amount with in due
  //      tamount = z + arears + 8f;
  //      lblTotalAmount.Text = tamount.ToString();

  //      //after due amount
  //      lblbankcharge.Text = "8";
  //      dueamount = tamount + sur;
  //      lbldueamount.Text = dueamount.ToString();





    }

    protected void txtStorey_TextChanged(object sender, EventArgs e)
    {
        //Calc();
    }

    protected void txtBillingQuarter_TextChanged(object sender, EventArgs e)
    {
        //Calc();


        //conn = new SqlConnection();
        //conn.ConnectionString = ConfigurationManager.ConnectionStrings["kmcConnectionString"].ConnectionString;

        //cmd = new SqlCommand("sp_fetchMax", conn);
        //cmd.CommandType = CommandType.StoredProcedure;
        //cmd.Parameters.Add("@consumer_code", SqlDbType.VarChar).Value = lblcode.Text;
        //cmd.Parameters.Add("@code", SqlDbType.VarChar).Value = lblcode.Text;

        //conn.Open();
        //SqlDataReader sdrr = null;
        //sdrr = cmd.ExecuteReader();

        //while (sdrr.Read())
        //{
        //    lblMiddleCode.Text = sdrr[0].ToString();
        //}
        //conn.Close();

        //int mid = Convert.ToInt32(lblMiddleCode.Text) + 1;



        //if (mid.ToString().Length == 3)
        //{
        //    adDigit = "0" + mid.ToString();
        //    lblConsumerNo.Text = lblcode.Text + adDigit + "000";
        //   // lblcheckdigit.Text = ChkDgt.NewConsumerNo(txtConsumerID.Text);

        //}
        //else if (mid.ToString().Length == 2)
        //{
        //    adDigit = "00" + mid.ToString();
        //    lblConsumerNo.Text = lblcode.Text + adDigit + "000";
        //    //lblcheckdigit.Text = ChkDgt.NewConsumerNo(txtConsumerID.Text);
        //}
        //else
        //{
        //    adDigit = mid.ToString();
        //    lblConsumerNo.Text = lblcode.Text + adDigit + "000";
        //   // lblcheckdigit.Text = ChkDgt.NewConsumerNo(txtConsumerID.Text);
        //}

    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
 //       cmd = new SqlCommand("sp_insertconsumer", conn);
 //       cmd.CommandType = CommandType.StoredProcedure;
 //       cmd.Parameters.Add("@consumer_no", SqlDbType.VarChar).Value = txtConsumerID.Text;

 //       cmd.Parameters.Add("@consumer_name", SqlDbType.VarChar).Value = txtConsumerName.Text;
 //       cmd.Parameters.Add("@consumer_address", SqlDbType.VarChar).Value = txtAddress.Text;
 //       cmd.Parameters.Add("@category", SqlDbType.VarChar).Value = ddlpropertyType.SelectedItem.Text;
 //       cmd.Parameters.Add("@consumer_fname", SqlDbType.VarChar).Value = txtFatherName.Text;
 //       cmd.Parameters.Add("@consumer_cnic", SqlDbType.VarChar).Value = txtCNIC.Text;
 //       cmd.Parameters.Add("@consumer_mobile", SqlDbType.VarChar).Value = txtMobile.Text;


 //       cmd.Parameters.Add("@storey", SqlDbType.Int).Value = Convert.ToDouble(txtStorey.Text);
 //       cmd.Parameters.Add("@consumer_code", SqlDbType.VarChar).Value = lblcode.Text;
 //       cmd.Parameters.Add("@kmc_category", SqlDbType.VarChar).Value = lblPropertyCode.Text + "-" + ddlpropertyType.SelectedItem.Text;
 //       cmd.Parameters.Add("@Sqft_Sqyd", SqlDbType.VarChar).Value = lblsqyard.Text;
 //       cmd.Parameters.Add("@area", SqlDbType.Decimal).Value = Convert.ToDouble(txtSqyard.Text);
 //       cmd.Parameters.Add("@createdby", SqlDbType.VarChar).Value = Session["UserID"];

 //       conn.Open();
 //       cmd.ExecuteNonQuery();
 //       conn.Close();

 //       cmd = new SqlCommand("sp_insertAddConsumerHistory", conn);
 //       cmd.CommandType = CommandType.StoredProcedure;
 //       cmd.Parameters.Add("@inword_no", SqlDbType.VarChar).Value = txtInword.Text;
 //       cmd.Parameters.Add("@consumer_no", SqlDbType.VarChar).Value = txtConsumerID.Text;
 //       cmd.Parameters.Add("@consumer_name", SqlDbType.VarChar).Value = txtConsumerName.Text;
 //       cmd.Parameters.Add("@createdby", SqlDbType.VarChar).Value = Session["UserID"];
 //       cmd.Parameters.Add("@description", SqlDbType.VarChar).Value = txtdescrption.Text;

 //       conn.Open();
 //       cmd.ExecuteNonQuery();
 //       conn.Close();


 //       cmd = new SqlCommand("sp_insertTariff", conn);
 //       cmd.CommandType = CommandType.StoredProcedure;
 //       cmd.Parameters.Add("@consumer_no", SqlDbType.VarChar).Value = txtConsumerID.Text;
 //       cmd.Parameters.Add("@tariff", SqlDbType.Decimal).Value = Convert.ToDouble(lblCurrentAmount.Text);
        
 //       conn.Open();
 //       cmd.ExecuteNonQuery();
 //       conn.Close();

 //       cmd = new SqlCommand("sp_insertArrears", conn);
 //       cmd.CommandType = CommandType.StoredProcedure;
 //       cmd.Parameters.Add("@consumer_no", SqlDbType.VarChar).Value = txtConsumerID.Text;
 //       cmd.Parameters.Add("@outstanding_arrears", SqlDbType.Decimal).Value = Convert.ToDouble(lblArears.Text);

 //       conn.Open();
 //       cmd.ExecuteNonQuery();
 //       conn.Close();


 //       cmd = new SqlCommand("sp_insertinvoice", conn);
 //       cmd.CommandType = CommandType.StoredProcedure;
 //       cmd.Parameters.Add("@consumer_no", SqlDbType.VarChar).Value = txtConsumerID.Text;
 //       cmd.Parameters.Add("@consumer_code", SqlDbType.VarChar).Value = lblcode.Text;
 //       cmd.Parameters.Add("@consumer_name", SqlDbType.VarChar).Value = txtConsumerName.Text;
 //       cmd.Parameters.Add("@consumer_address", SqlDbType.VarChar).Value = txtAddress.Text;
 //       cmd.Parameters.Add("@category", SqlDbType.VarChar).Value = ddlpropertyType.SelectedItem.Text;
 //       cmd.Parameters.Add("@area", SqlDbType.Decimal).Value = Convert.ToDouble(txtSqyard.Text);
 //       cmd.Parameters.Add("@Sqft_Sqyd", SqlDbType.VarChar).Value = lblsqyard.Text;
 //       cmd.Parameters.Add("@storey", SqlDbType.Int).Value = Convert.ToInt16(txtStorey.Text);
 //       cmd.Parameters.Add("@zone", SqlDbType.VarChar).Value = ddlZone.SelectedItem.Text;
 //       cmd.Parameters.Add("@town", SqlDbType.VarChar).Value = ddlTown.SelectedItem.Text;
 //       cmd.Parameters.Add("@uc_no", SqlDbType.VarChar).Value = ddlUC.SelectedValue;
 //       cmd.Parameters.Add("@uc_name", SqlDbType.VarChar).Value = ddlUC.SelectedItem.Text;
 //       cmd.Parameters.Add("@block", SqlDbType.VarChar).Value = ddlBlock.SelectedItem.Text;
 //       cmd.Parameters.Add("@billing_month", SqlDbType.VarChar).Value = "Apr-Sep, 2018";
 //       cmd.Parameters.Add("@current_Charges", SqlDbType.Decimal).Value = Convert.ToDouble(lblCurrentAmount.Text);
	//	cmd.Parameters.Add("@current_arrears", SqlDbType.Decimal).Value = Convert.ToDouble(lblCurrArrears.Text);
 //       cmd.Parameters.Add("@outstanding_Arrears", SqlDbType.Decimal).Value = Convert.ToDouble(lblArears.Text);
 //       cmd.Parameters.Add("@consumer_service_charges", SqlDbType.Decimal).Value = 8.00f;
 //       cmd.Parameters.Add("@within_duedate_amount", SqlDbType.Decimal).Value = Convert.ToDouble(lblTotalAmount.Text);
 //       cmd.Parameters.Add("@consumer_surcharge", SqlDbType.Decimal).Value = lblPermonth.Text;
 //       cmd.Parameters.Add("@after_duedate_amount", SqlDbType.Decimal).Value = Convert.ToDouble(lblTotalAmount.Text) + Convert.ToDouble(lblPermonth.Text);
 //       cmd.Parameters.Add("@kmc_category", SqlDbType.VarChar).Value = lblPropertyCode.Text + "-" + ddlpropertyType.SelectedItem.Text;
 //       cmd.Parameters.Add("@createdby", SqlDbType.VarChar).Value = Session["UserID"];
 //       cmd.Parameters.Add("@consumer_checkdigit", SqlDbType.VarChar).Value = lblcheckdigit.Text;
 //       cmd.Parameters.Add("@billing_period_code", SqlDbType.VarChar).Value = "07 2018 01-3";
 //       cmd.Parameters.Add("@barcode", SqlDbType.VarChar).Value = txtConsumerID.Text + lblTotalAmount.Text;


 //       conn.Open();
 //       cmd.ExecuteNonQuery();
 //       conn.Close();


	//cmd = new SqlCommand("add_con_impact", conn);
 //       cmd.CommandType = CommandType.StoredProcedure;
 //       cmd.Parameters.Add("@inword", SqlDbType.VarChar).Value = txtInword.Text;
 //       cmd.Parameters.Add("@consumer_no", SqlDbType.VarChar).Value = txtConsumerID.Text;
       
 //       cmd.Parameters.Add("@consumer_name", SqlDbType.VarChar).Value = txtConsumerName.Text;
 //       cmd.Parameters.Add("@after_correction", SqlDbType.Decimal).Value = Convert.ToDouble(lblArears.Text);
 //       cmd.Parameters.Add("@description", SqlDbType.VarChar).Value = txtdescrption.Text;
 //       cmd.Parameters.Add("@createdby", SqlDbType.VarChar).Value = Session["UserID"];


 //       conn.Open();
 //       cmd.ExecuteNonQuery();
 //       conn.Close();

	//	btnSubmit.Visible = false;
 //       lblMessage.Text = "Done Successfully";



    }

    protected void btnCode_Click(object sender, EventArgs e)
    {
       

      
    }

    protected void txtConsumerID_TextChanged(object sender, EventArgs e)
    {
        string chk;
        lblcheckdigit.Text = ChkDgt.NewConsumerNo(txtConsumerID.Text);
    //    if(chk.ToString().Length == 14 )
    //    {
    //        lblcheckdigit.Text = chk + "0";
    //    }
    //    else
    //    {
    //        lblcheckdigit.Text = chk;
    //    }
    }

    
}