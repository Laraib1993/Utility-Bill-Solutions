<%@ Page Title="" Language="VB" MasterPageFile="~/User.master" AutoEventWireup="false" CodeFile="daily_collection_report_Bank.aspx.vb" Inherits="daily_collection_report" %>

<%@ Register Assembly="CrystalDecisions.Web, Version=13.0.2000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304"
    Namespace="CrystalDecisions.Web" TagPrefix="CR" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
<title>User | Daily Collection</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<form runat="server"> 
                <asp:ScriptManager EnablePartialRendering="true" ID="ScriptManager1" runat="server"></asp:ScriptManager>
   
    <br />
<br />
<br />
<br />
<br />
    <asp:Label ID="lblmsg" runat="server" Text="Label" Visible="False"></asp:Label>

            <div align="center">
            <table border="1">
            <tr>
                <td bgcolor="#4d5b76" colspan="2" align="center">
                    <font color="white" size="3pt" ><b>Daily Collection Report Date Wise</b></font>
                </td>
            </tr>
            <tr>
                <td>
                    From Date:
                </td>
                <td>
                    <asp:TextBox ID="txtfromdate" 
                        runat="server" 
                        class="tcal"
                        Height="25px" 
                        Font-Size="12" 
                        Fone-Name = "Tahoma" 
                        Font-Bold="True" 
                        MaxLength="10"
                        Width="150px">
                    </asp:TextBox>  
                </td>        
            </tr>
            <tr>
            <td>
                To Date:
            </td>
            <td>
                <asp:TextBox ID="txttodate" 
                    runat="server" 
                    class="tcal" 
                    Height="25px" 
                    Font-Size="12" 
                    Fone-Name = "Tahoma" 
                    Font-Bold="True" 
                    MaxLength="10"
                    Width="150px"></asp:TextBox>
            </td>        
        </tr>
         <tr>
            <td>
            </td>
            <td>
                <asp:Button ID="btnprint"  runat="server" Text="Preview" OnClick="btnprint_Click" Style="height: 25px;"  />
            </td>
        </tr>
    </table>
   </div>

 </form>
</asp:Content>

