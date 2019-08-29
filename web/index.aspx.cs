using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace web
{
    public partial class Formulario_web110 : System.Web.UI.Page
    {

        ServicioW.ServicioSoapClient miServicio = new ServicioW.ServicioSoapClient();
        protected void Page_Init(object sender, EventArgs e)
        {
            mtdCargarTipo();
            mtdCargarCiudad();
            mtdCargarCategoria();
        }


        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public void mtdCargarTipo()
        {
            DataSet dsTipo = new DataSet();
            dsTipo = miServicio.mtdListarTipo();
            int C = dsTipo.Tables["tblDatos"].Rows.Count;
            
            cmbBuscarTipo.DataSource = dsTipo.Tables["tblDatos"];
            cmbBuscarTipo.DataTextField = "Tipo";
            cmbBuscarTipo.DataValueField = "IdTipo";
            cmbBuscarTipo.DataBind();
        }

        public void mtdCargarCiudad()
        {
            DataSet dsCiudad = new DataSet();
            dsCiudad = miServicio.mtdListarCiudad();
            int C = dsCiudad.Tables["tblDatos"].Rows.Count;

            cmbBuscarCiudad.DataSource = dsCiudad.Tables["tblDatos"];
            cmbBuscarCiudad.DataTextField = "Ciudad";
            cmbBuscarCiudad.DataValueField = "IdCiudad";
            cmbBuscarCiudad.DataBind();
        }

        public void mtdCargarCategoria()
        {
            DataSet dsCategoria = new DataSet();
            dsCategoria = miServicio.mtdListarCategoria();
            int C = dsCategoria.Tables["tblDatos"].Rows.Count;

            cmbBuscarCategoria.DataSource = dsCategoria.Tables["tblDatos"];
            cmbBuscarCategoria.DataTextField = "Categoria";
            cmbBuscarCategoria.DataValueField = "IdCategoria";
            cmbBuscarCategoria.DataBind();
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            DataSet dsListar = new DataSet();
            ServicioW.clPublicacion objPublicacion = new ServicioW.clPublicacion();
            objPublicacion.IdTipo = int.Parse(cmbBuscarTipo.SelectedValue.ToString());
            objPublicacion.IdCiudad = int.Parse(cmbBuscarCiudad.SelectedValue.ToString());
            objPublicacion.IdCategoria = int.Parse(cmbBuscarCategoria.SelectedValue.ToString());
            dsListar = miServicio.mtdListarPublicaciones2(objPublicacion);
            DataList1.DataSource = dsListar;
            DataList1.DataBind();
        }

        protected void btnVerDetalles_Click(object sender, EventArgs e)
        {
            
        }

        protected void DataList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}