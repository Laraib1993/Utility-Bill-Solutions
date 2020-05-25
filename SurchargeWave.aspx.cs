using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;

public partial class SurchargeWave : System.Web.UI.Page
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
        cmd = new SqlCommand();
        cmd.Connection = getConnection.getconnection();
        cmd.CommandText = "SELECT i.consumer_no, i.Category,i.area, i.Storey, i.Current_Charges, i.Outstanding_Arrears, i.consumer_service_charges, i.within_duedate_amount, i.consumer_surcharge, i.after_duedate_amount, i.createdon,i.Createdby,t.consumer_no, t.tariff,i.consumer_name FROM invoice as i,tariff as t where i.consumer_no = '" + txtConsumerNo.Text + "' and t.consumer_no = '" + txtConsumerNo.Text + "'";

        sdr = cmd.ExecuteReader();
        while (sdr.Read())
        {
            txtPropertyType.Text = sdr[1].ToString();
            txtConsumerName.Text = sdr[14].ToString();
            txttariff.Text = sdr[13].ToString();
            txtStorey.Text = sdr[3].ToString();
            txtPerQuarter.Text = sdr[8].ToString();
            lblArears.Text = sdr[5].ToString();
            txtArears.Text = sdr[5].ToString();
            lblPermonth.Text = sdr[8].ToString();
            lblCurrentAmount.Text = sdr[4].ToString();

        }
        sdr.Dispose();
        cmd.Dispose();

       
    }

    public void Calc()
    {
        double x, y, z, sur, per, totalsur, arears, tamount, amount;

        x = Convert.ToDouble(txttariff.Text) * 3;




        if (txtStorey.Text == "0")
        {
            z = x;
        }

        else
        {
            y = ((Convert.ToDouble(txttariff.Text) / 2) * Convert.ToDouble(txtStorey.Text)) * 3;
            z = x + y;
        }


        //lblCurrentAmount.Text = z.ToString();

        ////surcharge calculation
        //per = 10f / 100f;
        //sur = per * z;
        //lblPermonth.Text = sur.ToString();

        //total surcharge wave calculation

        totalsur = Convert.ToDouble(txtPerQuarter.Text) * Convert.ToDouble(txtTotalQuarter.Text);
        lblSurchange.Text = totalsur.ToString();
        //outstanding arears
        amount = Convert.ToDouble(txtArears.Text) - totalsur;
        //arears = amount + totalsur;
        txtArears.Text = amount.ToString();
		lblSurchangeWave.Text = amount.ToString();

        //total amount
        tamount = Convert.ToDouble(lblCurrentAmount.Text) + amount + 8f;
        lblTotalAmount.Text = tamount.ToString();
        //differnece %
        per = (Convert.ToDouble(lblSurchange.Text)*100) / (Convert.ToDouble(lblArears.Text));
        per = Math.Round(per, 0);
        lblImpactPer.Text = per.ToString();
    }

    protected void txtTotalQuarter_TextChanged(object sender, EventArgs e)
    {
        Calc();
    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        cmd = new SqlCommand("sur_wave_impact", conn);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.Add("@inword", SqlDbType.VarChar).Value = txtInword.Text;
        cmd.Parameters.Add("@consumer_no", SqlDbType.VarChar).Value = txtConsumerNo.Text;

        cmd.Parameters.Add("@consumer_name", SqlDbType.VarChar).Value = txtConsumerName.Text;
        cmd.Parameters.Add("@previous_arrears", SqlDbType.Decimal).Value = Convert.ToDouble(lblArears.Text);
        cmd.Parameters.Add("@after_correction", SqlDbType.Decimal).Value = Convert.ToDouble(lblSurchangeWave.Text);
        cmd.Parameters.Add("@difference", SqlDbType.Decimal).Value = Convert.ToDouble(lblSurchange.Text);
        cmd.Parameters.Add("@difference_percentage", SqlDbType.Decimal).Value = Convert.ToDouble(lblImpactPer.Text);
        cmd.Parameters.Add("@description", SqlDbType.VarChar).Value = txtDescription.Text;
        cmd.Parameters.Add("@createdby", SqlDbType.VarChar).Value = Session["UserID"];


        conn.Open();
        cmd.ExecuteNonQuery();
        conn.Close();

        cmd = new SqlCommand("Update_arrears", conn);
        cmd.CommandType = CommandType.StoredProcedure;
       
        cmd.Parameters.Add("@consumer_no", SqlDbType.VarChar).Value = txtConsumerNo.Text;
        cmd.Parameters.Add("@outstanding_Arrears", SqlDbType.Decimal).Value = Convert.ToDouble(lblSurchangeWave.Text);

        conn.Open();
        cmd.ExecuteNonQuery();
        conn.Close();

        cmd = new SqlCommand("sp_updateOutstandings", conn);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.Add("@consumer_no", SqlDbType.VarChar).Value = txtConsumerNo.Text;
        cmd.Parameters.Add("@outstanding_Arrears", SqlDbType.Decimal).Value = Convert.ToDouble(lblSurchangeWave.Text);
        cmd.Parameters.Add("@current_arrears", SqlDbType.Decimal).Value = Convert.ToDouble(lblArears.Text);
        cmd.Parameters.Add("@within_duedate_amount", SqlDbType.Decimal).Value = Convert.ToDouble(lblTotalAmount.Text);
        cmd.Parameters.Add("@after_duedate_amount", SqlDbType.Decimal).Value = Convert.ToDouble(lblTotalAmount.Text) + Convert.ToDouble(lblPermonth.Text);
        cmd.Parameters.Add("@createdby", SqlDbType.VarChar).Value = Session["UserID"];
        cmd.Parameters.Add("@barcode", SqlDbType.VarChar).Value = txtConsumerNo.Text + lblTotalAmount.Text;


        conn.Open();
        cmd.ExecuteNonQuery();
        conn.Close();


    }
}