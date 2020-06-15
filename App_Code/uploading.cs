using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.IO;
using System.Data.OleDb;
using System.Data.Common;
public class uploading
{
    SqlCommand cmdd;
    SqlDataReader sdr;
    SqlConnection conn;
    OleDbConnection con;
    OleDbCommand cmd;
    DbDataReader dr;
    DataSet ds1;
    SqlDataAdapter oda1;
    DataTable Exceldt1;
    DataSet ds;
    OleDbDataAdapter oda;

    

    SqlBulkCopy bulkInsert;


    string CurrentAmount, outArrears, rebate, arrears, refected, afterreflection, percent, rebatstatus;
    double x, y, z;

    public void AdminBulkUploadAyshaManzilRebate(properties P)
    {
        if (P.AdminBulkInsertAyshaManzil.PostedFile != null)
        {
            string path = string.Concat(System.Web.HttpContext.Current.Server.MapPath("~/UploadFile/" + P.AdminBulkInsertAyshaManzil.PostedFile.FileName));
            P.AdminBulkInsertAyshaManzil.PostedFile.SaveAs(path);

            string excelCS = string.Format("Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties=Excel 8.0", path);

            using (con = new OleDbConnection(excelCS))
            {
                cmd = new OleDbCommand("select * from [Sheet1$]", con);
                con.Open();
                // Create DbDataReader to Data Worksheet  
                dr = cmd.ExecuteReader();
                // SQL Server Connection String  
                string CS = ConfigurationManager.ConnectionStrings["kmcConnectionString"].ConnectionString;
                conn = new SqlConnection();
                conn.ConnectionString = ConfigurationManager.ConnectionStrings["kmcConnectionString"].ConnectionString;
                
                ds = new DataSet();
                oda = new OleDbDataAdapter("select * from [Sheet1$]", con);
                con.Close();//close Excel connection after adding to data set  
                oda.Fill(ds);

                DataTable Exceldt = ds.Tables[0]; //copy data set to datatable 
                DataTable Exceldt2 = ds.Tables[0]; //copy data set to datatable
                bulkInsert = new SqlBulkCopy(CS);
                bulkInsert.DestinationTableName = "duplicatebill_history";  //Mapping Table column  
                bulkInsert.ColumnMappings.Add(Convert.ToInt16(0), Convert.ToInt16(1));
                bulkInsert.ColumnMappings.Add(Convert.ToInt16(1), Convert.ToInt16(2));
                bulkInsert.ColumnMappings.Add(Convert.ToInt16(2), Convert.ToInt16(5));
                bulkInsert.ColumnMappings.Add(Convert.ToInt16(3), Convert.ToInt16(6));
                bulkInsert.ColumnMappings.Add(Convert.ToInt16(4), Convert.ToInt16(3));
                bulkInsert.ColumnMappings.Add(Convert.ToInt16(5), Convert.ToInt16(4));
                bulkInsert.WriteToServer(Exceldt);

                for (int i = Exceldt.Rows.Count - 1; i >= 0; i--)
                {
                    cmdd = new SqlCommand("sp_select_inovice", conn);
                    cmdd.CommandType = CommandType.StoredProcedure;
                    string sd = Exceldt.Rows[i][0].ToString();
                    cmdd.Parameters.Add("@consumer_no", SqlDbType.VarChar).Value = Exceldt.Rows[i][0].ToString();
                    conn.Open();
                    sdr = cmdd.ExecuteReader();
                    while (sdr.Read())
                    {
                        rebatstatus = sdr[9].ToString();
                    }
                    sdr.Dispose();
                    cmd.Dispose();
                    conn.Close();
                    
                    string ccc = Exceldt.Rows[i][0].ToString();
                    string v = Exceldt.Rows[i][3].ToString();
                    if (Exceldt.Rows[i][3].ToString() != "Rebate Bill" || Convert.ToInt16(rebatstatus) == 1)
                    {
                        Exceldt.Rows[i].Delete();
                    }
                }
                Exceldt.AcceptChanges();
               

                for (int i = Exceldt.Rows.Count - 1; i >= 0; i--)
                {
                    cmdd = new SqlCommand("sp_select_inovice", conn);
                    cmdd.CommandType = CommandType.StoredProcedure;
                    string sd = Exceldt.Rows[i][0].ToString();
                    cmdd.Parameters.Add("@consumer_no", SqlDbType.VarChar).Value = Exceldt.Rows[i][0].ToString();
                    conn.Open();
                    sdr = cmdd.ExecuteReader();
                    while (sdr.Read())
                    {
                        CurrentAmount = sdr[6].ToString();
                        outArrears = sdr[7].ToString();
                        rebate = sdr[9].ToString();
                        arrears = sdr[7].ToString();
                        rebatstatus = sdr[9].ToString();
                    }
                    sdr.Dispose();
                    cmd.Dispose();
                    conn.Close();


                    x = Math.Round(Convert.ToDouble(outArrears) - (Convert.ToDouble(outArrears) * 0.25f));
                    y = Math.Round((Convert.ToDouble(outArrears) * 0.25f));
                    z = Math.Round((y * 100) / Convert.ToDouble(outArrears));

                    refected = y.ToString();
                    afterreflection = x.ToString();
                    percent = z.ToString();
                    string consumerss = Exceldt.Rows[i][0].ToString();
                    if (Convert.ToString(Exceldt.Rows[i][0]) != null || Convert.ToInt16(rebatstatus) == 0)
                    {
                        cmdd = new SqlCommand("sp_rebate2", conn);
                        cmdd.CommandType = CommandType.StoredProcedure;


                        cmdd.Parameters.Add("@consumer_no", SqlDbType.VarChar).Value = Exceldt.Rows[i][0].ToString();
                        cmdd.Parameters.Add("@after_rebate", SqlDbType.Decimal).Value = Convert.ToDouble(afterreflection);
                        cmdd.Parameters.Add("@createdby", SqlDbType.VarChar).Value = Exceldt.Rows[i][4].ToString();
                        cmdd.Parameters.Add("@createdon", SqlDbType.SmallDateTime).Value = Convert.ToDateTime(Exceldt.Rows[i][5]);
                        conn.Open();
                        cmdd.ExecuteNonQuery();
                        conn.Close();


                        cmdd = new SqlCommand("sp_rebate_reflect2", conn);
                        cmdd.CommandType = CommandType.StoredProcedure;
                        cmdd.Parameters.Add("@consumer_no", SqlDbType.VarChar).Value = Exceldt.Rows[i][0].ToString();
                        cmdd.Parameters.Add("@arrears", SqlDbType.Decimal).Value = Convert.ToDouble(afterreflection);
                        cmdd.Parameters.Add("@difference", SqlDbType.Decimal).Value = Convert.ToDouble(refected);
                        cmdd.Parameters.Add("@per", SqlDbType.Decimal).Value = Convert.ToDouble(percent);
                        cmdd.Parameters.Add("@curr_arrear", SqlDbType.Decimal).Value = Convert.ToDouble(0.05f);
                        cmdd.Parameters.Add("@createdby", SqlDbType.VarChar).Value = Exceldt.Rows[i][4].ToString();
                        cmdd.Parameters.Add("@createdon", SqlDbType.SmallDateTime).Value = Convert.ToDateTime(Exceldt.Rows[i][5]);
                        conn.Open();
                        cmdd.ExecuteNonQuery();
                        conn.Close();
                    }
                }

              
            }

        }
    }
    public void AdminBulkUploadAyshaManzil(properties P)
    {
        if (P.AdminBulkInsertAyshaManzil.PostedFile != null)
        {
            string path = string.Concat(System.Web.HttpContext.Current.Server.MapPath("~/UploadFile/" + P.AdminBulkInsertAyshaManzil.PostedFile.FileName));
            P.AdminBulkInsertAyshaManzil.PostedFile.SaveAs(path);

            string excelCS = string.Format("Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties=Excel 8.0", path);

            using (con = new OleDbConnection(excelCS))
            {
                cmd = new OleDbCommand("select * from [Sheet1$]", con);
                con.Open();
                // Create DbDataReader to Data Worksheet  
                dr = cmd.ExecuteReader();
                // SQL Server Connection String  
                string CS = ConfigurationManager.ConnectionStrings["kmcConnectionString"].ConnectionString;



                ds = new DataSet();
                oda = new OleDbDataAdapter("select * from [Sheet1$]", con);
                con.Close();//close Excel connection after adding to data set  
                oda.Fill(ds);

                DataTable Exceldt = ds.Tables[0]; //copy data set to datatable 

                for (int i = Exceldt.Rows.Count - 1; i >= 0; i--)
                {
                    string v = Exceldt.Rows[i][3].ToString();
                    if (Exceldt.Rows[i][3].ToString() == "Rebate Bill")
                    {
                        Exceldt.Rows[i].Delete();
                    }


                }

                Exceldt.AcceptChanges();


                bulkInsert = new SqlBulkCopy(CS);
                bulkInsert.DestinationTableName = "duplicatebill_history";
                //Mapping Table column  
                bulkInsert.ColumnMappings.Add(Convert.ToInt16(0), Convert.ToInt16(1));
                bulkInsert.ColumnMappings.Add(Convert.ToInt16(1), Convert.ToInt16(2));
                bulkInsert.ColumnMappings.Add(Convert.ToInt16(2), Convert.ToInt16(5));
                bulkInsert.ColumnMappings.Add(Convert.ToInt16(3), Convert.ToInt16(6));
                bulkInsert.ColumnMappings.Add(Convert.ToInt16(4), Convert.ToInt16(3));
                bulkInsert.ColumnMappings.Add(Convert.ToInt16(5), Convert.ToInt16(4));
                bulkInsert.WriteToServer(Exceldt);

            }

        }
    }

