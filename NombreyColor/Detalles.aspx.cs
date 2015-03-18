using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NombreyColor
{
    public partial class Detalles : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var c = Request.Cookies["nombre"];
            lblResNombre.Text = String.Format("{0}", c.Value);
            var v = Request.Cookies["color"];
            lblResColor.Text = String.Format("{0}", v.Value);

            lblFecha.Text = Application["Ultima_conexion"].ToString();
        }
    }
}