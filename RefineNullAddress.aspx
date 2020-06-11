<%@ Page Title="" Language="C#" MasterPageFile="~/User.master" AutoEventWireup="true" CodeFile="RefineNullAddress.aspx.cs" Inherits="RefineNullAddress" %>

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
                <h3>Refine Null Address</h3>
              </div>

              <div class="title_right">
                
              </div>
            </div>
            <div class="clearfix"></div>
            
           

            <div class="row">
              
 <div class="col-md-12 col-sm-12 col-xs-12">
                <div class="x_panel">
                  <div class="x_title">
                    <h2>Seletive Search For Null Addresses </h2>
                    
                    <div class="clearfix"></div>
                  </div>
                  <div class="x_content">

                    <form class="form-horizontal form-label-left" runat="server">

                      <div class="form-group">
                        <label class="col-sm-3 control-label">Cunsumer No</label>

                        <div class="col-sm-6">
                          
                          <div class="input-group">
                            <asp:TextBox ID="txtFindConsumer" runat="server" type="text" class="form-control" MaxLength="11" placeholder="Consumer No."></asp:TextBox>
                            <span class="input-group-btn">
                                              <asp:Button ID="btnFindcon" type="button" class="btn btn-primary" runat="server" Text="Verify Consumer" OnClick="btnFindcon_Click" />
                                          </span>
                              
                          </div>
                            <asp:Label class="col-md-offset-3 col-md-6" ID="lblverifyconsumer" runat="server" Visible="false" Font-Bold="True" ForeColor="#006600">Not Eligible</asp:Label>
                            
                        </div>
                          
                      </div>
                      <div class="divider-dashed"></div>

                        <asp:Panel ID="pnladdress" runat="server" Visible="false">

                       
                        
                             <div class="form-group">

                         <div class="form-group">
                        <asp:Button ID="txtkwsb" runat="server" type="button" class="btn btn-primary col-md-offset-3 col-md-6" Text="Verify from KWSB Data" OnClick="btnFindadd_Click" /> 

                      </div>
                          <div class="divider-dashed"></div>
                          </div>

                      <div class="form-group">

                         <div class="form-group">
                        <label class="col-md-3" id="lblkwsbaddress" runat="server" visible="false">Cunsumer Address</label>

                      </div>
                          <div class="divider-dashed"></div>
                          </div>
          <%--              <div class="form-group">
                       <asp:Label ID="lblConsumerAddress" runat="server" class="control-label col-md-3 col-sm-3 col-xs-12" Text="Consumer Address" Font-Bold="True"></asp:Label>
                        <div class="col-md-6 col-sm-9 col-xs-12">

                         <asp:TextBox ID="txtAddress" runat="server" type="text" class="form-control" data-validate-length-range="6" data-validate-words="2" name="name"  placeholder="%Address%" Visible="false" ></asp:TextBox>
                        </div>
                      </div>--%>
                        <div class="divider-dashed"></div>
                        <div class="ln_solid"></div>
                      <div class="form-group">
                        <div class="col-md-9 col-sm-9 col-xs-12 col-md-offset-3">
                          
                          <asp:Button ID="btnReset" runat="server" type="reset" class="btn btn-primary" Text="Reset" OnClick="btnReset_Click"/>
                          <asp:Button ID="btnSubmit" runat="server" type="submit" class="btn btn-success" Text="Submit" OnClick="btnModify_Click" />
                        </div>
                      </div>
                        
                       </asp:Panel>
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
            DataField="consumer_no"
            HeaderText="CONSUMER NO" ItemStyle-Wrap="False" HeaderStyle-Wrap="False" HeaderStyle-HorizontalAlign ="Center">
            <HeaderStyle HorizontalAlign="Center"></HeaderStyle> 
            <ItemStyle HorizontalAlign="Center"  ForeColor="Black" BackColor="white" Font-Bold="True"></ItemStyle>
        </asp:BoundField>

        <asp:BoundField 
            DataField="consumer_name"
            HeaderText="NAME" HeaderStyle-Wrap="False">
            <HeaderStyle HorizontalAlign="Center"></HeaderStyle> 
            <ItemStyle HorizontalAlign="left" ForeColor="Black" BackColor="white" Font-Bold="True" ></ItemStyle>
        </asp:BoundField>

      
      
        <asp:BoundField 
            DataField="consumer_address"
            HeaderText="ADDRESS" HeaderStyle-Wrap="False">
            <HeaderStyle HorizontalAlign="Center"></HeaderStyle> 
            <ItemStyle HorizontalAlign="left" ForeColor="Black" BackColor="white" Font-Bold="True"></ItemStyle>
        </asp:BoundField> 
       

        <asp:BoundField 
            DataField="Category"
            HeaderText="Category" ItemStyle-Wrap="False" HeaderStyle-Wrap="False" HeaderStyle-HorizontalAlign ="Center">
            <HeaderStyle HorizontalAlign="Center" ></HeaderStyle> 
            <ItemStyle HorizontalAlign="Center" ForeColor="Black" BackColor="white" Font-Bold="True" ></ItemStyle>
        </asp:BoundField>
     
        <asp:BoundField 
            DataField="area"
            
            HeaderText="Size" HeaderStyle-Wrap="False">
            <HeaderStyle HorizontalAlign="Center" ></HeaderStyle> 
            <ItemStyle HorizontalAlign="center" ForeColor="Black" BackColor="white" Font-Bold="True"></ItemStyle>
        </asp:BoundField>

        <asp:BoundField 
            DataField="Storey"
            
            HeaderText="Storey" HeaderStyle-Wrap="False">
            <HeaderStyle HorizontalAlign="Center" ></HeaderStyle> 
            <ItemStyle HorizontalAlign="center" ForeColor="Black" BackColor="white" Font-Bold="True" ></ItemStyle>
        </asp:BoundField>

        <asp:BoundField 
            DataField="Town"
            
            HeaderText="Town" HeaderStyle-Wrap="False">
            <HeaderStyle HorizontalAlign="Center" ></HeaderStyle> 
            <ItemStyle HorizontalAlign="center" ForeColor="Black" BackColor="white" Font-Bold="True" ></ItemStyle>
        </asp:BoundField>

         <asp:BoundField 
            DataField="uc_name"
            
            HeaderText="UC" HeaderStyle-Wrap="False">
            <HeaderStyle HorizontalAlign="right" ></HeaderStyle> 
            <ItemStyle HorizontalAlign="center" ForeColor="Black" BackColor="white" Font-Bold="True" ></ItemStyle>
        </asp:BoundField>

         <asp:BoundField 
            DataField="Block"
            
            HeaderText="Block" HeaderStyle-Wrap="False">
            <HeaderStyle HorizontalAlign="right" Width="80px"></HeaderStyle> 
            <ItemStyle HorizontalAlign="center" ForeColor="Black" BackColor="white" Font-Bold="True" Width="80px"></ItemStyle>
        </asp:BoundField>
     <asp:BoundField 
            DataField="current_Charges"
            
            HeaderText="Current" HeaderStyle-Wrap="False">
            <HeaderStyle HorizontalAlign="right" Width="80px"></HeaderStyle> 
            <ItemStyle HorizontalAlign="center" ForeColor="Black" BackColor="white" Font-Bold="True" Width="80px"></ItemStyle>
        </asp:BoundField>
     <asp:BoundField 
            DataField="outstanding_arrears"
            
            HeaderText="Arrears" HeaderStyle-Wrap="False">
            <HeaderStyle HorizontalAlign="right" Width="80px"></HeaderStyle> 
            <ItemStyle HorizontalAlign="center" ForeColor="Black" BackColor="white" Font-Bold="True" Width="80px"></ItemStyle>
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

