using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Servicio.Datos
{
    public class clFoto
    {
        public int idFoto { get; set; }
        public string Foto { get; set; }
        public int IdPublicacion { get; set; }

        clConexion objcone = new clConexion();

        public int mtdregistrar(string foto, int id)
        {
            string consulta = "insert into Foto(Foto, IdPublicacion) values('" + foto + "', " + id + ")";
            int res = objcone.mtdConectado(consulta);
            return res;
        }
    }
}