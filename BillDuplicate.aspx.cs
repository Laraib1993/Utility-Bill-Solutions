using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class BillDuplicate : System.Web.UI.Page
{
    private static SqlCommand cmd;
    private static SqlDataReader sdr;
    private static SqlDataAdapter sda;
    private static SqlConnection conn;
    ReportDocument rpt = new ReportDocument();
    string filepath;
    protected void Page_Load(object sender, EventArgs e)
    {
        conn = new SqlConnection();
        conn.ConnectionString = ConfigurationManager.ConnectionStrings["kmcConnectionString"].ToString();
        conn.Open();
        DataSet ds = new DataSet();
        string qry = "select * from invoice where Consumer_no = '" + txtConsumerNo.Text + "'";
        sda = new SqlDataAdapter(qry, conn);
        sda.Fill(ds, "invoice");
        rpt.Load(Server.MapPath("~/CrystalReport.rpt"));
        rpt.FileName = Server.MapPath("~/CrystalReport.rpt");
        crv.DisplayToolbar = true;
        crv.ToolPanelView = CrystalDecisions.Web.ToolPanelViewType.None;
        crv.Zoom(100);
        crv.HasExportButton = false;
        crv.HasPrintButton = true;
        crv.HasToggleGroupTreeButton = false;
        crv.HasToggleParameterPanelButton = false;
        crv.HasZoomFactorList = false;
        crv.HasCrystalLogo = false;
        crv.Font.Size = 8;
        crv.GroupTreeStyle.Font.Size = 8;
        crv.GroupTreeStyle.ShowLines = false;
        crv.ToolbarStyle.Width = Unit.Parse("2046px");

        rpt.SetDataSource(ds);
        crv.ReportSource = rpt;



       
        conn.Close();
    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        //filepath = Server.MapPath("~/" + "test.pdf");
        //rpt.ExportToDisk(ExportFormatType.PortableDocFormat, filepath);
        //System.IO.FileInfo fileinfo = new System.IO.FileInfo(filepath);
        //Response.AddHeader("Content-Disposition", "inline;filename=test.pdf");
        //Response.ContentType = "application/pdf";
        //Response.WriteFile(fileinfo.FullName);
       
    }
}