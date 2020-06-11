using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AyshaManzil : System.Web.UI.Page
{
    properties P = new properties();
    uploading bill = new uploading();
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnsubmit_Click(object sender, EventArgs e)
    {
        P.AdminBulkInsertAyshaManzil = filer_input1;
      //  bill.AdminBulkUploadAyshaManzilRebate(P);
        bill.AdminBulkUploadAyshaManzil(P);
    }
}