using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace Servicio.Datos
{
    public class clCategoria
    {

        public DataSet mtdListar()
        {
            string consulta = "select * from Categoria";
            DataSet dsCategoria = new DataSet();
            clConexion objConexion = new clConexion();
            dsCategoria = objConexion.mtdDesconectado(consulta);
            int can = dsCategoria.Tables["tblDatos"].Rows.Count;
            return dsCategoria;
        }

    }
}