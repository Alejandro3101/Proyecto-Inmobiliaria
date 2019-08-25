using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace Servicio.Datos
{
    public class clUsuario
    {

        public int IdUsuario { get; set; }
        public string Nombre { get; set; }
        public string Aapellido { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }
        public string Ciudad { get; set; }
        public string Ubicacion { get; set; }
        public string Contrasena { get; set; }
        public int IdRol { get; set; }
        clConexion objcone = new clConexion();

        public DataSet mtdLogin()
        {
            string consulta = "select u.IdUsuario, u.Contrasena, u.Email, u.Nombre, r.Rol From(Usuario as u INNER JOIN Rol as r On u.IdRol=r.IdRol) ";
            DataSet dsUsuarioLogin = new DataSet();
            dsUsuarioLogin = objcone.mtdDesconectado(consulta);
            return dsUsuarioLogin;
        }


    }
}