<%@ Page Title="" Language="C#" MasterPageFile="~/MainDashboard.master" AutoEventWireup="true" CodeFile="AyshaManzil.aspx.cs" Inherits="AyshaManzil" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
     <div class="">
            <div class="page-title">
              <div class="title_left">
                <h3>Upload Aysha Manzil Bill </h3>
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
                       <asp:Label ID="lblAdjustArrears" runat="server" class="control-label col-md-3 col-sm-3 col-xs-12" Text="Adjust Arrears" Font-Bold="True"></asp:Label>
                        <div class="col-md-9 col-sm-9 col-xs-12">
                           <input runat="server" type="file"  id="filer_input1">
                        </div>
                          
                      </div>
                       <div class="form-group">
                       <asp:Label ID="lblBillQuarter" runat="server" class="control-label col-md-3 col-sm-3 col-xs-12" Text="Billing Quarter" Font-Bold="True"></asp:Label>
                        <div class="col-md-9 col-sm-9 col-xs-12">
                           <asp:Button runat="server" type="submit" class="btn btn-success" ID="btnsubmit" Text="Upload Asha Manzil Record" OnClick="btnsubmit_Click" />
                        </div>
                          
                      </div>



                        

                    </form>
                  </div>
                </div>
              </div>
            </div>
          </div>
</asp:Content>

