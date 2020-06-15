using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for properties
/// </summary>
public class properties
{
    string propertycode;
    public System.Web.UI.HtmlControls.HtmlInputFile AdminBulkInsertAyshaManzil { get; set; }
    public string Propertycode
    {
        get
        {
            return propertycode;
        }
        set
        {
            propertycode = value;
        }
    }

    string size;
    public string Plot
    {
        get
        {
            return size;
        }
        set
        {
            size = value;
        }
    }

    //Delete consumer//
    public string AdminInsertDeleteConsumer_Inwordno { get; set; }
    public string AdminInsertDeleteConsumer_InwordnoForModifyImpact { get; set; }
    public string AdminInsertDeleteConsumer_Consumerno { get; set; }
    public string AdminInsertDeleteConsumer_ConsumernoDeleteConsumer { get; set; }
    public string AdminInsertDeleteConsumer_ConsumernoConsumer { get; set; }
    public string AdminInsertDeleteConsumer_ModificationStatus { get; set; }
    public string AdminInsertDeleteConsumer_ModificationStatusModifyImpact { get; set; }
    public string AdminInsertDeleteConsumer_Createdby { get; set; }
    public string AdminInsertDeleteConsumer_CreatedbyModifyImpact { get; set; }
    public string AdminInsertDeleteConsumer_Description { get; set; }
    public string AdminInsertDeleteConsumer_DescriptionModifyImpact { get; set; }
    public string AdminInsertDeleteConsumer_Impact { get; set; }

    //Delete consumer//

    //add storey//
    public string AdminInsertAddStorey_Inwordno { get; set; }
    public string AdminInsertAddStorey_InwordModifyimpact { get; set; }
    public string AdminInsertAddStorey_Consumerno { get; set; }
    public string AdminInsertAddStorey_ConsumernoInvoice { get; set; }
    public string AdminInsertAddStorey_ConsumernoConsumer { get; set; }
    public string AdminInsertAddStorey_ModificationStatus { get; set; }
    public string AdminInsertAddStorey_ModificationStatusModifyImpact { get; set; }
    public int AdminInsertAddStorey_NewStorey { get; set; }
    public decimal AdminInsertAddStorey_NewCurrentCharge { get; set; }
    public decimal AdminInsertAddStorey_NewOutstandingArrears { get; set; }
    public string AdminInsertAddStorey_Createdby { get; set; }
    public string AdminInsertAddStorey_CreatedbyModifyimpact { get; set; }
    public string AdminInsertAddStorey_Description { get; set; }
    public string AdminInsertAddStorey_DescriptionModifyImpact { get; set; }
    public decimal AdminInsertAddStorey_Difference { get; set; }
    public string AdminInsertAddStorey_Impact { get; set; }
    //add storey//




    // change in category //
    public string AdminInsertModificationForm_ChangeOfCategory_Inword { get; set; }
    public string AdminInsertModificationForm_ChangeOfCategory_consumerno { get; set; }
    public string AdminInsertModificationForm_ChangeOfCategory_category { get; set; }
    public string AdminInsertModificationForm_ChangeOfCategory_kmccategory { get; set; }
    public decimal AdminInsertModificationForm_ChangeOfCategory_area { get; set; }
    public decimal AdminInsertModificationForm_ChangeOfCategory_currentcharges { get; set; }
    public decimal AdminInsertModificationForm_ChangeOfCategory_outstandingarrears { get; set; }
    public string AdminInsertModificationForm_ChangeOfCategory_createdby { get; set; }
    public string AdminInsertModificationForm_ChangeOfCategory_discription { get; set; }
    public string AdminInsertModificationForm_ChangeOfCategory_impact { get; set; }
    public decimal AdminInsertModificationForm_ChangeOfCategory_difference { get; set; }
    public decimal AdminInsertModificationForm_ChangeOfCategory_differencepercentage { get; set; }
    public decimal AdminInsertModificationForm_ChangeOfCategory_sqft { get; set;}
    public decimal AdminInsertModificationForm_ChangeOfCategory_sqyd { get; set; }
    public string AdminInsertModificationForm_ChangeOfCategory_sqft_sqyd { get; set; }
    // change in category //



