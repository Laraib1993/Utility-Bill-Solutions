<%@ Page Title="" Language="C#" MasterPageFile="~/User.master" AutoEventWireup="true" CodeFile="Posting.aspx.cs" Inherits="Posting" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
   <title>Selective Search</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

     <div class="">
            <div class="page-title">
              <div class="title_left">
                <h3>Payment Posting</h3>
              </div>

              <div class="title_right">
                
              </div>
            </div>
            <div class="clearfix"></div>
            
           

            <div class="row">
              

              
              <div class="col-md-12 col-sm-12 col-xs-12">
                <div class="x_panel">
                  <div class="x_title">
                    <h2>Payment <small>Post</small></h2>
                    <ul class="nav navbar-right panel_toolbox">
                      <li><a class="collapse-link"><i class="fa fa-chevron-up"></i></a>
                      </li>
                      
                      <li><a class="close-link"><i class="fa fa-close"></i></a>
                      </li>
                    </ul>
                    <div class="clearfix"></div>
                  </div>
                  <div class="x_content">

                    <form class="form-horizontal form-label-left" runat="server">

                      <div class="form-group">
                        <label class="col-sm-3 control-label">By Cunsumer No.</label>

                        <div class="col-sm-6">
                          
                          <div class="input-group">
                            <asp:TextBox ID="txtFindConsumer" runat="server" type="text" class="form-control" placeholder="Consumer No."></asp:TextBox>
                            <span class="input-group-btn">
                                              <asp:Button ID="btnFindcon" type="button" class="btn btn-primary" runat="server" Text="Go!" OnClick="btnFindcon_Click" />
                                          </span>
                          </div>
                        </div>
                      </div>
                      
                        
                     
                        
                         
                       

                      
                        
                        
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
                      
                    </form>
                  </div>
                </div>
              </div>

               
              
            </div>
         
          </div>

</asp:Content>

