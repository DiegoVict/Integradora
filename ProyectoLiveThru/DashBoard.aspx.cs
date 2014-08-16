using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoLiveThru
{
    public partial class DashBoard : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAdminContacto_Click(object sender, EventArgs e)
        {
            Response.Redirect("PrincipalUsuarioContacto.aspx");
        }

        protected void btnModoPerfilPublico_Click(object sender, EventArgs e)
        {
            Response.Redirect("perfilArtista.aspx?Id=1");
        }

        protected void btnAdminEvento_Click(object sender, EventArgs e)
        {
            Response.Redirect("GestorEvento.aspx");
        }

        protected void btnAdminSeguidor_Click(object sender, EventArgs e)
        {

        }

        protected void btnAdminPerfil_Click(object sender, EventArgs e)
        {
            Response.Redirect("UsuarioArtistaOrganizadorModificar.aspx");
        }
    }
}