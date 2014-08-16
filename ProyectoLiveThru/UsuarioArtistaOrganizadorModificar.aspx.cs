using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoLiveThru
{
    public partial class UsuarioArtistaOrganizadorModificar : System.Web.UI.Page
    {
        public static Negocio.BO.UsuarioArtistaOrganizador OrganizadorUsuario;
        string rutaimagen = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (Session["oUsuario"] != null)
                {
                    if (!IsPostBack)
                    {
                        OrganizadorUsuario = (Negocio.BO.UsuarioArtistaOrganizador)Session["oUsuario"];
                        //int id = OrganizadorUsuario.id;
                        cargarUsuario(OrganizadorUsuario.id);
                    }
                }
            }
            catch (Exception ex)
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "myalert", "alert('" + ex.Message.ToString() + "');", true);
            }
        }

        public void cargarTipo()
        {
            Negocio.Services.UsuarioTipo oUsuTipo = new Negocio.Services.UsuarioTipo();
            DropDownList1.DataSource = oUsuTipo.GetAll();
            DropDownList1.DataValueField = "id";
            DropDownList1.DataTextField = "tipo";
            DropDownList1.DataBind();
        }

        public void cargarGenero()
        {
            Negocio.Services.Genero oGen = new Negocio.Services.Genero();
            ddlGenero.DataSource = oGen.GetAll();
            ddlGenero.DataValueField = "id";
            ddlGenero.DataTextField = "nombre";
            ddlGenero.DataBind();
        }
        
        public void cargarUsuario(int id)
        {
            Negocio.Services.UsuarioArtistaOrganizador usuAOCTRL = new Negocio.Services.UsuarioArtistaOrganizador();
            Negocio.BO.UsuarioArtistaOrganizador usuBO = new Negocio.BO.UsuarioArtistaOrganizador();
            usuBO = usuAOCTRL.GetOne(id);
            //lblID.Text = Convert.ToString(usuBO.id);
            txtUsuario.Text = usuBO.usuario;
            txtContrasenia.Text = usuBO.contrasenia;
            txtCorreo.Text = usuBO.correo;
            txtTwitter.Text = usuBO.twitter;
            txtFacebook.Text = usuBO.facebook;
            txtYoutube.Text = usuBO.youtube;
            txtNombre.Text = usuBO.nombre;
            txtDescripcion.Text = usuBO.descripcion;
            cargarTipo();
            DropDownList1.SelectedValue = usuBO.id_tipo.id.ToString();
            cargarGenero();
            ddlGenero.SelectedValue = usuBO.id_genero.id.ToString();
            Image1.ImageUrl = usuBO.imagen;
            lblStatus.Text = usuBO.imagen;
            lblStatus.Visible = true;
            rutaimagen = usuBO.imagen; 
        }

        public bool validarCampos()
        {
            bool paso = false;
            if (txtUsuario.Text.Trim() == "" || txtContrasenia.Text.Trim() == "" || txtCorreo.Text.Trim() == "" || txtTwitter.Text.Trim() == "" || txtFacebook.Text.Trim() == "" || txtYoutube.Text.Trim() == "" || txtNombre.Text.Trim() == "" || txtDescripcion.Text.Trim() == "" )
            {
                paso = false;
            }
            else paso = true;
            return paso;
        }

        void SaveFile()
        {
            Boolean fileOk = false;
            String path = Server.MapPath("~/Images/Usuarios/");

            if (fupImagen.HasFile)
            {
                String fileExtension = System.IO.Path.GetExtension(fupImagen.FileName).ToLower();
                String[] allowedExtensions = { ".gif", ".png", ".jpeg", ".jpg" };
                for (int i = 0; i < allowedExtensions.Length; i++)
                {
                    if (fileExtension == allowedExtensions[i])
                    {
                        fileOk = true;
                    }
                }

                if (fileOk)
                {
                    try
                    {
                        rutaimagen = path + fupImagen.FileName;
                        string fileName = fupImagen.FileName;
                        string tempfileName = "";
                        if (System.IO.File.Exists(rutaimagen))
                        {
                            int counter = 2;
                            while (System.IO.File.Exists(rutaimagen))
                            {
                                // if a file with this name already exists,
                                // prefix the filename with a number.
                                tempfileName = counter.ToString() + fileName;
                                rutaimagen = path + tempfileName;
                                counter++;
                            }
                        }
                        fupImagen.PostedFile.SaveAs(rutaimagen);
                        Image1.ImageUrl = rutaimagen;
                    }
                    catch (Exception ex)
                    {
                        lblImagen.Text = "No se pudo subir la imagen " + ex.Message.ToString();
                    }
                }
                else
                {
                    lblImagen.Text = "No se aceptan archivos de este tipo";
                }
            }
        }

        public void llenarDatos()
        {
            if (validarCampos())
            {
                try
                {
                    Negocio.BO.UsuarioArtistaOrganizador oUsuarioAO = new Negocio.BO.UsuarioArtistaOrganizador();
                    oUsuarioAO.id = OrganizadorUsuario.id;
                    oUsuarioAO.usuario = txtUsuario.Text.Trim();
                    oUsuarioAO.contrasenia = txtContrasenia.Text.Trim();
                    oUsuarioAO.correo = txtCorreo.Text.Trim();
                    oUsuarioAO.twitter = txtTwitter.Text.Trim();
                    oUsuarioAO.facebook = txtFacebook.Text.Trim();
                    oUsuarioAO.youtube = txtYoutube.Text.Trim();
                    oUsuarioAO.id_tipo.id = Convert.ToInt32(DropDownList1.SelectedValue);
                    oUsuarioAO.nombre = txtNombre.Text.Trim();
                    oUsuarioAO.descripcion = txtDescripcion.Text.Trim();
                    oUsuarioAO.id_genero.id = Convert.ToInt32(ddlGenero.SelectedValue);

                    if (fupImagen.HasFile)
                    {
                        oUsuarioAO.imagen = "/Images/Usuarios/" + fupImagen.FileName.ToString();
                    }
                    else
                    {
                        oUsuarioAO.imagen = OrganizadorUsuario.imagen;
                    }

                    
                    Session["oUsuario"] = oUsuarioAO;
                    Negocio.Services.UsuarioArtistaOrganizador oUsuAOCtrl = new Negocio.Services.UsuarioArtistaOrganizador();

                    oUsuAOCtrl.Update(oUsuarioAO);
                    cargarUsuario(OrganizadorUsuario.id);

                    string display = "Usuario Registrado Correctamente!";
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "myalert", "alert('" + display + "');", true);
                }
                catch
                {
                    throw;
                }
            }
            else
            {
                string display = "Favor de llenar todos los campos";
                ScriptManager.RegisterStartupScript(this, this.GetType(), "myalert", "alert('" + display + "');", true);
            }
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            SaveFile();
            llenarDatos();
        }

        protected void btnAdminContacto_Click(object sender, EventArgs e) 
        {
            Response.Redirect("PrincipalUsuarioContacto.aspx");
        }

        protected void btnModoPerfilPublico_Click(object sender, EventArgs e)
        {
            Response.Redirect("perfilArtista.aspx?Id="+OrganizadorUsuario.id+"");
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

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Index.aspx");
        }
    }
}