       public void AdminInsertUpdateDeleteConsumer(properties P)
    {
        using (cmdd = new SqlCommand())
        {
            cmdd.CommandType = CommandType.StoredProcedure;
            cmdd.CommandText = "sp_AdminInsertUpdate_ModificationForm_DeleteConsumer";
            cmdd.Connection = getConnection.getconnection();
            cmdd.Parameters.AddWithValue("@inword", P.AdminInsertDeleteConsumer_Inwordno);
            cmdd.Parameters.AddWithValue("@inword_modifyimpact", P.AdminInsertDeleteConsumer_InwordnoForModifyImpact);
            cmdd.Parameters.AddWithValue("@consumer_no", P.AdminInsertDeleteConsumer_Consumerno);
            cmdd.Parameters.AddWithValue("@consumer_no_deleteconsumer", P.AdminInsertDeleteConsumer_ConsumernoDeleteConsumer);
            cmdd.Parameters.AddWithValue("@consumer_no_consumer", P.AdminInsertDeleteConsumer_ConsumernoConsumer);
            cmdd.Parameters.AddWithValue("@modification_status", P.AdminInsertDeleteConsumer_ModificationStatus);
            cmdd.Parameters.AddWithValue("@modification_status_modifyimpact", P.AdminInsertDeleteConsumer_ModificationStatusModifyImpact);
            cmdd.Parameters.AddWithValue("@createdby", P.AdminInsertDeleteConsumer_Createdby);
            cmdd.Parameters.AddWithValue("@createdby_modifyimpact", P.AdminInsertDeleteConsumer_CreatedbyModifyImpact);
            cmdd.Parameters.AddWithValue("@description", P.AdminInsertDeleteConsumer_Description);
            cmdd.Parameters.AddWithValue("@description_modifyimpact", P.AdminInsertDeleteConsumer_DescriptionModifyImpact);
            cmdd.Parameters.AddWithValue("@impact", P.AdminInsertDeleteConsumer_Impact);
            cmdd.ExecuteNonQuery();

        }
    }

