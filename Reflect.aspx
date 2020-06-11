<%@ Page Title="" Language="C#" MasterPageFile="~/User.master" AutoEventWireup="true" CodeFile="Reflect.aspx.cs" Inherits="Reflect" %>

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
                    <div class="clearfix"></div>
                  </div>
                  <div class="x_content">
                    <br />
                    <form class="form-horizontal form-label-left" novalidate runat="server" >
                      <div class="form-group">
                       <asp:Label ID="lblConsumerNo" runat="server" class="control-label col-md-3 col-sm-3 col-xs-12" Text="Consumer Number" Font-Bold="True"></asp:Label>
                        <div class="col-md-9 col-sm-9 col-xs-12">
                         <asp:TextBox ID="txtConsumerNo" runat="server" type="text" class="form-control" data-validate-length-range="6" data-validate-words="2" name="name" required="required" placeholder="Consumer Number"></asp:TextBox>
                        </div>
                      </div>

                          <div class="form-group">
                       <asp:Label ID="Label1" runat="server" class="control-label col-md-3 col-sm-3 col-xs-12" Text="Payment Amount" Font-Bold="True"></asp:Label>
                        <div class="col-md-9 col-sm-9 col-xs-12">
                         <asp:TextBox ID="txtpaymentamount" runat="server" type="number" class="form-control" data-validate-length-range="6" data-validate-words="2" name="name" required="required" placeholder="Payment Amount Written On Scroll Given by Consumer"></asp:TextBox>
                        </div>
                      </div>


                                    <div class="form-group">
                       <asp:Label runat="server" class="control-label col-md-3 col-sm-3 col-xs-12" Text="Branch Code" Font-Bold="True"></asp:Label>
                        <div class="col-md-9 col-sm-9 col-xs-12">

                         <asp:TextBox ID="txtbranchcode" runat="server" type="text" class="form-control" data-validate-length-range="6" data-validate-words="2" name="name" required="required" placeholder="Branch Code"></asp:TextBox>
                        </div>
                      </div>

            <div class="form-group">
                       <asp:Label runat="server" class="control-label col-md-3 col-sm-3 col-xs-12" Text="Payment Date" Font-Bold="True"></asp:Label>
                        <div class="col-md-9 col-sm-9 col-xs-12">

                         <asp:TextBox ID="txtpaymentdate" runat="server" type="date" class="form-control" data-validate-length-range="6" data-validate-words="2" name="name" required="required" placeholder="Payment Date"></asp:TextBox>
                        </div>
                      </div>


                    <div class="form-group">
                       <asp:Label runat="server" class="control-label col-md-3 col-sm-3 col-xs-12" Text="Bank" Font-Bold="True"></asp:Label>
                        <div class="col-md-9 col-sm-9 col-xs-12">
                           <asp:DropDownList ID="ddlbank" runat="server" class="form-control" >
                               <asp:ListItem Text="Select Bank" Value="0" Selected="True"></asp:ListItem>
                               <asp:ListItem Text="HABIB BANK" Value="HABIB BANK"></asp:ListItem>
                               <asp:ListItem Text="NATIONAL BANK" Value="NATIONAL BANK"></asp:ListItem>
                               <asp:ListItem Text="SINDH BANK" Value="SINDH BANK"></asp:ListItem>
                               
                           </asp:DropDownList>
                        </div>
                      </div>

                      <div class="form-group">
                        <div class="col-md-9 col-sm-9 col-xs-12 col-md-offset-3">
                          <asp:Button ID="btnReset" runat="server" type="reset" class="btn btn-primary" Text="Reset Consumer" OnClick="btnReset_Click" />
                          <asp:Button ID="btnverifypostingvoucher" runat="server" type="submit" class="btn btn-success" Text="Verify Payment" OnClick="btnverifypostingvoucher_Click" />
                        </div>
                      </div>

                  <%--       <div class="form-group">
                       <asp:Label ID="lblInword" runat="server" class="control-label col-md-3 col-sm-3 col-xs-12" Text="Inword Number" Font-Bold="True"></asp:Label>
                        <div class="col-md-9 col-sm-9 col-xs-12">

                         <asp:TextBox ID="txtInword" runat="server" type="number" class="form-control" data-validate-length-range="6" data-validate-words="2" name="name" required="required" placeholder="Inword Number"></asp:TextBox>
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
                          <asp:DropDownList class="form-control" ID="ddlper" runat="server" AutoPostBack="false" OnSelectedIndexChanged="ddlper_SelectedIndexChanged">
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
                        
                      <div class="form-group">
                       <asp:Label ID="lblDescription" runat="server" class="control-label col-md-3 col-sm-3 col-xs-12" Text="Description" Font-Bold="True" ></asp:Label>
                        <div class="col-md-9 col-sm-9 col-xs-12">
                          <asp:TextBox ID="txtDescription" runat="server" type="text" class="form-control" data-validate-length-range="6" data-validate-words="2" required="required" placeholder="Description"></asp:TextBox>
                      
                        </div>
                      </div>--%>
                        
                        <asp:Label ID="lbltmpName" runat="server" Visible="False"></asp:Label>
                        <asp:Label ID="lbltmpfname" runat="server" Visible="False"></asp:Label>
                        <asp:Label ID="lbltmpadress" runat="server" Visible="False"></asp:Label>
                        <asp:Label ID="lbltmpcnic" runat="server" Visible="False"></asp:Label>
                        <asp:Label ID="lbltmpmobile" runat="server" Visible="False"></asp:Label>
                        <asp:Label ID="lblmessage" runat="server" Font-Bold="True" ForeColor="#006600"></asp:Label>
                      <div class="ln_solid"></div>

                           <br />
                         <asp:GridView ID="gvSearch" 
        runat="server"
        Width="100%"
        BorderColor="gray" 
        BorderStyle="Outset"
        BorderWidth="1px" 
        Font-Size="8.5pt"
        Font-Names="Sans-Serif"
        BackColor="Beige" 
        GridLines="Both"
        CellPadding="3"
        CellSpacing="6"
        AutoGenerateColumns="false" class="table table-striped table-bordered"
        >
