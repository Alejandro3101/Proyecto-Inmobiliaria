<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PruebaLogin3SinMaster.aspx.cs" Inherits="web.PruebaLogin3SinMaster" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Login</title>
     <link rel="stylesheet" href="csslogin/master.css">
</head>
<body>
    <div class = "Menu" >
 
   
    <div class="login-box">
      <img src="imglogin/logosaleya.png" class="avatar" alt="Avatar Image">
      <h1> Inicio de Sesion</h1>

    <form class="login100-form validate-form p-b-33 p-t-5" action="ValidarLogin.aspx" method="post" runat="server">

					<div >
                        <asp:TextBox ID="txtusuarioo" runat="server" class="input100" placeholder="Usuario" name="txtusuario"></asp:TextBox>
						<span class="focus-input100" data-placeholder="&#xe82a;"></span>
					</div>

					<div class="wrap-input100 validate-input" data-validate="Enter password">
						<asp:TextBox ID="txtcontrasena" runat="server" class="input100" placeholder="Contrasena" name="txtcontrasena"></asp:TextBox>
						<span class="focus-input100" data-placeholder="&#xe80f;"></span>
					</div>

					<div >
						<button class="jhonatan" type="boton";>
							Iniciar Sesion
						

				</form>
</body>
</html>

