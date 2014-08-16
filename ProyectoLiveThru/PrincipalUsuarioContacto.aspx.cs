using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoLiveThru
{
    public partial class Formulario_web2 : System.Web.UI.Page
    {
        public static Negocio.BO.UsuarioArtistaOrganizador OrganizadorUsuario;


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
                        LlenarListado();
                    }     
                }
            }
            catch (Exception ex)
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "myalert", "alert('" + ex.Message.ToString() + "');", true);
            }
                    
        }

        public void LlenarListado()
        {
            Negocio.Services.UsuarioContacto UsuarioContacto = new Negocio.Services.UsuarioContacto();
            gvListado.DataSource = UsuarioContacto.Get(8, OrganizadorUsuario.id.ToString());
            gvListado.DataBind();
        }

        public void LimpiarCampos()
        {
            txtNombre.Text = string.Empty;
            txtApellidoPat.Text = string.Empty;
            txtApellidoMat.Text = string.Empty;
            txtCorreo.Text = string.Empty;
            txtRFC.Text = string.Empty;
            txtDescripcion.Text = string.Empty;
          
        }
        #region LLamados
        public Negocio.BO.UsuarioContacto getContacto()
        {
            Negocio.BO.UsuarioContacto oUsuarioContacto = new Negocio.BO.UsuarioContacto();
            if (txtClaveContacto.Text.Trim().Length == 0)
            {
                oUsuarioContacto.id = 0;
            }
            else
            {
                oUsuarioContacto.id = Convert.ToInt32(txtClaveContacto.Text.Trim());
            }
            oUsuarioContacto.id_usuario.id = OrganizadorUsuario.id;
            oUsuarioContacto.nombre = txtNombre.Text.Trim();
            oUsuarioContacto.apellido_pat = txtApellidoPat.Text.Trim();
            oUsuarioContacto.apellido_mat = txtApellidoMat.Text.Trim();
            oUsuarioContacto.telefono = txtTelefono.Text.Trim();
            oUsuarioContacto.correo = txtCorreo.Text.Trim();
            oUsuarioContacto.rfc = txtRFC.Text.Trim();
            oUsuarioContacto.descripcion = txtDescripcion.Text.Trim();
            return oUsuarioContacto;
        }
        public void setContacto(Negocio.BO.UsuarioContacto item)
        {
            txtClaveContacto.Text = item.id.ToString();
            txtNombre.Text = item.nombre;
            txtApellidoPat.Text = item.apellido_pat;
            txtApellidoMat.Text = item.apellido_mat;
            txtCorreo.Text = item.correo;
            txtRFC.Text = item.rfc;
            txtDescripcion.Text = item.descripcion;
        }
        public void setUsuarioContcto(Negocio.BO.UsuarioContacto item)
        {
            txtClaveContacto.Text = item.id.ToString();
            TextBox2.Text = item.nombre;
            TextBox3.Text = item.apellido_pat;
            TextBox4.Text = item.apellido_mat;
            TextBox5.Text = item.telefono;
            TextBox6.Text = item.correo;
            TextBox7.Text = item.rfc;
            TextBox8.Text = item.descripcion;
            
        }

        public void cargarContactoOrganza(int id)
        {
            Negocio.Services.UsuarioContacto UsuarioContacto = new Negocio.Services.UsuarioContacto();
            Negocio.BO.UsuarioContacto oUsuarioContacto = new Negocio.BO.UsuarioContacto();
            oUsuarioContacto = UsuarioContacto.GetOne(id);
            txtClaveContacto.Text = oUsuarioContacto.id.ToString();
            txtNombre.Text = oUsuarioContacto.nombre;
            txtApellidoPat.Text = oUsuarioContacto.apellido_pat;
            txtApellidoMat.Text = oUsuarioContacto.apellido_mat;
            txtTelefono.Text = oUsuarioContacto.telefono;
            txtCorreo.Text = oUsuarioContacto.correo;
            txtRFC.Text = oUsuarioContacto.rfc;
            txtDescripcion.Text = oUsuarioContacto.descripcion;

            LimpiarCampos();
        }

        public Negocio.BO.UsuarioContacto getUsuarioContacto()
        {
            Negocio.BO.UsuarioContacto oUsuarioContacto = new Negocio.BO.UsuarioContacto();
            if (txtClaveContacto.Text.Trim().Length == 0)
            {
                oUsuarioContacto.id = 0;
            }
            else
            {
                oUsuarioContacto.id = Convert.ToInt32(TextBox1.Text.Trim());
            }
            oUsuarioContacto.nombre = txtNombre.Text.Trim();
            oUsuarioContacto.apellido_pat = txtApellidoPat.Text.Trim();
            oUsuarioContacto.apellido_mat = txtApellidoMat.Text.Trim();
            oUsuarioContacto.telefono = txtTelefono.Text.Trim();
            oUsuarioContacto.correo = txtCorreo.Text.Trim();
            oUsuarioContacto.rfc = txtRFC.Text.Trim();
            oUsuarioContacto.descripcion = txtDescripcion.Text.Trim();
            oUsuarioContacto.id_usuario.id = OrganizadorUsuario.id;
            return oUsuarioContacto;
        }
        public Negocio.BO.UsuarioContacto getContactoUsuario()
        {
            Negocio.BO.UsuarioContacto oUsuarioContacto = new Negocio.BO.UsuarioContacto();
            if (txtClaveContacto.Text.Trim().Length == 0)
            {
                oUsuarioContacto.id = 0;
            }
            else
            {
                oUsuarioContacto.id = Convert.ToInt32(txtClaveContacto.Text.Trim());
            }
            oUsuarioContacto.nombre = TextBox2.Text.Trim();
            oUsuarioContacto.apellido_pat = TextBox3.Text.Trim();
            oUsuarioContacto.apellido_mat = TextBox4.Text.Trim();
            oUsuarioContacto.telefono = TextBox5.Text.Trim();
            oUsuarioContacto.correo = TextBox6.Text.Trim();
            oUsuarioContacto.rfc = TextBox7.Text.Trim();
            oUsuarioContacto.descripcion = TextBox8.Text.Trim();
            oUsuarioContacto.id_usuario.id = OrganizadorUsuario.id;
            return oUsuarioContacto;
        }
        public void setUsuarioContacto(Negocio.BO.UsuarioContacto item)
        {
            txtClaveContacto.Text = item.id.ToString();
            txtNombre.Text = item.nombre;
            txtApellidoPat.Text = item.apellido_pat;
            txtApellidoMat.Text = item.apellido_mat;
            txtTelefono.Text = item.telefono;
            txtCorreo.Text = item.correo;
            txtRFC.Text = item.rfc;
            txtDescripcion.Text = item.descripcion;
        }
        #endregion

        #region Botones
        protected void btnAgregarContacto_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNombre.Text.Trim().Length == 0 || txtApellidoPat.Text.Trim().Length == 0 || txtApellidoMat.Text.Trim().Length == 0 || txtTelefono.Text.Trim().Length == 0 ||
                    txtCorreo.Text.Trim().Length == 0 || txtRFC.Text.Trim().Length == 0 || txtDescripcion.Text.Trim().Length == 0 )
                {
                    string display = "Campos vacios, verifíque";
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "myalert", "alert('" + display + "');", true);
                }
                else
                {
                    Negocio.Services.UsuarioContacto ContactoOrganizador = new Negocio.Services.UsuarioContacto();
                    Negocio.BO.UsuarioContacto UsuarioContacto = new Negocio.BO.UsuarioContacto();

                    int id = ContactoOrganizador.Add(getContacto());
                    LimpiarCampos();
                    LlenarListado();
                    string display = "Contacto Registrado Correctamente!";
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "myalert", "alert('" + display + "');", true);
                    
                }

            }
            catch (Exception ex)
            {
                string display = ex.Message.ToString();
                ScriptManager.RegisterStartupScript(this, this.GetType(), "myalert", "alert('" + display + "');", true);

            }
        }
        protected void btnModificarContacto_Click(object sender, EventArgs e)
        {
            try
            {
                if (TextBox2.Text.Trim().Length == 0 || TextBox3.Text.Trim().Length == 0 || TextBox4.Text.Trim().Length == 0 || TextBox5.Text.Trim().Length == 0 ||
                    TextBox6.Text.Trim().Length == 0 || TextBox7.Text.Trim().Length == 0 || TextBox8.Text.Trim().Length == 0)
                {
                    string display = "Campos vacios, verifíque";
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "myalert", "alert('" + display + "');", true);
                }
                else
                {
                    Negocio.Services.UsuarioContacto UsuarioContacto = new Negocio.Services.UsuarioContacto();
                    Negocio.BO.UsuarioContacto oUsuarioContacto = new Negocio.BO.UsuarioContacto();
                    UsuarioContacto.Update(getContactoUsuario());

                    string display = "Contacto modificado Correctamente!";
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "myalert", "alert('" + display + "');", true);
                    Response.Redirect("PrincipalUsuarioContacto.aspx");
                }

            }
            catch (Exception ex)
            {
                string display = ex.Message.ToString();
                ScriptManager.RegisterStartupScript(this, this.GetType(), "myalert", "alert('" + display + "');", true);

            }
        }
        #endregion

        protected void gvListado_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            try
            {
                Negocio.BO.UsuarioContacto oUsuarioContacto = new Negocio.BO.UsuarioContacto();
                Negocio.Services.UsuarioContacto UsuarioContacto = new Negocio.Services.UsuarioContacto();
                oUsuarioContacto.id = Convert.ToInt32(gvListado.Rows[e.RowIndex].Cells[0].Text);
                UsuarioContacto.Delete(oUsuarioContacto);
                string message = "Contacto eliminado con exito";
                ScriptManager.RegisterStartupScript(this, this.GetType(), "myalert", "alert('" + message.ToString() + "');", true);
                LlenarListado();
            }

            catch (Exception ex)
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "myalert", "alert('" + ex.Message.ToString() + "');", true);
            }
        }

        protected void gvListado_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                Negocio.Services.UsuarioContacto ServivioContacto = new Negocio.Services.UsuarioContacto();
                Negocio.BO.UsuarioContacto boContactp = new Negocio.BO.UsuarioContacto();
                int id = Convert.ToInt32(gvListado.SelectedRow.Cells[0].Text);
                setUsuarioContcto(ServivioContacto.GetOne(id));


            }
            catch (Exception ex)
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "myalert", "alert('" + ex.Message.ToString() + "');", true);
            }
        }

    }
}