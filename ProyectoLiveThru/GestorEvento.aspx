<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" EnableEventValidation="false" ValidateRequest="false" AutoEventWireup="true" CodeBehind="GestorEvento.aspx.cs" Inherits="ProyectoLiveThru.Formulario_web21" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Body" runat="server">
    <div class="panel panel-default">
			    <div class="panel-heading">
				    <h4>Funcion eventos</h4>
			    </div>
			    <div class="panel-body">
                <div class ="row">
                <div class="col-md-12 column">
				    <div class="panel-body">
                    <ul class="nav nav-tabs">
                    <li id="tabOriganizador" class="active">
                    <a href="#Listado" data-toggle="tab">Listado De Evento(s)</a>
		                </li>
                    <li id="tbOrganizadorModificar">
                    <a href="#general" data-toggle="tab">Agregar Evento(s)</a>
                    </li>
		             <li  id="tabContacto" >
                     <a href="#direccion" data-toggle="tab">Modificar Evento(s)</a>
		                </li>
                    </ul>

                        <div class="tab-content">
                        
                        <div class="tab-pane fade active in" id="Listado">
                        <div class="row">
                        <div class="col-md-12" >
                            <br />
                            <asp:GridView ID="gvListado" runat="server" align="center" BackColor="White" 
                            BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" CellPadding="3" 
                            ForeColor="Black" GridLines="Vertical" AutoGenerateColumns="False" EmptyDataText="<strong>No se encontraron Contactos.</strong>" OnRowDeleting="gvListado_RowDeleting" OnSelectedIndexChanged="gvListado_SelectedIndexChanged"> 
                            <Columns>
                                        <asp:BoundField DataField="id" HeaderText="Clave" />
                                        <asp:BoundField DataField="nombre" HeaderText="Lugar del Evento" />
                                        <asp:BoundField DataField="direccion" HeaderText="Direccion" />
                                        <asp:BoundField DataField="fecha" HeaderText="Fecha" />
                                        <asp:BoundField DataField="enlace" HeaderText="Enlace" />                                     
                                        <asp:BoundField DataField="nombre_organizador" HeaderText="Organizador" />
                                       <asp:TemplateField HeaderText="Opciones" InsertVisible="False" ShowHeader="False">
                                            <ItemTemplate>
                                                <asp:ImageButton ID="ImageButton1" runat="server" CausesValidation="False" CommandName="Select" ImageUrl="~/Images/1395795442_48111.ico" Text="Editar" />
                                                <asp:ImageButton ID="ImageButton2" runat="server" CausesValidation="False" CommandName="Delete" ImageUrl="~/Images/1395795438_11746.ico" Text="Eliminar" OnClientClick="javascript:return confirm('¿Desea Eliminar el registro?');"/>
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                    </Columns>
                                    <FooterStyle BackColor="#CCCCCC" />
                                    <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
                                    <SelectedRowStyle BackColor ="#000099" Font-Bold="true" ForeColor="White" />
                                    <HeaderStyle BackColor="Black" Font-Bold="true" ForeColor="White" />
                                    <AlternatingRowStyle BackColor="#CCCCCC" />
                            </asp:GridView>
                            </div>
                            </div>
                            <div>
                            </div>
                            </div>
                                                                             
		                <div class="tab-pane fade" id="general">
                            <div class="row">
                       <div class="panel-body">
                        <div class="col-md-6" >
     <asp:Label runat="server" ID="Label1" align="left"> <h4>Clave:</h4></asp:Label>
     <asp:TextBox ID="txtClaveEvento" runat="server" CssClass="form-control" Width="100%" 
     align="center" placeholder="" Enabled="false" ></asp:TextBox>
    <br />
    <asp:Label ID="Label2" runat="server" Text="Nombre"></asp:Label>
    <asp:TextBox ID="txtNombre" runat="server" class="form-control" Width="100%" 
     align="center" placeholder="Ingrese Nombre..."></asp:TextBox><br />
    <br />
    <asp:Label ID="Label3" runat="server" Text="Descripcion"></asp:Label>
    <asp:TextBox ID="txtDescripcion" runat="server" class="form-control" Width="100%" 
     align="center" placeholder="Ingrese Descripcion..."></asp:TextBox><br />
    <br />
    <asp:Label ID="Label4" runat="server" Text="Direccion"></asp:Label>
    <asp:TextBox ID="txtDireccion" runat="server" class="form-control" Width="100%" 
     align="center" placeholder="Ingrese Direccion..."></asp:TextBox><br />
    <br />
     <asp:Label ID="Label8" runat="server" Text="Fecha"></asp:Label>
    <asp:TextBox ID="txtFecha" runat="server" class="form-control" Width="100%" 
     align="center" placeholder="Ingrese Fecha..."></asp:TextBox><br />
    <br />
    <asp:Label ID="Label5" runat="server" Text="Enlace"></asp:Label>
    <asp:TextBox ID="txtEnlace" runat="server" class="form-control" Width="100%" 
     align="center" placeholder="Ingrese Correo..."></asp:TextBox><br />
    <asp:Label ID="Label6" runat="server" Text="Portada"></asp:Label>
    <asp:FileUpload ID="subiPortada" runat="server" ForeColor="#3399FF" Height="40px"/>
    <br />
 <asp:Image ID="Image1" runat="server" Width="250" Height="250" />
 <asp:Label ID="Label20" runat="server" Text=""></asp:Label>
   <br />
    <br />
                            
                             </div>
                           <div class="col-md-6" >
                            <br />
                             <div class="table-responsive">
                                 <fieldset class="fUploadControl">
                                                <legend>
                                                    <asp:Label ID="lblUploadFilesTitle" Text="Archivos a subir" runat="server"></asp:Label>
                                                </legend>
                                                <asp:Label ID="lblNote" Text="" CssClass="comment" runat="server" />
                                                <asp:Panel ID="pnlUpload" runat="server">
                                                    <asp:FileUpload ID="Galeria" CssClass="fileInput" runat="server" />
                                                </asp:Panel>
                                                <asp:HyperLink ID="lnkAddFileUpload" CssClass="AddNewButton" NavigateUrl="javascript:addFileUploadCtrl();" Text="Agregar" runat="server" />
                                                <div>

                                                    <asp:Button ID="tbnGaleria" runat="server" Text="AgregarImagenes" />  
                                                    <asp:Panel runat="server" ID="pnlImagenes" />
                                                </div>
                                                <asp:Label ID="lblInfo" Text="" CssClass="mssgOK" runat="server" />
                                            </fieldset>
                                 <!-- aqui va el datagrid-->
                            <asp:GridView ID="GridView1" runat="server" align="center" BackColor="White" 
                            BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" CellPadding="3" 
                            ForeColor="Black" GridLines="Vertical" AutoGenerateColumns="False" EmptyDataText="<strong>No se encontraron Imagenes.</strong>"> 
                            <AlternatingRowStyle BackColor="#CCCCCC" />
                            <Columns>
                                <asp:BoundField DataField="id" HeaderText="Clave" />
                                         <asp:ImageField DataImageUrlField="imagen" DataImageUrlFormatString="{0}" HeaderText="Encabezado imagen" ControlStyle-Height="150" ControlStyle-Width="200">
                                           </asp:ImageField>
                            </Columns>

                            <FooterStyle BackColor="#CCCCCC" />
                            <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
                            <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
                            <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
                        </asp:GridView>
                        
