using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoLiveThru
{
    public partial class Descubrir : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            getAllNewArtistas();
        }

        public void getAllNewArtistas()
        {
            Negocio.BO.UsuarioArtistaOrganizador oUsuarioArtistaOrganizador = new Negocio.BO.UsuarioArtistaOrganizador();
            List<Negocio.BO.UsuarioArtistaOrganizador> loUsuarioArtistaOrganizador = new List<Negocio.BO.UsuarioArtistaOrganizador>();
            Negocio.Services.UsuarioArtistaOrganizador servicesUsuarioArtistaOrganizador = new Negocio.Services.UsuarioArtistaOrganizador();

            loUsuarioArtistaOrganizador = servicesUsuarioArtistaOrganizador.GetAllObject();

            foreach (Negocio.BO.UsuarioArtistaOrganizador item in loUsuarioArtistaOrganizador)
            {
                Literal l1 = new Literal();
                Literal l2 = new Literal();
                Literal l3 = new Literal();
                Literal l4 = new Literal();
                Literal l5 = new Literal();
                Literal l6 = new Literal();
                Literal l7 = new Literal();
                Literal l8 = new Literal();
                Literal l9 = new Literal();
                Literal l10 = new Literal();
                Literal l11 = new Literal();

                l1.Text = "<div class=\"col-xs-6 col-sm-4 col-md-4 col-lg-3\">";
                l2.Text = "<div class=\"item\">";
                l3.Text = "<div class=\"pos-rlt\">";
                l4.Text = "<a href=\"perfilArtista.aspx?Id=" + item.id + "\"><img src=\"" + item.imagen + " \" alt=\"\" class=\"r r-2x img-full\" Width =\"150\" Height =\"350\"></a>";
                l5.Text = "</div>";
                l6.Text = "<div class=\"padder-v\">";
                //aqui ponerle el aspx donde mandara
                l7.Text = "<a href=\"perfilArtista.aspx?Id=" + item.id + "\" class=\"text-ellipsis\">" + item.nombre + "</a>";
                l8.Text = "<a href=\"" + item.facebook + " \" target=\"_blank\" class=\"text-ellipsis text-xs text-muted\">Sigueme en Facebook!</a>";
                l9.Text = "</div>";
                l10.Text = "</div>";
                l11.Text = "</div>";

                idPanelDescubrir.Controls.Add(l1);
                idPanelDescubrir.Controls.Add(l2);
                idPanelDescubrir.Controls.Add(l3);
                idPanelDescubrir.Controls.Add(l4);
                idPanelDescubrir.Controls.Add(l5);
                idPanelDescubrir.Controls.Add(l6);
                idPanelDescubrir.Controls.Add(l7);
                idPanelDescubrir.Controls.Add(l8);
                idPanelDescubrir.Controls.Add(l9);
                idPanelDescubrir.Controls.Add(l10);
                idPanelDescubrir.Controls.Add(l11);
            }
        }
    }
}