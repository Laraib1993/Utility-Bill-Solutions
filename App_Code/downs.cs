using System.Data;
using System.Data.SqlClient;
using System.Collections;
using System.Collections.Generic;
using System.Web.UI.WebControls;
using System.Configuration;
using System;

/// <summary>
/// Summary description for downs
/// </summary>
public class downs
{
    private static SqlCommand cmd;
    
    // properties p = new properties();
    properties p = new properties();
    SqlConnection conn;
    

  public downs()
    {
        
    }


    public static List<ListItem> propertytypemodification()
    {
        SqlConnection conn = new SqlConnection();
        conn.ConnectionString = ConfigurationManager.ConnectionStrings["kmcConnectionString"].ConnectionString;
        using (cmd = new SqlCommand("sp_PropertyType", conn))
        {
            List<ListItem> div = new List<ListItem>();
            cmd.CommandType = CommandType.StoredProcedure;
            conn.Open();
            using (SqlDataReader sdr = cmd.ExecuteReader())
            {
                while (sdr.Read())
                {

                    div.Add(new ListItem
                    {
                        Value = sdr[2].ToString() + "-" + sdr[1].ToString(),
                        Text = sdr[1].ToString(),


                    });



                }
            }

            return div;
        }

    }

    public static List<ListItem> listpostingvoucherqtrbank()
    {
        SqlConnection conn = new SqlConnection();
        conn.ConnectionString = ConfigurationManager.ConnectionStrings["kmcConnectionString"].ConnectionString;
        using (cmd = new SqlCommand("sp_postingvoucherqtrBank", conn))
        {
            List<ListItem> div = new List<ListItem>();



            cmd.CommandType = CommandType.StoredProcedure;
            conn.Open();



            using (SqlDataReader sdr = cmd.ExecuteReader())
            {
                while (sdr.Read())
                {
                    div.Add(new ListItem
                    {
                        Value = sdr[0].ToString(),
                        Text = sdr[0].ToString()
                    });
                }
            }

            return div;


        }


    }


    public static List<ListItem> listZone()
    {
         SqlConnection conn = new SqlConnection();
        conn.ConnectionString = ConfigurationManager.ConnectionStrings["kmcConnectionString"].ConnectionString;
        using (cmd = new SqlCommand("sp_zone", conn))
        {
            List<ListItem> div = new List<ListItem>();
           
            
    
            cmd.CommandType = CommandType.StoredProcedure;
            conn.Open();
            
            

            using (SqlDataReader sdr = cmd.ExecuteReader())
            {
                while (sdr.Read())
                {
                    div.Add(new ListItem
                    {
                        Value = sdr[0].ToString(),
                        Text = sdr[1].ToString()
                    });
                }
            }

            return div;
           
         
        }
        

    }
	
	public static List<ListItem> listTown()
    {
        SqlConnection conn = new SqlConnection();
        conn.ConnectionString = ConfigurationManager.ConnectionStrings["kmcConnectionString"].ConnectionString;
        using (cmd = new SqlCommand("sp_Town", conn))
        {
            List<ListItem> div = new List<ListItem>();



            cmd.CommandType = CommandType.StoredProcedure;
            conn.Open();



            using (SqlDataReader sdr = cmd.ExecuteReader())
            {
                while (sdr.Read())
                {
                    div.Add(new ListItem
                    {
                        Value = sdr[0].ToString(),
                        Text = sdr[1].ToString()
                    });
                }
            }

            return div;


        }


    }

    public static List<ListItem> SelectedTown(int a)
    {
        SqlConnection conn = new SqlConnection();
        conn.ConnectionString = ConfigurationManager.ConnectionStrings["kmcConnectionString"].ConnectionString;
        using (cmd = new SqlCommand("sp_SelectTown",conn))
        {
            List<ListItem> div = new List<ListItem>();
            cmd.CommandType = CommandType.StoredProcedure;
            conn.Open();
            

            cmd.Parameters.AddWithValue("@status", a);

            using (SqlDataReader sdr = cmd.ExecuteReader())
            {
                while (sdr.Read())
                {
                    div.Add(new ListItem
                    {
                        Value = sdr[0].ToString(),
                        Text = sdr[1].ToString()
                    });

                }
            }

            return div;


        }
    }


    public static List<ListItem> SelectedUC(int a)
    {

        SqlConnection conn = new SqlConnection();
        conn.ConnectionString = ConfigurationManager.ConnectionStrings["kmcConnectionString"].ConnectionString;
        using (cmd = new SqlCommand("sp_selectUC",conn))
        {
            List<ListItem> div = new List<ListItem>();
            cmd.CommandType = CommandType.StoredProcedure;
            conn.Open();

            cmd.Parameters.AddWithValue("@townid", a);

            using (SqlDataReader sdr = cmd.ExecuteReader())
            {
                while (sdr.Read())
                {
                    div.Add(new ListItem
                    {
                        Value = sdr[0].ToString(),
                        Text = sdr[1].ToString()
                    });
                }
            }

            return div;


        }
    }

