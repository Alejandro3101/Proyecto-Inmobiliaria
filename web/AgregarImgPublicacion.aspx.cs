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
        string CadenaConexion = "Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename =|DataDirectory|\\bdSaleYa.mdf; Integrated Security = True";

        protected void Page_Load(object sender, EventArgs e)
        {
            ConsultaImagen();
        }
        protected void btnSubir_Click(object sender, EventArgs e)
        {
            //obtener datos de la imagen
            int Tamanio = fuploadImagen.PostedFile.ContentLength;
            byte[] ImagenOriginal = new byte[Tamanio];
            fuploadImagen.PostedFile.InputStream.Read(ImagenOriginal, 0, Tamanio);
            Bitmap ImagenOriginalBinaria = new Bitmap(fuploadImagen.PostedFile.InputStream);

            //Crear una imagen thumbnail
            System.Drawing.Image imtThumbnail;
            int TamanioThumbnail = 200;
            imtThumbnail = RedimencionarImagen(ImagenOriginalBinaria, TamanioThumbnail);
            byte[] bImagenThumbnail = new byte[TamanioThumbnail];

            ImageConverter Convertidor = new ImageConverter();
            bImagenThumbnail = (byte[])Convertidor.ConvertTo(imtThumbnail, typeof(byte[]));



            //Insertar en la bse de datos

            SqlConnection Conexion = new SqlConnection(CadenaConexion);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "INSERT INTO Foto(Foto,IdPublicacion)VALUES (@imagen,@Publicacion)";
            cmd.Parameters.Add("@imagen", SqlDbType.Image).Value = bImagenThumbnail;
            cmd.Parameters.Add("@Publicacion", SqlDbType.Text).Value = txtTitulo.Text;

            cmd.CommandType = CommandType.Text;
            cmd.Connection = Conexion;
            
            Conexion.Open();

            cmd.ExecuteNonQuery();

            String ImagenDataUrl64 = "data:image/jpg;base64," + Convert.ToBase64String(bImagenThumbnail);
            ImgPreView.ImageUrl = ImagenDataUrl64;


            ConsultaImagen();

        }
        public System.Drawing.Image RedimencionarImagen(System.Drawing.Image ImagenOriginal, int Alto)
        {
            var Radio = (Double)Alto / ImagenOriginal.Height;
            var NuevoAncho = (int)(ImagenOriginal.Width * Radio);
            var NuevoAlto = (int)(ImagenOriginal.Height * Radio);
            var NuevaImagenRedimencionada = new Bitmap(NuevoAncho, NuevoAlto);
            var g = Graphics.FromImage(NuevaImagenRedimencionada);
            g.DrawImage(ImagenOriginal, 0, 0, NuevoAncho, NuevoAlto);
            return NuevaImagenRedimencionada;
        }

        protected void ConsultaImagen()
        {
            SqlConnection Conexion = new SqlConnection(CadenaConexion);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "Select Foto,IdUsuario From Foto ORDER BY ID ASC";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = Conexion;
            
            Conexion.Open();
            DataTable ImagenesBD = new DataTable();
            ImagenesBD.Load(cmd.ExecuteReader());

            Repeater1.DataSource = ImagenesBD;
            Repeater1.DataBind();
            Conexion.Close();
        }
    }
}