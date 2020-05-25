<%@ Page Title="" Language="C#" MasterPageFile="~/User.master" AutoEventWireup="true" CodeFile="PartPayment.aspx.cs" Inherits="PartPayment" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <title>Part Payment</title>
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
                <h3>Part Payment</h3>
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
                    <form class="form-horizontal form-label-left" novalidate runat="server" >
                        
                         
                        <div class="form-group">
                       <asp:Label ID="lblConsumerNo" runat="server" class="control-label col-md-3 col-sm-3 col-xs-12" Text="Consumer Number" Font-Bold="True"></asp:Label>
                        <div class="col-md-9 col-sm-9 col-xs-12">

                         <asp:TextBox ID="txtConsumerNo" runat="server" type="text" style="text-transform:uppercase;" class="form-control" data-validate-length-range="6" data-validate-words="2"  required="required" placeholder="Consumer Number" MaxLength="11" OnTextChanged="txtConsumerNo_TextChanged"></asp:TextBox>
                        </div>
                      </div>
                        <div class="form-group">
                       <asp:Label ID="lblConsumerName" runat="server" class="control-label col-md-3 col-sm-3 col-xs-12" Text="Consumer Name" Font-Bold="True"></asp:Label>
                        <div class="col-md-9 col-sm-9 col-xs-12">
                           <asp:TextBox ID="txtConsumerName" runat="server" type="text" class="form-control" data-validate-length-range="6" data-validate-words="2"  required="required" placeholder="Consumer Name" ReadOnly ></asp:TextBox>
                       
                              </div>
                      </div>
                      <div class="form-group">
                       <asp:Label ID="lblPerQuarter" runat="server" class="control-label col-md-3 col-sm-3 col-xs-12" Text="Per Quarter" Font-Bold="True"></asp:Label>
                        <div class="col-md-9 col-sm-9 col-xs-12">

                         <asp:TextBox ID="txtPerQuarter" runat="server" type="text" class="form-control" data-validate-length-range="6" data-validate-words="2"  required="required" placeholder="Per Quarter" ReadOnly></asp:TextBox>
                        </div>
                      </div>
                     
                      
                     
                      <div class="form-group">
                       <asp:Label ID="lblPropertyType" runat="server" class="control-label col-md-3 col-sm-3 col-xs-12" Text="Property Type" Font-Bold="True"></asp:Label>
                        <div class="col-md-9 col-sm-9 col-xs-12">
                           <asp:TextBox ID="txtPropertyType" runat="server" type="text" class="form-control" placeholder="240" ReadOnly></asp:TextBox>
                      
                        </div>
                      </div>

                        <div class="form-group">
                       <asp:Label ID="lblAddress" runat="server" class="control-label col-md-3 col-sm-3 col-xs-12" Text="Address" Font-Bold="True"></asp:Label>
                        <div class="col-md-9 col-sm-9 col-xs-12">
                           <asp:TextBox ID="txtAddress" runat="server" type="text" class="form-control" placeholder="500" ReadOnly></asp:TextBox>
                      
                        </div>
                      </div>

                       
                         <div class="form-group">
                       <asp:Label ID="lblstorey" runat="server" class="control-label col-md-3 col-sm-3 col-xs-12" Text="Storey" Font-Bold="True" ></asp:Label>
                        <div class="col-md-9 col-sm-9 col-xs-12">
                          <asp:TextBox ID="txtStorey" runat="server" type="text" class="form-control" placeholder="1" ReadOnly></asp:TextBox>
                      
                        </div>
                      </div>
                        <div class="form-group">
                       <asp:Label ID="lblTotalArears" runat="server" class="control-label col-md-3 col-sm-3 col-xs-12" Text="OutStanding Arears" Font-Bold="True"></asp:Label>
                        <div class="col-md-9 col-sm-9 col-xs-12">
                           <asp:TextBox ID="txtArears" runat="server" type="text" class="form-control" placeholder="500" ReadOnly></asp:TextBox>
                      
                        </div>
                      </div>
                         <div class="form-group">
                       <asp:Label ID="lblPartPayment" runat="server" class="control-label col-md-3 col-sm-3 col-xs-12" Text="Part Payment Into" Font-Bold="True"></asp:Label>
                        <div class="col-md-9 col-sm-9 col-xs-12">
                           <asp:TextBox ID="txtPartPayment" runat="server" type="number" class="form-control" placeholder="2" OnTextChanged="txtTotalQuarter_TextChanged"></asp:TextBox>
                        </div>
                      </div>
                      
                        <asp:Label ID="lblConsumerCode" runat="server" Text="" Visible="false"></asp:Label>
                        <asp:Label ID="lblSize" runat="server" Text="" Visible="false"></asp:Label>
                        <asp:Label ID="lblSqft" runat="server" Text="" Visible="false"></asp:Label>
                        <asp:Label ID="lblzone" runat="server" Text="" Visible="false"></asp:Label>
                        <asp:Label ID="lbltown" runat="server" Text="" Visible="false"></asp:Label>
                        <asp:Label ID="lblUcno" runat="server" Text="" Visible="false"></asp:Label>
                        <asp:Label ID="lblUcName" runat="server" Text="" Visible="false"></asp:Label>
                        <asp:Label ID="lblBlock" runat="server" Text="" Visible="false"></asp:Label>
                        <asp:Label ID="lblBillingMonth" runat="server" Text="" Visible="false"></asp:Label>
                        <asp:Label ID="lblKmcCategory" runat="server" Text="" Visible="false"></asp:Label>
                        <asp:Label ID="lblCheckdigit" runat="server" Text="" Visible="false"></asp:Label>
                        <asp:Label ID="lblBillingCode" runat="server" Text="" Visible="false"></asp:Label>
                        <asp:Label ID="lblbarcode" runat="server" Text="" Visible="false"></asp:Label>
                        <asp:Label ID="lblMessage" runat="server" Text="" Visible="true" Font-Bold="true" ForeColor="#006600" Font-Size="Large"></asp:Label>
                      
                       
                         
                        
                  


                      <div class="ln_solid"></div>
                      <div class="form-group">
                        <div class="col-md-9 col-sm-9 col-xs-12 col-md-offset-3">
                          <asp:Button ID="btnCancle" runat="server" type="button" class="btn btn-primary" Text="Cancle" />
                          <asp:Button ID="btnReset" runat="server" type="reset" class="btn btn-primary" Text="Reset" OnClick="btnReset_Click" />
                          <asp:Button ID="btnSubmit" runat="server" type="submit" class="btn btn-success" Text="Submit" OnClick="btnSubmit_Click" />
                        </div>
                      </div>

                    </form>
                  </div>
                </div>
              </div>

                <div class="col-md-6 col-xs-12">
                <div class="x_panel">
                  <div class="x_title">
                    <h2>Summary <small>different form elements</small></h2>
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
                          <h2 class="line_30">Total Directive</h2>

                          <table class="countries_list">
                            <tbody>
                                 <tr>
                                <td>Current Amount</td>
                                <td class="fs15 fw700 text-right">
                                    <asp:Label ID="lblCurrentAmount" runat="server" Text=""></asp:Label>
                                </td>
                              </tr>
                              <tr>
                                <td>Outstanding Arears</td>
                                <td class="fs15 fw700 text-right">
                                    <asp:Label ID="lblArears" runat="server" Text=""></asp:Label></td>
                              </tr>
                                 <tr>
                                <td>Per Month Surcharge</td>
                                <td class="fs15 fw700 text-right">
                                    <asp:Label ID="lblPermonth" runat="server" Text=""></asp:Label>

                                </td>
                              </tr>
                              <tr>
                                <td>Total No. Installment</td>
                                <td class="fs15 fw700 text-right">
                                    <asp:Label ID="lblInstal" runat="server" Text=""></asp:Label></td>
                              </tr>
                                 <tr>
                                <td>Per Istallment arrears</td>
                                <td class="fs15 fw700 text-right">
                                    <asp:Label ID="lblperInstal" runat="server" Text=""></asp:Label></td>
                              </tr>
							  <tr>
                                <td>After Istallment Within due Amount</td>
                                <td class="fs15 fw700 text-right">
                                    <asp:Label ID="lblwithin" runat="server" Text=""></asp:Label></td>
                              </tr>
                             
                              <tr>
                                <td>Total Amount</td>
                                <td class="fs15 fw700 text-right">
                                    <asp:Label ID="lblTotalAmount" runat="server" Text=""></asp:Label>
                                </td>
                              </tr>
                                 <tr>
                                <td>Due Amount</td>
                                <td class="fs15 fw700 text-right">
                                    <asp:Label ID="lbldue" runat="server" Text=""></asp:Label>
                                </td>
                              </tr>
                            </tbody>
                          </table>
                        </div>
                      
                      </div>
                    </div>
                </div>
`				

              </div>

                
              
            </div>

            
          </div>
</asp:Content>

