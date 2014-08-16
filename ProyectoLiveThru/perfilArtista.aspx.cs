using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoLiveThru
{
    public partial class perfilArtista : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string id = Request.QueryString["Id"];
            int idArtista = Convert.ToInt32(id);
            getInformacionArtista(idArtista);
        }

        public void getInformacionArtista(int idArtista)
        {
            Negocio.BO.UsuarioArtistaOrganizador oUsuarioArtistaOrganizador = new Negocio.BO.UsuarioArtistaOrganizador();
            //List<Negocio.BO.UsuarioArtistaOrganizador> lUsuarioArtistaOrganizador = new List<Negocio.BO.UsuarioArtistaOrganizador>();
            Negocio.Services.UsuarioArtistaOrganizador usuarioArtistaOrganizadorServices = new Negocio.Services.UsuarioArtistaOrganizador();

            List<Negocio.BO.Evento> lEvento = new List<Negocio.BO.Evento>();
            Negocio.Services.Evento eventoServices = new Negocio.Services.Evento();

            List<Negocio.BO.UsuarioContacto> lUsuarioContacto = new List<Negocio.BO.UsuarioContacto>();
            Negocio.Services.UsuarioContacto usuarioContactoServices = new Negocio.Services.UsuarioContacto();

            List<Negocio.BO.UsuarioArtistaSeguir> lUsuarioArtistaSeguir = new List<Negocio.BO.UsuarioArtistaSeguir>();
            Negocio.Services.UsuarioArtistaSeguir usuarioArtistaSeguirServices = new Negocio.Services.UsuarioArtistaSeguir();


            
            /***Historia***/
            oUsuarioArtistaOrganizador = usuarioArtistaOrganizadorServices.artistaGetOne(idArtista);

            Literal lHistoria1 = new Literal();
            Literal lHistoria2 = new Literal();
            Literal lHistoria3 = new Literal();



            //Nombre Artista
            lHistoria1.Text = "<div class=\"col-md-4\"> " +
                              "<h3>Artista\\Banda : <b>"+oUsuarioArtistaOrganizador.nombre+"</b></h3>"+
                                "</div>";

            // Redes Sociales
            lHistoria2.Text = "<div class=\"col-md-8\">" +
                        "<div id=\"social-buttons\">" +
                            "<a class=\"btn btn-default\" data-toggle=\"button\">" +
                                "<span class=\"text\"> <i class=\"fa fa-thumbs-down text-danger\"></i></span>" +
                                "<span class=\"text-active\"> <i class=\"fa fa-thumbs-up text-success\"></i></span>" +
                            "</a>" +
                            "<a href=\"" + oUsuarioArtistaOrganizador.facebook + "\" class=\"btn btn-rounded btn-sm btn-primary\"> <i class=\"fa fa-fw fa-facebook\"></i>Facebook    </a>" +
                            "<a href=\"" + oUsuarioArtistaOrganizador.facebook + "\" class=\"btn btn-rounded btn-sm btn-info\"> <i class=\"fa fa-fw fa-twitter\"></i>Twitter    </a>" +
                            "<a href=\"" + oUsuarioArtistaOrganizador.facebook + "\" class=\"btn btn-rounded btn-sm btn-danger\"><i class=\"fa fa-fw fa-youtube\"></i>YouTube    </a>" +
                            "<a href=\"" + oUsuarioArtistaOrganizador.facebook + "\" class=\"btn btn-rounded btn-sm btn-success\"><i class=\"fa fa-fa\"></i>Compartir...    </a>" +
                            " </div> </div> "+
                            "<div class=\"col-md-12\"></div>";
            //Inicio Perfil
            lHistoria3.Text = "<div class=\"col-md-4\">" +
                              "<section class=\"panel panel-default\">" +
                              "<div class=\"panel-body\">" +
                              "<div class=\"clearfix text-center m-t\">" +
                              "<div class=\"inline\">" +
                              "<div class=\"r r-2x img-full\">" +
                              "<img src=\"" + oUsuarioArtistaOrganizador.imagen + "\" class=\"\" alt=\"...\" Width =\"300\" Height =\"400\"></div>" +
                              "</div> </div> </div>" +
                              "<footer class=\"panel-footer bg-info text-center\">" +
                              "<div class=\"row pull-out\">" +
                              "<div class=\"col-xs-6\">" +
                              "<div class=\"padder-v\">" +
                //aqui se debe hacer el count para ver cuando seguidores tiene (PENDIENTE)
                              "<span class=\"m-b-xs h3 block text-white\">245</span>" +
                              "<small class=\"text-muted\">Seguidores</small>" +
                              "</div>" +
                              "</div>" +
                              "<div class=\"col-xs-6\">" +
                              "<div class=\"padder-v\">" +
                // AQUI PONER LA CANTIDAD DE EVENTOS CREADOS POR EL ARTISTA (PENDIENTE)
                              "<span class=\"m-b-xs h3 block text-white\">3</span>" +
                              "<small class=\"text-muted\">Eventos</small>" +
                              "</div>" +
                              "</div>" +
                              "</div>" +
                              "</footer>" +
                              "</section>" +
                              "</div>"+
            				  "<div class=\"col-md-8\">"+
                              oUsuarioArtistaOrganizador.descripcion +
                              "</div>";

            idPanelHistoria.Controls.Add(lHistoria1);
            idPanelHistoria.Controls.Add(lHistoria2);
            idPanelHistoria.Controls.Add(lHistoria3);
                              
            /***Eventos***/
            lEvento = eventoServices.GetObjetc(7, idArtista.ToString());

            foreach (Negocio.BO.Evento item in lEvento)
            {
                Literal literalEvento = new Literal();
                literalEvento.Text = "<article class=\"media\">" +
                                "<div class=\"pull-left\">" +
                                "<span>" +
                                "<img src=\"" + item.imagen + "\" class=\"\" alt=\"...\" style=\"width:100px\">" +
                                "</span>" +
                                "</div>" +
                                "<div class=\"media-body\"> " +
                                "<a href=\"#\" class=\"h4 text-success\">" + item.nombre + "</a>" +
                                "<small class=\"block m-t-xs\">" + item.descripcion + "</small>" +
                                "<em class=\"text-xs\">" +
                                "Creado Por <b>" + item.id_organizador.nombre   + "</b> , <span class=\"text-danger\">   " + item.fecha.ToLongDateString() + " - " + item.fecha.ToShortTimeString() + "</span></em>" +
                                "</div>" +
                                "</article>" +
                                "<div class=\"line pull-in\">" +
                                "</div>";
                idPanelEvento.Controls.Add(literalEvento);
            }

            /***Discografia-Por definir***/

            /***Contacto***/
            lUsuarioContacto = usuarioContactoServices.GetObjetc(8, idArtista.ToString());
            //esta literal es solo para cerrar el row
            Literal literalContacto = new Literal();
            int contador = 0;

            string htmlContacto = "";
            for(int i=0;i<lUsuarioContacto.Count;i++)
            {

                //Literal literalContacto = new Literal();
                //string nombreContacto = lUsuarioContacto[i].nombre + " " + lUsuarioContacto[i].apellido_pat + " " + lUsuarioContacto[i].apellido_mat ;
                if(lUsuarioContacto.Count==1)
                {
                    htmlContacto += "<div class=\"row\">" +
                      "<div class=\"col-md-12\">" +
                      "<div class=\"col-xs-6\"> <strong>" + lUsuarioContacto[i].descripcion + "</strong>" +
                      "<h4>" + lUsuarioContacto[i].nombre + "</h4>" +
                      "<p>" +
                      "<b>Teléfono :</b> " + lUsuarioContacto[i].telefono + "" +
                      "<br>" +
                      "<b>Email :</b> " + lUsuarioContacto[i].correo + "" +
                      "</p>" +
                      "</div>" +
                      "</div>" +
                      "</div>";
                    //idPanelContacto.Controls.Add(literalContacto);
                }
                else
                {
                    if (contador == 0)
                    {
                        contador++;

                        htmlContacto += "<div class=\"row\">" +
                                        "<div class=\"col-md-12\">" +
                                              "<div class=\"col-xs-6\"> <strong>" + lUsuarioContacto[i].descripcion + "</strong>" +
                                              "<h4>" + lUsuarioContacto[i].nombre + "</h4>" +
                                              "<p>" +
                                              "<b>Teléfono :</b> " + lUsuarioContacto[i].telefono + "" +
                                              "<br>" +
                                              "<b>Email :</b> " + lUsuarioContacto[i].correo + "" +
                                              "</p>" +
                                              "</div>";
                        if (i + 1 == lUsuarioContacto.Count)
                        {
                            htmlContacto += "</div> </div>";
                        }
                        else
                        {

                        }
                        //idPanelContacto.Controls.Add(literalContacto);
                    }
                    else
                    {
                        contador = 0;
                        htmlContacto +=  "<div class=\"col-xs-6\"> <strong>" + lUsuarioContacto[i].descripcion + "</strong>" +
                                              "<h4>" + lUsuarioContacto[i].nombre + "</h4>" +
                                              "<p>" +
                                              "<b>Teléfono :</b> " + lUsuarioContacto[i].telefono + "" +
                                              "<br>" +
                                              "<b>Email :</b>" + lUsuarioContacto[i].correo + "" +
                                              "</p>" +
                                              "</div> </div> </div>";
                        //idPanelContacto.Controls.Add(literalContacto);
                    }
                }
            }

            literalContacto.Text =  htmlContacto;
            idPanelContacto.Controls.Add(literalContacto);

            /***Seguidores***/

            lUsuarioArtistaSeguir = usuarioArtistaSeguirServices.GetObjetc(0, idArtista.ToString());

            foreach (Negocio.BO.UsuarioArtistaSeguir item in lUsuarioArtistaSeguir)
            {
                Literal literalSeguidor = new Literal();

                literalSeguidor.Text = " <div class=\"col-xs-6 col-sm-4 col-md-4 col-lg-3\"> " +
                                       " <div class=\"item\"> " +
                                       " <div class=\"pos-rlt\"> " +
                                       " <a href=\"#\"><img src=\"" + item.id_usuario_estandar.imagen + "\" width=\"200\" height=\"300\" alt=\"\" class=\"r r-2x img-full\"></a> " +
                                       " </div> " +
                                       " <div class=\"padder-v\"> " +
                                       " <a href=\"#\" class=\"text-ellipsis\">" + item.id_usuario_estandar.usuario + "</a>" +
                                       " <a href=\"" + item.id_usuario_estandar.facebook + "\" target=\"_blank\" class=\"text-ellipsis text-xs text-muted\">Sigueme en Facebook!</a> " +
                                       " </div> " +
                                       " </div> " +
                                       " </div> ";
                idPanelSeguidor.Controls.Add(literalSeguidor);
            }


            //idPanelHistoria.Controls.Add(lHistoria4);
        }
    }
}