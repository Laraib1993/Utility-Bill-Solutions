﻿<%@ Page Title="" Language="VB" MasterPageFile="~/Dashboard.master" AutoEventWireup="false" CodeFile="completebill.aspx.vb" Inherits="completebill" %>

<%@ Register Assembly="CrystalDecisions.Web, Version=13.0.2000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304"
    Namespace="CrystalDecisions.Web" TagPrefix="CR" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
 <title>Complete Bill</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <form runat="server"> 
                <asp:ScriptManager EnablePartialRendering="true" ID="ScriptManager1" runat="server"></asp:ScriptManager>
      
  <script type="text/javascript">
      function Print() {
          var dvReport = document.getElementById("dvReport");
          var frame1 = dvReport.getElementsByTagName("iframe")[0];
          if (navigator.appName.indexOf("Internet Explorer") != -1 || navigator.appVersion.indexOf("Trident") != -1) {
              frame1.name = frame1.id;
              window.frames[frame1.id].focus();
              window.frames[frame1.id].print();
          }
          else {
              var frameDoc = frame1.contentWindow ? frame1.contentWindow : frame1.contentDocument.document ? frame1.contentDocument.document : frame1.contentDocument;
              frameDoc.print();
          }
      }
    </script>

   
      <asp:UpdatePanel ID="consumernoPanel" runat="server" UpdateMode="Conditional">
               <ContentTemplate>

      <div align="center">
             <div style="background-color:#3D566B;padding: 5px; margin: 10px 20px 10px 20px; border: 2px solid #C0C0C0;border-radius: 10px; -moz-border-radius: 10px;-webkit-border-radius: 10px;width:240px;" class="col-md-9 col-sm-9 col-xs-12">
                <table cellpadding="0" cellspacing="0" align="center" width="100%" >
                    <tr >
                        <td>
                                <asp:TextBox ID="txtconsumerno" 
                                runat="server"
                                CssClass="upper-case"
                                placeholder="A0000000000"  
                                AutoPostBack="True"
                                Width="225px" 
                                Font-Bold="True" MaxLength="11" />
                        </td>
                         
                    </tr>
                     <tr >
                        
                         <td style="margin-right:200px">
                             
                                <asp:Button ID="btnsearch" OnClick = "btnsearch_Click" Style="height: 25px;"   runat="server" Text="Preview" />
                                 <input type="button" id="btnPrint" OnClick = "btnins_Click" runat="server" Style="height: 25px;" value="Print"  OnClientClick ="Print()" />
                         </td>
                    </tr>
                     <tr>
                         <td>
                                
                         </td>
                     </tr>
                </table>
            </div>
            </div>


     <div id="dvReport" align="center">
            <CR:CrystalReportViewer ID="GPreportdatewise" 
                runat="server" 
                AutoDataBind="true" 
                EnableDatabaseLogonPrompt="False" 
                EnableParameterPrompt="False" />
    </div>
     </ContentTemplate>
           <Triggers>
                 <asp:PostBackTrigger ControlID = "btnsearch"/>
                 <asp:PostBackTrigger ControlID = "GPreportdatewise"/>
           </Triggers>
    </asp:UpdatePanel>          
        </form>
  </asp:Content>


