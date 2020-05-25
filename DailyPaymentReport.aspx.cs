using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class DailyPaymentReport : System.Web.UI.Page
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
        string qry = "SELECT Consumer_no, Billing_Period, branch_code, amount, Payment_Date FROM posting_voucher";
        sda = new SqlDataAdapter(qry, conn);
        sda.Fill(ds, "posting_voucher");
        rpt.Load(Server.MapPath("~/Daily_collection.rpt"));
        rpt.FileName = Server.MapPath("~/Daily_collection.rpt");
        //crv.DisplayToolbar = true;
        //crv.ToolPanelView = CrystalDecisions.Web.ToolPanelViewType.None;
        //crv.Zoom(100);
        //crv.HasExportButton = false;
        //crv.HasPrintButton = true;
        //crv.HasToggleGroupTreeButton = false;
        //crv.HasToggleParameterPanelButton = false;
        //crv.HasZoomFactorList = false;
        //crv.HasCrystalLogo = false;
        //crv.Font.Size = 8;
        //crv.GroupTreeStyle.Font.Size = 8;
        //crv.GroupTreeStyle.ShowLines = false;
        //crv.ToolbarStyle.Width = Unit.Parse("2046px");

        rpt.SetDataSource(ds);
        //crv.ReportSource = rpt;
        //filepath = Server.MapPath("~/" + "test.pdf");
        //rpt.ExportToDisk(ExportFormatType.PortableDocFormat, filepath);
        //rpt.ExportToHttpResponse(ExportFormatType.PortableDocFormat, Response, true, "PersonDetails");
        pdfcontroller();
        conn.Close();
    }

    public void pdfcontroller()
    {
        Response.Clear();

        filepath = Server.MapPath("~/" + "test.pdf");
        rpt.ExportToDisk(ExportFormatType.PortableDocFormat, filepath);
        System.IO.FileInfo fileinfo = new System.IO.FileInfo(filepath);
        Response.AddHeader("Content-Disposition", "inline;filename=test.pdf");
        Response.ContentType = "application/pdf";
        Response.WriteFile(fileinfo.FullName);
        //filepath = Server.MapPath("~/" + "test.pdf");
        //rpt.ExportToDisk(ExportFormatType.PortableDocFormat, filepath);
        //WebClient User = new WebClient();
        //Byte[] FileBuffer = User.DownloadData(filepath);
        //if (FileBuffer != null)
        //{
        //    Response.ContentType = "application/pdf";
        //    Response.AddHeader("content-length", FileBuffer.Length.ToString());
        //    Response.BinaryWrite(FileBuffer);
        //}


    }

}