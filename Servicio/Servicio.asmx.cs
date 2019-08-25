using Servicio.Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace Servicio
{
    /// <summary>
    /// Descripción breve de Servicio
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class Servicio : System.Web.Services.WebService
    {

        [WebMethod]
        public DataSet mtdListarCategoria()
        {
            DataSet dsCategoria = new DataSet();
            clCategoria objCategoria = new clCategoria();
            dsCategoria = objCategoria.mtdListar();
            return dsCategoria;
        }

        [WebMethod]
        public DataSet mtdListarCiudad()
        {
            DataSet dsCiudad = new DataSet();
            clCiudad objCiudad = new clCiudad();
            dsCiudad = objCiudad.mtdListar();
            return dsCiudad;
        }

        [WebMethod]
        public DataSet mtdListarEstado()
        {
            DataSet dsEstado = new DataSet();
            clEstado objEstado = new clEstado();
            dsEstado = objEstado.mtdListar();
            return dsEstado;
        }

        [WebMethod]
        public DataSet mtdListarTipo()
        {
            DataSet dsTipo = new DataSet();
            clTipo objTipo = new clTipo();
            dsTipo = objTipo.mtdListar();
            return dsTipo;
        }

        [WebMethod]
        public DataSet mtdListarPublicaciones2(clPublicacion objPubli)
        {
            DataSet dsPublicacion = new DataSet();
            clPublicacion objPublicacion = new clPublicacion();
            dsPublicacion = objPublicacion.mtdListar2(objPubli);
            return dsPublicacion;
        }


        [WebMethod]
        public int mtdRegistrarPublicacion(clPublicacion objPublicacion)
        {
            clPublicacion objPubli = new clPublicacion();
            int result = objPubli.mtdRegistrar(objPublicacion);
            return result;
        }

        [WebMethod]
        public int Login(string usuario, string contrasena)
        {
            clConexion objcone = new clConexion();
            int res = objcone.mtdLogin(usuario, contrasena);
            return res;
        }
    }
}
