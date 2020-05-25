<%@ Page Title="" Language="C#" MasterPageFile="~/MainDashboard.master" AutoEventWireup="true" CodeFile="AdminDashboard.aspx.cs" Inherits="AdminDashboard" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <title>KMC | Home</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

     <!-- top tiles -->
          <div class="row tile_count">
            <div class="col-md-2 col-sm-4 col-xs-6 tile_stats_count">
              <span class="count_top"><i class="fa fa-user"></i> New Consumers</span>
              <div class="count" runat="server" id="dailynewconsumer">2500</div>
              <span class="count_bottom"><i class="green">Today's </i> Total</span>
            </div>
            <div class="col-md-2 col-sm-4 col-xs-6 tile_stats_count">
              <span class="count_top"><i class="fa fa-user"></i> Stubs Posting</span>
              <div class="count" runat="server" id="dailystubsposting">123.50</div>
              <span class="count_bottom"><i class="green">Today's </i> Total</span>
            </div>
            <div class="col-md-2 col-sm-4 col-xs-6 tile_stats_count">
              <span class="count_top"><i class="fa fa-user"></i> MUCT Employee Bill</span>
              <div class="count green" runat="server" id="dailymuctemployee" >2,500</div>
              <span class="count_bottom"><i class="green">Today's </i> Total</span>
            </div>
            <div class="col-md-2 col-sm-4 col-xs-6 tile_stats_count">
              <span class="count_top"><i class="fa fa-user"></i> Camp Office</span>
              <div class="count" runat="server" id="dailycampoffice">4,567</div>
              <span class="count_bottom"><i class="green">Today's </i> Total</span>
            </div>
            <div class="col-md-2 col-sm-4 col-xs-6 tile_stats_count">
              <span class="count_top"><i class="fa fa-user"></i> Head Office</span>
              <div class="count" runat="server" id="dailyheadoffice">2,315</div>
              <span class="count_bottom"><i class="green">Today's </i> Total</span>
            </div>
            <div class="col-md-2 col-sm-4 col-xs-6 tile_stats_count">
              <span class="count_top"><i class="fa fa-user"></i> Rebate Issued</span>
              <div class="count" runat="server" id="dailyrebate">7,325</div>
              <span class="count_bottom"><i class="green">Today's </i> Total</span>
            </div>
              <div class="col-md-2 col-sm-4 col-xs-6 tile_stats_count">
              <span class="count_top"><i class="fa fa-user"></i> 15% Bill Issued</span>
              <div class="count" runat="server" id="Div10">2,315</div>
              <span class="count_bottom"><i class="green">Today's </i> Total</span>
            </div>
          </div>
            
          <!-- /top tiles -->

          <div class="row">
            <div class="col-md-12 col-sm-12 col-xs-12">
              <div class="dashboard_graph">

                <div class="row x_title">
                  <div class="col-md-6">
                    <h3>Department Sheet <small></small></h3>
                  </div>
                  
                </div>
              </div>
            </div>

          </div>
          <br />

          <div class="row">


               <!-- top tiles -->
          <div class="row tile_count">
            <div class="col-md-2 col-sm-4 col-xs-6 tile_stats_count">
              <span class="count_top"><i class="fa fa-user"></i> Kachi Abadi</span>
              <div class="count" runat="server" id="dailykatchiabadi">2500</div>
              <span class="count_bottom"><i class="green">Today's </i> Total New ID</span>
            </div>
            <div class="col-md-2 col-sm-4 col-xs-6 tile_stats_count">
              <span class="count_top"><i class="fa fa-user"></i> Land Dept</span>
              <div class="count" runat="server" id="dailylanddeot">123.50</div>
              <span class="count_bottom"><i class="green">Today's </i> Total New ID</span>
            </div>
            <div class="col-md-2 col-sm-4 col-xs-6 tile_stats_count">
              <span class="count_top"><i class="fa fa-user"></i> PD Orangi</span>
              <div class="count green" runat="server" id="dailypdorangi">2,500</div>
              <span class="count_bottom"><i class="green">Today's </i> Total New ID</span>
            </div>
            <div class="col-md-2 col-sm-4 col-xs-6 tile_stats_count">
              <span class="count_top"><i class="fa fa-user"></i> Estate Dept</span>
              <div class="count" runat="server" id="dailydept">4,567</div>
              <span class="count_bottom"><i class="green">Today's </i> Total New ID</span>
            </div>
               <div class="col-md-2 col-sm-4 col-xs-6 tile_stats_count">
              <span class="count_top"><i class="fa fa-user"></i> Walkin Consumer</span>
              <div class="count" runat="server" id="Div11">4,567</div>
              <span class="count_bottom"><i class="green">Today's </i> Total New ID</span>
            </div>
           
          <!-- /top tiles -->

              <div class="row">
            <div class="col-md-12 col-sm-12 col-xs-12">
              <div class="dashboard_graph">

                <div class="row x_title">
                  <div class="col-md-6">
                    <h3>Rebate <small>Area</small></h3>
                  </div>
                  
                </div>
              </div>
            </div>

          </div>

             <!-- top tiles -->
          <div class="row tile_count">
            <div class="col-md-2 col-sm-4 col-xs-6 tile_stats_count">
              <span class="count_top"><i class="fa fa-user"></i> Camp Office</span>
              <div class="count" runat="server" id="dailyrebatecampoffice">2500</div>
              <span class="count_bottom"><i class="green">Today's </i> Rebate Issued</span>
            </div>
            <div class="col-md-2 col-sm-4 col-xs-6 tile_stats_count">
              <span class="count_top"><i class="fa fa-user"></i> Head Office</span>
              <div class="count" runat="server" id="dailyrebateheadoffice">123.50</div>
              <span class="count_bottom"><i class="green">Today's </i> Rebate Issued</span>
            </div>
           
          <!-- /top tiles -->

          </div>


                <div class="row">
            <div class="col-md-12 col-sm-12 col-xs-12">
              <div class="dashboard_graph">

                <div class="row x_title">
                  <div class="col-md-6">
                    <h3>Payment <small>Posting Area</small></h3>
                  </div>
                  
                </div>
              </div>
            </div>

          </div>

             <!-- top tiles -->
          <div class="row tile_count">
            <div class="col-md-2 col-sm-4 col-xs-6 tile_stats_count">
              <span class="count_top"><i class="fa fa-user"></i> HBL</span>
              <div class="count" runat="server" id="Div1">2500</div>
              <span class="count_bottom"><i class="green">Today's </i> Payment Posted</span>
            </div>
            <div class="col-md-2 col-sm-4 col-xs-6 tile_stats_count">
              <span class="count_top"><i class="fa fa-user"></i> NBP</span>
              <div class="count" runat="server" id="Div2">123.50</div>
              <span class="count_bottom"><i class="green">Today's </i> Payment Posted</span>
            </div>
           <div class="col-md-2 col-sm-4 col-xs-6 tile_stats_count">
              <span class="count_top"><i class="fa fa-user"></i> SBP</span>
              <div class="count" runat="server" id="Div3">123.50</div>
              <span class="count_bottom"><i class="green">Today's </i> Payment Posted</span>
            </div>
          <!-- /top tiles -->

          </div>

                              <div class="row">
            <div class="col-md-12 col-sm-12 col-xs-12">
              <div class="dashboard_graph">

                <div class="row x_title">
                  <div class="col-md-6">
                    <h3>Impact & Personal Information <small> Area</small></h3>
                  </div>
                  
                </div>
              </div>
            </div>

          </div>

             <!-- top tiles -->
          <div class="row tile_count">
            <div class="col-md-2 col-sm-4 col-xs-6 tile_stats_count">
              <span class="count_top"><i class="fa fa-user"></i> Modification Case</span>
              <div class="count" runat="server" id="Div4">2500</div>
              <span class="count_bottom"><i class="green">Today's </i> Modification Case</span>
            </div>
            <div class="col-md-2 col-sm-4 col-xs-6 tile_stats_count">
              <span class="count_top"><i class="fa fa-user"></i> Change of Name</span>
              <div class="count" runat="server" id="Div5">123.50</div>
              <span class="count_bottom"><i class="green">Today's </i> </span>
            </div>
           <div class="col-md-2 col-sm-4 col-xs-6 tile_stats_count">
              <span class="count_top"><i class="fa fa-user"></i> Change of Address</span>
              <div class="count" runat="server" id="Div6">123.50</div>
              <span class="count_bottom"><i class="green">Today's </i> </span>
            </div>
          <!-- /top tiles -->

          </div>

                 <div class="row">
            <div class="col-md-12 col-sm-12 col-xs-12">
              <div class="dashboard_graph">

                <div class="row x_title">
                  <div class="col-md-6">
                    <h3>Empty Address <small> Area</small></h3>
                  </div>
                  
                </div>
              </div>
            </div>

          </div>

             <!-- top tiles -->
          <div class="row tile_count">
            <div class="col-md-2 col-sm-4 col-xs-6 tile_stats_count">
              <span class="count_top"><i class="fa fa-user"></i> Filled Data</span>
              <div class="count" runat="server" id="Div7">2500</div>
              <span class="count_bottom"><i class="green">Today's </i> Filled Data</span>
            </div>
            <div class="col-md-2 col-sm-4 col-xs-6 tile_stats_count">
              <span class="count_top"><i class="fa fa-user"></i> Filled Data</span>
              <div class="count" runat="server" id="Div8">123.50</div>
              <span class="count_bottom"><i class="green">Weekly </i> </span>
            </div>
           <div class="col-md-2 col-sm-4 col-xs-6 tile_stats_count">
              <span class="count_top"><i class="fa fa-user"></i> Filled Data</span>
              <div class="count" runat="server" id="Div9">123.50</div>
              <span class="count_bottom"><i class="green">Monthly </i> </span>
            </div>
          <!-- /top tiles -->

          </div>


</asp:Content>

