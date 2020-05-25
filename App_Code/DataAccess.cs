
using System.Data;
using System.Data.SqlClient;
/// <summary>
/// Summary description for DataAccess
/// </summary>
public class DataAccess
{
    private static SqlCommand cmd;
    private static SqlDataReader sdr;
    private static bool state;
    public static bool inside(string id, string pass)
    {
        
        using (cmd = new SqlCommand())
{

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_inside";
            cmd.Connection = getConnection.getconnection();
            cmd.Parameters.AddWithValue("@Username", id);
            cmd.Parameters.AddWithValue("@password", pass);
            cmd.ExecuteNonQuery();

            using (sdr = null)
            {
                using (sdr = cmd.ExecuteReader())
                {
                    while (sdr.Read())
                    {


                        if (sdr[4].ToString() == "1")
                        {
                            if (sdr[3].ToString() == "1")
                            {
                                if (sdr[1].ToString() == id && sdr[2].ToString() == pass)
                                {

                                    return true;

                                }

                                else
                                {
                                    return false;
                                    
                                }
                            }
                        }




                        else 
                        {
                            if (sdr[4].ToString() == "2")
                            {
                                if (sdr[2].ToString() == "1")
                                {

                                    return false;

                                }
                                else
                                {
                                    return true;
                                   
                                }
                            }
                            else
                            {
                                return false;

                            }



                        }

                       


                    }
                    return false;
                }
                
            }

        }
    }
}