using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoLiveThru.Login
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Session.Clear();
                Session.Abandon();
            }
        }

        protected void btnAcceder_Click(object sender, EventArgs e)
        {
            try
            {
                Negocio.Services.UsuarioEstandar usuarioEstandarServices = new Negocio.Services.UsuarioEstandar();
                Negocio.Services.UsuarioArtistaOrganizador usuarioArtistaOrganizadorServices = new Negocio.Services.UsuarioArtistaOrganizador();
                 
                if (txtUsuario.Text.Trim().Length == 0 || txtPassword.Text.Trim().Length == 0)
                {
                    string display = "Campos vacios, verifíque";
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "myalert", "alert('" + display + "');", true);
                }
                else
                {
                    try
                    {
                        Negocio.BO.UsuarioEstandar oUsuarioEstandar = new Negocio.BO.UsuarioEstandar();
                        oUsuarioEstandar.usuario = txtUsuario.Text.Trim();
                        oUsuarioEstandar.contrasenia = txtPassword.Text.Trim();

                        oUsuarioEstandar = usuarioEstandarServices.login(oUsuarioEstandar);
                        if (oUsuarioEstandar.id != 0)
                        {
                            Session["oUsuario"] = oUsuarioEstandar;
                            Session.Add("usuID", oUsuarioEstandar.id);
                            Response.Redirect("../UsuarioEstandarModificar.aspx");

                        }
                        else
                        {
                            Negocio.BO.UsuarioArtistaOrganizador oUsuarioArtistaOrganizador = new Negocio.BO.UsuarioArtistaOrganizador();
                            oUsuarioArtistaOrganizador.usuario = txtUsuario.Text.Trim();
                            oUsuarioArtistaOrganizador.contrasenia = txtPassword.Text.Trim();
                            oUsuarioArtistaOrganizador = usuarioArtistaOrganizadorServices.login(oUsuarioArtistaOrganizador);

                            if (oUsuarioArtistaOrganizador.id != 0)
                            {
                                Session["oUsuario"] = oUsuarioArtistaOrganizador;
                                Session.Add("usuID", oUsuarioArtistaOrganizador.id);
                                Response.Redirect("../UsuarioArtistaOrganizadorModificar.aspx");
                            }
                            else
                            {
                                string display = "El usuario ingresado no existe!";
                                ScriptManager.RegisterStartupScript(this, this.GetType(), "myalert", "alert('" + display + "');", true);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "myalert", "alert('" + ex.Message.ToString() + "');", true);
                    }
                }
            }
            catch (System.Exception ex)
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "myalert", "alert('" + ex.Message.ToString() + "');", true);
            }
        }
    }
}