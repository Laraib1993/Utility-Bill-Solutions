<%@ Page Title="" Language="C#" MasterPageFile="~/MainDashboard.master" AutoEventWireup="true" CodeFile="SurchargeWave.aspx.cs" Inherits="SurchargeWave" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <title>Surcharge Wave</title>
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
                <h3>Surcharge Wave</h3>
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
                       <asp:Label ID="lblInword" runat="server" class="control-label col-md-3 col-sm-3 col-xs-12" Text="Inword Number" Font-Bold="True"></asp:Label>
                        <div class="col-md-9 col-sm-9 col-xs-12">

                         <asp:TextBox ID="txtInword" runat="server" type="number" class="form-control" data-validate-length-range="6" data-validate-words="2" required="required" placeholder="Inword Number"></asp:TextBox>
                        </div>
                      </div>
                         
                        <div class="form-group">
                       <asp:Label ID="lblConsumerNo" runat="server" class="control-label col-md-3 col-sm-3 col-xs-12" Text="Consumer Number" Font-Bold="True"></asp:Label>
                        <div class="col-md-9 col-sm-9 col-xs-12">

                         <asp:TextBox ID="txtConsumerNo" runat="server" type="text" class="form-control" style="text-transform:uppercase;" MaxLength="11" data-validate-length-range="6" data-validate-words="2"  required="required" placeholder="Consumer Number" OnTextChanged="txtConsumerNo_TextChanged"></asp:TextBox>
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
                       <asp:Label ID="lblTariff" runat="server" class="control-label col-md-3 col-sm-3 col-xs-12" Text="Tariff Rate" Font-Bold="True"></asp:Label>
                        <div class="col-md-9 col-sm-9 col-xs-12">
                           <asp:TextBox ID="txttariff" runat="server" type="text" class="form-control" placeholder="500" ReadOnly></asp:TextBox>
                      
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
                       <asp:Label ID="lblTotalQuarter" runat="server" class="control-label col-md-3 col-sm-3 col-xs-12" Text="Total Quarter Wave" Font-Bold="True"></asp:Label>
                        <div class="col-md-9 col-sm-9 col-xs-12">
                           <asp:TextBox ID="txtTotalQuarter" runat="server" type="number" class="form-control" placeholder="23" OnTextChanged="txtTotalQuarter_TextChanged"></asp:TextBox>
                        </div>
                      </div>
                      <div class="form-group">
                       <asp:Label ID="lblDescription" runat="server" class="control-label col-md-3 col-sm-3 col-xs-12" Text="Description" Font-Bold="True" ></asp:Label>
                        <div class="col-md-9 col-sm-9 col-xs-12">
                          <asp:TextBox ID="txtDescription" runat="server" type="text" class="form-control" data-validate-length-range="6" data-validate-words="2"  required="required" placeholder="description"></asp:TextBox>
                      
                        </div>
                      </div>
                         
                       
                         
                        
                  


                      <div class="ln_solid"></div>
                      <div class="form-group">
                        <div class="col-md-9 col-sm-9 col-xs-12 col-md-offset-3">
                          <asp:Button ID="btnCancle" runat="server" type="button" class="btn btn-primary" Text="Cancle" />
                          <asp:Button ID="btnReset" runat="server" type="reset" class="btn btn-primary" Text="Reset" />
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
                                <td>Outstanding Arears</td>
                                <td class="fs15 fw700 text-right">
                                    <asp:Label ID="lblArears" runat="server" Text=""></asp:Label></td>
                              </tr>
                              <tr>
                                <td>Surcharge Wave Amount</td>
                                <td class="fs15 fw700 text-right">
                                    <asp:Label ID="lblSurchange" runat="server" Text=""></asp:Label></td>
                              </tr>
							  <tr>
                                <td>After Surcharge Wave Arrears</td>
                                <td class="fs15 fw700 text-right">
                                    <asp:Label ID="lblSurchangeWave" runat="server" Text=""></asp:Label></td>
                              </tr>
                              <tr>
                                <td>Per Month Surcharge</td>
                                <td class="fs15 fw700 text-right">
                                    <asp:Label ID="lblPermonth" runat="server" Text=""></asp:Label>

                                </td>
                              </tr>
                                <tr>
                                <td>Impact Percentage</td>
                                <td class="fs15 fw700 text-right">
                                    <asp:Label ID="lblImpactPer" runat="server" Text=""></asp:Label>

                                </td>
                              </tr>
                              <tr>
                                <td>Current Amount</td>
                                <td class="fs15 fw700 text-right">
                                    <asp:Label ID="lblCurrentAmount" runat="server" Text=""></asp:Label>
                                </td>
                              </tr>
                              <tr>
                                <td>Total Amount</td>
                                <td class="fs15 fw700 text-right">
                                    <asp:Label ID="lblTotalAmount" runat="server" Text=""></asp:Label>
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
                          <h2 class="line_30">Instruction You May Follow</h2>

                          <table class="countries_list">
                            <tbody>
                                <tr>
                                <td>Wave Surcharge, Update as Approved by Director (MUCT) bearing Inword # XXXXX Dated XX-XX-XXXX Wave Surcharge</td>
                                <td class="fs15 fw700 text-right">
                                   
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

