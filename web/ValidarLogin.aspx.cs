﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace web
{
    public partial class Formulario_web1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string usu = Request.Form["txtusuarioo"];
            string con = Request.Form["txtcontrasena"];
            ServicioW.ServicioSoapClient mi = new ServicioW.ServicioSoapClient();
            int res = mi.Login(usu, con);
            if (res > 0)
            {
                Session["Usuario"] = usu;
                Session["Contrasena"] = con; 
                Application["IdUsuario"] = res;
                Response.Redirect("index.aspx"); 
            }
            else
            {
                Response.Redirect("PruebaLogin3SinMaster.aspx");
            }
            
        }
    }
}