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
                    Imagen Agregada:
                    <br />
                    <asp:Image ID="ImgPreView" width="200" ImageUrl="https://cdn.pixabay.com/photo/2017/09/25/11/55/cyberspace-2784907_960_720.jpg" runat="server" />
                    <br />
                    <br />
                    Archivo:
                    <asp:FileUpload ID="fuploadImagen" accept=".jpg" runat="server" CssClass="form-control"/>
                    <br />
                    Titulo de Imagen
                    <asp:TextBox ID="txtTitulo" runat="server" CssClass="form-control"></asp:TextBox>
                    <br />
                    <asp:Button ID="btnSubir" runat="server" Text="Adjuntar Imagen" CssClass="btn btn-success" OnClick="btnSubir_Click" />

                </div>
                

            </div>
            
            
            <div class ="row"> 
                <asp:Repeater ID="Repeater1" runat="server">
                <ItemTemplate>
                    <div class="col-md-4">

                        <img class="img-responsive" src="data:image/jpg;base64,<%# Convert.ToBase64String((byte[]) DataBinder.Eval(Container.DataItem ,"Imagen")) %>" />
                        <%#  DataBinder.Eval(Container.DataItem ,"Titulo") %>
                        <br />
                    </div>


                </ItemTemplate> 

               </asp:Repeater>

            </div>
        </div>
    </form>
</body>
</html>