<HeaderStyle BackColor="#5a738e" />
<HeaderStyle ForeColor="White" />
<Columns>
        <asp:BoundField 
            DataField="Consumer_no"
            HeaderText="CONSUMER NO" ItemStyle-Wrap="False" HeaderStyle-Wrap="False">
            <HeaderStyle HorizontalAlign="left"></HeaderStyle> 
            <ItemStyle HorizontalAlign="left" Font-Bold="True"></ItemStyle>
        </asp:BoundField>

        <asp:BoundField 
            DataField="Billing_Period"
            HeaderText="BILLING Period" ItemStyle-Wrap="False" HeaderStyle-Wrap="False">
            <HeaderStyle HorizontalAlign="left"></HeaderStyle> 
            <ItemStyle HorizontalAlign="left" Font-Bold="True"></ItemStyle>
        </asp:BoundField>

        <asp:BoundField 
            DataField="branch_code"
            HeaderText="Branch Code" ItemStyle-Wrap="False" HeaderStyle-Wrap="False">
            <HeaderStyle HorizontalAlign="left"></HeaderStyle> 
            <ItemStyle HorizontalAlign="left" Font-Bold="True"></ItemStyle>
        </asp:BoundField>
	<asp:BoundField 
            DataField="amount"
            HeaderText="AMOUNT" ItemStyle-Wrap="False" HeaderStyle-Wrap="False">
            <HeaderStyle HorizontalAlign="left"></HeaderStyle> 
            <ItemStyle HorizontalAlign="left" Font-Bold="True"></ItemStyle>
        </asp:BoundField>

        <asp:BoundField 
            DataField="Payment_Date"
            HeaderText="PAYMENT DATE" ItemStyle-Wrap="False" HeaderStyle-Wrap="False">
            <HeaderStyle HorizontalAlign="left"></HeaderStyle> 
            <ItemStyle HorizontalAlign="left" Font-Bold="True"></ItemStyle>
        </asp:BoundField> 
     <asp:BoundField 
            DataField="Bank_Name"
            HeaderText="BANK NAME" ItemStyle-Wrap="False" HeaderStyle-Wrap="False">
            <HeaderStyle HorizontalAlign="left"></HeaderStyle> 
            <ItemStyle HorizontalAlign="left" Font-Bold="True"></ItemStyle>
        </asp:BoundField> 
   </Columns>
      </asp:GridView>
                          <br />

                        <asp:Panel ID="pnlpostingvoucher" runat="server" Visible="false">
                            <div class="form-group">
                                <div class="form-group">
                       <asp:Label runat="server" class="control-label col-md-3 col-sm-3 col-xs-12" Text="Billing Period" Font-Bold="True"></asp:Label>
                        <div class="col-md-9 col-sm-9 col-xs-12">

                         <asp:TextBox ID="txtbillingperiod" runat="server" type="text" class="form-control" data-validate-length-range="6" data-validate-words="2" name="name" required="required" placeholder="Billing Period"></asp:TextBox>
                        </div>
                      </div>
                        <div class="col-md-9 col-sm-9 col-xs-12 col-md-offset-3">
                          <asp:Button ID="btnpostingvoucher" runat="server" type="submit" class="btn btn-success" Text="Insert Payment" OnClick="btnpostingvoucher_Click" />
                        </div>
                      </div>

                             <br />
                         <asp:GridView ID="gvposting" 
        runat="server"
        Width="100%"
        BorderColor="gray" 
        BorderStyle="Outset"
        BorderWidth="1px" 
        Font-Size="8.5pt"
        Font-Names="Sans-Serif"
        BackColor="Beige" 
        GridLines="Both"
        CellPadding="3"
        CellSpacing="6"
        AutoGenerateColumns="false" class="table table-striped table-bordered"
        >
