using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace Servicio.Datos
{
    public class clCiudad
    {

        public DataSet mtdListar()
        {
            string consulta = "select * from Ciudad";
            DataSet dsCiudad = new DataSet();
            clConexion objConexion = new clConexion();
            dsCiudad = objConexion.mtdDesconectado(consulta);
            int can = dsCiudad.Tables["tblDatos"].Rows.Count;
            return dsCiudad;
        }

    }
}