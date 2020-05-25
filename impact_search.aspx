<%@ Page Title="" Language="C#" MasterPageFile="~/User.master" AutoEventWireup="true" CodeFile="impact_search.aspx.cs" Inherits="impact_search" %>




<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
   <title>impact Search</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

     <div class="">
            <div class="page-title">
              <div class="title_left">
                <h3>Impact Search</h3>
              </div>

              <div class="title_right">
                
              </div>
            </div>
            <div class="clearfix"></div>
            
           

            <div class="row">
              

              
              <div class="col-md-12 col-sm-12 col-xs-12">
                <div class="x_panel">
                  <div class="x_title">
                    <h2>Search <small>Impact</small></h2>
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
                        <label class="col-sm-3 control-label">By Impact</label>

                        <div class="col-sm-6">
                          
                          <div class="input-group">
                            <asp:TextBox ID="txtImapct" runat="server" type="text" class="form-control" placeholder="Negative"></asp:TextBox>
                            <span class="input-group-btn">
                                              <asp:Button ID="btnFindImpact" type="button" class="btn btn-primary" runat="server" Text="Go!" OnClick="btnFindImpact_Click" />
                                          </span>
                          </div>
                        </div>
                      </div>

                         <div class="divider-dashed"></div>

                         <div class="form-group">
                        <label class="col-sm-3 control-label">By Inword No.</label>

                        <div class="col-sm-6">
                          
                          <div class="input-group">
                            <asp:TextBox ID="txtInwordNo" runat="server" type="text" class="form-control" placeholder="Inword No."></asp:TextBox>
                            <span class="input-group-btn">
                                              <asp:Button ID="btnFindInword" type="button" class="btn btn-primary" runat="server" Text="Go!" OnClick="btnFindInword_Click" />
                                          </span>
                          </div>
                        </div>
                      </div>
					  <div class="divider-dashed"></div>
					  <div class="form-group">
                        <label class="col-sm-3 control-label">Date</label>


                        <div class="col-sm-6">
                          
                          <div class="input-group">
                            <asp:TextBox ID="txtfromdate" runat="server" type="Date" class="form-control" placeholder="From = MM/DD/YYYY"></asp:TextBox>
                               <asp:TextBox ID="txttodate" runat="server" type="Date" class="form-control" placeholder="To = MM/DD/YYYY "></asp:TextBox>
                            <span class="input-group-btn">
                                              <asp:Button ID="btnDate" type="button" class="btn btn-primary" runat="server" Text="Go!" OnClick="btnDate_Click" />
                                          </span>
                          </div>
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
            DataField="inword"
            HeaderText="Inword No." ItemStyle-Wrap="False" HeaderStyle-Wrap="False" HeaderStyle-HorizontalAlign ="Center">
            <HeaderStyle HorizontalAlign="Center"></HeaderStyle> 
            <ItemStyle HorizontalAlign="Center"  ForeColor="Black" BackColor="white" Font-Bold="True"></ItemStyle>
        </asp:BoundField>
    <asp:BoundField 
            DataField="modification_status"
            HeaderText="Modification Status" ItemStyle-Wrap="true" HeaderStyle-Wrap="False" HeaderStyle-HorizontalAlign ="Center">
            <HeaderStyle HorizontalAlign="Center" Width="80px"></HeaderStyle> 
            <ItemStyle HorizontalAlign="Center"  ForeColor="Black" BackColor="white" Font-Bold="True" Width="80px"></ItemStyle>
        </asp:BoundField>    
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
            DataField="previous_arrears"
            HeaderText="Previous Arrears" HeaderStyle-Wrap="False">
            <HeaderStyle HorizontalAlign="Center"></HeaderStyle> 
            <ItemStyle HorizontalAlign="left" ForeColor="Black" BackColor="white" Font-Bold="True"></ItemStyle>
        </asp:BoundField> 

    <asp:BoundField 
            DataField="after_correction"
            HeaderText="After Correction Arrears" HeaderStyle-Wrap="False">
            <HeaderStyle HorizontalAlign="Center"></HeaderStyle> 
            <ItemStyle HorizontalAlign="left" ForeColor="Black" BackColor="white" Font-Bold="True"></ItemStyle>
        </asp:BoundField> 
       

        <asp:BoundField 
            DataField="difference"
            HeaderText="Difference" ItemStyle-Wrap="False" HeaderStyle-Wrap="False" HeaderStyle-HorizontalAlign ="Center">
            <HeaderStyle HorizontalAlign="Center" ></HeaderStyle> 
            <ItemStyle HorizontalAlign="Center" ForeColor="Black" BackColor="white" Font-Bold="True" ></ItemStyle>
        </asp:BoundField>
     
        <asp:BoundField 
            DataField="difference_percentage"
            
            HeaderText="Impact In %" HeaderStyle-Wrap="False">
            <HeaderStyle HorizontalAlign="Center" ></HeaderStyle> 
            <ItemStyle HorizontalAlign="center" ForeColor="Black" BackColor="white" Font-Bold="True"></ItemStyle>
        </asp:BoundField>

        

        <asp:BoundField 
            DataField="impact"
            
            HeaderText="Impact" HeaderStyle-Wrap="False">
            <HeaderStyle HorizontalAlign="Center" ></HeaderStyle> 
            <ItemStyle HorizontalAlign="center" ForeColor="Black" BackColor="white" Font-Bold="True" ></ItemStyle>
        </asp:BoundField>

         
     <asp:BoundField 
            DataField="Description"
            
            HeaderText="Description" HeaderStyle-Wrap="False">
            <HeaderStyle HorizontalAlign="right" Width="80px"></HeaderStyle> 
            <ItemStyle HorizontalAlign="center" ForeColor="Black" BackColor="white" Font-Bold="True" Width="80px"></ItemStyle>
        </asp:BoundField>
    <asp:BoundField 
            DataField="createdon"
            
            HeaderText="Date" HeaderStyle-Wrap="False">
            <HeaderStyle HorizontalAlign="right" Width="80px"></HeaderStyle> 
            <ItemStyle HorizontalAlign="center" ForeColor="Black" BackColor="white" Font-Bold="True" Width="80px"></ItemStyle>
        </asp:BoundField>
    <asp:BoundField 
            DataField="createdby"
            
            HeaderText="User" HeaderStyle-Wrap="False">
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

