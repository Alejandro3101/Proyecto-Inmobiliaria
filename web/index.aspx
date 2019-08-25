<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="web.Formulario_web110" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!DOCTYPE html>
<html>
  <head>
 <Title> SaleYa &mdash; Busqueda de Inmuebles</title>
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">

    <link rel="stylesheet" href="https://fonts.googleapis.com/css?family=Nunito+Sans:200,300,400,700,900|Roboto+Mono:300,400,500"> 
    <link rel="stylesheet" href="fonts/icomoon/style.css">

    <link rel="stylesheet" href="css/bootstrap.min.css">
    <link rel="stylesheet" href="css/magnific-popup.css">
    <link rel="stylesheet" href="css/jquery-ui.css">
    <link rel="stylesheet" href="css/owl.carousel.min.css">
    <link rel="stylesheet" href="css/owl.theme.default.min.css">
    <link rel="stylesheet" href="css/bootstrap-datepicker.css">
    <link rel="stylesheet" href="css/mediaelementplayer.css">
    <link rel="stylesheet" href="css/animate.css">
    <link rel="stylesheet" href="fonts/flaticon/font/flaticon.css">
    <link rel="stylesheet" href="css/fl-bigmug-line.css">
    
  
    <link rel="stylesheet" href="css/aos.css">

    <link rel="stylesheet" href="css/style.css">
    
  </head>
  <body>
  
  <div class="site-loader">
      <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:bdSaleYaConnectionString %>" SelectCommand="SELECT Categoria.Categoria, Ciudad.Ciudad, Tipo.Tipo, Publicacion.Nombre, Publicacion.Precio, Publicacion.Descripcion, Publicacion.Telefono, Publicacion.Estrato, Publicacion.Direccion, Publicacion.NumeroHabitaciones FROM Publicacion INNER JOIN Ciudad ON Publicacion.IdCiudad = Ciudad.IdCiudad INNER JOIN Tipo ON Publicacion.IdTipo = Tipo.IdTipo INNER JOIN Categoria ON Publicacion.IdCategoria = Categoria.IdCategoria WHERE (Categoria.Categoria = @Categoria) OR (Ciudad.Ciudad = @Ciudad) OR (Tipo.Tipo = @Tipo)">
          <SelectParameters>
              <asp:ControlParameter ControlID="cmbBuscarCiudad" Name="Ciudad" PropertyName="SelectedValue" />
              <asp:ControlParameter ControlID="cmbBuscarTipo" Name="Tipo" PropertyName="SelectedValue" />
              <asp:ControlParameter ControlID="cmbBuscarCategoria" Name="Categoria" PropertyName="SelectedValue" />
          </SelectParameters>
      </asp:SqlDataSource>
      </div>
  
  <div class="site-wrap">

    <div class="site-mobile-menu">
      <div class="site-mobile-menu-header">
        <div class="site-mobile-menu-close mt-3">
          <span class="icon-close2 js-menu-toggle"></span>
        </div>
      </div>
      <div class="site-mobile-menu-body"></div>
    </div> <!-- .site-mobile-menu -->

    <div class="site-navbar mt-4">
        <div class="container py-1">
          <div class="row align-items-center">
            <div class="col-8 col-md-8 col-lg-4">
              <h1 class="mb-0"><a href="index.html" class="text-white h2 mb-0"><strong>SaleYa<span class="text-danger">.</span></strong></a></h1>
            </div>
            <div class="col-4 col-md-4 col-lg-8">
              <nav class="site-navigation text-right text-md-right" role="navigation">

                <div class="d-inline-block d-lg-none ml-md-0 mr-auto py-3"><a href="#" class="site-menu-toggle js-menu-toggle text-white"><span class="icon-menu h3"></span></a></div>

                <ul class="site-menu js-clone-nav d-none d-lg-block">
                  <li class="active">
                    <a href="index.html">Inicio</a>

                  </li>
                  <li><a href="Publicacion.aspx">Publicar Inmueble</a></li>
                    <li><a href="Login.aspx">Login</a></li>
                </ul>
              </nav>
            </div>
           

          </div>
        </div>
      </div>
    </div>

    <div class="slide-one-item home-slider owl-carousel">

      <div class="site-blocks-cover overlay" style="background-image: url(images/hero_bg_1.jpg);" data-aos="fade" data-stellar-background-ratio="0.5">
        <div class="container">
          <div class="row align-items-center justify-content-center text-center">
            <div class="col-md-10">
              <span class="d-inline-block bg-success text-white px-3 mb-3 property-offer-type rounded">Para Aquiler</span>
              <h1 class="mb-2">Sogamoso</h1>
              <p class="mb-5"><strong class="h2 text-success font-weight-bold">$650.000.000</strong></p>
              <p><a href="#" class="btn btn-white btn-outline-white py-3 px-5 rounded-0 btn-2">Ver Detalles</a></p>
            </div>
          </div>
        </div>
      </div>  

      <div class="site-blocks-cover overlay" style="background-image: url(images/hero_bg_2.jpg);" data-aos="fade" data-stellar-background-ratio="0.5">
        <div class="container">
          <div class="row align-items-center justify-content-center text-center">
            <div class="col-md-10">
              <span class="d-inline-block bg-danger text-white px-3 mb-3 property-offer-type rounded">Para Venta</span>
              <h1 class="mb-2">Duitama</h1>
              <p class="mb-5"><strong class="h2 text-success font-weight-bold">$200.000.000</strong></p>
              <p><a href="#" class="btn btn-white btn-outline-white py-3 px-5 rounded-0 btn-2">Ver Detalles</a></p>
            </div>
          </div>
        </div>
      </div>  

    </div>


    <div class="site-section site-section-sm pb-0">
      <div class="container">
        <div class="row">
          <form class="form-search col-md-12" runat="server" style="margin-top: -100px;">
            <div class="row  align-items-end">
              <div class="col-md-3">
                <label for="list-types">Tipo De Vivienda</label>
                <div class="select-wrap">
                  <span class="icon icon-arrow_drop_down"></span>
                    <asp:DropDownList  class="form-control d-block rounded-0" ID="cmbBuscarCategoria" runat="server" ></asp:DropDownList>
                </div>
              </div>
              <div class="col-md-3">
                <label for="offer-types">Tipo de Contrato</label>
                <div class="select-wrap">
                  <span class="icon icon-arrow_drop_down"></span>
                    <asp:DropDownList class="form-control d-block rounded-0" ID="cmbBuscarTipo" runat="server"  ></asp:DropDownList>
                </div>
              </div>
              <div class="col-md-3">
                <label for="select-city">Ciudad</label>
                <div class="select-wrap">
                  <span class="icon icon-arrow_drop_down"></span>
                    <asp:DropDownList class="form-control d-block rounded-0" ID="cmbBuscarCiudad" runat="server"  ></asp:DropDownList>
                </div>
              </div>
              <div class="col-md-3">
                  <asp:Button  class="btn btn-success text-white btn-block rounded-0" ID="btnBuscar" runat="server" Text="Buscar" />
                  <%--<input type="submit" class="btn btn-success text-white btn-block rounded-0" value="Buscar" />--%>
              </div>
            </div>
          </form>
        </div>  
      </div>
    </div>

   

          
      

    <div class="site-section">
        <div class="container">
            <div class="row justify-content-center">
                <div class="col-md-7 text-center">
                    <div class="site-section-title">
                        <h2>¿Por qué nosotros?</h2>
                    </div>
                    <p>Somos intermediarios para la venta de inmuebles,En nuestra pagina encontraras facilidad para comprar tu casa o apartamento , Y si quieres vender tu inmueble tambien tambien lo puedes hacer muy facilmente, Las inmobiliarias pueden registrar varios inmuebles a la vez a nombre de ellos.</p>
                </div>

            </div>
            <br />
            <br />
            <div class="container">
                <div class="row justify-content-center mb-10">
                    <div class="col-md-10 text-center">
                        <div class="site-section-title">
                            <h2>¿Quienes Somos?</h2>
                        </div>
                        <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit. Debitis maiores quisquam saepe architecto error corporis aliquam. Cum ipsam a consectetur aut sunt sint animi, pariatur corporis, eaque, deleniti cupiditate officia.</>
                    </div>
                </div>
            </div>
            <br />
            <br />
            <div class="row">
                <div class="col-md-20 col-lg-4">
                    <a href="#" class="service text-center">
                        <span class="icon flaticon-house"></span>
                        <h2 class="service-heading">Inmobiliarias</h2>
                        <p>Lorem ipsum dolor sit amet consectetur adipisicing elit. Incidunt iure qui natus perspiciatis ex odio molestia.</p>
                        
                    </a>
                </div>
                <div class="col-md-6 col-lg-4">
                    <a href="#" class="service text-center">
                        <span class="icon flaticon-sold"></span>
                        <h2 class="service-heading">Personas</h2>
                        <p>Lorem ipsum dolor sit amet consectetur adipisicing elit. Incidunt iure qui natus perspiciatis ex odio molestia.</p>
                        
                    </a>
                </div>
                <div class="col-md-6 col-lg-4">
                    <a href="#" class="service text-center">
                        <span class="icon flaticon-camera"></span>
                        <h2 class="service-heading">Seguridad</h2>
                        <p>Lorem ipsum dolor sit amet consectetur adipisicing elit. Incidunt iure qui natus perspiciatis ex odio molestia.</p>
                        
                    </a>
                </div>
            </div>
        </div>
    </div>
      <br />
      <br />
        

    <footer class="site-footer">
        <div class="container">
            <div class="row">
                <div class="col-lg-4">
                    <div class="mb-5">
                        <h3 class="footer-heading mb-4">About Homeland</h3>
                        <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit. Saepe pariatur reprehenderit vero atque, consequatur id ratione, et non dignissimos culpa? Ut veritatis, quos illum totam quis blanditiis, minima minus odio!</p>
                    </div>


                </div>
                <div class="col-lg-4 mb-5 mb-lg-0">
                    <div class="row mb-5">
                        <div class="col-md-12">
                            <h3 class="footer-heading mb-4">Navigations</h3>
                        </div>
                        <div class="col-md-6 col-lg-6">
                            <ul class="list-unstyled">
                                <li><a href="#">Home</a></li>
                                <li><a href="#">Buy</a></li>
                                <li><a href="#">Rent</a></li>
                                <li><a href="#">Properties</a></li>
                            </ul>
                        </div>
                        <div class="col-md-6 col-lg-6">
                            <ul class="list-unstyled">
                                <li><a href="#">About Us</a></li>
                                <li><a href="#">Privacy Policy</a></li>
                                <li><a href="#">Contact Us</a></li>
                                <li><a href="#">Terms</a></li>
                            </ul>
                        </div>
                    </div>

                </div>
                <div class="col-lg-4 mb-5 mb-lg-0">
                    <h3 class="footer-heading mb-4">Follow Us</h3>
                    <div>
                        <a href="#" class="pl-0 pr-3"><span class="icon-facebook"></span></a>
                        <a href="#" class="pl-3 pr-3"><span class="icon-twitter"></span></a>
                        <a href="#" class="pl-3 pr-3"><span class="icon-instagram"></span></a>
                        <a href="#" class="pl-3 pr-3"><span class="icon-linkedin"></span></a>
                    </div>

                </div>

            </div>
            <div class="row pt-5 mt-5 text-center">
                <div class="col-md-12">
                    <p>
                        <!-- Link back to Colorlib can't be removed. Template is licensed under CC BY 3.0. -->
                        Copyright &copy;
                        <script data-cfasync="false" src="/cdn-cgi/scripts/5c5dd728/cloudflare-static/email-decode.min.js"></script>
                        <script>document.write(new Date().getFullYear());</script> All rights reserved | This template is made with <i class="icon-heart text-danger" aria-hidden="true"></i> by <a href="https://colorlib.com" target="_blank">Colorlib</a>
                        <!-- Link back to Colorlib can't be removed. Template is licensed under CC BY 3.0. -->
                    </p>
                </div>

            </div>
        </div>
    </footer>

  

  <script src="js/jquery-3.3.1.min.js"></script>
  <script src="js/jquery-migrate-3.0.1.min.js"></script>
  <script src="js/jquery-ui.js"></script>
  <script src="js/popper.min.js"></script>
  <script src="js/bootstrap.min.js"></script>
  <script src="js/owl.carousel.min.js"></script>
  <script src="js/mediaelement-and-player.min.js"></script>
  <script src="js/jquery.stellar.min.js"></script>
  <script src="js/jquery.countdown.min.js"></script>
  <script src="js/jquery.magnific-popup.min.js"></script>
  <script src="js/bootstrap-datepicker.min.js"></script>
  <script src="js/aos.js"></script>

  <script src="js/main.js"></script>
    
  </body>
</html>
</asp:Content>
