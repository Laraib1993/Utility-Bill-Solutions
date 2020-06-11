<%@ Page Title="" Language="C#" MasterPageFile="~/User.master" AutoEventWireup="true" CodeFile="ChangeInSize.aspx.cs" Inherits="ChangeInSize" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <title>KMC | Consumer Session</title>
    <script>
        function ValidAlphabet() {

            var code = (event.which) ? event.which : event.keyCode;

            if ((code >= 65 && code <= 90) ||
                (code >= 97 && code <= 122) || (code == 32))
            { return true; }
            else
            { return false; }
        }
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="">
            <div class="page-title">
              <div class="title_left">
                <h3>Change In Size</h3>
              </div>

              <div class="title_right">
                
              </div>
            </div>
            <div class="clearfix"></div>
            
           

            <div class="row">
              

              <div class="col-md-6 col-xs-12">
                <div class="x_panel">
                  <div class="x_title">
                    <h2>Form <small>different form elements</small></h2>
                    <ul class="nav navbar-right panel_toolbox">
                      <li><a class="collapse-link"><i class="fa fa-chevron-up"></i></a>
                      </li>
                      <li class="dropdown">
                        <a href="#" class="dropdown-toggle" data-toggle="dropdown" role="button" aria-expanded="false"><i class="fa fa-wrench"></i></a>
                        <ul class="dropdown-menu" role="menu">
                          <li><a href="#">Settings 1</a>
                          </li>
                          <li><a href="#">Settings 2</a>
                          </li>
                        </ul>
                      </li>
                      <li><a class="close-link"><i class="fa fa-close"></i></a>
                      </li>
                    </ul>
                    <div class="clearfix"></div>
                  </div>
                  <div class="x_content">
                    <br />
                    <form class="form-horizontal form-label-left" runat="server" novalidate>
                        <div class="form-group">
                       <asp:Label ID="lblInwordNo" runat="server" class="control-label col-md-3 col-sm-3 col-xs-12" Text="Inword Number" Font-Bold="True"></asp:Label>
                        <div class="col-md-9 col-sm-9 col-xs-12">
                         <asp:TextBox ID="txtInwordNo" runat="server" type="text" class="form-control" data-validate-length-range="6" data-validate-words="2" name="name" required="required" placeholder="Inword Number"></asp:TextBox>
                        </div>
                      </div>

                         <div class="form-group">
                       <asp:Label ID="Label1" runat="server" class="control-label col-md-3 col-sm-3 col-xs-12" Text="Inword Date" Font-Bold="True"></asp:Label>
                        <div class="col-md-9 col-sm-9 col-xs-12">
                         <asp:TextBox ID="txtinworddate" runat="server" type="date" class="form-control" data-validate-length-range="6" data-validate-words="2" name="name" required="required" placeholder="Inword Number"></asp:TextBox>
                        </div>
                      </div>
                        
                        <div class="form-group">
                       <asp:Label ID="lblConsumerNo" runat="server" class="control-label col-md-3 col-sm-3 col-xs-12" Text="Consumer No" Font-Bold="True"></asp:Label>
                        <div class="col-md-9 col-sm-9 col-xs-12">
                         <asp:TextBox ID="txtConsumerNo" runat="server" OnTextChanged="txtConsumerNo_TextChanged" AutoPostBack="true" type="text" class="form-control" data-validate-length-range="6" data-validate-words="2" name="name" required="required" placeholder="Consumer No"></asp:TextBox>
                        </div>
                      </div>

                        <div class="form-group">
                       <asp:Label ID="lblNewArea" runat="server" class="control-label col-md-3 col-sm-3 col-xs-12" Text="New Area" Font-Bold="True"></asp:Label>
                        <div class="col-md-9 col-sm-9 col-xs-12">
                         <asp:TextBox ID="txtNewArea" runat="server" type="number" class="form-control" data-validate-length-range="6" data-validate-words="2" name="name" required="required" placeholder="New Area"></asp:TextBox>
                        </div>
                      </div>

                        <div class="form-group">
                       <asp:Label ID="lblNewCurrent" runat="server" class="control-label col-md-3 col-sm-3 col-xs-12" Text="New Current" Font-Bold="True"></asp:Label>
                        <div class="col-md-9 col-sm-9 col-xs-12">
                         <asp:TextBox ID="txtNewCurrent" runat="server" type="number" class="form-control" data-validate-length-range="6" data-validate-words="2" name="name" required="required" placeholder="New Current"></asp:TextBox>
                        </div>
                      </div>

                        <div class="form-group">
                       <asp:Label ID="lblNewOutstanding" runat="server" class="control-label col-md-3 col-sm-3 col-xs-12" Text="New Outstanding" Font-Bold="True"></asp:Label>
                        <div class="col-md-9 col-sm-9 col-xs-12">
                         <asp:TextBox ID="txtNewOutstanding" runat="server" type="number" class="form-control" data-validate-length-range="6" data-validate-words="2" name="name" required="required" placeholder="New Outstanding"></asp:TextBox>
                        </div>
                      </div>

                        

                      <div class="form-group">
                       <asp:Label ID="lblImpact" runat="server" class="control-label col-md-3 col-sm-3 col-xs-12" Text="Impact" Font-Bold="True"></asp:Label>
                        <div class="col-md-9 col-sm-9 col-xs-12">
                         <asp:DropDownList class="form-control" ID="ddlimpact" runat="server">
                             <asp:ListItem Value="0">Select Impact</asp:ListItem>
                             <asp:ListItem>Positive</asp:ListItem>
                             <asp:ListItem>Negative</asp:ListItem>
                             <asp:ListItem>No Impact</asp:ListItem>
                         </asp:DropDownList>

                             </div>
                      </div>

                                                 <div class="form-group">
                       <asp:Label ID="Label2" runat="server" class="control-label col-md-3 col-sm-3 col-xs-12" Text="Type" Font-Bold="True"></asp:Label>
                        <div class="col-md-9 col-sm-9 col-xs-12">
                         <asp:DropDownList class="form-control" ID="ddlsizetype" runat="server">
                             <asp:ListItem Value="0">Select Size Type</asp:ListItem>
                             <asp:ListItem >Increase</asp:ListItem>
                             <asp:ListItem>Decrease</asp:ListItem>
                         </asp:DropDownList>

                             </div>
                      </div>
                      
                        
                        <asp:Label ID="lblcode" runat="server" Text=""></asp:Label>

                     

                        <asp:Label ID="lblMiddleCode" runat="server"></asp:Label>
                        <asp:Label ID="lblPropertyCode" runat="server"></asp:Label>
                        <asp:Label ID="lblMessage" runat="server" Text="" Visible="true" Font-Bold="true" ForeColor="#006600" Font-Size="Large"></asp:Label>
                      


                      <div class="ln_solid"></div>
                      <div class="form-group">
                        <div class="col-md-9 col-sm-9 col-xs-12 col-md-offset-3">
                          <asp:Button ID="btnCancel" runat="server" type="button" class="btn btn-primary" Text="Cancel" />
                          <asp:Button ID="btnReset" runat="server" type="reset" OnClick="btnReset_Click" class="btn btn-primary" Text="Reset" />
                          <asp:Button ID="btnModify" runat="server" type="submit" class="btn btn-success" Text="Modify" OnClick="btnModify_Click" />
                        </div>
                      </div>

                    </form>
                  </div>
                </div>
              </div>

                

                 <div class="col-md-6 col-xs-12">
                <div class="x_panel">
                  <div class="x_title">
                    <h2>To Do <small>List</small></h2>
                    <ul class="nav navbar-right panel_toolbox">
                      <li><a class="collapse-link"><i class="fa fa-chevron-up"></i></a>
                      </li>
                      <li class="dropdown">
                        <a href="#" class="dropdown-toggle" data-toggle="dropdown" role="button" aria-expanded="false"><i class="fa fa-wrench"></i></a>
                        <ul class="dropdown-menu" role="menu">
                          <li><a href="#">Settings 1</a>
                          </li>
                          <li><a href="#">Settings 2</a>
                          </li>
                        </ul>
                      </li>
                      <li><a class="close-link"><i class="fa fa-close"></i></a>
                      </li>
                    </ul>
                    <div class="clearfix"></div>
                  </div>
                  <div class="x_content">
                      <div class="dashboard-widget-content">
                        <div class="col-md-12 hidden-small">
                          <h2 class="line_30">Description Here!</h2>

                          <table class="countries_list">
                            <tbody>
                               <tr><td><b>Old Arrears :</b><label id="lbloldarea" runat="server"></label></td></tr>
                                <tr><td><b>Old Arrears Unit :</b><label id="lblsqy_sqft" runat="server"></label></td></tr>
                                <label id="lbloldcategory" visible="false" runat="server"></label>
                                <tr><td><b>Old Outstanding :</b><label id="lbloldouttanding" runat="server"></label></td></tr>
                                <tr><td><b>Modification Description :</b><label id="lbldescription" runat="server"></label></td></tr>
                                 <label id="lbloldkmccategory" runat="server" visible="false"></label>
                               
                              
                               
                                
                            </tbody>
                          </table>
                        </div>
                      
                      </div>
                    </div>
                </div>

              

                


              </div>
              
            </div>

            

           


            
          </div>
</asp:Content>

