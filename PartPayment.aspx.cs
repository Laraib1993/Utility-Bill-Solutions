using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;

public partial class PartPayment : System.Web.UI.Page
{
    SqlCommand cmd;
    SqlDataReader sdr;
    SqlConnection conn;
   
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["UserID"] == null)
        {
            Response.Redirect("Login.aspx");
        }
        conn = new SqlConnection();
        conn.ConnectionString = ConfigurationManager.ConnectionStrings["kmcConnectionString"].ConnectionString;
       
    }

    protected void txtConsumerNo_TextChanged(object sender, EventArgs e)
    {
        txtConsumerNo.Text = (txtConsumerNo.Text).ToString().ToUpper();
        cmd = new SqlCommand("selectInvoice", getConnection.getconnection());
        
        cmd.CommandType = CommandType.StoredProcedure;
        //cmd.CommandText = "SELECT i.consumer_no, i.Category,i.area, i.Storey, i.Current_Charges, i.Outstanding_Arrears, i.consumer_service_charges, i.within_duedate_amount, i.consumer_surcharge, i.after_duedate_amount, i.createdon,i.Createdby,t.consumer_no, t.tariff,i.consumer_name FROM invoice as i,tariff as t where i.consumer_no = '" + txtConsumerNo.Text + "' and t.consumer_no = '" + txtConsumerNo.Text + "'";
        cmd.Parameters.Add("@consumer_no", SqlDbType.VarChar).Value = txtConsumerNo.Text;
        sdr = cmd.ExecuteReader();
        while (sdr.Read())
        {

            lblConsumerCode.Text = sdr[1].ToString();
            txtConsumerName.Text = sdr[2].ToString();
            txtAddress.Text = sdr[3].ToString();
            txtPropertyType.Text = sdr[4].ToString();
            lblSize.Text = sdr[5].ToString();
            lblSqft.Text = sdr[6].ToString();
            txtStorey.Text = sdr[7].ToString();
            lblzone.Text = sdr[8].ToString();
            lbltown.Text = sdr[9].ToString();
            lblUcno.Text = sdr[10].ToString();
            lblUcName.Text = sdr[11].ToString();
            lblBlock.Text = sdr[12].ToString();
            lblBillingMonth.Text = sdr[15].ToString();
            txtPerQuarter.Text = sdr[16].ToString();
            lblCurrentAmount.Text = sdr[16].ToString();
            lblArears.Text = sdr[17].ToString();
            txtArears.Text = sdr[17].ToString();
            lblPermonth.Text = sdr[20].ToString();
            lblKmcCategory.Text = sdr[22].ToString();
            lblCheckdigit.Text = sdr[26].ToString();
            lblBillingCode.Text = sdr[27].ToString();
            lblbarcode.Text = sdr[28].ToString();


        }
        sdr.Dispose();
        cmd.Dispose();

       
    }

    public void Calc()
    {
        double x, y, z,  tamount;

        x = Convert.ToDouble(txtArears.Text) / Convert.ToDouble(txtPartPayment.Text);
        y = Convert.ToDouble(lblCurrentAmount.Text) + x;
        tamount = y + 8f;

        lblInstal.Text = txtPartPayment.Text;
        lblperInstal.Text = x.ToString();
        lblwithin.Text = y.ToString();
        lblTotalAmount.Text = tamount.ToString();
        z = tamount + Convert.ToDouble(lblPermonth.Text);
        lbldue.Text = z.ToString();



        //lblCurrentAmount.Text = z.ToString();

        ////surcharge calculation
        //per = 10f / 100f;
        //sur = per * z;
        //lblPermonth.Text = sur.ToString();

        //total surcharge wave calculation

        //totalsur = Convert.ToDouble(txtPerQuarter.Text) * Convert.ToDouble(txtPartPayment.Text);
        //lblInstal.Text = totalsur.ToString();
        ////outstanding arears
        //amount = Convert.ToDouble(txtArears.Text) - totalsur;
        ////arears = amount + totalsur;
        //txtArears.Text = amount.ToString();
        //lblwithin.Text = amount.ToString();

        ////total amount
        //tamount = Convert.ToDouble(lblCurrentAmount.Text) + amount + 8f;
        //lblTotalAmount.Text = tamount.ToString();
        ////differnece %
        //per = (Convert.ToDouble(lblInstal.Text)*100) / (Convert.ToDouble(lblArears.Text));
        //per = Math.Round(per, 0);

    }

    protected void txtTotalQuarter_TextChanged(object sender, EventArgs e)
    {
        Calc();
    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        cmd = new SqlCommand("sp_UpdatePartPayemnt", conn);
        cmd.CommandType = CommandType.StoredProcedure;

        cmd.Parameters.Add("@consumer_no", SqlDbType.VarChar).Value = txtConsumerNo.Text;
        
        cmd.Parameters.Add("@part_payment_into", SqlDbType.VarChar).Value = txtPartPayment.Text;
      
        cmd.Parameters.Add("@part_payemnt_arrears", SqlDbType.Decimal).Value = Convert.ToDouble(lblperInstal.Text);
        cmd.Parameters.Add("@createdby", SqlDbType.VarChar).Value = Session["UserID"];


        conn.Open();
        cmd.ExecuteNonQuery();
        conn.Close();

        btnSubmit.Visible = false;
        lblMessage.Text = "Installment Done Successfully";

      

    }

    protected void btnReset_Click(object sender, EventArgs e)
    {
        Response.Redirect(Request.Url.ToString());
       
    }
}