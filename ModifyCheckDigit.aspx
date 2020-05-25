<%@ Page Title="" Language="C#" MasterPageFile="~/User.master" AutoEventWireup="true" CodeFile="ModifyCheckDigit.aspx.cs" Inherits="ModifyCheckDigit" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <title>Modification</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
       <div class="">
            <div class="page-title">
              <div class="title_left">
                <h3>Modify CheckDigit</h3>
              </div>

              <div class="title_right">
                
              </div>
            </div>
            <div class="clearfix"></div>
            
            <div class="row">
              

              <div class="col-md-6 col-xs-12">
                <div class="x_panel">
                  <div class="x_title">
                    <h2>Form <small>Edit Check Digit</small></h2>
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
                       <asp:Label ID="lblConsumerNo" runat="server" class="control-label col-md-3 col-sm-3 col-xs-12" Text="Consumer Number" Font-Bold="True"></asp:Label>
                        <div class="col-md-9 col-sm-9 col-xs-12">

                         <asp:TextBox ID="txtConsumerNo" runat="server" type="text" class="form-control" data-validate-length-range="6" data-validate-words="2" name="name" required="required" placeholder="Consumer Number"></asp:TextBox>
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
                          <asp:Button ID="btnReset" runat="server" type="reset" class="btn btn-primary" Text="Reset" OnClick="btnReset_Click" />
                          <asp:Button ID="btnSubmit" runat="server" type="submit" class="btn btn-success" Text="Submit" OnClick="btnSubmit_Click" />
                        </div>
                      </div>

                    </form>
                  </div>
                </div>
              </div>

            </div>

          </div>
</asp:Content>

