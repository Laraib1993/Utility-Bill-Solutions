using System.Data.SqlClient;
using System.Configuration;

/// <summary>
/// Summary description for getConnection
/// </summary>
public class getConnection
{
    private static SqlConnection conn;
    public static SqlConnection getconnection()
    {
        if (conn == null)
        {
            conn = new SqlConnection();
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["kmcConnectionString"].ConnectionString;
            conn.Open();
			
            
        }
        return conn;
    }
}