using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace web
{
    public partial class Formulario_web18 : System.Web.UI.Page
    {

        ServicioW.ServicioSoapClient miServicioW = new ServicioW.ServicioSoapClient();
        protected void Page_Load(object sender, EventArgs e)

        {
            mtdCargarRol();



        }

        public void mtdCargarRol()
        {
            DataSet dsRol = new DataSet();
            dsRol = miServicioW.mtdListarRol();
            int C = dsRol.Tables["tblDatos"].Rows.Count;

            cmbRol.DataSource = dsRol.Tables["tblDatos"];
            cmbRol.DataTextField = "Rol";
            cmbRol.DataValueField = "IdRol";
            cmbRol.DataBind();
        }

        protected void btnRegistrar_Click(object sender, EventArgs e)
        {
            ServicioW.clUsuario objUsuario = new ServicioW.clUsuario();
            objUsuario.Nombre = txtNombre.Text;
            objUsuario.Apellido = txtApellido.Text;
            objUsuario.Email = txtEmail.Text;
            objUsuario.Telefono = txtTelefono.Text;
            objUsuario.Ciudad = txtCiudad.Text;
            objUsuario.Ubicacion = txtUbicacion.Text;
            objUsuario.Contrasena = txtContrasena.Text;
            objUsuario.IdRol = int.Parse(cmbRol.SelectedValue.ToString());
            
            int result = miServicioW.mtdRegistrarUsuario(objUsuario);
            if (result > 0)
            {

                Response.Redirect("index.aspx");

            }
        }
    }
}