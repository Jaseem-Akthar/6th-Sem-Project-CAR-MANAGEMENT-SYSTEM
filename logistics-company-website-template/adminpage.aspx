<%@ Page Language="VB" AutoEventWireup="false" CodeFile="adminpage.aspx.vb" Inherits="logistics_company_website_template_adminpage" %>

<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="utf-8">
    <title>Supra Cabs - Cab Booking</title>
    <meta content="width=device-width, initial-scale=1.0" name="viewport">
    <meta content="Free HTML Templates" name="keywords">
    <meta content="Free HTML Templates" name="description">

    <!-- Favicon -->
    <link href="img/favicon.ico" rel="icon">

    <!-- Google Web Fonts -->
    <link rel="preconnect" href="https://fonts.gstatic.com">
    <link href="https://fonts.googleapis.com/css2?family=Poppins:wght@100;200;300;400;500;600;700;800;900&display=swap" rel="stylesheet">

    <!-- Font Awesome -->
    <link href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/5.10.0/css/all.min.css" rel="stylesheet">

    <!-- Libraries Stylesheet -->
    <link href="lib/owlcarousel/assets/owl.carousel.min.css" rel="stylesheet">

    <!-- Customized Bootstrap Stylesheet -->
    <link href="css/style.css" rel="stylesheet">

<style>

        ._29C7I{
            padding:0 20px;
            background-color:white;
            contain:content;

        }
