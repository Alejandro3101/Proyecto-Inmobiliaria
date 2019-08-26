using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace Servicio.Datos
{
    public class clRol
    {

        public DataSet mtdListarRol()
        {
            string consulta = "select * from Rol";
            DataSet dsRol = new DataSet();
            clConexion objConexion = new clConexion();
            dsRol = objConexion.mtdDesconectado(consulta);
            int can = dsRol.Tables["tblDatos"].Rows.Count;
            return dsRol;
        }
    }
}