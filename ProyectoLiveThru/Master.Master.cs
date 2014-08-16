using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoLiveThru
{
    public partial class Master : System.Web.UI.MasterPage
    {
       public static Negocio.BO.UsuarioArtistaOrganizador ousuario;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["oUsuario"] == null)
            {
                Response.Redirect("/Login/default.aspx");
            }
            else
            {
                ousuario = (Negocio.BO.UsuarioArtistaOrganizador)Session["oUsuario"];
                lblUsuario.Text = ousuario.nombre;
                userImgPerfil.Src = ousuario.imagen;
                lblNombreUsuario.Text = ousuario.nombre;
                //getPerfilArtista();
            }
            //generosGetAll();
        }

        public void getPerfilArtista()
        {
            Literal l1 = new Literal();

            l1.Text = " <li class=\"dropdown\"> " +
                      " <a href=\"#\" class=\"dropdown-toggle\" data-toggle=\"dropdown\"> " +
                      " <span class=\"thumb-sm avatar pull-right m-t-n-sm m-b-n-sm m-l-sm hidden-xs\"> <img src=\""+ousuario.imagen+"\" alt=\"Amperion\" style=\"max-width: 40px; max-height: 40px\"> </span> " +
                      " <b class=\"caret\"></b> " +
                      " </a> " +
                      " <section class=\"dropdown-menu aside-xl animated fadeInUp\"> " +
                      " <section class=\"panel bg-white\"> " +
                      " <div class=\"panel-heading b-light bg-light\"> <strong>"+ousuario.nombre+"</strong> " +
                      " </div> " +
                      " <div class=\"list-group list-group-alt\"> "+
                      " <a href=\"/UsuarioArtistaOrganizadorModificar.aspx\" class=\"media list-group-item\"> " +
                      " <span class=\"media-body block m-b-none\">Mi Perfil " +
                      " <br> " +
                      " </span> " +
                      " </a> " +
                      " </div> " +
                      " <div class=\"list-group list-group-alt\"> " +
                      " <a href=\"/Login/default.aspx\" class=\"media list-group-item\"> " +
                      " <span class=\"media-body block m-b-none\">Salir " +
                      " <br> " +
                      " </span> " +
                      " </a> " +
                      " </div> " +
                      " </section> " +
                      " </section> " +
                      " </li> ";
            //idPanelPerfil.Controls.Add(l1);
        }
        /*public void generosGetAll()
        {
            List<Negocio.BO.Genero> lGenero = new List<Negocio.BO.Genero>();
            Negocio.Services.Genero servicesGenero = new Negocio.Services.Genero();

            lGenero = servicesGenero.GetAllObjetc();

            foreach (Negocio.BO.Genero item in lGenero)
            {
                Literal l1 = new Literal();
                Literal l2 = new Literal();
                Literal l3 = new Literal();
                Literal l4 = new Literal();
                Literal l5 = new Literal();
                Literal l6 = new Literal();
                Literal l7 = new Literal();

                l1.Text = "<div class=\"list-group list-group-alt\"> \n";
                l2.Text = "<a href=\"/Generos.aspx\" class=\"media list-group-item\"> \n";
                l3.Text = "<span class=\"media-body block m-b-none\">"+item.nombre+" \n";
                //l4.Text = "<br>";
                l5.Text = "</span> \n";
                l6.Text = "</a> \n";
                l7.Text = "</div> \n";

                idPanelListadoGenero.Controls.Add(l1);
                idPanelListadoGenero.Controls.Add(l2);
                idPanelListadoGenero.Controls.Add(l3);
                //idPanelListadoGenero.Controls.Add(l4);
                idPanelListadoGenero.Controls.Add(l5);
                idPanelListadoGenero.Controls.Add(l6);
                idPanelListadoGenero.Controls.Add(l7);
            }*/
        }
    }
