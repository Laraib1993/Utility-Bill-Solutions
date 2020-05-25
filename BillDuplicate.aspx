<%@ Page Title="" Language="C#" MasterPageFile="~/MainDashboard.master" AutoEventWireup="true" CodeFile="BillDuplicate.aspx.cs" Inherits="BillDuplicate" %>

<%@ Register Assembly="CrystalDecisions.Web, Version=13.0.2000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304" Namespace="CrystalDecisions.Web" TagPrefix="CR" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    
    
         <form id="form1" runat="server">
    
                       <asp:Label ID="lblConsumerNO" runat="server" class="control-label col-md-3 col-sm-3 col-xs-12" Text="Consumer Number" Font-Bold="True"></asp:Label>
                       

                        <%-- <asp:TextBox ID="txtConsumerNo" runat="server" type="text" class="form-control" data-validate-length-range="11" data-validate-words="2" name="name" required="required" placeholder="Consumer Number"></asp:TextBox>--%>
                         <asp:TextBox ID="txtConsumerNo" runat="server"></asp:TextBox>
        <asp:Button ID="btnSubmit" runat="server" Text="submit" OnClick="btnSubmit_Click" />
                             
           <CR:CrystalReportViewer ID="crv" runat="server" AutoDataBind="true" ReportSourceID="crs"  />
                       <CR:CrystalReportSource ID="crs" runat="server">
                       </CR:CrystalReportSource>
                    
       
    
    </form>
         
</asp:Content>

