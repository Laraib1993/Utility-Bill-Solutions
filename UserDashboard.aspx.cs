using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class UserDashboard : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string userID = Session["userID"].ToString();
        string password = Session["password"].ToString();
        int roleID = Convert.ToInt16(Session["roleID"]);
        bool verifiedStatus = SessionVerification.GetUserVerification(userID, password);
        if (verifiedStatus == false)
        {
            Server.Transfer("Login.aspx");
        }
        else
        {

        }
    }
}