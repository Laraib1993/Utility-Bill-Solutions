<%@ Page Title="" Language="C#" MasterPageFile="~/MainDashboard.master" AutoEventWireup="true" CodeFile="ModifyProperty.aspx.cs" Inherits="ModifyProperty" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <title>Modification Property</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="">
            <div class="page-title">
              <div class="title_left">
                <h3>Modification Property</h3>
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

                         <asp:TextBox ID="txtInword" runat="server" type="text" class="form-control" data-validate-length-range="6" data-validate-words="2" name="name" required="required" placeholder="Inword Number"></asp:TextBox>
                        </div>
                      </div>
                         <div class="form-group">
                       <asp:Label ID="lblModificationStatus" runat="server" class="control-label col-md-3 col-sm-3 col-xs-12" Text="Modification Status" Font-Bold="True"></asp:Label>
                        <div class="col-md-9 col-sm-9 col-xs-12">
                           <asp:TextBox ID="txtModification" runat="server" type="text" class="form-control" data-validate-length-range="6" data-validate-words="2" name="name" required="required" placeholder="Modification Status"></asp:TextBox>
                       
                              </div>
                      </div>
                        <div class="form-group">
                       <asp:Label ID="lblConsumerNo" runat="server" class="control-label col-md-3 col-sm-3 col-xs-12" Text="Consumer Number" Font-Bold="True"></asp:Label>
                        <div class="col-md-9 col-sm-9 col-xs-12">

                         <asp:TextBox ID="txtConsumerNo" runat="server" type="text" class="form-control" data-validate-length-range="6" data-validate-words="2" name="name" required="required" placeholder="Consumer Number" OnTextChanged="txtConsumerNo_TextChanged"></asp:TextBox>
                        </div>
                      </div>
                   
                      <div class="form-group">
                       <asp:Label ID="lblZone" runat="server" class="control-label col-md-3 col-sm-3 col-xs-12" Text="Zone" Font-Bold="True"></asp:Label>
                        <div class="col-md-9 col-sm-9 col-xs-12">
                         
                             <asp:TextBox ID="txtZone" runat="server" type="text" class="form-control" placeholder="zone" ReadOnly></asp:TextBox>
                          
                        </div>
                      </div>
                      <div class="form-group">
                        <asp:Label ID="lblTown" runat="server" class="control-label col-md-3 col-sm-3 col-xs-12" Text="Town" Font-Bold="True"></asp:Label>
                        <div class="col-md-9 col-sm-9 col-xs-12">
                             <asp:TextBox ID="txtTown" runat="server" type="text" class="form-control" placeholder="Town" ReadOnly></asp:TextBox>

                        </div>
                      </div>
                      <div class="form-group">
                       <asp:Label ID="lblUC" runat="server" class="control-label col-md-3 col-sm-3 col-xs-12" Text="Select UC" Font-Bold="True"></asp:Label>
                        <div class="col-md-9 col-sm-9 col-xs-12">
                        <asp:TextBox ID="txtUC" runat="server" type="text" class="form-control" placeholder="UC" ></asp:TextBox>

                        </div>
                      </div>
                      <div class="form-group">
                       <asp:Label ID="lblBlock" runat="server" class="control-label col-md-3 col-sm-3 col-xs-12" Text="Select Block" Font-Bold="True"></asp:Label>
                        <div class="col-md-9 col-sm-9 col-xs-12">
                          <asp:TextBox ID="txtBlock" runat="server" type="text" class="form-control" placeholder="Town" ></asp:TextBox>

                        </div>
                      </div>
                        <div class="form-group">
                       <asp:Label ID="lblpropertyType" runat="server" class="control-label col-md-3 col-sm-3 col-xs-12" Text="Property Type" Font-Bold="True"></asp:Label>
                        <div class="col-md-9 col-sm-9 col-xs-12">
                          <asp:DropDownList class="form-control" ID="ddlpropertyType" runat="server" AutoPostBack="True"  ></asp:DropDownList>

                        </div>
                      </div>
                         <div class="form-group">
                       <asp:Label ID="lblsqyard" runat="server" class="control-label col-md-3 col-sm-3 col-xs-12" Text="Square Yard" Font-Bold="True"></asp:Label>
                        <div class="col-md-9 col-sm-9 col-xs-12">

                         <asp:TextBox ID="txtSqyard" runat="server" type="text" class="form-control" data-validate-length-range="6" data-validate-words="2" name="name" required="required" placeholder="500"></asp:TextBox>
                        </div>
                      </div>

                        <div class="form-group">
                       <asp:Label ID="lblTariff" runat="server" class="control-label col-md-3 col-sm-3 col-xs-12" Text="Select Tariff" Font-Bold="True"></asp:Label>
                        <div class="col-md-9 col-sm-9 col-xs-12">
                          <asp:TextBox ID="txttariff" runat="server" type="text" class="form-control" placeholder="Town" ></asp:TextBox>

                        </div>
                      </div>
                       
                         <div class="form-group">
                       <asp:Label ID="lblstorey" runat="server" class="control-label col-md-3 col-sm-3 col-xs-12" Text="Storey" Font-Bold="True" ></asp:Label>
                        <div class="col-md-9 col-sm-9 col-xs-12">
                            <asp:TextBox ID="txtStorey" runat="server" type="text" class="form-control" data-validate-length-range="6" data-validate-words="2" name="name" required="required" placeholder="1"></asp:TextBox>
                      
                        </div>
                      </div>
                        <div class="form-group">
                       <asp:Label ID="lblImpact" runat="server" class="control-label col-md-3 col-sm-3 col-xs-12" Text="Impact" Font-Bold="True" ></asp:Label>
                        <div class="col-md-9 col-sm-9 col-xs-12">
                            <asp:TextBox ID="txtImpact" runat="server" type="text" class="form-control" data-validate-length-range="6" data-validate-words="2" name="name" required="required" placeholder="Impact"></asp:TextBox>
                      
                        </div>
                      </div>
                      <div class="form-group">
                       <asp:Label ID="lblDescription" runat="server" class="control-label col-md-3 col-sm-3 col-xs-12" Text="Description" Font-Bold="True" ></asp:Label>
                        <div class="col-md-9 col-sm-9 col-xs-12">
                          <asp:TextBox ID="txtDescription" runat="server" type="text" class="form-control" data-validate-length-range="6" data-validate-words="2" name="name" required="required" placeholder="Pool"></asp:TextBox>
                      
                        </div>
                      </div>
                         <div class="form-group">
                       <asp:Label ID="lblApproved" runat="server" class="control-label col-md-3 col-sm-3 col-xs-12" Text="Approved By" Font-Bold="True" ></asp:Label>
                        <div class="col-md-9 col-sm-9 col-xs-12">
                          <asp:TextBox ID="txtApproved" runat="server" type="text" class="form-control" data-validate-length-range="6" data-validate-words="2" name="name" required="required" placeholder="Senior Director"></asp:TextBox>
                      
                        </div>
                      </div>
                        <div class="form-group">
                       <asp:Label ID="lblOutword" runat="server" class="control-label col-md-3 col-sm-3 col-xs-12" Text="Outword Number" Font-Bold="True"></asp:Label>
                        <div class="col-md-9 col-sm-9 col-xs-12">

                         <asp:TextBox ID="txtOutword" runat="server" type="text" class="form-control" data-validate-length-range="6" data-validate-words="2" name="name" required="required" placeholder="Outword Number"></asp:TextBox>
                        </div>
                      </div>
                  


                      <div class="ln_solid"></div>
                      <div class="form-group">
                        <div class="col-md-9 col-sm-9 col-xs-12 col-md-offset-3">
                          <asp:Button ID="btnCancle" runat="server" type="button" class="btn btn-primary" Text="Cancle" />
                          <asp:Button ID="btnReset" runat="server" type="reset" class="btn btn-primary" Text="Reset" />
                          <asp:Button ID="btnSubmit" runat="server" type="submit" class="btn btn-success" Text="Submit" />
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
                                <td>Total Surcharge</td>
                                <td class="fs15 fw700 text-right">
                                    <asp:Label ID="lblSurchange" runat="server" Text=""></asp:Label></td>
                              </tr>
                              <tr>
                                <td>Per Month Surcharge</td>
                                <td class="fs15 fw700 text-right">
                                    <asp:Label ID="lblPermonth" runat="server" Text=""></asp:Label>

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

              

                


              </div>
              
            </div>

            

           


            
          </div>
</asp:Content>

