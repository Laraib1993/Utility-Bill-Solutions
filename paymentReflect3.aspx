﻿<%@ Page Title="" Language="C#" MasterPageFile="~/User.master" AutoEventWireup="true" CodeFile="paymentReflect3.aspx.cs" Inherits="paymentReflect" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <title>Payment Reflection</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
       <div class="">
            <div class="page-title">
              <div class="title_left">
                <h3>Payment Reflection</h3>
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

                         <asp:TextBox ID="txtConsumerNo" runat="server" type="text" class="form-control" data-validate-length-range="6" data-validate-words="2" name="name" required="required" placeholder="Consumer Number" OnTextChanged="txtConsumerNo_TextChanged"></asp:TextBox>
                        </div>
                      </div>
                       
                         <div class="form-group">
                       <asp:Label ID="lblModificationStatus" runat="server" class="control-label col-md-3 col-sm-3 col-xs-12" Text="Modification Status" Font-Bold="True"></asp:Label>
                        <div class="col-md-9 col-sm-9 col-xs-12">
                          <asp:DropDownList class="form-control" ID="ddlModify" runat="server" AutoPostBack="false">
                              <asp:ListItem Value ="0">Select Status</asp:ListItem>
                              <asp:ListItem Value="1">Payment Reflect</asp:ListItem>
                              <asp:ListItem Value="2">systematic Error</asp:ListItem>
                              
                          </asp:DropDownList>

                       
                              </div>
                      </div>
               
                      <div class="form-group">
                       <asp:Label ID="lblOutsandingArrears" runat="server" class="control-label col-md-3 col-sm-3 col-xs-12" Text="Outstanding Arrears" Font-Bold="True"></asp:Label>
                        <div class="col-md-9 col-sm-9 col-xs-12">

                         <asp:TextBox ID="txtarrears" runat="server" type="text" class="form-control" data-validate-length-range="6" data-validate-words="2"  required="required" placeholder="OutStanding Arrears" ReadOnly></asp:TextBox>
                        </div>
                      </div>
                      
                      
                      <div class="form-group">
                       <asp:Label ID="lblReflect" runat="server" class="control-label col-md-3 col-sm-3 col-xs-12" Text="Reflect Amount" Font-Bold="True"></asp:Label>
                        <div class="col-md-9 col-sm-9 col-xs-12">
                          <asp:TextBox ID="txtreflect" runat="server" type="number" class="form-control" data-validate-linked="email" required="required" placeholder="Reflect Amount"></asp:TextBox>
                        </div>
                      </div>
                         <div class="form-group">
                       <asp:Label ID="lblper" runat="server" class="control-label col-md-3 col-sm-3 col-xs-12" Text="Bill Percentage" Font-Bold="True"></asp:Label>
                        <div class="col-md-9 col-sm-9 col-xs-12">
                          <asp:DropDownList class="form-control" ID="ddlper" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlper_SelectedIndexChanged">
                              <asp:ListItem Value ="0">Select Status</asp:ListItem>
                              <asp:ListItem Value="1">100%</asp:ListItem>
                              <asp:ListItem Value="0.05">5%</asp:ListItem>
                          </asp:DropDownList>

                       
                              </div>
                      </div>
                         <div class="form-group">
                       <asp:Label ID="lblReflectionPeriod" runat="server" class="control-label col-md-3 col-sm-3 col-xs-12" Text="Bill Period" Font-Bold="True"></asp:Label>
                        <div class="col-md-9 col-sm-9 col-xs-12">
                          <asp:DropDownList class="form-control" ID="ddlreflectiobperiod" runat="server" AutoPostBack="false">
                              
                          </asp:DropDownList>

                       
                              </div>
                      </div>
                         <div class="form-group">
                       <asp:Label ID="lblDate" runat="server" class="control-label col-md-3 col-sm-3 col-xs-12" Text="Payment Date" Font-Bold="True"></asp:Label>
                        <div class="col-md-9 col-sm-9 col-xs-12">
                         <asp:TextBox ID="txttodate" runat="server" type="Date" class="form-control" placeholder="To = MM/DD/YYYY "></asp:TextBox>
                        </div>
                      </div>
                    
                        
                        
                  
                        <asp:Label ID="lbltmpName" runat="server" Visible="False"></asp:Label>
                        <asp:Label ID="lbltmpfname" runat="server" Visible="False"></asp:Label>
                        <asp:Label ID="lbltmpadress" runat="server" Visible="False"></asp:Label>
                        <asp:Label ID="lbltmpcnic" runat="server" Visible="False"></asp:Label>
                        <asp:Label ID="lbltmpmobile" runat="server" Visible="False"></asp:Label>

                        <asp:Label ID="lblmessage" runat="server" Font-Bold="True" ForeColor="#006600"></asp:Label>

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
                                <td>Name</td>
                                <td class="fs15 fw700 text-right">
                                    <asp:Label ID="lblName" runat="server" Text=""></asp:Label></td>
                              </tr>
                              <tr>
                                <td>Address</td>
                                <td class="fs15 fw700 text-right">
                                    <asp:Label ID="lblAddress" runat="server" Text=""></asp:Label></td>
                              </tr>
                              <tr>
                                <td>Category</td>
                                <td class="fs15 fw700 text-right">
                                    <asp:Label ID="lblCategory" runat="server" Text=""></asp:Label>

                                </td>
                              </tr>
                              <tr>
                                <td>Size</td>
                                <td class="fs15 fw700 text-right">
                                    <asp:Label ID="lblArea" runat="server" Text=""></asp:Label>
                                </td>
                              </tr>
                              <tr>
                                <td>Storey</td>
                                <td class="fs15 fw700 text-right">
                                    <asp:Label ID="lblStorey" runat="server" Text=""></asp:Label>
                                </td>
                              </tr>
                                <tr>
                                <td>Current Amount</td>
                                <td class="fs15 fw700 text-right">
                                    <asp:Label ID="lblCurrentAmount" runat="server" Text=""></asp:Label>
                                </td>
                              </tr>
                                <tr>
                                <td>Outstanding Arrears</td>
                                <td class="fs15 fw700 text-right">
                                    <asp:Label ID="lbloutArrears" runat="server" Text=""></asp:Label>
                                </td>
                              </tr>
                                 <tr>
                                <td>After Reflection</td>
                                <td class="fs15 fw700 text-right">
                                    <asp:Label ID="lblafterreflection" runat="server" Text=""></asp:Label>
                                </td>
                              </tr>
                                 <tr>
                                <td>Impact Percentage</td>
                                <td class="fs15 fw700 text-right">
                                    <asp:Label ID="lblpercent" runat="server" Text=""></asp:Label>
                                </td>
                              </tr>
                            </tbody>
                          </table>
                        </div>
                      
                      </div>
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
                          <h2 class="line_30">Instruction You May Follow</h2>

                          <table class="countries_list">
                            <tbody>
                                <tr>
                                <td>Payment Reflect behalf of bank scroll Inword # XXXXX Dated XX-XX-XXXX as per Director (MUCT) signature</td>
                                <td class="fs15 fw700 text-right">
                                   
                                    </td>
                              </tr>
                                <tr>
                                     <td></td>
                                
                                <td class="fs15 fw700 text-right">
                                   
                                    </td>
                              </tr>
                                 <tr>
                                     <td>Systemtic Error due to replacement of software, the modified data did not share by the MSCL(Previous Contractor) Updated approved by Director (MUCT) behalf of preivous hardcopy Records and MUCT Bill bearing inword # XXXXX Dated XX-XX-XXXX</td>
                                
                                <td class="fs15 fw700 text-right">
                                   
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

