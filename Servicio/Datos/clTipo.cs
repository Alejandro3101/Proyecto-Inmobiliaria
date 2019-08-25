using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace Servicio.Datos
{
    public class clTipo
    {
        public DataSet mtdListar()
        {
            string consulta = "select * from Tipo";
            DataSet dsTipo = new DataSet();
            clConexion objConexion = new clConexion();
            dsTipo = objConexion.mtdDesconectado(consulta);
            int can = dsTipo.Tables["tblDatos"].Rows.Count;
            return dsTipo;
        }


    }
}