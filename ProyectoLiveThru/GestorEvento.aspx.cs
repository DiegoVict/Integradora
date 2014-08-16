using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Text;

namespace ProyectoLiveThru
{
    public partial class Formulario_web21 : System.Web.UI.Page
    {
        public static Negocio.BO.UsuarioArtistaOrganizador OrganizadorUsuario;

        public string rutaimagen = "";
        private int __MaxSize = 4096;
        protected void Page_Load(object sender, EventArgs e)
        {

            try
            {
                if (Session["oUsuario"] != null)
                {

                    if (!Page.IsPostBack)
                    {
                        OrganizadorUsuario = (Negocio.BO.UsuarioArtistaOrganizador)Session["oUsuario"];
                        LlenarDatosImagenes();
                        LlenarGaleria();

                        if (ViewState[this.ID + "MAXFILESLIMIT"] != null)
                            lnkAddFileUpload.Visible = Convert.ToInt32(ViewState[this.ID + "MAXFILESLIMIT"]) > 1;

                        if (ViewState[this.ID + "MAXUPLOADSIZE"] == null)
                            ViewState[this.ID + "MAXUPLOADSIZE"] = __MaxSize;


                    }
                }
            }
            catch (Exception ex)
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "myalert", "alert('" + ex.Message.ToString() + "');", true);
            }            
        }

        #region insertarImagenes
        protected override void OnPreRender(EventArgs e)
        {
            string _checkMssg = "Por favor seleccione el primer archivo antes de agregar otros.";

            StringBuilder _js = new StringBuilder("<script type=\"text/javascript\">");
            _js.Append("function addFileUploadCtrl(){");
            _js.AppendFormat("if(document.getElementById(\"{0}\").value.length == 0)", Galeria.ClientID);
            _js.Append("{");
            _js.AppendFormat("alert(\"{0}\");return;", _checkMssg);
            _js.Append("}");
            _js.Append("if (!document.getElementById || !document.createElement) return false;");
            _js.AppendFormat("var uploadArea = document.getElementById(\"{0}\");", pnlUpload.ClientID);
            _js.Append("if (!uploadArea) return;");
            _js.Append("var _uploadControl = document.createElement(\"input\");");
            _js.Append("if (!addFileUploadCtrl.newID) addFileUploadCtrl.newID = 1;");
            _js.Append("_uploadControl.type = \"file\";");
            _js.Append("_uploadControl.setAttribute(\"id\", \"upldFile_\" + addFileUploadCtrl.newID);");
            _js.Append("_uploadControl.setAttribute(\"name\", \"upldFile_\" + addFileUploadCtrl.newID);");
            _js.Append("_uploadControl.setAttribute(\"class\", \"fileInput\");");
            _js.Append("uploadArea.appendChild(_uploadControl);");
            _js.Append("addFileUploadCtrl.newID++;");

            if (ViewState[this.ID + "MAXFILESLIMIT"] != null) // límite de cantidad de archivos.
            {
                _js.AppendFormat("if(addFileUploadCtrl.newID > {0} -1)", ViewState[this.ID + "MAXFILESLIMIT"]);
                _js.AppendFormat("document.getElementById(\"{0}\").style.display = 'none';", lnkAddFileUpload.ClientID);
            }

            _js.AppendFormat("document.getElementById(\"{0}\").style.display='none';", lblInfo.ClientID); // limpiar mensaje de información.
            _js.Append("}</script>");

            if (this.Page.Master != null)
                this.Page.Master.Page.ClientScript.RegisterStartupScript(this.GetType(), Guid.NewGuid().ToString(), _js.ToString());
            else
                this.Page.ClientScript.RegisterStartupScript(this.GetType(), Guid.NewGuid().ToString(), _js.ToString());


            base.OnPreRender(e);

        }
        public bool UploadFiles(bool CreateDir)
        {
            bool _resultOK = false;

            string _dirPath = Server.MapPath(ViewState[this.ID + "DESTINATIONFOLDER"].ToString());


            if (CreateDir)
            {
                DirectoryInfo _d = new DirectoryInfo(_dirPath);
                if (!_d.Exists)
                    _d.Create();
            }

            HttpFileCollection _fcol = Request.Files;
            if (ValidarExtensiones(_fcol))
            {
                if (ValidarTamaño(_fcol))
                {
                    #region Guardar archivos

                    try
                    {
                        double _fSizes = 0;
                        int _cantFiles = 0;
                        for (int i = 0; i < _fcol.Count; i++)
                        {
                            HttpPostedFile _postedF = _fcol[i];
                            if (_postedF.ContentLength > 0)
                            {
                                string _f2save = string.Format("{0}\\{1}", _dirPath, Path.GetFileName(_postedF.FileName));
                                _postedF.SaveAs(_f2save);
                                _fSizes += _postedF.ContentLength;
                                _cantFiles++;
                            }
                        }

                        if (_cantFiles > 0)
                        {
                            if (_fSizes < 1024)
                                lblInfo.Text = string.Format("{0:0.00} KB subidos en {1} archivos.", _fSizes / 1024, _cantFiles);
                            else
                                lblInfo.Text = string.Format("{0} KB subidos en {1} archivos.", Math.Round(_fSizes / 1024), _cantFiles);

                            lblInfo.CssClass = "mssgOK";

                            _resultOK = true;
                        }
                        else
                        {
                            lblInfo.Text = "No se subieron archivos. Seleccione un archivo para subir.";
                            lblInfo.CssClass = "mssgERROR";
                        }
                    }
                    catch (Exception ex)
                    {
                        lblInfo.Text = string.Format("Se produjo un error al subir los archivos: {0}", ex.Message);
                        lblInfo.CssClass = "mssgERROR";
                    }

                    #endregion
                }
                else
                {
                    lblInfo.Text = string.Format("Los archivos a subir superan el tamaño permitido de {0} MB.", Convert.ToInt32(ViewState[this.ID + "MAXUPLOADSIZE"]) / 1024);
                    lblInfo.CssClass = "mssgERROR";
                }
            }
            else
            {
                lblInfo.Text = "Uno o más archivos contiene una extensión no permitida. Los archivos no fueron subidos.";
                lblInfo.CssClass = "mssgERROR";
            }

            return _resultOK;
        }

        /// <summary>
        /// Verifica las extensiones de archivo permitidas. Si no se especificó ninguna, se puede subir cualquier tipo de archivo.
        /// </summary>
        /// <param name="p_Fcol"></param>
        /// <returns></returns>
        protected bool ValidarExtensiones(HttpFileCollection p_Fcol)
        {
            if (ViewState[this.ID + "FILEEXTENSIONSENABLED"] == null)
                return true;

            bool _allValid = true;
            string _regX = string.Format("({0})$", ViewState[this.ID + "FILEEXTENSIONSENABLED"]); // Establece la expresión regular de validación.

            for (int i = 0; i < p_Fcol.Count; i++)
            {
                RegexOptions _rOptions = RegexOptions.IgnoreCase
                    | RegexOptions.Singleline
                    | RegexOptions.Compiled;

                Regex _rX = new Regex(_regX, _rOptions);

                if (_rX.Match(p_Fcol[i].FileName).Length == 0) // si alguna extensión no coincide cancela la subida de todos los archivos.
                {
                    _allValid = false;
                    break;
                }
            }

            return _allValid;
        }

        /// <summary>
        /// Controla el tamaño total de todos los archivos a subir. Si no se especifica, utiliza el máximo definido en __MaxSize.
        /// </summary>
        /// <param name="p_Fcol"></param>
        /// <returns></returns>
        protected bool ValidarTamaño(HttpFileCollection p_Fcol)
        {
            int _totSize = 0;
            for (int i = 0; i < p_Fcol.Count; i++)
                _totSize += p_Fcol[i].ContentLength;

            return _totSize < Convert.ToInt32(ViewState[this.ID + "MAXUPLOADSIZE"]) * 1024;
        }

        #endregion
        #region Metodos
        public void LlenarDatosImagenes()
        {
            Negocio.Services.Evento UsuarioEvento = new Negocio.Services.Evento();
            gvListado.DataSource = UsuarioEvento.Get(7, OrganizadorUsuario.id.ToString());
            
            gvListado.DataBind();
        }
        public void LlenarGaleria()
        {
            Negocio.Services.EventoGaleria UsuarioEvento = new Negocio.Services.EventoGaleria();
            GridView1.DataSource = UsuarioEvento.GetAll();
            GridView1.DataBind();
        }
            void SaveFile()
        {
            Boolean fileOk = false;
            String path = Server.MapPath("/Content/Images/eventos/");

            if (subiPortada.HasFile)
            {
                String fileExtension = System.IO.Path.GetExtension(subiPortada.FileName).ToLower();
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
                        rutaimagen = path + subiPortada.FileName;
                        string fileName = subiPortada.FileName;
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
                        subiPortada.PostedFile.SaveAs(rutaimagen);
                    }
                    catch (Exception ex)
                    {
                        Label20.Text = "No se pudo subir la imagen " + ex.Message.ToString();
                    }
                }
                else
                {
                    Label20.Text = "No se aceptan archivos de este tipo";
                }
            }
            
        }

            //void GaleriaFile()
            //{
            //    Boolean fileOk = false;
            //    String path = Server.MapPath("~/EventoImagenes/");

            //    if (Galeria.HasFile)
            //    {
            //        String fileExtension = System.IO.Path.GetExtension(Galeria.FileName).ToLower();
            //        String[] allowedExtensions = { ".gif", ".png", ".jpeg", ".jpg" };
            //        for (int i = 0; i < allowedExtensions.Length; i++)
            //        {
            //            if (fileExtension == allowedExtensions[i])
            //            {
            //                fileOk = true;
            //            }
            //        }

            //        if (fileOk)
            //        {
            //            try
            //            {
            //                rutaimagen = path + Galeria.FileName;
            //                string fileName = Galeria.FileName;
            //                string tempfileName = "";
            //                if (System.IO.File.Exists(rutaimagen))
            //                {
            //                    int counter = 2;
            //                    while (System.IO.File.Exists(rutaimagen))
            //                    {
            //                        // if a file with this name already exists,
            //                        // prefix the filename with a number.
            //                        tempfileName = counter.ToString() + fileName;
            //                        rutaimagen = path + tempfileName;
            //                        counter++;
            //                    }


            //                }
            //                Galeria.PostedFile.SaveAs(rutaimagen);
            //            }
            //            catch (Exception ex)
            //            {
            //                lblGaleria.Text = "No se pudo subir la imagen " + ex.Message.ToString();
            //            }
            //        }
            //        else
            //        {
            //            lblGaleria.Text = "No se aceptan archivos de este tipo";
            //        }
            //    }

            //}

            public void LimpiarCampos()
            {

           txtNombre.Text = string.Empty;
           txtDescripcion.Text = string.Empty;
           txtDireccion.Text = string.Empty;
           txtFecha.Text = string.Empty;
           rutaimagen = string.Empty;
           txtEnlace.Text = string.Empty;
                
            }
        public Negocio.BO.Evento getEvento()
       
        {
            Negocio.BO.Evento oEvento = new Negocio.BO.Evento();
           if(txtClaveEvento.Text.Trim().Length == 0)
           {
               oEvento.id = 0;
           }
            else
           {
               oEvento.id = Convert.ToInt32(txtClaveEvento.Text.Trim());
           }
           oEvento.nombre = txtNombre.Text.Trim();
           oEvento.descripcion = txtDescripcion.Text.Trim();
           oEvento.direccion = txtDireccion.Text.Trim();
           oEvento.fecha = Convert.ToDateTime(txtFecha.Text.Trim());
           oEvento.imagen = rutaimagen;
           oEvento.enlace = txtEnlace.Text.Trim();
           oEvento.id_organizador.id = Convert.ToInt32(OrganizadorUsuario.id);
           oEvento.imagen = "/Content/Images/eventos/" + subiPortada.FileName.ToString();
           Negocio.BO.EventoGaleria GaleriaEvento = new Negocio.BO.EventoGaleria();
           GaleriaEvento.foto = "/EventoImagenes/" + Galeria.FileName.ToString();
           return oEvento;
        }
        public Negocio.BO.Evento ModiEvento()
        {
            Negocio.BO.Evento oEvento = new Negocio.BO.Evento();
            if(txtClave.Text.Trim().Length == 0)
            {
                oEvento.id = 0;
            }
            else
            {
                oEvento.id = Convert.ToInt32(txtClave.Text.Trim());
            }
            oEvento.nombre = texNombre.Text.Trim();
            oEvento.descripcion = txtDetalle.Text.Trim();
            oEvento.direccion = txtCalle.Text.Trim();
            oEvento.fecha = Convert.ToDateTime(txtAnno.Text.Trim());
            oEvento.imagen = rutaimagen;
            oEvento.enlace = txtEnlace.Text.Trim();
            oEvento.imagen = "/Content/Images/eventos/" + subiPortada.FileName.ToString();
            return oEvento;
        }
        public void setEvento(Negocio.BO.Evento item)
        {
            txtClaveEvento.Text = item.id.ToString();
            txtNombre.Text = item.nombre;
            txtDescripcion.Text = item.descripcion;
            txtDireccion.Text = item.direccion;
            txtEnlace.Text = item.enlace;
            rutaimagen = item.imagen;
            Image1.ImageUrl = item.imagen;
            
        }

        public void setModiEvento(Negocio.BO.Evento item)
        {
            txtClave.Text = item.id.ToString();
            texNombre.Text = item.nombre;
            txtDetalle.Text = item.descripcion;
            txtCalle.Text = item.direccion;
            txtAnno.Text = item.fecha.ToString();
            txtEn.Text = item.enlace;
            rutaimagen = item.imagen;
            Image2.ImageUrl = item.imagen;
        }
        #endregion

        #region Buttons
        
        protected void btnAgregarEventos_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNombre.Text.Trim().Length == 0 || txtDescripcion.Text.Trim().Length == 0 || txtDireccion.Text.Trim().Length == 0 ||
                    txtFecha.Text.Trim().Length == 0 || txtEnlace.Text.Trim().Length == 0 || subiPortada.FileName.Trim().Length == 0)
                {
                    string display = "Campos vacios, verifíque";
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "myalert", "alert('" + display + "');", true);
                    LlenarGaleria();
                }
                else
                {
                    Negocio.Services.Evento EventoUsuario = new Negocio.Services.Evento();
                    Negocio.BO.Evento oEventoUsuario = new Negocio.BO.Evento();
                    SaveFile();
                    int id = EventoUsuario.Add(getEvento());

                    LimpiarCampos();
                    LlenarDatosImagenes();
                    string display = "Cliente Registrado Correctamente!";
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "myalert", "alert('" + display + "');", true);
                }

            }
            catch (Exception ex)
            {
                string display = ex.Message.ToString();
                ScriptManager.RegisterStartupScript(this, this.GetType(), "myalert", "alert('" + display + "');", true);

            }
        }
        #region BotonesEliminar
        protected void gvListado_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            try
            {
                Negocio.Services.Evento EventoService = new Negocio.Services.Evento();
                Negocio.BO.Evento oEvento = new Negocio.BO.Evento();
                oEvento.id = Convert.ToInt32(gvListado.Rows[e.RowIndex].Cells[0].Text);
                EventoService.Delete(oEvento);
                Response.Redirect("GestorEvento.aspx");
                string message = "Evento eliminado con exito";
                ScriptManager.RegisterStartupScript(this, this.GetType(), "myalert", "alert('" + message.ToString() + "');", true);
                LlenarDatosImagenes();
            }
            catch (Exception ex)
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "myalert", "alert('" + ex.Message.ToString() + "');", true);
            }
        }
        #endregion
        #endregion

        protected void tbnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (texNombre.Text.Trim().Length == 0 || txtDetalle.Text.Trim().Length == 0 || txtCalle.Text.Trim().Length == 0 ||
                    txtAnno.Text.Trim().Length == 0 || txtEn.Text.Trim().Length == 0)
                {
                    string display = "Campos vacios, verifíque";
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "myalert", "alert('" + display + "');", true);
                }
                else
                {
                    Negocio.Services.Evento EventoServices = new Negocio.Services.Evento();
                    Negocio.BO.Evento oEvento = new Negocio.BO.Evento();
                    EventoServices.Update(ModiEvento());
                    string display = "Evento modificado Correctamente!";
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "myalert", "alert('" + display + "');", true);
                    Response.Redirect("GestorEvento.aspx");
                }

            }
            catch (Exception ex)
            {
                string display = ex.Message.ToString();
                ScriptManager.RegisterStartupScript(this, this.GetType(), "myalert", "alert('" + display + "');", true);

            }
        }

        protected void gvListado_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Negocio.Services.Evento EventoSer = new Negocio.Services.Evento();
                Negocio.BO.Evento BoEvento = new Negocio.BO.Evento();
                int id = Convert.ToInt32(gvListado.SelectedRow.Cells[0].Text);
                setModiEvento(EventoSer.GetOne(id));
            }
            catch (Exception ex)
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "myalert", "alert('" + ex.Message.ToString() + "');", true);
            }
        }

       }
}