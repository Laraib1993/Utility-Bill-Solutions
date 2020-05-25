<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
   <meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
    <!-- Meta, title, CSS, favicons, etc. -->
    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1">

    <title>KMC | Login </title>

    <!-- Bootstrap -->
    <link href="js/bootstrap/dist/css/bootstrap.min.css" rel="stylesheet">
    <!-- Font Awesome -->
    <link href="js/font-awesome/css/font-awesome.min.css" rel="stylesheet">
    <!-- NProgress -->
   <%-- <link href="js/nprogress/nprogress.css" rel="stylesheet">--%>
    <link href="js/iCheck/skins/flat/green.css" rel="stylesheet">
    <!-- bootstrap-progressbar -->
   <%-- <link href="js/bootstrap-progressbar/css/bootstrap-progressbar-3.3.4.min.css" rel="stylesheet">--%>
    <!-- Animate.css -->
    <link href="js/animate.css/animate.min.css" rel="stylesheet">
   <%-- <link href="js/pnotify/dist/pnotify.css" rel="stylesheet">--%>
    <link href="js/pnotify/dist/pnotify.buttons.css" rel="stylesheet">
   <%-- <link href="js/pnotify/dist/pnotify.nonblock.css" rel="stylesheet">--%>

    <!-- Custom Theme Style -->
    <link href="css/custom.min.css" rel="stylesheet">
</head>
<body class="login">
    <div>
      <a class="hiddenanchor" id="signup"></a>
      <a class="hiddenanchor" id="signin"></a>


      <div class="login_wrapper">

        <div class="animate form login_form">

          <section class="login_content">
              
             
            <form runat="server">
              <h1>Login KMC</h1>
              <div>
              <asp:TextBox ID="txtUserName" runat="server"  type="text" class="form-control" placeholder="Username" required="" ></asp:TextBox>
               
               
              </div>
              <div>
                <asp:TextBox ID="txtPassword" runat="server" type="password" class="form-control" placeholder="Password" required=""  ></asp:TextBox>
              </div>
              
                  <asp:Label ID="lblMessage" runat="server" ForeColor="#FF0066"></asp:Label>
              <div>
                <asp:Button ID="btnInSide" runat="server" type="button" class="btn btn-default submit" value="Log in" OnClick="btnInSide_Click" Text="Log In" />
                <a class="reset_pass" href="#signup">Lost your password?</a>
              </div>

              <div class="clearfix"></div>

              <div class="separator">
                
               
                <div class="clearfix"></div>
                <br />

                <div>
                  <h1><i class="fa fa-home"></i> Powered By</h1>
                  <p>©2017 & All Rights Reserved. KMC Privacy and Terms</p>
                </div>
              </div>
            </form>
          </section>
        </div>

        <div id="register" class="animate form registration_form">
          <section class="login_content">
            <form>
              <h1>Renew Password</h1>
              <div>
                <input type="text" class="form-control" placeholder="Username" required="" />
              </div>
              <div>
                <input type="email" class="form-control" placeholder="Email" required="" />
              </div>
              <div>
                <input type="text" class="form-control" placeholder="Code" required="" />
              </div>
              <div>
                <a class="btn btn-default submit" href="#signin">Submit</a>
              </div>

              <div class="clearfix"></div>

              <div class="separator">
                
                

                <div class="clearfix"></div>
                <br />

                <div>
                  <h1><i class="fa fa-home"></i> Powered By</h1>
                  <p>©2017 & All Rights Reserved. KMC Privacy and Terms</p>
                </div>
              </div>
            </form>
          </section>
        </div>
      </div>
    </div>


    <script src="js/jquery/dist/jquery.min.js"></script>
    <!-- Bootstrap -->
    <script src="js/bootstrap/dist/js/bootstrap.min.js"></script>
    <!-- FastClick -->
    <script src="js/fastclick/lib/fastclick.js"></script>
    <!-- NProgress -->
   <%-- <script src="js/nprogress/nprogress.js"></script>--%>
    <!-- bootstrap-progressbar -->
    <script src="js/bootstrap-progressbar/bootstrap-progressbar.min.js"></script>
    <!-- iCheck -->
    <script src="js/iCheck/icheck.min.js"></script>
   <%-- <<script src="js/pnotify/dist/pnotify.js"></script>--%>
  <%--  <script src="js/pnotify/dist/pnotify.buttons.js"></script>--%>
   <%-- <script src="js/pnotify/dist/pnotify.nonblock.js"></script>--%>
     <script src="js/custom.min.js"></script>


  </body>
</html>
