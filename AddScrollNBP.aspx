<%@ Page Title="" Language="C#" MasterPageFile="~/User.master" AutoEventWireup="true" CodeFile="AddScrollNBP.aspx.cs" Inherits="AddScroll" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <title>Sccroll Insert</title>
    <script type='text/javascript'>
    function isNumber(evt) {
        evt = (evt) ? evt : window.event;
        var charCode = (evt.which) ? evt.which : evt.keyCode;
        if (charCode > 31 && (charCode < 48 || charCode > 57)) {
            return false;
        }
        return true;
    }
</script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="">
            <div class="page-title">
              <div class="title_left">
                <h3>Scroll Insert</h3>
              </div>

              <div class="title_right">
                
              </div>
            </div>
            <div class="clearfix"></div>
            
           

            <div class="row">
              

              
              <div class="col-md-12 col-sm-12 col-xs-12">
                <div class="x_panel">
                  <div class="x_title">
                    <h2>Search <small>Seletive</small></h2>
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
                       <asp:Label runat="server" class="control-label col-md-3 col-sm-3 col-xs-12" Text="Consumer Number"  Font-Bold="True"></asp:Label>
                        <div class="col-md-7 col-sm-7 col-xs-12">

                         <asp:TextBox ID="txtconsumer" runat="server" type="text" class="form-control" MaxLength="11" data-validate-words="2" name="name" required="required" placeholder="Consumer Number"></asp:TextBox>
                        </div>
                      </div>


            <div class="form-group">
                       <asp:Label runat="server" class="control-label col-md-3 col-sm-3 col-xs-12" Text="Amount" Font-Bold="True"></asp:Label>
                        <div class="col-md-7 col-sm-7 col-xs-12">

                         <asp:TextBox ID="txtamount" runat="server" type="text" class="form-control" maxlength="5" onkeypress="return isNumber(event)" data-validate-length-range="6" data-validate-words="2" name="name" required="required" placeholder="Amount"></asp:TextBox>
                        </div>
                      </div>


            <div class="form-group">
                       <asp:Label runat="server" class="control-label col-md-3 col-sm-3 col-xs-12" Text="Branch Code" Font-Bold="True"></asp:Label>
                        <div class="col-md-7 col-sm-7 col-xs-12">

                         <asp:TextBox ID="txtbranchcode" runat="server" type="text" maxlength="4" onkeypress="return isNumber(event)" class="form-control" data-validate-length-range="6" data-validate-words="2" name="name" required="required" placeholder="Branch Code"></asp:TextBox>
                        </div>
                      </div>

            <div class="form-group">
                       <asp:Label runat="server" class="control-label col-md-3 col-sm-3 col-xs-12" Text="Amount" Font-Bold="True"></asp:Label>
                        <div class="col-md-7 col-sm-7 col-xs-12">

                         <asp:TextBox ID="txtpaymentdate" runat="server" type="date" class="form-control" data-validate-length-range="6" data-validate-words="2" name="name" required="required" placeholder="Payment Date"></asp:TextBox>
                        </div>
                      </div>

              
                

                     <div class="form-group">
                       <asp:Label runat="server" class="control-label col-md-3 col-sm-3 col-xs-12" Text="Billing Period" Font-Bold="True"></asp:Label>
                        <div class="col-md-7 col-sm-7 col-xs-12">
                            <input runat="server"  id="txtbillingperiod" class="form-control" required="required" onkeyup="this.value = this.value.toUpperCase();" placeholder="Billing Period"/>
                         
                        </div>
                      </div>



                      <div class="form-group">
                       <asp:Label runat="server" class="control-label col-md-3 col-sm-3 col-xs-12" Text="Bank" Font-Bold="True"></asp:Label>
                        <div class="col-md-7 col-sm-7 col-xs-12">
                          <input runat="server"  id="Text1" class="form-control" required="required" placeholder="NATIONAL BANK" disabled="disabled"/>
                        </div>
                      </div>

                  <%--  <div class="form-group">
                       <asp:Label runat="server" class="control-label col-md-3 col-sm-3 col-xs-12" Text="Bank" Font-Bold="True"></asp:Label>
                        <div class="col-md-7 col-sm-7 col-xs-12">
                           <asp:DropDownList ID="ddlbank" runat="server" class="col-md-7 col-sm-7 col-xs-12 form-control" Enabled="false" >
                               <asp:ListItem Text="Select Bank" Value="-1"></asp:ListItem>
                               <asp:ListItem Text="HABIB BANK" Value="HABIB BANK" Selected="True"></asp:ListItem>
                               <asp:ListItem Text="NATIONAL BANK" Value="HABIB BANK"></asp:ListItem>
                               <asp:ListItem Text="SINDH BANK" Value="HABIB BANK"></asp:ListItem>
                               
                           </asp:DropDownList>
                        </div>
                      </div>--%>


                



              <div class="form-group">
                        <div class="col-md-9 col-sm-9 col-xs-12 col-md-offset-3">
                          <asp:Button ID="btnCancle" runat="server" type="button" class="btn btn-primary" Text="Cancle" />
                          <asp:Button ID="btnReset" runat="server" type="reset" class="btn btn-primary" Text="Reset" />
                            <asp:Button ID="btnsearch" runat="server" type="text" class="btn btn-primary" Text="Verify" OnClick="btnsearch_Click" />
                            <asp:Panel ID="pnlinsert" runat="server">
                          <asp:Button ID="btnSubmit" runat="server" type="submit" class="btn btn-success" Text="Submit" OnClick="btnSubmit_Click" Visible="false" />
                        </asp:Panel>
                         </div>
                      </div>

                      <div class="ln_solid">
                          <asp:Label ID="lblerror" runat="server"></asp:Label>

                      </div>

                        
                        
                        
                        
                        
                        <asp:Panel ID="pnl" runat="server" >
                             <div class="ln_solid"></div>
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
            HeaderText="CONSUMER NO" ItemStyle-Wrap="False" HeaderStyle-Wrap="False" HeaderStyle-HorizontalAlign ="Center">
            <HeaderStyle HorizontalAlign="Center"></HeaderStyle> 
            <ItemStyle HorizontalAlign="Center"  ForeColor="Black" BackColor="white" Font-Bold="True"></ItemStyle>
        </asp:BoundField>

        <asp:BoundField 
            DataField="Billing_Period"
            HeaderText="Billing Period" HeaderStyle-Wrap="False">
            <HeaderStyle HorizontalAlign="Center"></HeaderStyle> 
            <ItemStyle HorizontalAlign="left" ForeColor="Black" BackColor="white" Font-Bold="True" ></ItemStyle>
        </asp:BoundField>

      
      
        <asp:BoundField 
            DataField="branch_code"
            HeaderText="Branch Code" HeaderStyle-Wrap="False">
            <HeaderStyle HorizontalAlign="Center"></HeaderStyle> 
            <ItemStyle HorizontalAlign="left" ForeColor="Black" BackColor="white" Font-Bold="True"></ItemStyle>
        </asp:BoundField> 
       

        <asp:BoundField 
            DataField="amount"
            HeaderText="Amount" ItemStyle-Wrap="False" HeaderStyle-Wrap="False" HeaderStyle-HorizontalAlign ="Center">
            <HeaderStyle HorizontalAlign="Center" ></HeaderStyle> 
            <ItemStyle HorizontalAlign="Center" ForeColor="Black" BackColor="white" Font-Bold="True" ></ItemStyle>
        </asp:BoundField>
     
        

        <asp:BoundField 
            DataField="Payment_Date"
            
            HeaderText="Payment Date" HeaderStyle-Wrap="False">
            <HeaderStyle HorizontalAlign="Center" ></HeaderStyle> 
            <ItemStyle HorizontalAlign="center" ForeColor="Black" BackColor="white" Font-Bold="True" ></ItemStyle>
        </asp:BoundField>

        <asp:BoundField 
            DataField="Bank_Name"
            
            HeaderText="Bank" HeaderStyle-Wrap="False">
            <HeaderStyle HorizontalAlign="Center" ></HeaderStyle> 
            <ItemStyle HorizontalAlign="center" ForeColor="Black" BackColor="white" Font-Bold="True" ></ItemStyle>
        </asp:BoundField>

</Columns>
      </asp:GridView>
                          <br />
                    
                        </asp:Panel>
                        
                     
                          
                       
                      
                    </form>
                  </div>
                </div>
              </div>

               
              
            </div>
         
          </div>
</asp:Content>