    public void AdminInsertUpdateAddStorey(properties P)
    {
        using (cmdd = new SqlCommand())
        {
            cmdd.CommandType = CommandType.StoredProcedure;
            cmdd.CommandText = "sp_AdminInsertUpdate_ModificationForm_AddStorey";
            cmdd.Connection = getConnection.getconnection();
            cmdd.Parameters.AddWithValue("@inword", P.AdminInsertAddStorey_Inwordno);
            cmdd.Parameters.AddWithValue("@inword_modifyimpact", P.AdminInsertAddStorey_InwordModifyimpact);
            cmdd.Parameters.AddWithValue("@consumer_no", P.AdminInsertAddStorey_Consumerno);
            cmdd.Parameters.AddWithValue("@consumer_no_invoice", P.AdminInsertAddStorey_ConsumernoInvoice);
            cmdd.Parameters.AddWithValue("@consumer_no_Consumer", P.AdminInsertAddStorey_ConsumernoConsumer);
            cmdd.Parameters.AddWithValue("@modification_status", P.AdminInsertAddStorey_ModificationStatus);
            cmdd.Parameters.AddWithValue("@modification_status_modifyimpact", P.AdminInsertAddStorey_ModificationStatusModifyImpact);
            cmdd.Parameters.AddWithValue("@new_storey", P.AdminInsertAddStorey_NewStorey);
            cmdd.Parameters.AddWithValue("@new_current_Charge", P.AdminInsertAddStorey_NewCurrentCharge);
            cmdd.Parameters.AddWithValue("@new_outstanding_Arrears", P.AdminInsertAddStorey_NewOutstandingArrears);
            cmdd.Parameters.AddWithValue("@createdby", P.AdminInsertAddStorey_Createdby);
            cmdd.Parameters.AddWithValue("@createdby_modifyimpact", P.AdminInsertAddStorey_CreatedbyModifyimpact);
            cmdd.Parameters.AddWithValue("@description", P.AdminInsertAddStorey_Description);
            cmdd.Parameters.AddWithValue("@description_modifyimpact", P.AdminInsertAddStorey_DescriptionModifyImpact);
            cmdd.Parameters.AddWithValue("@difference", P.AdminInsertAddStorey_Difference);
            cmdd.Parameters.AddWithValue("@impact", P.AdminInsertAddStorey_Impact);
            cmdd.ExecuteNonQuery();

        }
    }


