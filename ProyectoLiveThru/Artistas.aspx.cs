using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoLiveThru
{
    public partial class Artistas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                string id = Request.QueryString["Id"];
                int idGenero = Convert.ToInt32(id);

                getAllArtistas(idGenero);
                //getAllArtistas();
            }
            catch (Exception ex)
            {
                string mensaje = ex.Message.ToString();
            }
        }

        public void getAllArtistas(int idGenero)
        {
            /* Negocio.BO.UsuarioArtistaOrganizador oUsuarioArtistaOrganizador = new Negocio.BO.UsuarioArtistaOrganizador();
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
                 Literal l12 = new Literal();
                 Literal l13 = new Literal();
                 Literal l14 = new Literal();
                 Literal l15 = new Literal();
                 Literal l16 = new Literal();
                 Literal l17 = new Literal();
                 Literal l18 = new Literal();

                 l1.Text ="<div class=\"col-xs-6 col-sm-4 col-md-3 col-lg-2\">";
                 l2.Text ="<div class=\"item\">";
                 l3.Text ="<div class=\"pos-rlt\">";
                 l4.Text ="<div class=\"item-overlay opacity r r-2x bg-black\">";
                 l5.Text ="<div class=\"center text-center m-t-n\">";
                 l6.Text ="<a href=\"#\"> <i class=\"fa fa-play-circle i-2x\"></i>";
                 l7.Text ="</a>";
                 l8.Text ="</div>";
                 l9.Text ="</div>";
                 //aqui ponerle el aspx donde mandara
                 l10.Text ="<a href=\"track-detail.html\">";
                 l11.Text ="<img src=\""+item.imagen+"\" alt=\"\" class=\"r r-2x img-full\"></a>";
                 l12.Text ="</div>";
                 l13.Text ="<div class=\"padder-v\">";
                 l14.Text ="<a href=\"track-detail.html\" data-bjax=\"\" data-target=\"#bjax-target\" data-el=\"#bjax-el\" data-replace=\"true\" class=\"text-ellipsis\">"+item.nombre+"</a>";
                 l15.Text ="<a href=\""+item.facebook+"\" target=\"_blank\" data-bjax=\"\" data-target=\"#bjax-target\" data-el=\"#bjax-el\" data-replace=\"true\" class=\"text-ellipsis text-xs text-muted\">Join us! on Facebook</a>";
                 l16.Text = "</div>";
                 l17.Text = "</div>";
                 l18.Text = "</div>";

                 idPanelArtistas.Controls.Add(l1);
                 idPanelArtistas.Controls.Add(l2);
                 idPanelArtistas.Controls.Add(l3);
                 idPanelArtistas.Controls.Add(l4);
                 idPanelArtistas.Controls.Add(l5);
                 idPanelArtistas.Controls.Add(l6);
                 idPanelArtistas.Controls.Add(l7);
                 idPanelArtistas.Controls.Add(l8);
                 idPanelArtistas.Controls.Add(l9);
                 idPanelArtistas.Controls.Add(l10);
                 idPanelArtistas.Controls.Add(l11);
                 idPanelArtistas.Controls.Add(l12);
                 idPanelArtistas.Controls.Add(l13);
                 idPanelArtistas.Controls.Add(l14);
                 idPanelArtistas.Controls.Add(l15);
                 idPanelArtistas.Controls.Add(l16);
                 idPanelArtistas.Controls.Add(l17);
                 idPanelArtistas.Controls.Add(l18);
             }
             * */
            Negocio.BO.UsuarioArtistaOrganizador oUsuarioArtistaOrganizador = new Negocio.BO.UsuarioArtistaOrganizador();
            List<Negocio.BO.UsuarioArtistaOrganizador> loUsuarioArtistaOrganizador = new List<Negocio.BO.UsuarioArtistaOrganizador>();
            Negocio.Services.UsuarioArtistaOrganizador servicesUsuarioArtistaOrganizador = new Negocio.Services.UsuarioArtistaOrganizador();

            loUsuarioArtistaOrganizador = servicesUsuarioArtistaOrganizador.artistaGetObject(7,idGenero.ToString());

            if (loUsuarioArtistaOrganizador.Count > 0)
            {
                lblGenero.Text = loUsuarioArtistaOrganizador[0].id_genero.nombre;
            }
            else
            {
                lblGenero.Text = "No hay Artistas aqui";
            }

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

                idPanelArtistas.Controls.Add(l1);
                idPanelArtistas.Controls.Add(l2);
                idPanelArtistas.Controls.Add(l3);
                idPanelArtistas.Controls.Add(l4);
                idPanelArtistas.Controls.Add(l5);
                idPanelArtistas.Controls.Add(l6);
                idPanelArtistas.Controls.Add(l7);
                idPanelArtistas.Controls.Add(l8);
                idPanelArtistas.Controls.Add(l9);
                idPanelArtistas.Controls.Add(l10);
                idPanelArtistas.Controls.Add(l11);
            }
        }
    }
}