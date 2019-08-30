using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace web
{
    public partial class Formulario_web19 : System.Web.UI.Page
    {

        ServicioW.ServicioSoapClient miServicio = new ServicioW.ServicioSoapClient();
        protected void Page_Init (object sender, EventArgs e)
        {
            mtdCargarTipo();
            mtdCargarCiudad();
            mtdCargarCategoria();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btnSubir_Click(object sender, EventArgs e)
        {




            ////obtener datos de la imagen
            //int Tamanio = fuploadImagen.PostedFile.ContentLength;
            //byte[] ImagenOriginal = new byte[Tamanio];
            //fuploadImagen.PostedFile.InputStream.Read(ImagenOriginal, 0, Tamanio);
            //Bitmap ImagenOriginalBinaria = new Bitmap(fuploadImagen.PostedFile.InputStream);

            ////Crear una imagen thumbnail
            //System.Drawing.Image imtThumbnail;
            //int TamanioThumbnail = 200;
            //imtThumbnail = RedimencionarImagen(ImagenOriginalBinaria, TamanioThumbnail);
            //byte[] bImagenThumbnail = new byte[TamanioThumbnail];

            //ImageConverter Convertidor = new ImageConverter();
            //bImagenThumbnail = (byte[])Convertidor.ConvertTo(imtThumbnail, typeof(byte[]));



            //Insertar en la bse de datos

    //        SqlConnection Conexion = new SqlConnection(CadenaConexion);
    //        SqlCommand cmd = new SqlCommand();
    //        cmd.CommandText = "INSERT INTO Foto(Foto)VALUES (@Foto)";
    //        cmd.Parameters.Add("@imagen", SqlDbType.Image).Value = bImagenThumbnail;
            

    //        cmd.CommandType = CommandType.Text;
    //        cmd.Connection = Conexion;
    //        Conexion.Open();
    //        cmd.ExecuteNonQuery();


    //        String ImagenDataUrl64 = "data:image/jpg;base64," + Convert.ToBase64String(bImagenThumbnail);
    //        ImgPreView.ImageUrl = ImagenDataUrl64;


    //        ConsultaImagen();

    //    }

    //    public System.Drawing.Image RedimencionarImagen(System.Drawing.Image ImagenOriginal, int Alto)
    //    {
    //        var Radio = (Double)Alto / ImagenOriginal.Height;
    //        var NuevoAncho = (int)(ImagenOriginal.Width * Radio);
    //        var NuevoAlto = (int)(ImagenOriginal.Height * Radio);
    //        var NuevaImagenRedimencionada = new Bitmap(NuevoAncho, NuevoAlto);
    //        var g = Graphics.FromImage(NuevaImagenRedimencionada);
    //        g.DrawImage(ImagenOriginal, 0, 0, NuevoAncho, NuevoAlto);
    //        return NuevaImagenRedimencionada;
    //    }

    //    protected void ConsultaImagen()
    //    {
    //        SqlConnection Conexion = new SqlConnection(CadenaConexion);
    //        SqlCommand cmd = new SqlCommand();
    //        cmd.CommandText = "Select Foto From Foto ORDER BY ID ASC";
    //        cmd.CommandType = CommandType.Text;
    //        cmd.Connection = Conexion;
    //        Conexion.Open();

    //        DataTable ImagenesBD = new DataTable();
    //        ImagenesBD.Load(cmd.ExecuteReader());

    //        Repeater1.DataSource = ImagenesBD;
    //        Repeater1.DataBind();
    //        Conexion.Close();

      }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }

        public void mtdCargarTipo()
        {
            DataSet dsTipo = new DataSet();
            dsTipo = miServicio.mtdListarTipo();
            int C = dsTipo.Tables["tblDatos"].Rows.Count;

            cmbTipo.DataSource = dsTipo.Tables["tblDatos"];
            cmbTipo.DataTextField = "Tipo";
            cmbTipo.DataValueField = "IdTipo";
            cmbTipo.DataBind();
        }

        public void mtdCargarCiudad()
        {
            DataSet dsCiudad = new DataSet();
            dsCiudad = miServicio.mtdListarCiudad();
            int C = dsCiudad.Tables["tblDatos"].Rows.Count;

            cmbCiudad.DataSource = dsCiudad.Tables["tblDatos"];
            cmbCiudad.DataTextField = "Ciudad";
            cmbCiudad.DataValueField = "IdCiudad";
            cmbCiudad.DataBind();
        }

        public void mtdCargarCategoria()
        {
            DataSet dsCategoria = new DataSet();
            dsCategoria = miServicio.mtdListarCategoria();
            int C = dsCategoria.Tables["tblDatos"].Rows.Count;

            cmbCategoria.DataSource = dsCategoria.Tables["tblDatos"];
            cmbCategoria.DataTextField = "Categoria";
            cmbCategoria.DataValueField = "IdCategoria";
            cmbCategoria.DataBind();
        }

        

        protected void btnPublicar_Click(object sender, EventArgs e)
        {
            Response.Redirect("AgregarImgPublicacion.aspx");
            //ServicioW.clPublicacion objPublicacion = new ServicioW.clPublicacion();
            //objPublicacion.Nombre = txtNombre.Text;
            //objPublicacion.Precio = int.Parse(txtPrecio.Text);
            //objPublicacion.Descripcion = txtDescripcion.Text;
            //objPublicacion.Telefono = txtTelefono.Text;
            //objPublicacion.Estrato = cmbEstrato.SelectedValue.ToString();
            //objPublicacion.Direccion = txtDescripcion.Text;
            //objPublicacion.Habitaciones = int.Parse(cmbHabitacion.SelectedValue.ToString());
            //objPublicacion.IdUsuario = int.Parse(Application["IdUsuario"].ToString());
            //objPublicacion.IdTipo = int.Parse(cmbTipo.SelectedValue.ToString());
            //objPublicacion.IdEstado = 1;
            //objPublicacion.IdCiudad = int.Parse(cmbCiudad.SelectedValue.ToString());
            //objPublicacion.IdCategoria = int.Parse(cmbCategoria.SelectedValue.ToString());
            //int result = miServicio.mtdRegistrarPublicacion(objPublicacion);
            //if (result > 0)
            //{

            //    Response.Redirect("AgregarImgPublicacion.aspx");

            //}
        }

        protected void cmbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}