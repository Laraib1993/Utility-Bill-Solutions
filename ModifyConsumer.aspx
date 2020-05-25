<%@ Page Title="" Language="C#" MasterPageFile="~/User.master" AutoEventWireup="true" CodeFile="ModifyConsumer.aspx.cs" Inherits="ModifyConsumer" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <title>Modification</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
       <div class="">
            <div class="page-title">
              <div class="title_left">
                <h3>Modification Consumer</h3>
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
                          <asp:DropDownList class="form-control" ID="ddlModify" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlModify_SelectedIndexChanged">
                              <asp:ListItem Value ="0">Select Status</asp:ListItem>
                              <asp:ListItem Value="1">Change in Name</asp:ListItem>
                              <asp:ListItem Value="2">Change in Address</asp:ListItem>
                              <asp:ListItem Value="3">Change in Name and Address</asp:ListItem>
                          </asp:DropDownList>

                       
                              </div>
                      </div>
                        <div class="form-group">
                       <asp:Label ID="lblConsumerNo" runat="server" class="control-label col-md-3 col-sm-3 col-xs-12" Text="Consumer Number" Font-Bold="True"></asp:Label>
                        <div class="col-md-9 col-sm-9 col-xs-12">

                         <asp:TextBox ID="txtConsumerNo" runat="server" type="text" class="form-control" data-validate-length-range="6" data-validate-words="2" name="name" required="required" placeholder="Consumer Number" OnTextChanged="txtConsumerNo_TextChanged"></asp:TextBox>
                        </div>
                      </div>
                      <div class="form-group">
                       <asp:Label ID="lblConsumerName" runat="server" class="control-label col-md-3 col-sm-3 col-xs-12" Text="Consumer Name" Font-Bold="True"></asp:Label>
                        <div class="col-md-9 col-sm-9 col-xs-12">

                         <asp:TextBox ID="txtConsumerName" runat="server" type="text" class="form-control" data-validate-length-range="6" data-validate-words="2" name="name" required="required" placeholder="Full Name"></asp:TextBox>
                        </div>
                      </div>
                      <div class="form-group">
                       <asp:Label ID="lblFatherName" runat="server" class="control-label col-md-3 col-sm-3 col-xs-12" Text="Father Name" Font-Bold="True"></asp:Label>
                        <div class="col-md-9 col-sm-9 col-xs-12">
                           <asp:TextBox ID="txtFatherName" runat="server" type="text" class="form-control" placeholder="Father Name"></asp:TextBox>
                        </div>
                      </div>
                      <div class="form-group">
                        <asp:Label ID="lblCNIC" runat="server" class="control-label col-md-3 col-sm-3 col-xs-12" Text="CNIC" Font-Bold="True"></asp:Label>
                        <div class="col-md-9 col-sm-9 col-xs-12">
                           <asp:TextBox ID="txtCNIC" runat="server" type="text" class="form-control" name="CNIC" required="required" placeholder="CNIC Number"></asp:TextBox>
                        </div>
                      </div>
                      <div class="form-group">
                       <asp:Label ID="lblMobile" runat="server" class="control-label col-md-3 col-sm-3 col-xs-12" Text="Mobile" Font-Bold="True"></asp:Label>
                        <div class="col-md-9 col-sm-9 col-xs-12">
                          <asp:TextBox ID="txtMobile" runat="server" type="text" class="form-control" name="Mobile" data-validate-linked="email" required="required" placeholder="Mobile Number"></asp:TextBox>
                        </div>
                      </div>
                      <div class="form-group">
                       <asp:Label ID="lblAddress" runat="server" class="control-label col-md-3 col-sm-3 col-xs-12" Text="Address" Font-Bold="True"></asp:Label>
                        <div class="col-md-9 col-sm-9 col-xs-12">
                           <asp:TextBox ID="txtAddress" runat="server" type="text" class="form-control" placeholder="Address" ReadOnly></asp:TextBox>
                        </div>
                      </div>
                      
                      
                     
                      <div class="form-group">
                       <asp:Label ID="lblDescription" runat="server" class="control-label col-md-3 col-sm-3 col-xs-12" Text="Description" Font-Bold="True" ></asp:Label>
                        <div class="col-md-9 col-sm-9 col-xs-12">
                          <asp:TextBox ID="txtDescription" runat="server" type="text" class="form-control" data-validate-length-range="6" data-validate-words="2" name="name" required="required" placeholder="Pool"></asp:TextBox>
                      
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
                                <td>Change name as inword # XXXXX Dated XX-XX-XXXX as Director (MUCT) instruction</td>
                                <td class="fs15 fw700 text-right">
                                   
                                    </td>
                              </tr>
                                <tr>
                                     <td>Change Address as inword # XXXXX Dated XX-XX-XXXX as Director (MUCT) instruction</td>
                                
                                <td class="fs15 fw700 text-right">
                                   
                                    </td>
                              </tr>
                                 <tr>
                                     <td>Change name and Address as inword # XXXXX Dated XX-XX-XXXX as Director (MUCT) instruction</td>
                                
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

