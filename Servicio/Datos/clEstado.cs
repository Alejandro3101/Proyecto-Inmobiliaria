using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace Servicio.Datos
{
    public class clEstado
    {
        public DataSet mtdListar()
        {
            string consulta = "select * from Estado";
            DataSet dsEstado = new DataSet();
            clConexion objConexion = new clConexion();
            dsEstado = objConexion.mtdDesconectado(consulta);
            int can = dsEstado.Tables["tblDatos"].Rows.Count;
            return dsEstado;
            
        }


    }
}