</div>
                     </div>
                                </div>
                                <div class="row">
                     <div class="col-md-12" align="center">
                 <div class="col-md-4">
                <div align="center"></div>
                </div>
                    <div class="col-md-4">
                    <div align="center">
                           <asp:Button ID="btnAgregarEventos" runat="server" Width="100%"  Text="Agregar Evento(s)" 
                            class="btn btn-inverse" BackColor="Black" ForeColor=White OnClick="btnAgregarEventos_Click"/>
                        
                            </div>
                        </div>
                        </div> 
                        </div>           
		                </div>
                            </div>
                                
                        <div class="tab-pane fade" id="direccion">
 <asp:ScriptManager ID="ScriptManager1" runat="server" />
    <asp:UpdatePanel ID="upnGeneral" runat="server">
        <ContentTemplate>
            <div class="row">
            <div class="col-md-6" >
                                    <br />
     <asp:Label runat="server" ID="Label7" align="left"> <h4>Clave:</h4></asp:Label>
     <asp:TextBox ID="txtClave" runat="server" CssClass="form-control" Width="100%" 
     align="center" placeholder="" Enabled="False" MaxLength="7" ></asp:TextBox>
    <br />
    <asp:Label ID="Label9" runat="server" Text="Nombre"></asp:Label>
    <asp:TextBox ID="texNombre" runat="server" class="form-control" Width="100%" 
     align="center" placeholder="Ingrese Nombre..."></asp:TextBox><br />
    <br />
    <asp:Label ID="Label10" runat="server" Text="Descripcion"></asp:Label>
    <asp:TextBox ID="txtDetalle" runat="server" class="form-control" Width="100%" 
     align="center" placeholder="Ingrese Descripcion..." Height="131px"></asp:TextBox><br />
    <br />
    <asp:Label ID="Label11" runat="server" Text="Direccion"></asp:Label>
    <asp:TextBox ID="txtCalle" runat="server" class="form-control" Width="100%" 
     align="center" placeholder="Ingrese Direccion..."></asp:TextBox><br />
    <br />
     <asp:Label ID="Label12" runat="server" Text="Fecha"></asp:Label>
    <asp:TextBox ID="txtAnno" runat="server" class="form-control" Width="100%" 
     align="center" placeholder="Ingrese Fecha..."></asp:TextBox><br />
    <br />
    <asp:Label ID="Label13" runat="server" Text="Enlace"></asp:Label>
    <asp:TextBox ID="txtEn" runat="server" class="form-control" Width="100%" 
     align="center" placeholder="Ingrese Correo..."></asp:TextBox><br />
    <asp:Label ID="Label14" runat="server" Text="Portada"></asp:Label>
    <asp:FileUpload ID="midific" runat="server" ForeColor="#3399FF" Height="40px"/>
    <br />
   <asp:Image ID="Image2" runat="server" Width="250" Height="250" />
 <asp:Label ID="Label21" runat="server" Text=""></asp:Label><br />
                                    <br />
                                                            <div class="row">
                     <div class="col-md-12" align="center">
                 <div class="col-md-3">
                <div align="center"></div>
                </div>
                    <div class="col-md-6">
                    <div align="center">
                            <asp:Button ID="tbnModificar" runat="server" Width="100%"  Text="Modificar Contacto" 
                            class="btn btn-inverse" BackColor="Black" ForeColor=White OnClick="tbnModificar_Click"/>
                        
                            </div>
                        </div>
                        <div class="col-md-3"></div>
</div>
        </div>

                            </div>
                
                                                                 </div>
                                    </ContentTemplate>
        <Triggers>
            <asp:AsyncPostBackTrigger ControlID="tbnModificar" />
        </Triggers>
        </asp:UpdatePanel>
		                </div>


	                </div>
                    </div>
				    </div>
                    </div>
                    </div>
        </div>


    
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="Footer" runat="server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="VLAside" runat="server">
</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="Contenido" runat="server">
</asp:Content>
<asp:Content ID="Content6" ContentPlaceHolderID="scripts" runat="server">
</asp:Content>
