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
        public float Precio { get; set; }
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
            string consulta = "select * from Publicacion where IdPublicacion = "+objPublica.IdPublicacion+" ";
            DataSet dsPublicacion = new DataSet();
            clConexion objConexion = new clConexion();
            dsPublicacion = objConexion.mtdDesconectado(consulta);
            return dsPublicacion;
        }

        public DataSet mtdListar2( clPublicacion objPubli )
        {
            string consulta = "select IdPublicacion,Nombre,Precio,Descripcion,Telefono,Estrato,Direccion,NumeroHabitaciones from Publicacion inner join Categoria on Categoria.IdCategoria = Publicacion.IdCategoria inner join Ciudad on Ciudad.IdCiudad = Publicacion.IdCiudad inner join Tipo on Tipo.IdTipo = Publicacion.IdTipo where Publicacion.IdCategoria = " + objPubli.IdCategoria + " and Publicacion.IdCiudad = " + objPubli.IdCiudad + "and Publicacion.IdTipo = " + objPubli.IdTipo + "";
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

    }
}