using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace web
{
    public partial class Formulario_web115 : System.Web.UI.Page
    {
        ServicioW.ServicioSoapClient miServicio = new ServicioW.ServicioSoapClient();

        protected void Page_Init(object sender, EventArgs e)
        {
            mtdCargarTipo();
            mtdCargarCiudad();
            mtdCargarCategoria();
            mtdCargarEstado();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            mtdCargarDatos();
        }

        protected void btnPublicar_Click(object sender, EventArgs e)
        {
           
            ServicioW.clPublicacion objPublicacion = new ServicioW.clPublicacion();
            objPublicacion.Nombre = txtNombre.Text;
            objPublicacion.Precio = txtPrecio.Text;
            objPublicacion.Descripcion = txtDescripcion.Text;
            objPublicacion.Telefono = txtTelefono.Text;
            objPublicacion.Estrato = cmbEstrato.SelectedValue.ToString();
            objPublicacion.Direccion = txtDireccion.Text;
            objPublicacion.Habitaciones = int.Parse(cmbHabitacion.SelectedValue.ToString());
            objPublicacion.IdUsuario = int.Parse(Application["IdUsuario"].ToString());
            objPublicacion.IdTipo = int.Parse(cmbTipo.SelectedValue.ToString());
            objPublicacion.IdEstado = int.Parse(cmbEstado.SelectedValue.ToString());
            objPublicacion.IdCiudad = int.Parse(cmbCiudad.SelectedValue.ToString());
            objPublicacion.IdCategoria = int.Parse(cmbCategoria.SelectedValue.ToString());

            string Valor = Request.QueryString["id"].ToString();
            objPublicacion.IdPublicacion = int.Parse(Valor); 

            int result = miServicio.mtdEditarPublicacion(objPublicacion);
            if (result > 0)
            {

                Response.Redirect("MisPublicaciones.aspx");

            }
        }

        public void mtdCargarTipo()
        {
            DataSet dsTipo = new DataSet();
            dsTipo = miServicio.mtdListarTipo();
            int C = dsTipo.Tables["tblDatos"].Rows.Count;

            cmbTipo.DataSource = dsTipo.Tables["tblDatos"];
            cmbTipo.DataTextField = "Tipo";
            cmbTipo.DataValueField = "IdTipo";
            cmbTipo.DataBind();
        }

        public void mtdCargarEstado()
        {
            DataSet dsEstado = new DataSet();
            dsEstado = miServicio.mtdListarEstado();
            int C = dsEstado.Tables["tblDatos"].Rows.Count;

            cmbEstado.DataSource = dsEstado.Tables["tblDatos"];
            cmbEstado.DataTextField = "Estado";
            cmbEstado.DataValueField = "IdEstado";
            cmbEstado.DataBind();
        }

        public void mtdCargarDatos()
        {
            string Valor = Request.QueryString["id"].ToString();
            DataSet dsListar = new DataSet();
            ServicioW.clPublicacion objPublicacion = new ServicioW.clPublicacion();
            objPublicacion.IdPublicacion = int.Parse(Valor.ToString());
            dsListar = miServicio.mtdListarPublicacion(objPublicacion);
            
            txtNombre.Text = dsListar.Tables["tblDatos"].Rows[0]["Nombre"].ToString();
            txtPrecio.Text = dsListar.Tables["tblDatos"].Rows[0]["Precio"].ToString();
            txtDireccion.Text = dsListar.Tables["tblDatos"].Rows[0]["Direccion"].ToString();
            txtTelefono.Text = dsListar.Tables["tblDatos"].Rows[0]["Telefono"].ToString();
            //cmbTipo.Text = dsListar.Tables["tblDatos"].Rows[0]["Tipo"].ToString();
           
            
           
            cmbHabitacion.Text = dsListar.Tables["tblDatos"].Rows[0]["NumeroHabitaciones"].ToString();
            cmbEstrato.Text = dsListar.Tables["tblDatos"].Rows[0]["Estrato"].ToString();
            txtDescripcion.Text = dsListar.Tables["tblDatos"].Rows[0]["Descripcion"].ToString();
            
            
        }





        public void mtdCargarCiudad()
        {
            DataSet dsCiudad = new DataSet();
            dsCiudad = miServicio.mtdListarCiudad();
            int C = dsCiudad.Tables["tblDatos"].Rows.Count;

            cmbCiudad.DataSource = dsCiudad.Tables["tblDatos"];
            cmbCiudad.DataTextField = "Ciudad";
            cmbCiudad.DataValueField = "IdCiudad";
            cmbCiudad.DataBind();
        }

        public void mtdCargarCategoria()
        {
            DataSet dsCategoria = new DataSet();
            dsCategoria = miServicio.mtdListarCategoria();
            int C = dsCategoria.Tables["tblDatos"].Rows.Count;

            cmbCategoria.DataSource = dsCategoria.Tables["tblDatos"];
            cmbCategoria.DataTextField = "Categoria";
            cmbCategoria.DataValueField = "IdCategoria";
            cmbCategoria.DataBind();
        }

        
        
    }
}