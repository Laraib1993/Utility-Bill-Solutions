<%@ Page Title="" Language="C#" MasterPageFile="~/User.master" AutoEventWireup="true" CodeFile="AddStoreyForm.aspx.cs" Inherits="AddStoreyForm" %>

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
                <h3>Add Storey</h3>
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
                       <asp:Label ID="lblDescription" runat="server" class="control-label col-md-3 col-sm-3 col-xs-12" Text="Inword Date" Font-Bold="True"></asp:Label>
                        <div class="col-md-9 col-sm-9 col-xs-12">
                         <asp:TextBox ID="txtDescription" runat="server" type="date" class="form-control" data-validate-length-range="6" data-validate-words="2" name="name" required="required" placeholder="Description"></asp:TextBox>
                        </div>
                      </div>

                        <div class="form-group">
                       <asp:Label ID="lblConsumerNo" runat="server" class="control-label col-md-3 col-sm-3 col-xs-12" Text="Consumer No" Font-Bold="True"></asp:Label>
                        <div class="col-md-9 col-sm-9 col-xs-12">
                         <asp:TextBox ID="txtConsumerNo" runat="server" type="text" class="form-control" data-validate-length-range="6" data-validate-words="2" name="name" required="required" placeholder="Consumer No"></asp:TextBox>
                        </div>
                      </div>

                      <%--<div class="form-group">
                       <asp:Label ID="lblmodificationstatus" runat="server" class="control-label col-md-3 col-sm-3 col-xs-12" Text="Modification Status" Font-Bold="True"></asp:Label>
                        <div class="col-md-9 col-sm-9 col-xs-12">
                         <asp:TextBox ID="txtmodificationstatus" runat="server" type="text" class="form-control" data-validate-length-range="6" data-validate-words="2" name="name" required="required" placeholder="Modification Status"></asp:TextBox>
                        <asp:DropDownList  ID="ddlmodificationstatus" runat="server" type="text" class="form-control">
                            <asp:ListItem>Select Status </asp:ListItem>
                            <asp:ListItem>Add Storey (One Storey)</asp:ListItem>
                            <asp:ListItem>Add Storey (Two Storey)</asp:ListItem>
                            <asp:ListItem>Add Storey (Three Storey)</asp:ListItem>
                            <asp:ListItem>Add Storey (Four Storey)</asp:ListItem>
                        </asp:DropDownList>
                        </div>
                      </div>--%>

                        <div class="form-group">
                       <asp:Label ID="lblNewStorey" runat="server" class="control-label col-md-3 col-sm-3 col-xs-12" Text="New Storey" Font-Bold="True"></asp:Label>
                        <div class="col-md-9 col-sm-9 col-xs-12">
                         <asp:TextBox ID="txtNewStorey" runat="server" type="number" class="form-control" data-validate-length-range="6" data-validate-words="2" name="name" required="required" placeholder="New Storey"></asp:TextBox>
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
                       <asp:Label ID="lblDifference" runat="server" class="control-label col-md-3 col-sm-3 col-xs-12" Text="Difference" Font-Bold="True"></asp:Label>
                        <div class="col-md-9 col-sm-9 col-xs-12">
                         <asp:TextBox ID="txtDifference" runat="server" type="text" class="form-control" data-validate-length-range="6" data-validate-words="2" name="name" required="required" placeholder="Old - New"></asp:TextBox>
                        </div>
                      </div>

                        <div class="form-group">
                       <asp:Label ID="lblImpact" runat="server" class="control-label col-md-3 col-sm-3 col-xs-12" Text="Impact" Font-Bold="True"></asp:Label>
                        <div class="col-md-9 col-sm-9 col-xs-12">
                            <asp:DropDownList  ID="txtImpact" runat="server" type="text" class="form-control">
                            <asp:ListItem>Select Impact </asp:ListItem>
                            <asp:ListItem>Positive</asp:ListItem>
                            <asp:ListItem>Negative</asp:ListItem>
                            <asp:ListItem>No Impact</asp:ListItem>
                        </asp:DropDownList>
                         <%--<asp:TextBox ID="txtImpact" runat="server" type="text" class="form-control" data-validate-length-range="6" data-validate-words="2" name="name" required="required" placeholder="Impact"></asp:TextBox>--%>
                        </div>
                      </div>
                      <%--<div class="form-group">
                       <asp:Label ID="lblFatherName" runat="server" class="control-label col-md-3 col-sm-3 col-xs-12" Text="Father Name" Font-Bold="True"></asp:Label>
                        <div class="col-md-9 col-sm-9 col-xs-12">
                           <asp:TextBox ID="txtFatherName" runat="server" type="text" class="form-control" placeholder="Father Name" onkeypress="return ValidAlphabet()"></asp:TextBox>
                        </div>
                      </div>
                      <div class="form-group">
                        <asp:Label ID="lblCNIC" runat="server" class="control-label col-md-3 col-sm-3 col-xs-12" Text="CNIC" Font-Bold="True"></asp:Label>
                        <div class="col-md-9 col-sm-9 col-xs-12">
                           <asp:TextBox ID="txtCNIC" runat="server" type="text" class="form-control" required="required" placeholder="CNIC Number"></asp:TextBox>
                        </div>
                      </div>
                      <div class="form-group">
                       <asp:Label ID="lblMobile" runat="server" class="control-label col-md-3 col-sm-3 col-xs-12" Text="Mobile" Font-Bold="True"></asp:Label>
                        <div class="col-md-9 col-sm-9 col-xs-12">
                          <asp:TextBox ID="txtMobile" runat="server" type="number" class="form-control"  required="required" placeholder="Mobile Number"></asp:TextBox>
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

                         <asp:TextBox ID="txtSqyard" runat="server" type="number" class="form-control" data-validate-length-range="6" data-validate-words="2" name="name" required="required" placeholder="500" OnTextChanged="txtSqyard_TextChanged"></asp:TextBox>
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
                           <asp:TextBox ID="txtStorey" runat="server" type="number" class="form-control" data-validate-length-range="6" data-validate-words="2" name="name" required="required" placeholder="1" OnTextChanged="txtStorey_TextChanged"></asp:TextBox>
                      
                        </div>
                      </div>
                        
                       <div class="form-group">
                       <asp:Label ID="lblBillQuarter" runat="server" class="control-label col-md-3 col-sm-3 col-xs-12" Text="Billing Quarter" Font-Bold="True"></asp:Label>
                        <div class="col-md-9 col-sm-9 col-xs-12">
                           <asp:TextBox ID="txtBillingQuarter" runat="server" type="number" class="form-control" data-validate-length-range="6" data-validate-words="2" name="name" required="required" placeholder="31" OnTextChanged="txtBillingQuarter_TextChanged" ></asp:TextBox>
                       <asp:Label ID="lblConsumerNo" runat="server"></asp:Label>
                        </div>
                          
                      </div>
                        <div class="form-group">
                       <asp:Label ID="lblConsunerID" runat="server" class="control-label col-md-3 col-sm-3 col-xs-12" Text="Consumer Number" Font-Bold="True"></asp:Label>
                        <div class="col-md-9 col-sm-9 col-xs-12">

                         <asp:TextBox ID="txtConsumerID" runat="server" type="text" class="form-control"  MaxLength="11" required="required" placeholder="Consumer No." OnTextChanged="txtConsumerID_TextChanged"></asp:TextBox>
                        </div>
                      </div>

                        <div class="form-group">
                       <asp:Label ID="lbldescription" runat="server" class="control-label col-md-3 col-sm-3 col-xs-12" Text="Description" Font-Bold="True"></asp:Label>
                        <div class="col-md-9 col-sm-9 col-xs-12">

                         <asp:TextBox ID="txtdescrption" runat="server" type="text" class="form-control" data-validate-length-range="6" data-validate-words="2" name="name" required="required" placeholder="Outword Number"></asp:TextBox>
                        </div>
                      </div>--%>
                        
                        <asp:Label ID="lblcode" runat="server" Text=""></asp:Label>

                     

                        <asp:Label ID="lblMiddleCode" runat="server"></asp:Label>
                        <asp:Label ID="lblPropertyCode" runat="server"></asp:Label>
                        <asp:Label ID="lblMessage" runat="server" Text="" Visible="true" Font-Bold="true" ForeColor="#006600" Font-Size="Large"></asp:Label>
                      


                      <div class="ln_solid"></div>
                      <div class="form-group">
                        <div class="col-md-9 col-sm-9 col-xs-12 col-md-offset-3">
                          <asp:Button ID="btnCancel" runat="server" type="button" class="btn btn-primary" Text="Cancel" />
                          <asp:Button ID="btnReset" runat="server" type="reset" class="btn btn-primary" Text="Reset" />
                          <asp:Button ID="btnModify" runat="server" type="submit" class="btn btn-success" Text="Modify" OnClick="btnModify_Click" />
                        </div>
                      </div>

                    </form>
                  </div>
                </div>
              </div>

                <%--<div class="col-md-6 col-xs-12">
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
                                <td>Current Arrears</td>
                                <td class="fs15 fw700 text-right">
                                    <asp:Label ID="lblCurrArrears" runat="server" Text=""></asp:Label></td>
                              </tr>
                              <tr>
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

              

                


              </div>--%>

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
                                <tr>
                                <td>Add storeys, Update approved by modifications committee for data of MUCT (KMC) bearing Inword # 00000 Dated 29-05-2020. Add Storeys as per survey report picture and document.</td>
                                <td class="fs15 fw700 text-right">
                                   
                                    </td>
                              </tr>
                                <%--<tr>
                                     <td>Add new consumer as Shop as per survey Update as Approved by Senior Director and Director (MUCT) bearing Inword # XXXXX Dated XX-XX-XXXX as per KMC pick-Up Form Attached</td>
                                
                                <td class="fs15 fw700 text-right">
                                   
                                    </td>
                              </tr>
                                 <tr>
                                     <td>Add new consumer as Residential as per survey Update as Approved by Senior Director and Director (MUCT) bearing Inword # XXXXX Dated XX-XX-XXXX as per KMC pick-Up Form Attached</td>
                                
                                <td class="fs15 fw700 text-right">
                                   
                                    </td>
                              </tr>--%>
                              
                              
                               
                                
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

