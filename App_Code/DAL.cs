using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

public class DAL
{
    
	public DAL()
	{
	}

    public static bool CheckAuthenticationOnly(string UserID, string UserPass)
    {

        bool var = false;
         
              SqlCommand cao_cmd = new SqlCommand();           
        cao_cmd.CommandText = "select * from userinfo where Username='" + UserID + "' and Password='" + UserPass + "'";
        cao_cmd.Connection = getConnection.getconnection(); 
		
        SqlDataReader cao_sdr = null; 


		
        cao_sdr = cao_cmd.ExecuteReader();   

        //cao_cmd.CommandType = CommandType.StoredProcedure;
        //       cao_cmd.CommandText = "sp_inside";
        //       cao_cmd.Connection = getConnection.getconnection();
        //       cao_cmd.Parameters.AddWithValue("@Username", UserID);
        //       cao_cmd.Parameters.AddWithValue("@password", UserPass);
        

            while (cao_sdr.Read())
            {
                if (UserID == cao_sdr[1].ToString() && UserPass == cao_sdr[3].ToString())
                {
                    var = true;   
                }
                else
                {
                    var = false;
                }
            }
            cao_cmd.Dispose();
            cao_sdr.Dispose();
            return var;
    }
    public static int CheckRoles(string UserID, string UserPass)
    { 
        int cr_var = 4;
        
        SqlCommand cr_cmd = new SqlCommand();
        cr_cmd.CommandText = "select * from userinfo where Username='" + UserID + "' and Password='" + UserPass + "'";
        cr_cmd.Connection = getConnection.getconnection();
        SqlDataReader cr_sdr = null;
        cr_sdr = cr_cmd.ExecuteReader();

        //cr_cmd.CommandType = CommandType.StoredProcedure;
        //    cr_cmd.CommandText = "sp_inside";
        //    cr_cmd.Connection = getConnection.getconnection();
        //    cr_cmd.Parameters.AddWithValue("@Username", UserID);
        //    cr_cmd.Parameters.AddWithValue("@password", UserPass);
        //    SqlDataReader cr_sdr = null;
        //    cr_sdr = cr_cmd.ExecuteReader();

        while (cr_sdr.Read())
        {
            if (UserID == cr_sdr[1].ToString() && UserPass == cr_sdr[3].ToString())
            {
                if (Convert.ToInt16(cr_sdr[8]) == 1)
                {
                    cr_var = 1;
                }
                else
                {
                    if (Convert.ToInt16(cr_sdr[8]) == 2)
                    {
                        cr_var = 2;
                    }
                    else
                    {
                        if (Convert.ToInt16(cr_sdr[8]) == 3)
                        {
                            cr_var = 3;
                        }
                        else
                        {
                            cr_var = 99;
                        }
                    }
                }
            }
            else
            {
             
            }
        }
        cr_cmd.Dispose();
        cr_sdr.Dispose();
        return cr_var;
    }
}
