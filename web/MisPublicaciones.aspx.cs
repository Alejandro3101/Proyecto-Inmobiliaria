using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace web
{
    public partial class Formulario_web114 : System.Web.UI.Page
    {

        ServicioW.ServicioSoapClient miServicio = new ServicioW.ServicioSoapClient();
        protected void Page_Init(object sender, EventArgs e)
        {
            mtdCargarCategoria();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            
            DataSet dsListar = new DataSet();
            ServicioW.clPublicacion objPublicacion = new ServicioW.clPublicacion();
            objPublicacion.IdUsuario = int.Parse(Application["IdUsuario"].ToString());
            dsListar = miServicio.mtdListarPublicacionesU(objPublicacion);
            GridView1.DataSource = dsListar;
            GridView1.DataBind();
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
            objPublicacion.IdTipo = int.Parse(cmbBuscarCategoria.SelectedValue.ToString());
            dsListar = miServicio.mtdListarPublicacionesU2(objPublicacion);
            GridView1.DataSource = dsListar;
            GridView1.DataBind();
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int pos = GridView1.SelectedIndex;
            String Valor = GridView1.Rows[pos].Cells[1].Text;

        }
    }
}