<HeaderStyle BackColor="#5a738e" />
<HeaderStyle ForeColor="White" />
<Columns>
        <asp:BoundField 
            DataField="Consumer_no"
            HeaderText="CONSUMER NO" ItemStyle-Wrap="False" HeaderStyle-Wrap="False">
            <HeaderStyle HorizontalAlign="left"></HeaderStyle> 
            <ItemStyle HorizontalAlign="left" Font-Bold="True"></ItemStyle>
        </asp:BoundField>

        <asp:BoundField 
            DataField="Billing_Period"
            HeaderText="BILLING Period" ItemStyle-Wrap="False" HeaderStyle-Wrap="False">
            <HeaderStyle HorizontalAlign="left"></HeaderStyle> 
            <ItemStyle HorizontalAlign="left" Font-Bold="True"></ItemStyle>
        </asp:BoundField>

        <asp:BoundField 
            DataField="branch_code"
            HeaderText="Branch Code" ItemStyle-Wrap="False" HeaderStyle-Wrap="False">
            <HeaderStyle HorizontalAlign="left"></HeaderStyle> 
            <ItemStyle HorizontalAlign="left" Font-Bold="True"></ItemStyle>
        </asp:BoundField>
	<asp:BoundField 
            DataField="amount"
            HeaderText="AMOUNT" ItemStyle-Wrap="False" HeaderStyle-Wrap="False">
            <HeaderStyle HorizontalAlign="left"></HeaderStyle> 
            <ItemStyle HorizontalAlign="left" Font-Bold="True"></ItemStyle>
        </asp:BoundField>

        <asp:BoundField 
            DataField="Payment_Date"
            HeaderText="PAYMENT DATE" ItemStyle-Wrap="False" HeaderStyle-Wrap="False">
            <HeaderStyle HorizontalAlign="left"></HeaderStyle> 
            <ItemStyle HorizontalAlign="left" Font-Bold="True"></ItemStyle>
        </asp:BoundField> 
     <asp:BoundField 
            DataField="Bank_Name"
            HeaderText="BANK NAME" ItemStyle-Wrap="False" HeaderStyle-Wrap="False">
            <HeaderStyle HorizontalAlign="left"></HeaderStyle> 
            <ItemStyle HorizontalAlign="left" Font-Bold="True"></ItemStyle>
        </asp:BoundField> 
   </Columns>
      </asp:GridView>
                          <br />

                        </asp:Panel>









                        <%--rebate area--%>
                        <asp:Panel runat="server" ID="pnlcheckrebate" Visible="false">
                       <div class="form-group">
                        <div class="col-md-12 col-sm-12 col-xs-12 ">
                          <asp:Button ID="txtcheckcanclerebate" runat="server" type="reset" class="btn btn btn-danger" Text="Check If Rebate Cancle" OnClick="txtcheckcanclerebate_Click" />
                          <asp:Button ID="txtcheckrebate" runat="server" type="submit" class="btn btn-success" Text="Rebate Check" OnClick="txtcheckrebate_Click" />
                        </div>
                      </div>
                             <div class="ln_solid"></div>
                            <asp:Label ID="lblrebateerror" runat="server" Visible="False" ForeColor="#FF0000"></asp:Label>
                      
                        <br />
                         <asp:GridView ID="gvcheckrebate" 
        runat="server"
        Width="100%"
        BorderColor="gray" 
        BorderStyle="Outset"
        BorderWidth="1px" 
        Font-Size="8.5pt"
        Font-Names="Sans-Serif"
        BackColor="Beige" 
        GridLines="Both"
        CellPadding="3"
        CellSpacing="6"
        AutoGenerateColumns="false" class="table table-striped table-bordered"
        >
