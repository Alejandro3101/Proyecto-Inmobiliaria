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
        public DataSet mtdListarPublicacion(clPublicacion objPublica)
        {
            DataSet dsPublicacion = new DataSet();
            clPublicacion objPubli = new clPublicacion();
            dsPublicacion = objPubli.mtdListar(objPublica);
            return dsPublicacion;
        }

        [WebMethod]
        public DataSet mtdListarPublicaciones2(clPublicacion objPubli)
        {
            DataSet dsPublicacion = new DataSet();
            clPublicacion objPublicacion = new clPublicacion();
            dsPublicacion = objPublicacion.mtdListar2(objPubli);
            int cant = dsPublicacion.Tables[0].Rows.Count;
            return dsPublicacion;
        }

        [WebMethod]
        public DataSet mtdListarPublicacion3(clPublicacion objPublica)
        {
            DataSet dsPublicacion = new DataSet();
            clPublicacion objPubli = new clPublicacion();
            dsPublicacion = objPubli.mtdListar3(objPublica);
            return dsPublicacion;
        }

        [WebMethod]
        public DataSet mtdListarPublicacionesU(clPublicacion objPubliU)
        {
            DataSet dsPublicacionU = new DataSet();
            clPublicacion objPublicacionU = new clPublicacion();
            dsPublicacionU = objPublicacionU.mtdListarPublicacionU(objPubliU);
            return dsPublicacionU;
        }

        [WebMethod]
        public DataSet mtdListarPublicacionesU2(clPublicacion objPubliU2)
        {
            DataSet dsPublicacion = new DataSet();
            clPublicacion objPublicacion = new clPublicacion();
            dsPublicacion = objPublicacion.mtdListarPublicacioneU2(objPubliU2);
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
        public int mtdRegistrarUsuario(clUsuario objUsuario)
        {
            clUsuario objUsuar = new clUsuario();
            int result = objUsuario.mtdRegistrarUsu(objUsuario);
            return result;
        }

        [WebMethod]
        public int Login(string usuario, string contrasena)
        {
            clConexion objcone = new clConexion();
            int res = objcone.mtdLogin(usuario, contrasena);
            return res;
        }
        [WebMethod]
        public int Imagenes(string usuario, string contrasena)
        {
            clConexion objcone = new clConexion();
            int res = objcone.mtdLogin(usuario, contrasena);
            return res;
        }
        [WebMethod]
        public DataSet mtdListarRol()
        {
            DataSet dsRol = new DataSet();
            clRol objRol = new clRol();
            dsRol = objRol.mtdListarRol();
            return dsRol;
        }
        [WebMethod]
        public int mtdRegistrarFoto(string foto, int id)
        {
            clFoto objfoto = new clFoto();
            int result = objfoto.mtdregistrar(foto, id);
            return result;
        }
        [WebMethod]
        public int mtdUltimaPublicacion()
        {
            clConexion objcone = new clConexion();
            int res = objcone.tomarUltimaPublicacion();
            return res;
        }
    }
}
