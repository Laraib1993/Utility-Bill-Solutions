using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Login : System.Web.UI.Page
{
    private static bool c;

    public object AdminDashBoard { get; private set; }

    protected void Page_Load(object sender, EventArgs e)
    {
        
    }

    protected void btnInSide_Click(object sender, EventArgs e)
    {

        Session["userID"] = "";
        Session["password"] = "";
        Session["roleID"] = "99";

        bool LoginStatus = false;
        LoginStatus = Convert.ToBoolean(DAL.CheckAuthenticationOnly(txtUserName.Text, txtPassword.Text));
        int RoleStatus = Convert.ToInt16(DAL.CheckRoles(txtUserName.Text, txtPassword.Text));


        if (LoginStatus == true)
        {
            if (RoleStatus == 3)
            {
                Session["userID"] = txtUserName.Text;
                Session["password"] = txtPassword.Text;
                Session["roleID"] = "3";
                Response.Redirect("UserDashboard.aspx");
            }
            else
            {
                if (RoleStatus == 2)
                {
                    Session["userID"] = txtUserName.Text;
                    Session["password"] = txtPassword.Text;
                    Session["roleID"] = "2";
                    Response.Redirect("UserDashboard.aspx");
                }
                else
                {
                    if (RoleStatus == 1)
                    {
                        Session["userID"] = txtUserName.Text;
                        Session["password"] = txtPassword.Text;
                        Session["roleID"] = "1";
                        Response.Redirect("AdminDashboard.aspx");
                    }
                    else
                    {
                        Session["userID"] = "";
                        Session["password"] = "";
                        Session["roleID"] = "99";

                        lblMessage.Text = "Invalid authentication!";
                    }
                }
            }
        }
        else
        {
            Session["userID"] = "";
            Session["password"] = "";
            Session["roleID"] = "99";
            lblMessage.Text = "Invalid authentication!";
        }
    }
}

     