<HeaderStyle BackColor="#5a738e" />
<HeaderStyle ForeColor="White" />
<Columns>
       <asp:BoundField 
            DataField="inwordno"
            HeaderText="INWORD NO" ItemStyle-Wrap="False" HeaderStyle-Wrap="False">
            <HeaderStyle HorizontalAlign="left"></HeaderStyle> 
            <ItemStyle HorizontalAlign="left" Font-Bold="True"></ItemStyle>
        </asp:BoundField>
        <asp:BoundField 
            DataField="consumer_no"
            HeaderText="CONSUMER NO" ItemStyle-Wrap="False" HeaderStyle-Wrap="False">
            <HeaderStyle HorizontalAlign="left"></HeaderStyle> 
            <ItemStyle HorizontalAlign="left" Font-Bold="True"></ItemStyle>
        </asp:BoundField>

        <asp:BoundField 
            DataField="pervious_outstanding"
            HeaderText="OLD OUTSTANDING" ItemStyle-Wrap="False" HeaderStyle-Wrap="False">
            <HeaderStyle HorizontalAlign="left"></HeaderStyle> 
            <ItemStyle HorizontalAlign="left" Font-Bold="True"></ItemStyle>
        </asp:BoundField>

        <asp:BoundField 
            DataField="after_rebate_outstanding"
            HeaderText="AFTER REBATE" ItemStyle-Wrap="False" HeaderStyle-Wrap="False">
            <HeaderStyle HorizontalAlign="left"></HeaderStyle> 
            <ItemStyle HorizontalAlign="left" Font-Bold="True"></ItemStyle>
        </asp:BoundField>
	<asp:BoundField 
            DataField="difference"
            HeaderText="DIFFERENCE" ItemStyle-Wrap="False" HeaderStyle-Wrap="False">
            <HeaderStyle HorizontalAlign="left"></HeaderStyle> 
            <ItemStyle HorizontalAlign="left" Font-Bold="True"></ItemStyle>
        </asp:BoundField>

        <asp:BoundField 
            DataField="cancledby"
            HeaderText="CANCLED BY" ItemStyle-Wrap="False" HeaderStyle-Wrap="False">
            <HeaderStyle HorizontalAlign="left"></HeaderStyle> 
            <ItemStyle HorizontalAlign="left" Font-Bold="True"></ItemStyle>
        </asp:BoundField> 
     <asp:BoundField 
            DataField="cancledon"
            HeaderText="CANCLED ON" ItemStyle-Wrap="False" HeaderStyle-Wrap="False">
            <HeaderStyle HorizontalAlign="left"></HeaderStyle> 
            <ItemStyle HorizontalAlign="left" Font-Bold="True"></ItemStyle>
        </asp:BoundField> 
   </Columns>
      </asp:GridView>
                          <br />

                            <br />
                         <asp:GridView ID="gvcheckrebate2" 
        runat="server"
        Width="100%"
        BorderColor="gray" 
        BorderStyle="Outset"
        BorderWidth="1px" 
        Font-Size="8.5pt"
        Font-Names="Sans-Serif"
        BackColor="Beige" 
        GridLines="Both"
        CellPadding="3"
        CellSpacing="6"
        AutoGenerateColumns="false" class="table table-striped table-bordered"
        >
