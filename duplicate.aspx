<%@ Page Title="" Language="C#" MasterPageFile="~/MainDashboard.master" AutoEventWireup="true" CodeFile="duplicate.aspx.cs" Inherits="duplicate" %>

<%@ Register Assembly="CrystalDecisions.Web, Version=13.0.2000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304" Namespace="CrystalDecisions.Web" TagPrefix="CR" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">

    <title>Duplicate</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <div class="">
        <div class="row">
         <form id="form1" runat="server">
    <div class="col-md-12 col-sm-12 col-xs-12" style="vertical-align:middle">
       <div class="form-group">
                       <asp:Label ID="lblConsumerNO" runat="server" class="control-label col-md-3 col-sm-3 col-xs-12" Text="Consumer Number" Font-Bold="True"></asp:Label>
                        <div class="col-md-3 col-sm-9 col-xs-12">

                        <%-- <asp:TextBox ID="txtConsumerNo" runat="server" type="text" class="form-control" data-validate-length-range="11" data-validate-words="2" name="name" required="required" placeholder="Consumer Number"></asp:TextBox>--%>
                         </div>
           <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click"  />
                      </div>
        <CR:CrystalReportViewer ID="crv" runat="server" AutoDataBind="true" style="vertical-align:central" Visible="False"/>
    </div>
    </form>
            </div>
    </div>
</asp:Content>

