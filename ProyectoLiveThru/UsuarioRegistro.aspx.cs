using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoLiveThru
{
    public partial class UsuarioRegistro : System.Web.UI.Page
    {
        public string rutaimagen = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                cargarTipo();
                cargarGenero();
            }
            
        }

        void usuarioEstandar()
        {
            lblGenero.Visible = false;
            ddlGenero.Visible = false;
            lblNacimiento.Visible = true;
            txtNacimiento.Visible = true;
            lblSexo.Visible = true;
            ddlSexo.Visible = true;
        }

        void usuarioArtistaOrganizador()
        {
            lblGenero.Visible = true;
            ddlGenero.Visible = true;
            lblNacimiento.Visible = false;
            txtNacimiento.Visible = false;
            lblSexo.Visible = false;
            ddlSexo.Visible = false;
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DropDownList1.SelectedIndex == 0)
            {
                usuarioEstandar();
            }
            else
            {
                usuarioArtistaOrganizador();
            }
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

        public bool validarCampos()
        {
            bool paso = false;
            if (DropDownList1.SelectedIndex == 0)
            {
                if (txtUsuario.Text.Trim() == "" || txtContrasenia.Text.Trim() == "" || txtCorreo.Text.Trim() == "" || txtTwitter.Text.Trim() == "" || txtFacebook.Text.Trim() == "" || txtYoutube.Text.Trim() == "" || txtNombre.Text.Trim() == "" || txtDescripcion.Text.Trim() == "" || txtNacimiento.Text.Trim() == "")
                {
                    paso = false;
                }
                else paso = true;
            }
            else
            {
                if (DropDownList1.SelectedIndex != 0)
                {
                    if (txtUsuario.Text.Trim() == "" || txtContrasenia.Text.Trim() == "" || txtCorreo.Text.Trim() == "" || txtTwitter.Text.Trim() == "" || txtFacebook.Text.Trim() == "" || txtYoutube.Text.Trim() == "" || txtNombre.Text.Trim() == "" || txtDescripcion.Text.Trim() == "" )
                    {
                        paso = false;
                    }
                    else paso = true;
                }
            }
            return paso;
        }

        public void llenarDatos()
        {
            if (validarCampos())
            {
                try
                {
                    if (DropDownList1.SelectedIndex == 0)
                    {
                        Negocio.BO.UsuarioEstandar oUsuarioE = new Negocio.BO.UsuarioEstandar();
                        oUsuarioE.id_tipo = new Negocio.BO.UsuarioTipo();
                        oUsuarioE.usuario = txtUsuario.Text.Trim();
                        oUsuarioE.contrasenia = txtContrasenia.Text.Trim();
                        oUsuarioE.correo = txtCorreo.Text.Trim();
                        oUsuarioE.twitter = txtTwitter.Text.Trim();
                        oUsuarioE.facebook = txtFacebook.Text.Trim();
                        oUsuarioE.youtube = txtYoutube.Text.Trim();
                        oUsuarioE.id_tipo.id = DropDownList1.SelectedIndex + 1;
                        oUsuarioE.nombre = txtNombre.Text.Trim();
                        oUsuarioE.descripcion = txtDescripcion.Text.Trim();
                        oUsuarioE.nacimiento = txtNacimiento.Text.Trim();
                        oUsuarioE.sexo = ddlSexo.Text.Trim();
                        oUsuarioE.imagen = "/Images/Usuarios/" + fupImagen.FileName.ToString();

                        Negocio.Services.UsuarioEstandar oUsuarioEstCtrl = new Negocio.Services.UsuarioEstandar();
                        oUsuarioEstCtrl.Add(oUsuarioE);
                    }
                    else
                    {
                        Negocio.BO.UsuarioArtistaOrganizador oUsuarioAO = new Negocio.BO.UsuarioArtistaOrganizador();
                        oUsuarioAO.usuario = txtUsuario.Text.Trim();
                        oUsuarioAO.contrasenia = txtContrasenia.Text.Trim();
                        oUsuarioAO.correo = txtCorreo.Text.Trim();
                        oUsuarioAO.twitter = txtTwitter.Text.Trim();
                        oUsuarioAO.facebook = txtFacebook.Text.Trim();
                        oUsuarioAO.youtube = txtYoutube.Text.Trim();
                        oUsuarioAO.id_tipo.id = DropDownList1.SelectedIndex + 1;
                        oUsuarioAO.nombre = txtNombre.Text.Trim();
                        oUsuarioAO.descripcion = txtDescripcion.Text.Trim();
                        oUsuarioAO.id_genero.id = ddlGenero.SelectedIndex + 1;
                        oUsuarioAO.imagen = "/Images/Usuarios/" + fupImagen.FileName.ToString();

                        Negocio.Services.UsuarioArtistaOrganizador oUsuAOCtrl = new Negocio.Services.UsuarioArtistaOrganizador();
                        oUsuAOCtrl.Add(oUsuarioAO);
                    }
                    string display = "Usuario Registrado Correctamente!";
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "myalert", "alert('" + display + "');", true);
                }
                catch (ExecutionEngineException ex)
                {
                    string display = "Error al guardar usuario " + ex;
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "myalert", "alert('" + display + "');", true);
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

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Index.aspx");
        }
    }
}