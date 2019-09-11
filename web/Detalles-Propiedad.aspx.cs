using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using web;

namespace web
{
    public partial class Formulario_web112 : System.Web.UI.Page
    {
        ServicioW.ServicioSoapClient miServicio = new ServicioW.ServicioSoapClient();
        protected void Page_Load(object sender, EventArgs e)
        {
            int Id = int.Parse(Application["IdPublicacion"].ToString());
            DataSet dsListar = new DataSet();
            ServicioW.clPublicacion objPublicacion = new ServicioW.clPublicacion();
            objPublicacion.IdPublicacion = Id;
            dsListar = miServicio.mtdListarPublicacion3(objPublicacion);
           // lblNombre.Text = dsListar.Tables["tblDatos"].Rows[0]["Nombre"].ToString();
            //imgFoto.ImageUrl= "/PublicacionesImagenes/" + dsListar.Tables["tblDatos"].Rows[0]["Foto"].ToString();
            lblPrecio.Text = dsListar.Tables["tblDatos"].Rows[0]["Precio"].ToString();
            lblHabitacion.Text = dsListar.Tables["tblDatos"].Rows[0]["NumeroHabitaciones"].ToString();
            lblEstrato.Text = dsListar.Tables["tblDatos"].Rows[0]["Estrato"].ToString();
            lblTelefono.Text = dsListar.Tables["tblDatos"].Rows[0]["Telefono"].ToString();
            lblDescripcion.Text = dsListar.Tables["tblDatos"].Rows[0]["Descripcion"].ToString();
            DataList1.DataSource = dsListar;
            DataList1.DataBind();
        }
    }
}