using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace web
{
    public partial class Formulario_web1 : System.Web.UI.Page
    {
        ServicioW.ServicioSoapClient miServicio = new ServicioW.ServicioSoapClient();

       protected void Page_Load(object sender, EventArgs e)
        {
            DataSet dsListar = new DataSet();
            ServicioW.clPublicacion objPublicacion = new ServicioW.clPublicacion();
            dsListar = miServicio.mtdListarPublicacion();
            DataList1.DataSource = dsListar;
            DataList1.DataBind();
        }
    }
}