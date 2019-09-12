using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using web;
using System.Net;
using System.Net.Mail;


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

        protected void btnEnviar_Click(object sender, EventArgs e)
        {

            try
            {
                MailMessage msg = new MailMessage();
                msg.From = new MailAddress(txtFrom.Text);
                msg.To.Add(txtTo.Text);
                msg.Subject = txtSubject.Text;
                msg.Body = txtMenssage.Text;
                MailAddress ms = new MailAddress(txtCopy.Text);
                msg.CC.Add(ms);
                SmtpClient sc = new SmtpClient("smpt.gmail.com");
                sc.Port = 25;
                sc.Credentials = new NetworkCredential(txtFrom.Text, txtPass.Text);
                sc.EnableSsl = true;
                sc.Send(msg);
                Response.Write("Correo Enviado");
            }
            catch (Exception ex)
            {

                Response.Write(ex.Message);
            }





        }
    }
}