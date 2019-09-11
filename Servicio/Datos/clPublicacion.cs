using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace Servicio.Datos
{
    public class clPublicacion
    {

        public int IdPublicacion { get; set; }
        public String Nombre { get; set; }
        public String Precio { get; set; }
        public String Descripcion { get; set; }
        public String Telefono { get; set; }
        public String Estrato { get; set; }
        public String Direccion { get; set; }
        public int Habitaciones { get; set; }
        public int IdUsuario { get; set; }
        public int IdTipo { get; set; }
        public int IdEstado { get; set; }
        public int IdCiudad { get; set; }
        public int IdCategoria { get; set; }


        public DataSet mtdListar(clPublicacion objPublica )
        {
            string consulta = "select Nombre,Precio,Descripcion,Telefono,Estrato,Direccion,NumeroHabitaciones,Tipo.Tipo,Categoria.Categoria,Ciudad.Ciudad,Estado.Estado" +
                "  from Publicacion inner join Categoria on Categoria.IdCategoria = Publicacion.IdCategoria inner join Ciudad on Ciudad.IdCiudad = Publicacion.IdCiudad" +
                " inner join Tipo on Tipo.IdTipo = Publicacion.IdTipo inner join Estado on Estado.IdEstado = Publicacion.IdEstado where IdPublicacion = " + objPublica.IdPublicacion+" ";
            DataSet dsPublicacion = new DataSet();
            clConexion objConexion = new clConexion();
            dsPublicacion = objConexion.mtdDesconectado(consulta);
            return dsPublicacion;
        }

        public DataSet mtdListar2( clPublicacion objPubli )
        {
            string consulta = "select  Publicacion.IdPublicacion,Nombre,Precio,Descripcion,Telefono,Estrato,Direccion,NumeroHabitaciones,Foto.Foto " +
                "from Publicacion inner join Categoria on Categoria.IdCategoria = Publicacion.IdCategoria " +
                "inner join Ciudad on Ciudad.IdCiudad = Publicacion.IdCiudad inner join Tipo on Tipo.IdTipo = Publicacion.IdTipo" +
                " inner join Foto on Foto.IdPublicacion = Publicacion.IdPublicacion where  Publicacion.IdCategoria = " + objPubli.IdCategoria + " and Publicacion.IdCiudad = " + objPubli.IdCiudad + "and Publicacion.IdTipo = " + objPubli.IdTipo + "";
            DataSet dsUsuario = new DataSet();
            clConexion objConexion = new clConexion();
            dsUsuario = objConexion.mtdDesconectado(consulta);
            return dsUsuario;
        }

        public DataSet mtdListar3(clPublicacion objPublica)
        {
            string consulta = "select Nombre,Precio,Descripcion,Telefono,Estrato,Direccion,NumeroHabitaciones,Tipo.Tipo,Categoria.Categoria,Ciudad.Ciudad,Estado.Estado, Foto.Foto" +
                "  from Publicacion inner join Categoria on Categoria.IdCategoria = Publicacion.IdCategoria inner join Ciudad on Ciudad.IdCiudad = Publicacion.IdCiudad" +
                " inner join Tipo on Tipo.IdTipo = Publicacion.IdTipo inner join Estado on Estado.IdEstado = Publicacion.IdEstado inner join Foto on Foto.IdPublicacion = Publicacion.IdPublicacion where Publicacion.IdPublicacion = " + objPublica.IdPublicacion + " ";
            DataSet dsPublicacion = new DataSet();
            clConexion objConexion = new clConexion();
            dsPublicacion = objConexion.mtdDesconectado(consulta);
            return dsPublicacion;
        }

        public DataSet mtdListarPublicacionU(clPublicacion objPublica)
        {
            string consulta = "select Publicacion.IdPublicacion,Nombre,Precio,Descripcion,Telefono,Estrato,Direccion,NumeroHabitaciones,Tipo.Tipo,Categoria.Categoria,Ciudad.Ciudad,Estado.Estado" +
                "  from Publicacion inner join Categoria on Categoria.IdCategoria = Publicacion.IdCategoria inner join Ciudad on Ciudad.IdCiudad = Publicacion.IdCiudad" +
                " inner join Tipo on Tipo.IdTipo = Publicacion.IdTipo inner join Estado on Estado.IdEstado = Publicacion.IdEstado  where IdUsuario = " + objPublica.IdUsuario +"";
            DataSet dsPublicacion = new DataSet();
            clConexion objConexion = new clConexion();
            dsPublicacion = objConexion.mtdDesconectado(consulta);
            return dsPublicacion;
        }

        public DataSet mtdListarPublicacioneU2(clPublicacion objPubli)
        {
            string consulta = "select Nombre,Precio,Descripcion,Telefono,Estrato,Direccion,NumeroHabitaciones,Tipo.Tipo,Categoria.Categoria,Ciudad.Ciudad,Estado.Estado " +
                "from Publicacion inner join Categoria on Categoria.IdCategoria = Publicacion.IdCategoria inner join Ciudad on Ciudad.IdCiudad = Publicacion.IdCiudad " +
                "inner join Tipo on Tipo.IdTipo = Publicacion.IdTipo inner join Estado on Estado.IdEstado = Publicacion.IdEstado where Publicacion.IdCategoria = " + objPubli.IdCategoria + "";
            DataSet dsUsuario = new DataSet();
            clConexion objConexion = new clConexion();
            dsUsuario = objConexion.mtdDesconectado(consulta);
            return dsUsuario;
        }

        public int mtdRegistrar(clPublicacion objPubli)
        {
            string consulta = "insert into Publicacion(Nombre,Precio,Descripcion,Telefono,Estrato,Direccion,NumeroHabitaciones,IdUsuario,IdTipo,IdEstado,IdCiudad,IdCategoria)" +
                "values('" + objPubli.Nombre + "','" + objPubli.Precio + "','" + objPubli.Descripcion + "', '" + objPubli.Telefono + "', '" + objPubli.Estrato + "', '" + objPubli.Direccion + "'" +
                ", '" + objPubli.Habitaciones + "'," + objPubli.IdUsuario + "," + objPubli.IdTipo + "," + objPubli.IdEstado + "," + objPubli.IdCiudad + "," + objPubli.IdCategoria + " )";
            clConexion objConexion = new clConexion();
            int resultado = objConexion.mtdConectado(consulta);
            return resultado;
        }
        public int mtdEditarPublicacion(clPublicacion objPubli)
        {
            string consulta = "update Publicacion set Nombre = '"+ objPubli.Nombre + "', Precio = '"+ objPubli.Precio + "', Descripcion='"+ objPubli.Descripcion + "', Telefono = '"+ objPubli.Telefono + "', Estrato = '"+ objPubli.Estrato + "' , Direccion = '"+ objPubli.Direccion + "', NumeroHabitaciones = "+ objPubli.Habitaciones + " , IdUsuario = "+ objPubli.IdUsuario + " , IdTipo = "+ objPubli.IdTipo + ", IdEstado = "+ objPubli.IdEstado + ", IdCiudad = "+ objPubli.IdCiudad + " , IdCategoria = "+ objPubli.IdCategoria + " where IdPublicacion = "+objPubli.IdPublicacion+" ";
            clConexion objConexion = new clConexion();
            int resultado = objConexion.mtdConectado(consulta);
            return resultado;
        }

    }
}