    //change in size//
    public string AdminInsertChangeInSize_InwordNo { get; set; }
    public string AdminInsertChangeInSize_InwordmodifyImpact { get; set; }
    public string AdminInsertChangeInSize_Consumerno { get; set; }
    public string AdminInsertChangeInSize_ConsumernoInvoice { get; set; }
    public string AdminInsertChangeInSize_ConsumernoConsumer { get; set; }
    public string AdminInsertChangeInSize_ModificationStatus { get; set; }
    public string AdminInsertChangeInSize_ModificationStatusModifyimpact { get; set; }
    public decimal AdminInsertChangeInSize_NewArea { get; set; }
    public decimal AdminInsertChangeInSize_AreaForConsumer { get; set; }
    public decimal AdminInsertChangeInSize_NewCurrentCharge { get; set; }
    public decimal AdminInsertChangeInSize_NewOutstandingArrears { get; set; }
    public string AdminInsertChangeInSize_Createdby { get; set; }
    public string AdminInsertChangeInSize_CreatedbyModifyImpact { get; set; }
    public string AdminInsertChangeInSize_Description { get; set; }
    public string AdminInsertChangeInSize_DescriptionModifyImpact { get; set; }
    public decimal AdminInsertChangeInSize_Difference { get; set; }
    public string AdminInsertChangeInSize_Impact { get; set; }
    public decimal AdminInsertChangeInSize_Sqyd { get; set; }
    public decimal AdminInsertChangeInSize_Sqft { get; set; }
    //change in size//

    //delete storey//
    public string AdminInsertDeleteStorey_InwordNo { get; set; }
    public string AdminInsertDeleteStorey_InwordNoModifyImpact { get; set; }
    public string AdminInsertDeleteStorey_ConsumerNo { get; set; }
    public string AdminInsertDeleteStorey_ConsumernoConsumer { get; set; }
    public string AdminInsertDeleteStorey_ConsumernoInvoice { get; set; }
    public string AdminInsertDeleteStorey_ModificationStatus { get; set; }
    public string AdminInsertDeleteStorey_ModificatioStatusModifyImpact { get; set; }
    public int AdminInsertDeleteStorey_NewStorey { get; set; }
    public decimal AdminInsertDeleteStorey_NewCurrentCharge { get; set; }
    public decimal AdminInsertDeleteStorey_NewOutstandingArrears { get; set; }
    public string AdminInsertDeleteStorey_Createdby { get; set; }
    public string AdminInsertDeleteStorey_CreatedbyModifyImpact { get; set; }
    public string AdminInsertDeleteStorey_Description { get; set; }
    public string AdminInsertDeleteStorey_DescriptionModifyImpact { get; set; }
    public decimal AdminInsertDeleteStorey_Difference { get; set; }
    public string AdminInsertDeleteStorey_Impact { get; set; }
    //delete storey//





    // change of category & decrease of size//

    public string AdminInsertModificationForm_ChangeOfCategoryAndSize_Inword { get; set; }
    public string AdminInsertModificationForm_ChangeOfCategoryAndSize_category { get; set; }
    public string AdminInsertModificationForm_ChangeOfCategoryAndSize_kmccategory { get; set; }
    public string AdminInsertModificationForm_ChangeOfCategoryAndSize_description { get; set; }
    public int AdminInsertModificationForm_ChangeOfCategoryAndSize_storey { get; set; }
    public decimal AdminInsertModificationForm_ChangeOfCategoryAndSize_currentcharges { get; set; }
    public decimal AdminInsertModificationForm_ChangeOfCategoryAndSize_outstandingarrears { get; set; }
    public decimal AdminInsertModificationForm_ChangeOfCategoryAndSize_difference { get; set; }
    public decimal AdminInsertModificationForm_ChangeOfCategoryAndSize_diffpercentage { get; set; }
    public string AdminInsertModificationForm_ChangeOfCategoryAndSize_createdby { get; set; }
    public string AdminInsertModificationForm_ChangeOfCategoryAndSize_impact { get; set; }
    public string AdminInsertModificationForm_ChangeOfCategoryAndSize_consumerno { get; set; }
    public decimal AdminInsertModificationForm_ChangeOfCategoryAndSize_sqft { get; set; }
    public decimal AdminInsertModificationForm_ChangeOfCategoryAndSize_sqyd { get; set; }
    public string AdminInsertModificationForm_ChangeOfCategoryAndSize_sqft_sqyd { get; set; }
    public decimal AdminInsertModificationForm_ChangeOfCategoryAndSize_area { get; set; }

