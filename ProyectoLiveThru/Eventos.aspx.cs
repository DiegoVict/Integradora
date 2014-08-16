using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoLiveThru
{
    public partial class Eventos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            getAllEventos();
        }

        public void getAllEventos()
        {
            List<Negocio.BO.Evento> lEvento = new List<Negocio.BO.Evento>();
            Negocio.Services.Evento eventoServices = new Negocio.Services.Evento();

            lEvento = eventoServices.GetAllObjetc();

            foreach (Negocio.BO.Evento item in lEvento)
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
                Literal l19 = new Literal();
                Literal l20 = new Literal();
                Literal l21 = new Literal();
                Literal l22 = new Literal();
                Literal l23 = new Literal();
                Literal l24 = new Literal();
                Literal l25 = new Literal();
                Literal l26 = new Literal();

                l1.Text = "<div class=\"post-item\">";
                l2.Text = "<div class=\"post-media\">";
                l3.Text = "<img src=\"" + item.imagen + " \" class=\"img-full\"></div>";
                l4.Text = "<div class=\"caption wrapper-lg\">";
                l5.Text = "<h2 class=\"post-title\">";
                l6.Text = "<a href=\"#\">"+item.nombre+"</a>";
                l7.Text = "</h2>";
                l8.Text = "<div class=\"post-sum\">";
                l9.Text = "<p>";
                l10.Text = item.descripcion;
                l11.Text = "</p>";
                l12.Text = "</div>";
                l13.Text = "<div class=\"line line-lg\"></div>";
                l14.Text = "<div class=\"text-muted\">";
                l15.Text = "<i class=\"fa fa-user icon-muted\"></i>";
                l16.Text = "by ";
                l17.Text = "<a href=\"#\" class=\"m-r-sm\">"+item.id_organizador.nombre+"</a>";
                l18.Text = "<i class=\"fa fa-clock-o icon-muted\"></i>";
                l19.Text = " " + item.fecha.ToShortDateString() + " " + item.fecha.ToShortTimeString();
                l20.Text = "<a href=\"#\" class=\"m-l-sm\">";
                l21.Text = "<i class=\"fa fa-comment-o icon-muted\"></i>";
                l22.Text = " 0 comments";
                l23.Text = "</a>";
                l24.Text = "</div>";
                l25.Text = "</div>";
                l26.Text = "</div>";

                idPanelEvento.Controls.Add(l1);
                idPanelEvento.Controls.Add(l2);
                idPanelEvento.Controls.Add(l3);
                idPanelEvento.Controls.Add(l4);
                idPanelEvento.Controls.Add(l5);
                idPanelEvento.Controls.Add(l6);
                idPanelEvento.Controls.Add(l7);
                idPanelEvento.Controls.Add(l8);
                idPanelEvento.Controls.Add(l9);
                idPanelEvento.Controls.Add(l10);
                idPanelEvento.Controls.Add(l11);
                idPanelEvento.Controls.Add(l12);
                idPanelEvento.Controls.Add(l13);
                idPanelEvento.Controls.Add(l14);
                idPanelEvento.Controls.Add(l15);
                idPanelEvento.Controls.Add(l16);
                idPanelEvento.Controls.Add(l17);
                idPanelEvento.Controls.Add(l18);
                idPanelEvento.Controls.Add(l19);
                idPanelEvento.Controls.Add(l20);
                idPanelEvento.Controls.Add(l21);
                idPanelEvento.Controls.Add(l22);
                idPanelEvento.Controls.Add(l23);
                idPanelEvento.Controls.Add(l24);
                idPanelEvento.Controls.Add(l25);
                idPanelEvento.Controls.Add(l26);
            }
        }
    }
}