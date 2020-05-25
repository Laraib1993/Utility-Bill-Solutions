<%@ Page Title="" Language="C#" MasterPageFile="~/MainDashboard.master" AutoEventWireup="true" CodeFile="PutConsumer.aspx.cs" Inherits="PutConsumer" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <title>KMC | Consumer Session</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

     <div class="">
            <div class="page-title">
              <div class="title_left">
                <h3>Add Consumer</h3>
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
                       <asp:Label ID="lblInword" runat="server" class="control-label col-md-3 col-sm-3 col-xs-12" Text="Inword Number" Font-Bold="True"></asp:Label>
                        <div class="col-md-9 col-sm-9 col-xs-12">

                         <asp:TextBox ID="txtInword" runat="server" type="text" class="form-control" data-validate-length-range="6" data-validate-words="2" name="name" required="required" placeholder="Inword Number"></asp:TextBox>
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
                           <asp:TextBox ID="txtAddress" runat="server" type="text" class="form-control" placeholder="Address"></asp:TextBox>
                        </div>
                      </div>
                      <div class="form-group">
                       <asp:Label ID="lblZone" runat="server" class="control-label col-md-3 col-sm-3 col-xs-12" Text="Select Zone" Font-Bold="True"></asp:Label>
                        <div class="col-md-9 col-sm-9 col-xs-12">
                         
                             <asp:DropDownList class="form-control" ID="ddlZone" runat="server" OnSelectedIndexChanged="ddlZone_SelectedIndexChanged" AutoPostBack="True"></asp:DropDownList>
                           <%-- <select class="form-control">
                            <option>Choose option</option>
                            <option>East</option>
                            <option>West</option>
                             <option>North</option>
                             <option>South</option>
                            
                          </select>--%>
                        </div>
                      </div>
                      <div class="form-group">
                        <asp:Label ID="lblTown" runat="server" class="control-label col-md-3 col-sm-3 col-xs-12" Text="Select Town" Font-Bold="True"></asp:Label>
                        <div class="col-md-9 col-sm-9 col-xs-12">
                             <asp:DropDownList class="form-control" ID="ddlTown" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlTown_SelectedIndexChanged"></asp:DropDownList>

                        </div>
                      </div>
                      <div class="form-group">
                       <asp:Label ID="lblUC" runat="server" class="control-label col-md-3 col-sm-3 col-xs-12" Text="Select UC" Font-Bold="True"></asp:Label>
                        <div class="col-md-9 col-sm-9 col-xs-12">
                        <asp:DropDownList class="form-control" ID="ddlUC" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlUC_SelectedIndexChanged"></asp:DropDownList>

                        </div>
                      </div>
                      <div class="form-group">
                       <asp:Label ID="lblBlock" runat="server" class="control-label col-md-3 col-sm-3 col-xs-12" Text="Select Block" Font-Bold="True"></asp:Label>
                        <div class="col-md-9 col-sm-9 col-xs-12">
                          <asp:DropDownList class="form-control" ID="ddlBlock" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlBlock_SelectedIndexChanged"></asp:DropDownList>

                        </div>
                      </div>
                        <div class="form-group">
                       <asp:Label ID="lblpropertyType" runat="server" class="control-label col-md-3 col-sm-3 col-xs-12" Text="Property Type" Font-Bold="True"></asp:Label>
                        <div class="col-md-9 col-sm-9 col-xs-12">
                          <asp:DropDownList class="form-control" ID="ddlpropertyType" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlpropertyType_SelectedIndexChanged"></asp:DropDownList>

                        </div>
                      </div>
                         <div class="form-group">
                       <asp:Label ID="lblsqyard" runat="server" class="control-label col-md-3 col-sm-3 col-xs-12" Text="" Font-Bold="True"></asp:Label>
                        <div class="col-md-9 col-sm-9 col-xs-12">

                         <asp:TextBox ID="txtSqyard" runat="server" type="text" class="form-control" data-validate-length-range="6" data-validate-words="2" name="name" required="required" placeholder="500" OnTextChanged="txtSqyard_TextChanged"></asp:TextBox>
                        </div>
                      </div>

                        <div class="form-group">
                       <asp:Label ID="lblTariff" runat="server" class="control-label col-md-3 col-sm-3 col-xs-12" Text="Tariff Rate" Font-Bold="True"></asp:Label>
                        <div class="col-md-9 col-sm-9 col-xs-12">
                          <asp:TextBox ID="txtTariff" runat="server" type="text" class="form-control" data-validate-length-range="6" data-validate-words="2" name="name" required="required" placeholder="240" ReadOnly></asp:TextBox>
                      
                        </div>
                      </div>
                       
                         <div class="form-group">
                       <asp:Label ID="lblstorey" runat="server" class="control-label col-md-3 col-sm-3 col-xs-12" Text="Storey" Font-Bold="True"></asp:Label>
                        <div class="col-md-9 col-sm-9 col-xs-12">
                           <asp:TextBox ID="txtStorey" runat="server" type="text" class="form-control" data-validate-length-range="6" data-validate-words="2" name="name" required="required" placeholder="1" OnTextChanged="txtStorey_TextChanged"></asp:TextBox>
                      
                        </div>
                      </div>
                        
                       <div class="form-group">
                       <asp:Label ID="lblBillQuarter" runat="server" class="control-label col-md-3 col-sm-3 col-xs-12" Text="Billing Quarter" Font-Bold="True"></asp:Label>
                        <div class="col-md-9 col-sm-9 col-xs-12">
                           <asp:TextBox ID="txtBillingQuarter" runat="server" type="text" class="form-control" data-validate-length-range="6" data-validate-words="2" name="name" required="required" placeholder="31" OnTextChanged="txtBillingQuarter_TextChanged"></asp:TextBox>
                      
                        </div>
                      </div>
                        <div class="form-group">
                       <asp:Label ID="lblConsumerID" runat="server" class="control-label col-md-3 col-sm-3 col-xs-12" Text="Consumer Number" Font-Bold="True"></asp:Label>
                       
                         <div class="input-group col-md-9 col-sm-9 col-xs-12">
                            <asp:TextBox ID="txtConsumerID" runat="server" type="text" class="form-control"></asp:TextBox>
                            <span class="input-group-btn">
                                              <asp:Button ID="btnCode" type="button" class="btn btn-primary" runat="server" Text="Go!" OnClick="btnCode_Click" />
                                          </span>
                          </div>
                            </div>

                        <div class="form-group">
                       <asp:Label ID="lbldescription" runat="server" class="control-label col-md-3 col-sm-3 col-xs-12" Text="Description" Font-Bold="True"></asp:Label>
                        <div class="col-md-9 col-sm-9 col-xs-12">

                         <asp:TextBox ID="txtdescrption" runat="server" type="text" class="form-control" data-validate-length-range="6" data-validate-words="2" name="name" required="required" placeholder="Outword Number"></asp:TextBox>
                        </div>
                      </div>
                        
                        <asp:Label ID="lblcode" runat="server" Text=""></asp:Label>

                     <%-- <div class="control-group">
                        <label class="control-label col-md-3 col-sm-3 col-xs-12">Input Tags</label>
                        <div class="col-md-9 col-sm-9 col-xs-12">
                          <input id="tags_1" type="text" class="tags form-control" value="social, adverts, sales" />
                          <div id="suggestions-container" style="position: relative; float: left; width: 250px; margin: 10px;"></div>
                        </div>
                      </div>
                      <div class="form-group">
                        <label class="col-md-3 col-sm-3 col-xs-12 control-label">Checkboxes and radios
                          <br>
                          <small class="text-navy">Normal Bootstrap elements</small>
                        </label>

                        <div class="col-md-9 col-sm-9 col-xs-12">
                          <div class="checkbox">
                            <label>
                              <input type="checkbox" value=""> Option one. select more than one options
                            </label>
                          </div>
                          <div class="checkbox">
                            <label>
                              <input type="checkbox" value=""> Option two. select more than one options
                            </label>
                          </div>
                          <div class="radio">
                            <label>
                              <input type="radio" checked="" value="option1" id="optionsRadios1" name="optionsRadios"> Option one. only select one option
                            </label>
                          </div>
                          <div class="radio">
                            <label>
                              <input type="radio" value="option2" id="optionsRadios2" name="optionsRadios"> Option two. only select one option
                            </label>
                          </div>
                        </div>
                      </div>

                      <div class="form-group">
                        <label class="col-md-3 col-sm-3 col-xs-12 control-label">Checkboxes and radios
                          <br>
                          <small class="text-navy">Normal Bootstrap elements</small>
                        </label>

                        <div class="col-md-9 col-sm-9 col-xs-12">
                          <div class="checkbox">
                            <label>
                              <input type="checkbox" class="flat" checked="checked"> Checked
                            </label>
                          </div>
                          <div class="checkbox">
                            <label>
                              <input type="checkbox" class="flat"> Unchecked
                            </label>
                          </div>
                          <div class="checkbox">
                            <label>
                              <input type="checkbox" class="flat" disabled="disabled"> Disabled
                            </label>
                          </div>
                          <div class="checkbox">
                            <label>
                              <input type="checkbox" class="flat" disabled="disabled" checked="checked"> Disabled & checked
                            </label>
                          </div>
                          <div class="radio">
                            <label>
                              <input type="radio" class="flat" checked name="iCheck"> Checked
                            </label>
                          </div>
                          <div class="radio">
                            <label>
                              <input type="radio" class="flat" name="iCheck"> Unchecked
                            </label>
                          </div>
                          <div class="radio">
                            <label>
                              <input type="radio" class="flat" name="iCheck" disabled="disabled"> Disabled
                            </label>
                          </div>
                          <div class="radio">
                            <label>
                              <input type="radio" class="flat" name="iCheck3" disabled="disabled" checked> Disabled & Checked
                            </label>
                          </div>
                        </div>
                      </div>
                      <div class="form-group">
                        <label class="control-label col-md-3 col-sm-3 col-xs-12">Switch</label>
                        <div class="col-md-9 col-sm-9 col-xs-12">
                          <div class="">
                            <label>
                              <input type="checkbox" class="js-switch" checked /> Checked
                            </label>
                          </div>
                          <div class="">
                            <label>
                              <input type="checkbox" class="js-switch" /> Unchecked
                            </label>
                          </div>
                          <div class="">
                            <label>
                              <input type="checkbox" class="js-switch" disabled="disabled" /> Disabled
                            </label>
                          </div>
                          <div class="">
                            <label>
                              <input type="checkbox" class="js-switch" disabled="disabled" checked="checked" /> Disabled Checked
                            </label>
                          </div>
                        </div>
                      </div>--%>


                        <asp:Label ID="lblMiddleCode" runat="server"></asp:Label>
                        <asp:Label ID="lblPropertyCode" runat="server"></asp:Label>
                        


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
                                <td>Check Digit</td>
                                <td class="fs15 fw700 text-right">
                                   <asp:Label ID="lblcheckdigit" runat="server"></asp:Label>
                                    </td>
                              </tr>
                                 <tr>
                                <td>Outstanding Arears</td>
                                <td class="fs15 fw700 text-right">
                                    <asp:Label ID="lblArears" runat="server" Text=""></asp:Label></td>
                              </tr>
                              <tr>
                                <td>Current Amount</td>
                                <td class="fs15 fw700 text-right">
                                    <asp:Label ID="lblCurrentAmount" runat="server" Text=""></asp:Label>
                                </td>
                              </tr>
                              <tr>
                                <td>Per Month Surcharge</td>
                                <td class="fs15 fw700 text-right">
                                    <asp:Label ID="lblPermonth" runat="server" Text=""></asp:Label>

                                </td>
                              </tr>
                              
                                <tr>
                                <td>Bank Charge</td>
                                <td class="fs15 fw700 text-right">
                                    <asp:Label ID="lblbankcharge" runat="server" Text=""></asp:Label></td>
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
                                    <asp:Label ID="lbldueamount" runat="server" Text=""></asp:Label></td>
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