.pI5n2{
    max-width:1200px;
    min-width:1200px;
    position:relative;
    margin:0 auto;
    height:auto;
    display:-ms-flexbox;
    display:flex;
    -ms-flex-align:center;
    align-items:center;
    contain:layout

}
._13eJa{
    position:relative;
    width:100%;

}
._3dU2z{
    width:100%;
    overflow:hidden;
    padding:15px 0;
    margin:-15px 0;

}
._1wKMm{
    transition:transform .5s ease;
    white-space:nowrap;

}
._1IJU1{
    display:-ms-flexbox;
    display:flex;
    -ms-flex-pack:justify;
    justify-content:space-between;

}
._3e_kl{
    display:inline-block;
    cursor:pointer;
   margin-right:2px;
  
}
._3e_kl img{
transition:transform .5s cubic-bezier(.215,.61,.355,1);
-webkit-backface-visibility:visible;
backface-visibility:visible;
transform:translateZ(0);

}
._3e_kl img:hover{
    -ms-transform:scale(1.05);
    transform:scale(1.05);

}
._1gDnr,._1OhVk{
    display:block;
    padding-right:5px;






</style>




</head>

<body>
    <form id="form1" runat="server">
    <!-- Topbar Start -->
    <div class="container-fluid bg-dark">
        <div class="row py-2 px-lg-5">
            <div class="col-lg-6 text-center text-lg-left mb-2 mb-lg-0">
                <div class="d-inline-flex align-items-center text-white">
                    <small><i class="fa fa-phone-alt mr-2"></i>+012 345 6789</small>
                    <small class="px-3">|</small>
                    <small><i class="fa fa-envelope mr-2"></i>info@example.com</small>
                </div>
            </div>
            <div class="col-lg-6 text-center text-lg-right">
                <div class="d-inline-flex align-items-center">
                    <a class="text-white px-2" href="">
                        <i class="fab fa-facebook-f"></i>
                    </a>
                    <a class="text-white px-2" href="">
                        <i class="fab fa-twitter"></i>
                    </a>
                    <a class="text-white px-2" href="">
                        <i class="fab fa-linkedin-in"></i>
                    </a>
                    <a class="text-white px-2" href="">
                        <i class="fab fa-instagram"></i>
                    </a>
                    <a class="text-white pl-2" href="">
                        <i class="fab fa-youtube"></i>
                    </a>
                </div>
            </div>
        </div>
    </div>
    <!-- Topbar End -->


     <!-- Navbar Start -->
    <div class="container-fluid p-0">
        <nav class="navbar navbar-expand-lg bg-light navbar-light py-3 py-lg-0 px-lg-5">
            <a href="index.html" class="navbar-brand ml-lg-3">
                <h1 class="m-0 display-5 text-uppercase text-primary"><i class="fa fa-map-marker-alt mr-2"></i>Supra Cabs</h1>
            </a>
            <button type="button" class="navbar-toggler" data-toggle="collapse" data-target="#navbarCollapse">
                <span class="navbar-toggler-icon"></span>
            </button>
            <div class="collapse navbar-collapse justify-content-between px-lg-3" id="navbarCollapse">
                <div class="navbar-nav m-auto py-0">
                    <a href="adminpage.aspx" class="nav-item nav-link active">Home</a>
                    <a href="astaff.aspx" class="nav-item nav-link">Staff</a>
                    <a href="aguest.aspx" class="nav-item nav-link">Guest</a>
                    <a href="apayments.aspx" class="nav-item nav-link">Payments</a>
                    <div class="nav-item dropdown">
                        <a href="#" class="nav-link dropdown-toggle" data-toggle="dropdown">Vehicles</a>
                        <div class="dropdown-menu rounded-0 m-0">
                            <a href="aadvehicles.aspx" class="dropdown-item">Add</a>
                            <a href="aeditvehicle.aspx" class="dropdown-item">Edit</a>
                            <a href="aeditvehicle.aspx" class="dropdown-item">Delete</a>

                        </div>
                    </div>
                    <a href="index.html" class="nav-item nav-link">Logout</a>
                </div>
                <!--<%--<a href="" class="btn btn-primary py-2 px-4 d-none d-lg-block">Get A Quote</a>--%>-->
            </div>
        </nav>
    </div>


        
   <%-- <!-- Header Start -->
    <div class="jumbotron jumbotron-fluid mb-5">
        <div class="container text-center py-5">
            <h1 class="text-primary mb-4">Safe & Faster</h1>
            <h1 class="text-white display-3 mb-5">Bike Rentals</h1>
            <div class="mx-auto" style="width: 100%; max-width: 600px;">
               
                    <div class="input-group">
                        <input type="text" class="form-control border-light" style="padding: 30px;" placeholder="Tracking Id">
                        <div class="input-group-append">
                            <button class="btn btn-primary px-3">Track & Trace</button>
                        </div>
                    </div>
                </div>
        </div>
    </div>--%>
    <!-- Header End -->






       <div class="_29C7I">
<div class="pI5n2">
<div class="_13eJa">
<div class="_3dU2z">
<div class="_1wKMm _2ntE2">

<div class="_3e_kl" subtype="topCarousel" style="margin-right: 275px; margin-left:5%;">
<img  height="260" src="car-2.jpg" class="_1gDnr">
    <p style="text-align:center; font-size:25px; ">Range Rover</p>
</div>

<div class="_3e_kl" subtype="topCarousel" style="margin-right: 100px;">
    <img  height="260" src="car-13.jpg" class="_1gDnr">
     <p style="text-align:center; font-size:25px; ">Brezza</p>
</div>
    <br />
    <div style=" margin-top:70px">
    <div class="_3e_kl" subtype="topCarousel" style="margin-right: 275px; margin-left:5%;">
<img height="260" src="car-8.jpg" class="_1gDnr">
         <p style="text-align:center; font-size:25px; ">Jeep Wrangler</p>
</div>
    <div class="_3e_kl" subtype="topCarousel" style="margin-right: 100px;">
    <img  height="260" src="car-14.png" class="_1gDnr">
         <p style="text-align:center; font-size:25px; ">KIA Seltos</p>
</div></div>
     <br />
    <div style=" margin-top:70px">
    <div class="_3e_kl" subtype="topCarousel" style="margin-right: 275px; margin-left:5%;">
<img height="260" src="car-15.jpg" class="_1gDnr">
         <p style="text-align:center; font-size:25px; ">Fortuner</p>
</div>
    <div class="_3e_kl" subtype="topCarousel" style="margin-right: 100px;">
    <img  height="260" src="car-19.jpg" class="_1gDnr">
         <p style="text-align:center; font-size:25px; ">Suzuki Dzire</p>
</div></div>

</div>
</div>  
</div>
</div>
</div>
    <!-- Header End -->
          <div class="form-group">
   


   
   </div>


    <div class="container-fluid bg-dark text-white border-top py-4 px-sm-3 px-md-5" style="border-color: #3E3E4E !important;">
        <div class="row">
            <div class="col-lg-6 text-center text-md-left mb-3 mb-md-0">
                <p class="m-0 text-white">&copy 2023; <%--<a href="#">Your Site Name</a>--%>. All Rights Reserved. 
				
				<!--/*** This template is free as long as you keep the footer author’s credit link/attribution link/backlink. If you'd like to use the template without the footer author’s credit link/attribution link/backlink, you can purchase the Credit Removal License from "https://htmlcodex.com/credit-removal". Thank you for your support. ***/-->
				<%--Designed by <a href="https://htmlcodex.com">HTML Codex</a>--%>
                </p>
            </div>
           <%-- <div class="col-lg-6 text-center text-md-right">
                <ul class="nav d-inline-flex">
                    <li class="nav-item">
                        <a class="nav-link text-white py-0" href="#">Privacy</a>
                    </li>
                    <li class="nav-item">
                        <a class="nav-link text-white py-0" href="#">Terms</a>
                    </li>
                    <li class="nav-item">
                        <a class="nav-link text-white py-0" href="#">FAQs</a>
                    </li>
                    <li class="nav-item">
                        <a class="nav-link text-white py-0" href="#">Help</a>
                    </li>
                </ul>
            </div>--%>
        </div>
    </div>
    <!-- Footer End -->
 

    <!-- Back to Top -->
    <a href="#" class="btn btn-lg btn-primary back-to-top"><i class="fa fa-angle-double-up"></i></a>


    <!-- JavaScript Libraries -->
    <script src="https://code.jquery.com/jquery-3.4.1.min.js"></script>
    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.4.1/js/bootstrap.bundle.min.js"></script>
    <script src="lib/easing/easing.min.js"></script>
    <script src="lib/waypoints/waypoints.min.js"></script>
    <script src="lib/counterup/counterup.min.js"></script>
    <script src="lib/owlcarousel/owl.carousel.min.js"></script>

    <!-- Contact Javascript File -->
    <script src="mail/jqBootstrapValidation.min.js"></script>
    <script src="mail/contact.js"></script>

    <!-- Template Javascript -->
    <script src="js/main.js"></script>
    </form>
</body>

</html>