<%@ Page Title="" Language="C#" MasterPageFile="~/User.master" AutoEventWireup="true" CodeFile="SelectSearch.aspx.cs" Inherits="SelectSearch" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
   <title>Selective Search</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">


     <div class="">
            <div class="page-title">
              <div class="title_left">
                <h3>Selective Search</h3>
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
                      <div class="divider-dashed"></div>
                        
                      <div class="form-group">
                        <label class="col-sm-3 control-label">By Address</label>

                        <div class="col-sm-6">
                          
                         <%-- <div class="input-group">
                            <asp:TextBox ID="txtFindAddress" runat="server" type="text" class="form-control"></asp:TextBox>
                              
                           
                          </div>--%>
                             <div class="input-group">
                            <asp:TextBox ID="txtFindBlock" runat="server" type="text" class="form-control" placeholder="address"></asp:TextBox>
                              
                            <span class="input-group-btn">
                                              <asp:Button ID="btnFindadd" type="button" class="btn btn-primary" runat="server" Text="Go!" OnClick="btnFindadd_Click" />
                                 
                            </span>
                          </div>
                        </div>
                          </div>
                         <div class="divider-dashed"></div>

                         <div class="form-group">
                        <label class="col-sm-3 control-label">By Cunsumer Name</label>

                        <div class="col-sm-6">
                          
                          <div class="input-group">
                            <asp:TextBox ID="txtConsumerName" runat="server" type="text" class="form-control" placeholder="Consumer Name"></asp:TextBox>
                            <span class="input-group-btn">
                                              <asp:Button ID="btnFindName" type="button" class="btn btn-primary" runat="server" Text="Go!" OnClick="btnFindName_Click" />
                                          </span>
                          </div>
                        </div>
                      </div>
                          <div class="divider-dashed"></div>
                        <%--<div class="form-group">
                       <asp:Label ID="lblZone" runat="server" class="control-label col-md-3 col-sm-3 col-xs-12" Text="Select Zone" Font-Bold="True"></asp:Label>
                        <div class="col-md-6 col-sm-6 col-xs-12">
                         
                             <asp:DropDownList class="form-control" ID="ddlZone" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlZone_SelectedIndexChanged" ></asp:DropDownList>
                         
                        </div>
                      </div>--%>

                         <div class="form-group">
                        <asp:Label ID="lblTown" runat="server" class="control-label col-md-3 col-sm-3 col-xs-12" Text="Select Town" Font-Bold="True"></asp:Label>
                        <div class="col-md-6 col-sm-6 col-xs-12">
                             <asp:DropDownList class="form-control" ID="ddlTown" runat="server" AutoPostBack="True"></asp:DropDownList>

                        </div>
                      </div>
                         <div class="form-group">
                       <asp:Label ID="lblConsumerName" runat="server" class="control-label col-md-3 col-sm-3 col-xs-12" Text="Consumer Name" Font-Bold="True"></asp:Label>
                        <div class="col-md-6 col-sm-9 col-xs-12">

                         <asp:TextBox ID="txtCName" runat="server" type="text" class="form-control" data-validate-length-range="6" data-validate-words="2" name="name"  placeholder="%Name%" ></asp:TextBox>
                        </div>
                      </div>
                        <div class="form-group">
                       <asp:Label ID="lblConsumerAddress" runat="server" class="control-label col-md-3 col-sm-3 col-xs-12" Text="Consumer Address" Font-Bold="True"></asp:Label>
                        <div class="col-md-6 col-sm-9 col-xs-12">

                         <asp:TextBox ID="txtAddress" runat="server" type="text" class="form-control" data-validate-length-range="6" data-validate-words="2" name="name"  placeholder="%Address%" ></asp:TextBox>
                        </div>
                      </div>
                         <%--<div class="form-group">
                       <asp:Label ID="lblUC" runat="server" class="control-label col-md-3 col-sm-3 col-xs-12" Text="Select UC" Font-Bold="True"></asp:Label>
                        <div class="col-md-6 col-sm-6 col-xs-12">
                        <asp:DropDownList class="form-control" ID="ddlUC" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlUC_SelectedIndexChanged"></asp:DropDownList>

                        </div>
                      </div>--%>
                        <%-- <div class="form-group">
                       <asp:Label ID="lblBlock" runat="server" class="control-label col-md-3 col-sm-3 col-xs-12" Text="Select Block" Font-Bold="True"></asp:Label>
                        <div class="col-md-6 col-sm-6 col-xs-12">
                          <asp:DropDownList class="form-control" ID="ddlBlock" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlBlock_SelectedIndexChanged"></asp:DropDownList>

                        </div>
                      </div>--%>
                       <%-- <div class="form-group">
                       <asp:Label ID="lblpropertyType" runat="server" class="control-label col-md-3 col-sm-3 col-xs-12" Text="Property Type" Font-Bold="True"></asp:Label>
                        <div class="col-md-6 col-sm-6 col-xs-12">
                          <asp:DropDownList class="form-control" ID="ddlpropertyType" runat="server"></asp:DropDownList>

                        </div>
                      </div>--%>
                        <div class="divider-dashed"></div>
                        <asp:Label ID="lblmessage" runat="server" Font-Bold="True" ForeColor="#006600"></asp:Label>
                        <div class="ln_solid"></div>
                      <div class="form-group">
                        <div class="col-md-9 col-sm-9 col-xs-12 col-md-offset-3">
                          <asp:Button ID="btnCancle" runat="server" type="button" class="btn btn-primary" Text="Cancle" />
                          <asp:Button ID="btnReset" runat="server" type="reset" class="btn btn-primary" Text="Reset" OnClick="btnReset_Click"/>
                          <asp:Button ID="btnSubmit" runat="server" type="submit" class="btn btn-success" Text="Submit" OnClick="btnSubmit_Click" />
                        </div>
                      </div>
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
		<asp:BoundField 
            DataField="current_arrears"
            
            HeaderText="5% Arrears" HeaderStyle-Wrap="False">
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

