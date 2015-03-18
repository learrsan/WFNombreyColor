using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NombreyColor
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var c = Request.Cookies["nombre"];

            if (c != null)
            {

                Response.Redirect("Detalles.aspx");
            }

            var v = Request.Cookies["color"];

            if (v != null)
            {


                Response.Redirect("Detalles.aspx");
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            var c = new HttpCookie("nombre");
            c.Value = txtNombre.Text;
            c.Expires = DateTime.Now.AddMonths(1);

            Response.Cookies.Add(c);

           
            var v = new HttpCookie("color");
            v.Value = txtColor.Text;
            v.Expires = DateTime.Now.AddMonths(1);

            Response.Cookies.Add(v);

            
            Response.Redirect("Detalles.aspx");
        }
    }
}