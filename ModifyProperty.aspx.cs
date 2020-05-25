using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ModifyProperty : System.Web.UI.Page
{
    SqlCommand cmd;
    SqlDataReader sdr;
    SqlConnection conn;
    string consumer_no, consumer_name, consumer_fname, consumer_cnic, consumer_mobile, consumer_address;
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

        cmd.CommandText = "SELECT i.consumer_no, i.Category, i.Storey, i.area, i.zone, i.town, i.uc_name, i.block, i.Current_Charges, i.Outstanding_Arrears, i.consumer_service_charges, i.within_duedate_amount, i.consumer_surcharge, i.after_duedate_amount, i.createdon,i.Createdby,t.consumer_no, t.tariff FROM invoice as i,tariff as t,consumer as c where i.consumer_no = '" + txtConsumerNo.Text + "' and c.consumer_no = '" + txtConsumerNo.Text + "' and t.consumer_no = '" + txtConsumerNo.Text + "'";
        conn.Open();
        sdr = cmd.ExecuteReader();
        while (sdr.Read())
        {
            txtZone.Text = sdr[4].ToString();
            txtTown.Text = sdr[5].ToString();
            
            txtUC.Text= sdr[6].ToString();
            txtBlock.Text = sdr[7].ToString();
            ddlpropertyType.Text = sdr[1].ToString();
            txtSqyard.Text = sdr[3].ToString();
            lblCurrentAmount.Text = sdr[8].ToString();
            txttariff.Text = sdr[8].ToString();
            txtStorey.Text = sdr[2].ToString();

            lblArears.Text = sdr[10].ToString();
            //txtArears.Text = sdr[6].ToString();
            lblTotalAmount.Text = sdr[12].ToString();
            lblPermonth.Text = sdr[13].ToString();


        }
        sdr.Dispose();
        cmd.Dispose();
        conn.Close();
    }
}