    public void AdminInsertUpdateChangeInSize(properties P)
    {
        using (cmdd = new SqlCommand())
        {
            cmdd.CommandType = CommandType.StoredProcedure;
            cmdd.CommandText = "sp_AdminInsertUpdate_ModificationForm_ChangeInSize";
            cmdd.Connection = getConnection.getconnection();
            cmdd.Parameters.AddWithValue("@inword", P.AdminInsertChangeInSize_InwordNo);
            cmdd.Parameters.AddWithValue("@inword_modifyimpact", P.AdminInsertChangeInSize_InwordmodifyImpact);
            cmdd.Parameters.AddWithValue("@consumer_no", P.AdminInsertChangeInSize_Consumerno);
            cmdd.Parameters.AddWithValue("@consumer_no_invoice", P.AdminInsertChangeInSize_ConsumernoInvoice);
            cmdd.Parameters.AddWithValue("@consumer_no_Consumer", P.AdminInsertChangeInSize_ConsumernoConsumer);
            cmdd.Parameters.AddWithValue("@modification_status", P.AdminInsertChangeInSize_ModificationStatus);
            cmdd.Parameters.AddWithValue("@modification_status_modifyimpact", P.AdminInsertChangeInSize_ModificationStatusModifyimpact);
            cmdd.Parameters.AddWithValue("@new_area", P.AdminInsertChangeInSize_NewArea);
            cmdd.Parameters.AddWithValue("@AreaForConsumer", P.AdminInsertChangeInSize_AreaForConsumer);
            cmdd.Parameters.AddWithValue("@new_current_Charge", P.AdminInsertChangeInSize_NewCurrentCharge);
            cmdd.Parameters.AddWithValue("@new_outstanding_Arrears", P.AdminInsertChangeInSize_NewOutstandingArrears);
            cmdd.Parameters.AddWithValue("@createdby", P.AdminInsertChangeInSize_Createdby);
            cmdd.Parameters.AddWithValue("@createdby_modifyimpact", P.AdminInsertChangeInSize_CreatedbyModifyImpact);
            cmdd.Parameters.AddWithValue("@description", P.AdminInsertChangeInSize_Description);
            cmdd.Parameters.AddWithValue("@description_modifyimpact", P.AdminInsertChangeInSize_DescriptionModifyImpact);
            cmdd.Parameters.AddWithValue("@difference", P.AdminInsertChangeInSize_Difference);
            cmdd.Parameters.AddWithValue("@impact", P.AdminInsertChangeInSize_Impact);
            cmdd.Parameters.AddWithValue("@sq_ft", P.AdminInsertChangeInSize_Sqft);
            cmdd.Parameters.AddWithValue("@sq_yd", P.AdminInsertChangeInSize_Sqyd);
            cmdd.ExecuteNonQuery();

        }
    }


