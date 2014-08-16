<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="UsuarioArtistaOrganizadorModificar.aspx.cs" Inherits="ProyectoLiveThru.UsuarioArtistaOrganizadorModificar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Body" runat="server">
    <div class ="row">
        <div class="col-md-12">
            <div class="col-md-2 column"  align="left">
                <br />

                <asp:Button ID="btnAdminPerfil" runat="server" class="btn btn-inverse" Text="Administrar Perfil" BackColor="Black" ForeColor="White" Font-Bold="True" Width="100%" OnClick="btnAdminPerfil_Click" Visible="false"/>

                <asp:Button ID="btnModoPerfilPublico" runat="server" class="btn btn-inverse" Text="Modo Perfil Publico" BackColor="Black" ForeColor="White" Font-Bold="True" Width="100%" OnClick="btnModoPerfilPublico_Click"/>
                <br />
                <br />
                <asp:Button ID="Button1" runat="server" class="btn btn-inverse" Text="Administrar Albumes" BackColor="Black" ForeColor="White" Font-Bold="True" Width="100%"/>
                <br />
                <br />
                <asp:Button ID="Button2" runat="server" class="btn btn-inverse" Text="Administrar Canciones" BackColor="Black" ForeColor="White" Font-Bold="True" Width="100%"/>
                <br />
                <br />
                <asp:Button ID="Button3" runat="server" class="btn btn-inverse" Text="Administrar PlayList" BackColor="Black" ForeColor="White" Font-Bold="True" Width="100%"/>
                <br />
                <br />
                <asp:Button ID="btnAdminEvento" runat="server" class="btn btn-inverse" Text="Administrar Eventos" BackColor="Black" ForeColor="White" Font-Bold="True" Width="100%" OnClick="btnAdminEvento_Click"/>
                <br />
                <br />
                <asp:Button ID="btnAdminContacto" runat="server" class="btn btn-inverse" Text="Administrar Contactos" BackColor="Black" ForeColor="White" Font-Bold="True" Width="100%" OnClick="btnAdminContacto_Click"/>
                <br />
                <br />
                <asp:Button ID="btnAdminSeguidor" runat="server" class="btn btn-inverse" Text="Administrar Seguidores" BackColor="Black" ForeColor="White" Font-Bold="True" Width="100%" OnClick="btnAdminSeguidor_Click"/>
                <br />
                <br />
            </div>
            <div class ="col-md-10 column">
                <br />
                <!-- DATOS DE USUARIO -->
                <div class="row">
                    <div  class="panel panel-info">
                        <div class="panel-heading">
	    	                <h3>Usuario </h3>
		                </div>
                        <div class="panel-body">
                            <div class="row">
                                <div class ="col-md-12 column">
                                    <div class ="col-md-6">
                                        <div class ="r r-2x img-full">
                                            <asp:Image ID="Image1" runat="server" Width ="150" Height ="150" />
                                        </div>
                                        <asp:Label ID="lblImagen" runat="server" Text="Label"><h4>Imagen de Usuario</h4></asp:Label> 
                                        <asp:FileUpload ID="fupImagen" runat="server" CssClass="form-control"/>
                                        <asp:Label ID="lblStatus" runat="server" Text="Label"><h4></h4></asp:Label>
                                        <br />
                                        <br />
                                        <asp:DropDownList ID="DropDownList1" runat="server" CssClass="form-control" AutoPostBack="true" Enabled="false">
                                            <asp:ListItem>Comun</asp:ListItem>
                                            <asp:ListItem>Artista</asp:ListItem>
                                            <asp:ListItem>Organizador</asp:ListItem>
                                        </asp:DropDownList>
                                    </div>
                                    <div class ="col-md-6">
                                        <asp:Label ID="lblID" runat="server" Text="" Visible ="false"><h4></h4></asp:Label>
                                        <asp:Label ID="lblUsuario" runat="server" Text="Label"><h4>Usuario</h4></asp:Label> 
                                        <asp:TextBox ID="txtUsuario" runat="server" CssClass="form-control" placeholder="Usuario..."></asp:TextBox>
                                        <asp:Label ID="lblContrasenia" runat="server" Text="Label"><h4>Contraseña</h4></asp:Label> 
                                        <asp:TextBox ID="txtContrasenia" runat="server" CssClass="form-control" placeholder="Contraseña..."></asp:TextBox>
                                        <asp:Label ID="lblConfirmaContra" runat="server" Text="Label"><h4>Confirmar Contraseña</h4></asp:Label> 
                                        <asp:TextBox ID="txtConfirmaContra" runat="server" CssClass="form-control" placeholder="Contraseña..."></asp:TextBox>
                                        <asp:Label ID="lblGenero" runat="server" Text="Label"><h4>Genero de la banda</h4></asp:Label> 
                                        <asp:DropDownList ID="ddlGenero" runat="server" CssClass="form-control" Enabled="false">
                                            <asp:ListItem>Rock</asp:ListItem>
                                            <asp:ListItem>Tropical</asp:ListItem>
                                            <asp:ListItem>Clasica</asp:ListItem>
                                        </asp:DropDownList>
                                    </div>

                                </div>
                            </div>        
                        </div>
                    </div>
                </div>
                <!-- Datos Personales -->
                <div class ="row">
                    <div  class="panel panel-info">
                        <div class="panel-heading">
                            <h3>Datos Personales</h3>
                        </div>
                        <div class="panel-body">
                            <div class ="row">
                                <div class ="col-md-12 column">
                                    <div class ="col-md-6">
                                        <asp:Label ID="lblNombre" runat="server" Text="Label"><h4>Nombre</h4></asp:Label> 
                                        <asp:TextBox ID="txtNombre" runat="server" CssClass="form-control" placeholder="Nombre Completo..."></asp:TextBox>
                                        <asp:Label ID="lblCorreo" runat="server" Text="Label"><h4>Correo</h4></asp:Label> 
                                        <asp:TextBox ID="txtCorreo" runat="server" CssClass="form-control" placeholder="Correo..."></asp:TextBox>
                                        <br />
                                    </div>
                                    <div class ="col-md-6">        
                                        <asp:Label ID="lblDescripcion" runat="server" Text="Label"><h4>Descrpción</h4></asp:Label> 
                                        <asp:TextBox ID="txtDescripcion" runat="server" CssClass="form-control" placeholder="Descipción..." Height="200px" TextMode="MultiLine"></asp:TextBox>
                                    </div>
                                </div>
                            </div>                                        
                        </div>
                    </div>
                </div>
                <!-- Redes Sociales -->
                <div class="row">
                    <div class="panel panel-info">
			            <div class="panel-heading">
				            <h3>Redes Sociales</h3>
			            </div>
			            <div class="panel-body">
                            <div class ="row">
                                <div class="col-md-12 column">
                                    <div class="col-md-6"> <!-- Usuario Generico Parte 2 -->
                                        <asp:Label ID="lblTwitter" runat="server" Text="Label"><h4>Twitter</h4></asp:Label> 
                                        <asp:TextBox ID="txtTwitter" runat="server" CssClass="form-control" placeholder="Url Twitter..."></asp:TextBox>
                                        <asp:Label ID="lblFacebook" runat="server" Text="Label"><h4>Facebook</h4></asp:Label> 
                                        <asp:TextBox ID="txtFacebook" runat="server" CssClass="form-control" placeholder="Url Facebook..."></asp:TextBox>     
                                    </div>
                                    <div class="col-md-6">
                                        <asp:Label ID="lblYoutube" runat="server" Text="Label"><h4>Youtube</h4></asp:Label> 
                                        <asp:TextBox ID="txtYoutube" runat="server" CssClass="form-control" placeholder="Url Youtube..."></asp:TextBox>   
                                        <asp:Label ID="lblUrl" runat="server" Text="Label"><h4>URL</h4></asp:Label> 
                                        <asp:TextBox ID="rxtUrl" runat="server" CssClass="form-control" placeholder="Url Pagina..."></asp:TextBox>   
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
                <!-- BOTONES -->
                <div class ="row">
                    <div class ="col-md-3"></div>
                    <div class ="col-md-3">
                        <asp:Button ID="btnGuardar" runat="server" Text="Guardar" CssClass="btn btn-default" align ="center" Width="100%" OnClick="btnGuardar_Click"/>
                        <br />
                        <br />
                    </div>

                    <div class ="col-md-3">
                        <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" CssClass="btn btn-default" align ="center"  Width="100%" OnClick="btnCancelar_Click"/>
                    </div>
                    <div class ="col-md-3"></div>
                </div>
                <br />
                <br />

            </div>
        </div>
    <br />
    <br />
    </div>
</asp:Content>
