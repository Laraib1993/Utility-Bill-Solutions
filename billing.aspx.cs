using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.IO;
using System.Drawing.Printing;
using System.Drawing;

public partial class billing : System.Web.UI.Page
{
    private static SqlCommand cmd;
    private static SqlDataReader sdr;
    private static SqlDataAdapter sda;
    private static SqlConnection conn;
   
    ReportDocument rpt = new ReportDocument();
    string filepath;
    protected void Page_Load(object sender, EventArgs e)
    {
        //ReportDocument crt = new ReportDocument();

        //crt.Load(Server.MapPath("~/Billing.rpt"));
        //crt.SetDatabaseLogon("sa", "123", "SPRINT-IT-PC", "KMC");
        //crt.ReadRecords();
        //crv.ReportSource = crt;

        conn = new SqlConnection();
        conn.ConnectionString = ConfigurationManager.ConnectionStrings["kmcConnectionString"].ToString();
        conn.Open();




    }

    public void pdfcontroller()
    {
        Response.Clear();
        filepath = Server.MapPath("~/" + "test.pdf");

        //try
        //{
        //    filepath = Server.MapPath("~/" + "test.pdf");
        //    ExportOptions CrExportOptions;
        //    DiskFileDestinationOptions CrDiskFileDestinationOptions = new DiskFileDestinationOptions();
        //    PdfRtfWordFormatOptions CrFormatTypeOptions = new PdfRtfWordFormatOptions();
        //    CrDiskFileDestinationOptions.DiskFileName = "~/test.pdf";
        //    CrExportOptions = rpt.ExportOptions;
        //    {
        //        CrExportOptions.ExportDestinationType = ExportDestinationType.DiskFile;
        //        CrExportOptions.ExportFormatType = ExportFormatType.PortableDocFormat;
        //        CrExportOptions.DestinationOptions = CrDiskFileDestinationOptions;
        //        CrExportOptions.FormatOptions = CrFormatTypeOptions;
        //    }
        //    rpt.Export();
        //}
        //catch (Exception ex)
        //{

        //    //MessageBox.Show(ex.ToString());
        //}



       


    }



    protected void btnSubmit_Click(object sender, EventArgs e)
    {

        DataSet ds = new DataSet();
        string qry = "select * from invoice where consumer_No = '" + txtConsumerNo.Text + "'";
        sda = new SqlDataAdapter(qry, conn);
        sda.Fill(ds, "invoice");
       // rpt.Load(Server.MapPath("~/CrystalReport.rpt"));
        //rpt.FileName = Server.MapPath("~/CrystalReport.rpt");
        //rpt.SetDatabaseLogon("sa", "123");
        TableLogOnInfos crtableLogoninfos = new TableLogOnInfos();
        TableLogOnInfo crtableLogoninfo = new TableLogOnInfo();
        Tables CrTables;
        rpt.Load(Server.MapPath("~/billing.rpt"));
        ConnectionInfo crConnectionInfo = new ConnectionInfo();
        rpt.FileName = Server.MapPath("~/billing.rpt");
        crConnectionInfo.ServerName = "WIN-7V1OQFPKUAJ";
        crConnectionInfo.DatabaseName = "kmc";
        crConnectionInfo.UserID = "sa";
        crConnectionInfo.Password = "Sprint@5555";

        CrTables = rpt.Database.Tables;
        foreach (CrystalDecisions.CrystalReports.Engine.Table CrTable in CrTables)
        {
            crtableLogoninfo = CrTable.LogOnInfo;
            crtableLogoninfo.ConnectionInfo = crConnectionInfo;
            CrTable.ApplyLogOnInfo(crtableLogoninfo);
        }
        //ConnectionInfo info = new ConnectionInfo();

        //info.ServerName = "SPRINT-IT-PC";
        //info.DatabaseName = "kmc";
        //info.UserID = "sa";
        //info.Password = "123";

        //System.Web.UI.WebControls.Table inc = new System.Web.UI.WebControls.Table();


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
        // rpt.ExportToHttpResponse(ExportFormatType.PortableDocFormat,Response, true, "PersonDetails");

        conn.Close();
        //filepath = Server.MapPath("~/" + "test.pdf");
        //rpt.ExportToDisk(ExportFormatType.PortableDocFormat, filepath);
        //System.IO.FileInfo fileinfo = new System.IO.FileInfo(filepath);
        //Response.AddHeader("Content-Disposition", "inline;filename=test.pdf");
        //Response.ContentType = "application/pdf";
        //Response.WriteFile(fileinfo.FullName);
    }
}