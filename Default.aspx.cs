using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using dataTableAdapters;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

public partial class _Default : System.Web.UI.Page
{
    private static SqlCommand cmd;
    private static SqlDataReader sdr;
    private static SqlDataAdapter sda;
    private static SqlConnection conn;
    ReportDocument rpt = new ReportDocument();
    protected void Page_Load(object sender, EventArgs e)
    {
        conn = new SqlConnection();
        conn.ConnectionString = ConfigurationManager.ConnectionStrings["kmcConnectionString"].ToString();
        conn.Open();
        DataSet ds = new DataSet();
        string qry = "select * from Town";
        sda = new SqlDataAdapter(qry, conn);
        sda.Fill(ds, "Town");
        rpt.Load(Server.MapPath("~/Billing.rpt"));
        rpt.FileName = Server.MapPath("~/Billing.rpt");
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
    }




}