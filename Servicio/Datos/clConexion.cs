using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Servicio.Datos
{
    public class clConexion
    {


        SqlConnection objConexion = null;


        public clConexion()
        {
            try
            {
                objConexion = new SqlConnection(" Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename =|DataDirectory|\\bdSaleYa.mdf; Integrated Security = True");
            }                                      
            catch (Exception exp)
            {
                string salida = exp.Message;
            }
        }

        public int mtdConectado(string consulta)
        {
            objConexion.Open();
            SqlCommand comando = new SqlCommand(consulta, objConexion);
            int resultado = comando.ExecuteNonQuery();
            objConexion.Close();
            return resultado;
        }
        public DataSet mtdDesconectado(string consulta)
        {
            objConexion.Open();
            SqlDataAdapter objadaptador = new SqlDataAdapter(consulta, objConexion);
            DataSet dsdatos = new DataSet();
            objadaptador.Fill(dsdatos, "tbldatos");
            objConexion.Close();
            return dsdatos;
        }

        public int mtdLogin(string usuario, string contrasena)
        {
            objConexion.Open();
            SqlCommand cmd = new SqlCommand("select u.IdUsuario, u.Contrasena, u.Email, u.Nombre, r.Rol From(Usuario as u INNER JOIN Rol as r On u.IdRol=r.IdRol) where u.Email = @Email and u.Contrasena = @Contrasena", objConexion);
            cmd.Parameters.AddWithValue("@Email", usuario);
            cmd.Parameters.AddWithValue("@Contrasena", contrasena);
            SqlDataAdapter adaptador = new SqlDataAdapter(cmd);
            DataTable login = new DataTable();
            adaptador.Fill(login);
            int res = login.Rows.Count;

            objConexion.Close();

            return res;
        }



    }
}
