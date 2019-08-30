<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AgregarImgPublicacion.aspx.cs" Inherits="web.AgregarImgPublicacion" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css" />
    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/js/bootstrap.min.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <div class ="container">
            <div class ="row"> 
                <div class="col-md-4 col.md-offset-4" >
                    <br />
                    Archivo:
                    <asp:FileUpload ID="fuploadImagen" accept=".jpg" runat="server" CssClass="form-control"/>
                    <br />
                    <asp:Button ID="btnSubir" runat="server" Text="Adjuntar Imagen" CssClass="btn btn-success" OnClick="btnSubir_Click" />

                </div>
                

            </div>
            
            
            <div class ="row"> 

            </div>
        </div>
    </form>
</body>
</html>