    // change of category & decrease of size//








    // change of category & decrease of size//

    public string AdminInsertChangeCategoryDecreaseSize_Inword { get; set; }
    public string AdminInsertChangeCategoryDecreaseSize_InwordModifyImpact { get; set; }
    public string AdminInsertChangeCategoryDecreaseSize_ConsumerNo { get; set; }
    public string AdminInsertChangeCategoryDecreaseSize_ConsumernoConsumer { get; set; }
    public string AdminInsertChangeCategoryDecreaseSize_ConsumernoInvoice { get; set; }
    public string AdminInsertChangeCategoryDecreaseSize_ModificationStatus { get; set; }
    public string AdminInsertChangeCategoryDecreaseSize_ModificationStatusModifyImpact { get; set; }
    public string AdminInsertChangeCategoryDecreaseSize_NewCategory { get; set; }
    public string AdminInsertChangeCategoryDecreaseSize_KMCCategory { get; set; }
    public string AdminInsertChangeCategoryDecreaseSize_NewCategoryForConsumer { get; set; }
    public decimal AdminInsertChangeCategoryDecreaseSize_NewArea { get; set; }
    public decimal AdminInsertChangeCategoryDecreaseSize_AreaForConsumer { get; set; }
    public decimal AdminInsertChangeCategoryDecreaseSize_NewCurrentCharge { get; set; }
    public decimal AdminInsertChangeCategoryDecreaseSize_NewOutstandingArrears { get; set; }
    public string AdminInsertChangeCategoryDecreaseSize_Createdby { get; set; }
    public string AdminInsertChangeCategoryDecreaseSize_CreatedbyModifyImpact { get; set; }
    public string AdminInsertChangeCategoryDecreaseSize_Description { get; set; }
    public string AdminInsertChangeCategoryDecreaseSize_DescriptionModifyImpact { get; set; }
    public decimal AdminInsertChangeCategoryDecreaseSize_Difference { get; set; }
    public string AdminInsertChangeCategoryDecreaseSize_Impact { get; set; }
    public decimal AdminInsertChangeCategoryDecreaseSize_SQFT { get; set; }
    public decimal AdminInsertChangeCategoryDecreaseSize_SQYD { get; set; }
    public string AdminInsertChangeSqYd_SqFt { get; set; }
    // change of category & decrease of size//

    //change of size & add storey//

    public string AdminInsertChangeSizeAddStorey_Inword { get; set; }
    public string AdminInsertChangeSizeAddStorey_InwordModifyImpact { get; set; }
    public string AdminInsertChangeSizeAddStorey_ConsumerNo { get; set; }
    public string AdminInsertChangeSizeAddStorey_ConsumernoConsumer { get; set; }
    public string AdminInsertChangeSizeAddStorey_ConsumernoInvoice { get; set; }
    public string AdminInsertChangeSizeAddStorey_ModificationStatus { get; set; }
    public string AdminInsertChangeSizeAddStorey_ModificationStatusModifyImpact { get; set; }
    public decimal AdminInsertChangeSizeAddStorey_NewArea { get; set; }
    public decimal AdminInsertChangeSizeAddStorey_AreaForConsumer { get; set; }
    public int AdminInsertChangeSizeAddStorey_NewStorey { get; set; }
    public decimal AdminInsertChangeSizeAddStorey_NewCurrentCharge { get; set; }
    public decimal AdminInsertChangeSizeAddStorey_NewOutstandingArrears { get; set; }
    public string AdminInsertChangeSizeAddStorey_Createdby { get; set; }
    public string AdminInsertChangeSizeAddStorey_CreatedbyModifyImpact { get; set; }
    public string AdminInsertChangeSizeAddStorey_Description { get; set; }
    public string AdminInsertChangeSizeAddStorey_DescriptionModifyImpact { get; set; }
    public decimal AdminInsertChangeSizeAddStorey_Difference { get; set; }
    public string AdminInsertChangeSizeAddStorey_Impact { get; set; }
    public decimal AdminInsertChangeSizeAddStorey_sqft { get; set; }
    public string AdminInsertChangeSizeAddStorey_sqydft { get; set; }
    public decimal AdminInsertChangeSizeAddStorey_sqyd { get; set; }
    //change of size & add storey//
}