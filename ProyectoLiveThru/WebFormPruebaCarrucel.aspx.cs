using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoLiveThru
{
    public partial class WebFormPruebaCarrucel : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string idfoto = Request.QueryString["IdFoto"];
            //TraeInfo(Convert.ToInt32(idfoto));
        }
    }
}