    public void AdminInsertUpdateDeleteStorey(properties P)
    {
        using (cmdd = new SqlCommand())
        {
            cmdd.CommandType = CommandType.StoredProcedure;
            cmdd.CommandText = "sp_AdminInsertUpdate_ModificationForm_DeleteStorey";
            cmdd.Connection = getConnection.getconnection();
            cmdd.Parameters.AddWithValue("@inword", P.AdminInsertDeleteStorey_InwordNo);
            cmdd.Parameters.AddWithValue("@inword_modifyimpact", P.AdminInsertDeleteStorey_InwordNoModifyImpact);
            cmdd.Parameters.AddWithValue("@consumer_no", P.AdminInsertDeleteStorey_ConsumerNo);
            cmdd.Parameters.AddWithValue("@consumer_no_Consumer", P.AdminInsertDeleteStorey_ConsumernoConsumer);
            cmdd.Parameters.AddWithValue("@consumer_no_invoice", P.AdminInsertDeleteStorey_ConsumernoInvoice);
            cmdd.Parameters.AddWithValue("@modification_status", P.AdminInsertDeleteStorey_ModificationStatus);
            cmdd.Parameters.AddWithValue("@modification_status_modifyimpact", P.AdminInsertDeleteStorey_ModificatioStatusModifyImpact);
            cmdd.Parameters.AddWithValue("@new_storey", P.AdminInsertDeleteStorey_NewStorey);
            cmdd.Parameters.AddWithValue("@new_current_Charge", P.AdminInsertDeleteStorey_NewCurrentCharge);
            cmdd.Parameters.AddWithValue("@new_outstanding_Arrears", P.AdminInsertDeleteStorey_NewOutstandingArrears);
            cmdd.Parameters.AddWithValue("@createdby", P.AdminInsertDeleteStorey_Createdby);
            cmdd.Parameters.AddWithValue("@createdby_modifyimpact", P.AdminInsertDeleteStorey_CreatedbyModifyImpact);
            cmdd.Parameters.AddWithValue("@description", P.AdminInsertDeleteStorey_Description);
            cmdd.Parameters.AddWithValue("@description_modifyimpact", P.AdminInsertDeleteStorey_DescriptionModifyImpact);
            cmdd.Parameters.AddWithValue("@difference", P.AdminInsertDeleteStorey_Difference);
            cmdd.Parameters.AddWithValue("@impact", P.AdminInsertDeleteStorey_Impact);
            cmdd.ExecuteNonQuery();

        }
    }




