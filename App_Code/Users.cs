using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

/// <summary>
/// Summary description for Users
/// </summary>
public class Users
{
    public static string RequestCount;
    public static string UserCount;
    public static string StudentCount;
    public static string FacultyCount;
    public static bool AlreadyUser = false;

    public static DataSet GetUserRequest()
    {
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = getConnection.getconnection();
        cmd.CommandText = "Select userID as UserName,roleID as Role, requestStatus from users";

        SqlDataAdapter sda = new SqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        sda.Fill(ds);
        return ds;
    }

    public static DataSet GetUserRequestList()
    {
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = getConnection.getconnection();
        cmd.CommandText = "Select u.userID as UserID,r.roleName as RoleName,rs.roleStatus RequestStatus from Users as u,Roles as r,roleStatus as rs Where u.roleID=r.roleID and u.RequestStatus=rs.roleStatusID";
        //cmd.CommandText = "Select userID as UserName,roleID as Role, requestStatus from users where RequestStatus=0";

        SqlDataAdapter sda = new SqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        sda.Fill(ds);
        return ds;
    }

    public static string GetRequestCount()
    {
        SqlCommand grc_cmd = new SqlCommand();
        grc_cmd.Connection = getConnection.getconnection();
        grc_cmd.CommandText = "Select Count(*) from Users where RequestStatus=0";

        SqlDataReader grc_sdr = null;
        grc_sdr = grc_cmd.ExecuteReader();

        while (grc_sdr.Read())
        {
            RequestCount = grc_sdr[0].ToString();
        }
        grc_cmd.Dispose();
        grc_sdr.Dispose();
        return RequestCount;
    }

    public static string GetUserCount()
    {
            SqlCommand guc_cmd = new SqlCommand();
            guc_cmd.Connection = getConnection.getconnection();
            guc_cmd.CommandText = "Select Count(*) from Users";

            SqlDataReader guc_sdr = null;
            guc_sdr = guc_cmd.ExecuteReader();

            while (guc_sdr.Read())
            {
                UserCount = guc_sdr[0].ToString();
            }
            guc_cmd.Dispose();
            guc_sdr.Dispose();
        
        return UserCount;

    }

    public static string GetStudentCount()
    {
        SqlCommand gsc_cmd = new SqlCommand();
        gsc_cmd.Connection = getConnection.getconnection();
        gsc_cmd.CommandText = "Select Count(*) from Users where roleID=1";

        SqlDataReader gsc_sdr = null;
        gsc_sdr = gsc_cmd.ExecuteReader();

        while (gsc_sdr.Read())
        {
            StudentCount = gsc_sdr[0].ToString();
        }
        gsc_cmd.Dispose();
        gsc_sdr.Dispose();
        return StudentCount;
    }

    public static string GetFacultyCount()
    {
        SqlCommand gfc_cmd = new SqlCommand();
        gfc_cmd.Connection = getConnection.getconnection();
        gfc_cmd.CommandText = "Select Count(*) from Users where roleID=2";

        SqlDataReader gfc_sdr = null;
        gfc_sdr = gfc_cmd.ExecuteReader();

        while (gfc_sdr.Read())
        {
            FacultyCount = gfc_sdr[0].ToString();
        }
        gfc_cmd.Dispose();
        gfc_sdr.Dispose();
        return FacultyCount;
    }

    public static void RegisterUser(string userID,string password,string passwordHint,string passwordhintAnswer,int roleID,int RequestStatus,string emailID,string Address)
    {
        SqlCommand ru_cmd = new SqlCommand();
        ru_cmd.Connection = getConnection.getconnection();
        ru_cmd.CommandText = "insert into users(userID,password,passwordHint,passwordhintAnswer,roleID,RequestStatus,emailID,Address) values('" + userID + "','" + password + "','" + passwordHint + "','" + passwordhintAnswer + "'," + roleID + "," + RequestStatus + ",'" + emailID + "','" + Address + "')";
        ru_cmd.ExecuteReader();

        ru_cmd.Dispose();
    }

    public static bool CheckAlreadyUser(string userID)
    {
        SqlCommand cau_cmd = new SqlCommand();
        SqlDataReader cau_sdr = null;
        cau_cmd.Connection = getConnection.getconnection();
        cau_cmd.CommandText = "select * from users where userID='" + userID + "'";
        cau_sdr = cau_cmd.ExecuteReader();

        if (cau_sdr.HasRows)
        {
            AlreadyUser = true;        
        }
        else
        {
            AlreadyUser = false;
        }
        cau_sdr.Dispose();
        cau_cmd.Dispose();
        return AlreadyUser;
    }
}