<HeaderStyle BackColor="#5a738e" />
<HeaderStyle ForeColor="White" />
<Columns>
       
        <asp:BoundField 
            DataField="consumer_no"
            HeaderText="CONSUMER NO" ItemStyle-Wrap="False" HeaderStyle-Wrap="False">
            <HeaderStyle HorizontalAlign="left"></HeaderStyle> 
            <ItemStyle HorizontalAlign="left" Font-Bold="True"></ItemStyle>
        </asp:BoundField>
        <asp:BoundField 
            DataField="outstanding_Arrears"
            HeaderText="OLD OUTSTANDING" ItemStyle-Wrap="False" HeaderStyle-Wrap="False">
            <HeaderStyle HorizontalAlign="left"></HeaderStyle> 
            <ItemStyle HorizontalAlign="left" Font-Bold="True"></ItemStyle>
        </asp:BoundField>

        <asp:BoundField 
            DataField="after_rebate"
            HeaderText="AFTER REBATE" ItemStyle-Wrap="False" HeaderStyle-Wrap="False">
            <HeaderStyle HorizontalAlign="left"></HeaderStyle> 
            <ItemStyle HorizontalAlign="left" Font-Bold="True"></ItemStyle>
        </asp:BoundField>

        <asp:BoundField 
            DataField="createdby"
            HeaderText="CANCLED BY" ItemStyle-Wrap="False" HeaderStyle-Wrap="False">
            <HeaderStyle HorizontalAlign="left"></HeaderStyle> 
            <ItemStyle HorizontalAlign="left" Font-Bold="True"></ItemStyle>
        </asp:BoundField> 
     <asp:BoundField 
            DataField="createdon"
            HeaderText="CANCLED ON" ItemStyle-Wrap="False" HeaderStyle-Wrap="False">
            <HeaderStyle HorizontalAlign="left"></HeaderStyle> 
            <ItemStyle HorizontalAlign="left" Font-Bold="True"></ItemStyle>
        </asp:BoundField> 
   </Columns>
      </asp:GridView>
                          <br />
                        </asp:Panel>


                        






                        
                        
                        
                        <div class="ln_solid"></div>
                        <div class="form-group" runat="server" id="pnlreflect" visible="false">
                        <div class="col-md-12 col-sm-12 col-xs-12">
                          
                          <asp:Button ID="btnsubmit" runat="server" type="submit" class="btn btn-danger" Text="If Rebate Amount Is Paid Then Click Here" OnClick="btnsubmit_Click" />
                        </div>
                      </div>
                        <div class="ln_solid"></div>
                        <div class="form-group" runat="server" id="pnlreflect2" visible="false">
                        <div class="col-md-12 col-sm-12 col-xs-12">
                         
                          <asp:Button ID="btncancle" runat="server" type="reset" class="btn btn-success" Text="If Rebate Amount Is Not Paid Then Click Here" OnClick="btncancle_Click" />
                        </div>
                      </div>
                    </form>
                  </div>
                </div>
              </div>

                <div class="col-md-6 col-xs-12">
                <div class="x_panel">
                  <div class="x_title">
                    <h2>Payment Reflect<small>form Bank Scroll</small></h2>
                   
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
              
                 

            </div>
          </div>
</asp:Content>