    public void AdminInsertUpdateChangeCategory(properties P)
    {
        using (cmdd = new SqlCommand())
        {
            cmdd.CommandType = CommandType.StoredProcedure;
            cmdd.CommandText = "sp_AdminInsertUpdate_ModificationForm_ChangeInCategory";
            cmdd.Connection = getConnection.getconnection();
            cmdd.Parameters.AddWithValue("@inword", P.AdminInsertModificationForm_ChangeOfCategory_Inword);
            cmdd.Parameters.AddWithValue("@ConsumerNo", P.AdminInsertModificationForm_ChangeOfCategory_consumerno);
            cmdd.Parameters.AddWithValue("@NewCategory", P.AdminInsertModificationForm_ChangeOfCategory_category);
            cmdd.Parameters.AddWithValue("@kmcCategory", P.AdminInsertModificationForm_ChangeOfCategory_kmccategory);
            cmdd.Parameters.AddWithValue("@NewArea", P.AdminInsertModificationForm_ChangeOfCategory_area);
            cmdd.Parameters.AddWithValue("@NewCurrentCharges", P.AdminInsertModificationForm_ChangeOfCategory_currentcharges);
            cmdd.Parameters.AddWithValue("@NewOutstandingArrears", P.AdminInsertModificationForm_ChangeOfCategory_outstandingarrears);
            cmdd.Parameters.AddWithValue("@createdby", P.AdminInsertModificationForm_ChangeOfCategory_createdby);
            cmdd.Parameters.AddWithValue("@description", P.AdminInsertModificationForm_ChangeOfCategory_discription);
            cmdd.Parameters.AddWithValue("@impact", P.AdminInsertModificationForm_ChangeOfCategory_impact);
            cmdd.Parameters.AddWithValue("@difference", P.AdminInsertModificationForm_ChangeOfCategory_difference);
            cmdd.Parameters.AddWithValue("@differnceperc", P.AdminInsertModificationForm_ChangeOfCategory_differencepercentage);
            cmdd.Parameters.AddWithValue("@sq_ft", P.AdminInsertModificationForm_ChangeOfCategory_sqft);
            cmdd.Parameters.AddWithValue("@sq_yd", P.AdminInsertModificationForm_ChangeOfCategory_sqyd);
            cmdd.Parameters.AddWithValue("@Sqft_Sqyd", P.AdminInsertModificationForm_ChangeOfCategory_sqft_sqyd);
            cmdd.ExecuteNonQuery();
        }
    }



