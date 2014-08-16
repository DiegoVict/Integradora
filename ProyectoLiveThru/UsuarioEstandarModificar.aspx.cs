using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoLiveThru
{
    public partial class UsuarioEstandarModificar : System.Web.UI.Page
    {
        string rutaimagen = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (Session["oUsuario"] != null)
                {
                    if (!IsPostBack)
                    {
                        int id = Convert.ToInt32(Session["usuID"]);
                        cargarusuario(id);
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

        public void cargarusuario(int id)
        {
            Negocio.Services.UsuarioEstandar usuEstCTRL = new Negocio.Services.UsuarioEstandar();
            Negocio.BO.UsuarioEstandar usuEstBO = new Negocio.BO.UsuarioEstandar();
            usuEstBO = usuEstCTRL.GetOne(id);
            lblID.Text = Convert.ToString(usuEstBO.id);
            txtUsuario.Text = usuEstBO.usuario;
            txtContrasenia.Text = usuEstBO.contrasenia;
            txtCorreo.Text = usuEstBO.correo;
            txtTwitter.Text = usuEstBO.twitter;
            txtFacebook.Text = usuEstBO.facebook;
            txtYoutube.Text = usuEstBO.youtube;
            txtNombre.Text = usuEstBO.nombre;
            txtDescripcion.Text = usuEstBO.descripcion;
            txtNacimiento.Text = usuEstBO.nacimiento;
            ddlSexo.SelectedValue = usuEstBO.sexo;
            cargarTipo();
            DropDownList1.SelectedValue = usuEstBO.id_tipo.id.ToString();
            Image1.ImageUrl = usuEstBO.imagen;
            lblStatus.Text = usuEstBO.imagen;
            rutaimagen = usuEstBO.imagen;
        }

        public bool validarCampos()
        {
            bool paso = false;
            if (txtUsuario.Text.Trim() == "" || txtContrasenia.Text.Trim() == "" || txtCorreo.Text.Trim() == "" || txtTwitter.Text.Trim() == "" || txtFacebook.Text.Trim() == "" || txtYoutube.Text.Trim() == "" || txtNombre.Text.Trim() == "" || txtDescripcion.Text.Trim() == "" || txtNacimiento.Text.Trim() == "")
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
                    Negocio.BO.UsuarioEstandar oUsuarioE = new Negocio.BO.UsuarioEstandar();
                    oUsuarioE.id = Convert.ToInt32(lblID.Text);
                    oUsuarioE.usuario = txtUsuario.Text.Trim();
                    oUsuarioE.contrasenia = txtContrasenia.Text.Trim();
                    oUsuarioE.correo = txtCorreo.Text.Trim();
                    oUsuarioE.twitter = txtTwitter.Text.Trim();
                    oUsuarioE.facebook = txtFacebook.Text.Trim();
                    oUsuarioE.youtube = txtYoutube.Text.Trim();
                    oUsuarioE.id_tipo.id = 1;
                    oUsuarioE.nombre = txtNombre.Text.Trim();
                    oUsuarioE.descripcion = txtDescripcion.Text.Trim();
                    oUsuarioE.nacimiento = txtNacimiento.Text.Trim();
                    oUsuarioE.sexo = ddlSexo.Text.Trim();
                    oUsuarioE.imagen = "/Images/Usuarios/" + fupImagen.FileName.ToString();
                    Negocio.Services.UsuarioEstandar oUsuECtrl = new Negocio.Services.UsuarioEstandar();

                    oUsuECtrl.Update(oUsuarioE);

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
    }
}