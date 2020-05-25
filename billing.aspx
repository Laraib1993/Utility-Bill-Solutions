<%@ Page Language="C#" AutoEventWireup="true" CodeFile="billing.aspx.cs" Inherits="billing" %>

<%@ Register assembly="CrystalDecisions.Web, Version=13.0.2000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304" namespace="CrystalDecisions.Web" tagprefix="CR" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Duplicate</title>
    <link href="css/custom.css" rel="stylesheet" />
    <link href="css/custom.min.css" rel="stylesheet" />
</head>
<body style="background-color:#F7F7F7">
    <form id="form1" runat="server">
        <div style="position:relative">
    <div style="position:relative; margin-left: 500px; margin-top: 50px" >
     <asp:Label ID="lblConsumerNO" runat="server" class="control-label col-md-3 col-sm-3 col-xs-12" Text="Consumer Number" Font-Bold="True"></asp:Label>
                      
        <asp:TextBox ID="txtConsumerNo" runat="server" class="control-label col-md-3 col-sm-3 col-xs-12"></asp:TextBox>
        <asp:Button ID="btnSubmit" runat="server" Text="submit" OnClick="btnSubmit_Click" /></div> 
    <div style="position:relative; margin-left: 300px; margin-top: 50px">
        <CR:CrystalReportViewer ID="crv" runat="server" AutoDataBind="true"  Visible="true" EnableParameterPrompt="False" EnableDatabaseLogonPrompt="False"/>
        
        
        </div>
    
    </div>
    </form>
</body>
</html>