    public void AdminInsertUpdateChangeCategoryAddStorey(properties P)
    {
        using (cmdd = new SqlCommand())
        {
            cmdd.CommandType = CommandType.StoredProcedure;
            cmdd.CommandText = "sp_AdminInsertUpdate_ModificationForm_ChangeOfCategoryAndStorey";
            cmdd.Connection = getConnection.getconnection();
            cmdd.Parameters.AddWithValue("@inword", P.AdminInsertModificationForm_ChangeOfCategoryAndSize_Inword);
            cmdd.Parameters.AddWithValue("@category", P.AdminInsertModificationForm_ChangeOfCategoryAndSize_category);
            cmdd.Parameters.AddWithValue("@kmccategory", P.AdminInsertModificationForm_ChangeOfCategoryAndSize_kmccategory);
            cmdd.Parameters.AddWithValue("@description", P.AdminInsertModificationForm_ChangeOfCategoryAndSize_description);
            cmdd.Parameters.AddWithValue("@Storey", P.AdminInsertModificationForm_ChangeOfCategoryAndSize_storey);
            cmdd.Parameters.AddWithValue("@current_Charge", P.AdminInsertModificationForm_ChangeOfCategoryAndSize_currentcharges);
            cmdd.Parameters.AddWithValue("@outstanding_Arrears", P.AdminInsertModificationForm_ChangeOfCategoryAndSize_outstandingarrears);
            cmdd.Parameters.AddWithValue("@difference", P.AdminInsertModificationForm_ChangeOfCategoryAndSize_difference);
            cmdd.Parameters.AddWithValue("@difference_percentage", P.AdminInsertModificationForm_ChangeOfCategoryAndSize_diffpercentage);
            cmdd.Parameters.AddWithValue("@createdby", P.AdminInsertModificationForm_ChangeOfCategoryAndSize_createdby);
            cmdd.Parameters.AddWithValue("@impact", P.AdminInsertModificationForm_ChangeOfCategoryAndSize_impact);
            cmdd.Parameters.AddWithValue("@consumer_no", P.AdminInsertModificationForm_ChangeOfCategoryAndSize_consumerno);
            cmdd.Parameters.AddWithValue("@sq_ft", P.AdminInsertModificationForm_ChangeOfCategoryAndSize_sqft);
            cmdd.Parameters.AddWithValue("@sq_yd", P.AdminInsertModificationForm_ChangeOfCategoryAndSize_sqyd);
            cmdd.Parameters.AddWithValue("@sqft_sqyd", P.AdminInsertModificationForm_ChangeOfCategoryAndSize_sqft_sqyd);
            cmdd.Parameters.AddWithValue("@area", P.AdminInsertModificationForm_ChangeOfCategoryAndSize_area);
            cmdd.ExecuteNonQuery();
        }
    }
    public void AdminInsertUpdateChangeCategoryDecreaseSize(properties P)
    {
        using (cmdd = new SqlCommand())
        {
            cmdd.CommandType = CommandType.StoredProcedure;
            cmdd.CommandText = "sp_AdminInsertUpdate_ModificationForm_ChangeOfCategory_DecreaseOfSize";
            cmdd.Connection = getConnection.getconnection();
            cmdd.Parameters.AddWithValue("@inword", P.AdminInsertChangeCategoryDecreaseSize_Inword);
            cmdd.Parameters.AddWithValue("@inword_modifyimpact", P.AdminInsertChangeCategoryDecreaseSize_InwordModifyImpact);
            cmdd.Parameters.AddWithValue("@consumer_no", P.AdminInsertChangeCategoryDecreaseSize_ConsumerNo);
            cmdd.Parameters.AddWithValue("@consumer_no_Consumer", P.AdminInsertChangeCategoryDecreaseSize_ConsumernoConsumer);
            cmdd.Parameters.AddWithValue("@consumer_no_invoice", P.AdminInsertChangeCategoryDecreaseSize_ConsumernoInvoice);
            cmdd.Parameters.AddWithValue("@modification_status", P.AdminInsertChangeCategoryDecreaseSize_ModificationStatus);
            cmdd.Parameters.AddWithValue("@modification_status_modifyimpact", P.AdminInsertChangeCategoryDecreaseSize_ModificationStatusModifyImpact);
            cmdd.Parameters.AddWithValue("@new_category", P.AdminInsertChangeCategoryDecreaseSize_NewCategory);
            cmdd.Parameters.AddWithValue("@kmc_category", P.AdminInsertChangeCategoryDecreaseSize_KMCCategory);
            cmdd.Parameters.AddWithValue("@new_categoryForConsumer", P.AdminInsertChangeCategoryDecreaseSize_NewCategoryForConsumer);
            cmdd.Parameters.AddWithValue("@new_area", P.AdminInsertChangeCategoryDecreaseSize_NewArea);
            cmdd.Parameters.AddWithValue("@AreaForConsumer", P.AdminInsertChangeCategoryDecreaseSize_AreaForConsumer);
            cmdd.Parameters.AddWithValue("@new_current_Charge", P.AdminInsertChangeCategoryDecreaseSize_NewCurrentCharge);
            cmdd.Parameters.AddWithValue("@new_outstanding_Arrears", P.AdminInsertChangeCategoryDecreaseSize_NewOutstandingArrears);
            cmdd.Parameters.AddWithValue("@createdby", P.AdminInsertChangeCategoryDecreaseSize_Createdby);
            cmdd.Parameters.AddWithValue("@createdby_modifyimpact", P.AdminInsertChangeCategoryDecreaseSize_CreatedbyModifyImpact);
            cmdd.Parameters.AddWithValue("@description", P.AdminInsertChangeCategoryDecreaseSize_Description);
            cmdd.Parameters.AddWithValue("@description_modifyimpact", P.AdminInsertChangeCategoryDecreaseSize_DescriptionModifyImpact);
            cmdd.Parameters.AddWithValue("@difference", P.AdminInsertChangeCategoryDecreaseSize_Difference);
            cmdd.Parameters.AddWithValue("@impact", P.AdminInsertChangeCategoryDecreaseSize_Impact);
            cmdd.Parameters.AddWithValue("@sq_ft", P.AdminInsertChangeCategoryDecreaseSize_SQFT);
            cmdd.Parameters.AddWithValue("@sq_yd", P.AdminInsertChangeCategoryDecreaseSize_SQYD);
            cmdd.Parameters.AddWithValue("@sqft_sqyd", P.AdminInsertChangeSqYd_SqFt);
            cmdd.ExecuteNonQuery();

        }
    }


