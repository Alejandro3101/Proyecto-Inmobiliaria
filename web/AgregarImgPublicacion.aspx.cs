using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace web
{
    public partial class AgregarImgPublicacion : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }
        protected void btnSubir_Click(object sender, EventArgs e)
        {
            if (fuploadImagen.HasFile)
            {
                //opteniendo la extension
                string ext = System.IO.Path.GetExtension(fuploadImagen.FileName);
                ext = ext.ToLower();
                //optener nombre archivo
                string nom = fuploadImagen.FileName;
                //configurando el tamaño en bytes
                //int tam = fuploadImagen.PostedFile.ContentLength;
                //Response.Write(ext + ", " + tam);
                //guardamos en el servidor
                fuploadImagen.SaveAs(Server.MapPath("~/PublicacionesImagenes/" + fuploadImagen.FileName));

                ServicioW.ServicioSoapClient mi = new ServicioW.ServicioSoapClient();
                int ultimaPublicacion = mi.mtdUltimaPublicacion();

                mi.mtdRegistrarFoto(nom, ultimaPublicacion);
            }
            else
            {
                Response.Write("Cargue Imagen...");
            }
        }
    }
}