    public static List<ListItem> SelectedBlock(int a, int b)
    {
        SqlConnection conn = new SqlConnection();
        conn.ConnectionString = ConfigurationManager.ConnectionStrings["kmcConnectionString"].ConnectionString;
        properties p = new properties();
        using (cmd = new SqlCommand("sp_SelectBlock",conn))
        {
            List<ListItem> div = new List<ListItem>();
            cmd.CommandType = CommandType.StoredProcedure;
            conn.Open();

            cmd.Parameters.AddWithValue("@ucid", a);
            cmd.Parameters.AddWithValue("@townid", b);

            using (SqlDataReader sdr = cmd.ExecuteReader())
            {
                while (sdr.Read())
                {
                    div.Add(new ListItem
                    {
                        Value = sdr[0].ToString(),
                        Text = sdr[1].ToString()
                    });

                    
                }
               
            }

            return div;


        }
    }


    public static List<ListItem> propertytypeModificatioin()
    {
        SqlConnection conn = new SqlConnection();
        conn.ConnectionString = ConfigurationManager.ConnectionStrings["kmcConnectionString"].ConnectionString;
        using (cmd = new SqlCommand("sp_PropertyType", conn))
        {
            List<ListItem> div = new List<ListItem>();
            cmd.CommandType = CommandType.StoredProcedure;
            conn.Open();
            using (SqlDataReader sdr = cmd.ExecuteReader())
            {
                while (sdr.Read())
                {

                    div.Add(new ListItem
                    {
                        Value = sdr[0].ToString(),
                        Text = sdr[1].ToString(),



                    });



                }
            }

            return div;
        }

    }

    public static List<ListItem> propertytype(int a)
    {
        SqlConnection conn = new SqlConnection();
        conn.ConnectionString = ConfigurationManager.ConnectionStrings["kmcConnectionString"].ConnectionString;
        using (cmd = new SqlCommand("sp_PropertyType",conn))
        {
            List<ListItem> div = new List<ListItem>();
            cmd.CommandType = CommandType.StoredProcedure;
            conn.Open();
            using (SqlDataReader sdr = cmd.ExecuteReader())
            {
                while (sdr.Read())
                {

                    div.Add(new ListItem
                    {
                        Value = sdr[0].ToString(),
                        Text = sdr[1].ToString(),


                    });



                }
            }

            return div;
        }

    }


    public static List<ListItem> category(int a)
    {
        SqlConnection conn = new SqlConnection();
        conn.ConnectionString = ConfigurationManager.ConnectionStrings["kmcConnectionString"].ConnectionString;
        using (cmd = new SqlCommand("sp_category", conn))
        {
            List<ListItem> div = new List<ListItem>();
            cmd.CommandType = CommandType.StoredProcedure;
            conn.Open();
            cmd.Parameters.AddWithValue("@propertyTypeID", a);
            using (SqlDataReader sdr = cmd.ExecuteReader())
            {
                while (sdr.Read())
                {

                    div.Add(new ListItem
                    {
                        Value = sdr[0].ToString(),
                        Text = sdr[1].ToString(),


                    });



                }
            }

            return div;
        }

    }


    public int plot(int a)
    {
        using (cmd = new SqlCommand())
        {
            
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_Plot";
            cmd.Parameters.AddWithValue("@type", a);
            cmd.Connection = getConnection.getconnection();
            using (SqlDataReader sdr = cmd.ExecuteReader())
            {
                while (sdr.Read())
                {

                    if (Convert.ToInt32(p.Plot) >= Convert.ToInt32(sdr[0].ToString()) && Convert.ToInt32(p.Plot) <= Convert.ToInt32(sdr[1].ToString()))
                    {
                        a = Convert.ToInt32(sdr[2].ToString());
                    }


                }
                return a;
            }

           
        }

        


    }
	
	public static List<ListItem> listbillingperiod()
    {
        SqlConnection conn = new SqlConnection();
        conn.ConnectionString = ConfigurationManager.ConnectionStrings["kmcConnectionString"].ConnectionString;
        using (cmd = new SqlCommand("sp_billing_period", conn))
        {
            List<ListItem> div = new List<ListItem>();



            cmd.CommandType = CommandType.StoredProcedure;
            conn.Open();



            using (SqlDataReader sdr = cmd.ExecuteReader())
            {
                while (sdr.Read())
                {
                    div.Add(new ListItem
                    {
                        Value = sdr[0].ToString(),
                        Text = sdr[1].ToString()
                    });
                }
            }

            return div;


        }


    }
}