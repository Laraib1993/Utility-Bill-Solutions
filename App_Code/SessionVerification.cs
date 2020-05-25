using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

public class SessionVerification
{
    public static bool verification = false;

    public SessionVerification()
    {
    }

    public static bool GetSpecificVerification(string userID, string password)
    {
        int roleID=Convert.ToInt16(DAL.CheckRoles(userID, password));
        if (roleID == 3)
        {
            verification = DAL.CheckAuthenticationOnly(userID, password);
        }
        else
        {
            verification = false;
        }
        return verification;
    }


    public static bool GetUserVerification(string userID, string password)
    {
        int roleID = Convert.ToInt16(DAL.CheckRoles(userID, password));
        if (roleID == 2 || roleID == 3)
        {
            verification = DAL.CheckAuthenticationOnly(userID, password);
        }
        else
        {
            verification = false;
        }
        return verification;
    }

    public static bool GetAdminVerification(string userID, string password)
    {
        int roleID = Convert.ToInt16(DAL.CheckRoles(userID, password));
        if (roleID == 1)
        {
            verification = DAL.CheckAuthenticationOnly(userID, password);
        }
        else
        {
            verification = false;
        }
        return verification;
    }


}