    public void AdminInsertUpdateChangeSizeAddStorey(properties P)
    {
        using (cmdd = new SqlCommand())
        {
            cmdd.CommandType = CommandType.StoredProcedure;
            cmdd.CommandText = "sp_AdminInsertUpdate_ModificationForm_ChangeofSize_AddStorey";
            cmdd.Connection = getConnection.getconnection();
            cmdd.Parameters.AddWithValue("@inword", P.AdminInsertChangeSizeAddStorey_Inword);
            cmdd.Parameters.AddWithValue("@inword_modifyimpact", P.AdminInsertChangeSizeAddStorey_InwordModifyImpact);
            cmdd.Parameters.AddWithValue("@consumer_no", P.AdminInsertChangeSizeAddStorey_ConsumerNo);
            cmdd.Parameters.AddWithValue("@consumer_no_Consumer", P.AdminInsertChangeSizeAddStorey_ConsumernoConsumer);
            cmdd.Parameters.AddWithValue("@consumer_no_invoice", P.AdminInsertChangeSizeAddStorey_ConsumernoInvoice);
            cmdd.Parameters.AddWithValue("@modification_status", P.AdminInsertChangeSizeAddStorey_ModificationStatus);
            cmdd.Parameters.AddWithValue("@modification_status_modifyimpact", P.AdminInsertChangeSizeAddStorey_ModificationStatusModifyImpact);
            cmdd.Parameters.AddWithValue("@new_area", P.AdminInsertChangeSizeAddStorey_NewArea);
            cmdd.Parameters.AddWithValue("@AreaForConsumer", P.AdminInsertChangeSizeAddStorey_AreaForConsumer);
            cmdd.Parameters.AddWithValue("@new_storey", P.AdminInsertChangeSizeAddStorey_NewStorey);
            cmdd.Parameters.AddWithValue("@new_current_Charge", P.AdminInsertChangeSizeAddStorey_NewCurrentCharge);
            cmdd.Parameters.AddWithValue("@new_outstanding_Arrears", P.AdminInsertChangeSizeAddStorey_NewOutstandingArrears);
            cmdd.Parameters.AddWithValue("@createdby", P.AdminInsertChangeSizeAddStorey_Createdby);
            cmdd.Parameters.AddWithValue("@createdby_modifyimpact", P.AdminInsertChangeSizeAddStorey_CreatedbyModifyImpact);
            cmdd.Parameters.AddWithValue("@description", P.AdminInsertChangeSizeAddStorey_Description);
            cmdd.Parameters.AddWithValue("@description_modifyimpact", P.AdminInsertChangeSizeAddStorey_DescriptionModifyImpact);
            cmdd.Parameters.AddWithValue("@difference", P.AdminInsertChangeSizeAddStorey_Difference);
            cmdd.Parameters.AddWithValue("@impact", P.AdminInsertChangeSizeAddStorey_Impact);
            cmdd.Parameters.AddWithValue("@sq_ft", P.AdminInsertChangeSizeAddStorey_sqft);
            cmdd.Parameters.AddWithValue("@sq_yd", P.AdminInsertChangeSizeAddStorey_sqyd);
            cmdd.Parameters.AddWithValue("@sqft_sqyd", P.AdminInsertChangeSizeAddStorey_sqydft);
            cmdd.ExecuteNonQuery();
        }
    }
}