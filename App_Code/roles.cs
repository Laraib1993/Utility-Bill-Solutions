using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

public class roles
{
	public roles()
	{

	}

    public static void addRoles(string roleName)
    {
        SqlCommand ar_cmd = new SqlCommand();
        ar_cmd.Connection = getConnection.getconnection();
        ar_cmd.CommandText = "Insert Into Roles(roleName) values('" + roleName + "')";
        ar_cmd.ExecuteReader();
    }

    public static void deleteRoles(int roleID)
    {
        SqlCommand ar_cmd = new SqlCommand();
        ar_cmd.Connection = getConnection.getconnection();
        ar_cmd.CommandText = "Delete from roles where roleID="+roleID+"";
        ar_cmd.ExecuteReader();
    }

    public static DataSet SearchAllRoles()
    {
        SqlCommand sar_cmd = new SqlCommand();
        sar_cmd.Connection = getConnection.getconnection();
        sar_cmd.CommandText = "Select * from roles";

        SqlDataAdapter sar_sda = new SqlDataAdapter(sar_cmd);
        DataSet sar_ds = new DataSet();
        sar_sda.Fill(sar_ds);

        sar_cmd.Dispose();
        sar_sda.Dispose();

        return sar_ds;

    }

    public static DataSet SearchSpecificRole(int roleName)
    {
        SqlCommand dr_cmd = new SqlCommand();
        dr_cmd.Connection = getConnection.getconnection();
        dr_cmd.CommandText = "Select * from roles where roleName=" + roleName + "";

        SqlDataAdapter dr_sda = new SqlDataAdapter(dr_cmd);
        DataSet dr_ds = new DataSet();
        dr_sda.Fill(dr_ds);

        dr_cmd.Dispose();
        dr_sda.Dispose();

        return dr_ds;
    }

}
