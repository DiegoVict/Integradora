<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="UsuarioEstandarModificar.aspx.cs" Inherits="ProyectoLiveThru.UsuarioEstandarModificar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Body" runat="server">
    <h2 class="font-thin m-b">
	    Mi Perfil
    </h2>

    <div class ="container">
        <div class="row">
            <div class="panel-body">
                <!-- Datos de usuario -->
                <div class ="row">
                    <div class="col-md-11 column">
                        <div class="panel-body">
                            <div class="tab-content">
                                <div class="tab-pane fade active in" id ="general">
                                    <div class="row"> 
                                        <div class=" panel-body">
                                            <div class="col-md-6" > <!-- Usuario Generico Parte 1 -->
                                                <asp:Label ID="lblID" runat="server" Text="" Visible ="false"><h4></h4></asp:Label>
                                                <asp:Label ID="lblUsuario" runat="server" Text="Label"><h4>Usuario</h4></asp:Label> 
                                                <asp:TextBox ID="txtUsuario" runat="server" CssClass="form-control" placeholder="Usuario..."></asp:TextBox>
                                                <asp:Label ID="lblContrasenia" runat="server" Text="Label"><h4>Contraseña</h4></asp:Label> 
                                                <asp:TextBox ID="txtContrasenia" runat="server" CssClass="form-control" placeholder="Contraseña..."></asp:TextBox>
                                                <asp:Label ID="lblConfirmaContra" runat="server" Text="Label"><h4>Confirmar Contraseña</h4></asp:Label> 
                                                <asp:TextBox ID="txtConfirmaContra" runat="server" CssClass="form-control" placeholder="Contraseña..."></asp:TextBox>
                                                <asp:Label ID="lblCorreo" runat="server" Text="Label"><h4>Correo</h4></asp:Label> 
                                                <asp:TextBox ID="txtCorreo" runat="server" CssClass="form-control" placeholder="Correo..."></asp:TextBox>
                                            </div>
                                            <div class="col-md-6"> <!-- Usuario Generico Parte 2 -->
                                                <asp:Label ID="lblTwitter" runat="server" Text="Label"><h4>Twitter</h4></asp:Label> 
                                                <asp:TextBox ID="txtTwitter" runat="server" CssClass="form-control" placeholder="Url Twitter..."></asp:TextBox>
                                                <asp:Label ID="lblFacebook" runat="server" Text="Label"><h4>Facebook</h4></asp:Label> 
                                                <asp:TextBox ID="txtFacebook" runat="server" CssClass="form-control" placeholder="Url Facebook..."></asp:TextBox>
                                                <asp:Label ID="lblYoutube" runat="server" Text="Label"><h4>Youtube</h4></asp:Label> 
                                                <asp:TextBox ID="txtYoutube" runat="server" CssClass="form-control" placeholder="Url Youtube..."></asp:TextBox>
                                                <asp:Label ID="lblTipo" runat="server" Text="Label"><h4>Tipo de Usuario</h4></asp:Label> 
                                                <asp:DropDownList ID="DropDownList1" runat="server" CssClass="form-control" AutoPostBack="true" Enabled="false">
                                                    <asp:ListItem>Comun</asp:ListItem>
                                                    <asp:ListItem>Artista</asp:ListItem>
                                                    <asp:ListItem>Organizador</asp:ListItem>
                                                </asp:DropDownList>
                                            </div>
                                        </div>
                                    </div>
                                    <div class ="row">
                                        <div class ="panel-body">
                                            <div class ="col-lg-6">
                                                <asp:Label ID="lblNombre" runat="server" Text="Label"><h4>Nombre</h4></asp:Label> 
                                                <asp:TextBox ID="txtNombre" runat="server" CssClass="form-control" placeholder="Nombre Completo..."></asp:TextBox>
                                                <asp:Label ID="lblDescripcion" runat="server" Text="Label"><h4>Descrpción</h4></asp:Label> 
                                                <asp:TextBox ID="txtDescripcion" runat="server" CssClass="form-control" placeholder="Descipción..." Height="200px" TextMode="MultiLine"></asp:TextBox>
                                            </div>
                                            <div class ="col-md-6">
                                                <asp:Panel ID="pnlEstandar" runat="server" Visible="true">
                                                    <asp:Label ID="lblNacimiento" runat="server" Text="Label"><h4>Fecha de Nacimiento (DD/mm/YYYY)</h4></asp:Label> 
                                                    <asp:TextBox ID="txtNacimiento" runat="server" CssClass="form-control" placeholder="Fecha de Nacimiento..."></asp:TextBox>
                                                    <asp:Label ID="lblSexo" runat="server" Text="Label"><h4>Sexo</h4></asp:Label>
                                                    <asp:DropDownList ID="ddlSexo" runat="server" CssClass="form-control">
                                                        <asp:ListItem>Hombre</asp:ListItem>
                                                        <asp:ListItem>Mujer</asp:ListItem>
                                                        <asp:ListItem>Otro</asp:ListItem>
                                                    </asp:DropDownList>
                                                </asp:Panel>
                                                <asp:Label ID="lblImagen" runat="server" Text="Label"><h4>Imagen de Usuario</h4></asp:Label> 
                                                <asp:FileUpload ID="fupImagen" runat="server" CssClass="form-control"/>
                                                <br />
                                                <div class ="r r-2x img-full">
                                                    <asp:Image ID="Image1" runat="server" />
                                                </div>
                                                <asp:Label ID="lblStatus" runat="server" Text="Label"><h4></h4></asp:Label> 
                                            </div>
                                        </div>
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
                        <asp:Button ID="btnGuardar" runat="server" Text="Guardar" CssClass="btn btn-default" align ="center" Width="100%" OnClick="btnGuardar_Click" />
                    </div>
                    <div class ="col-md-3">
                        <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" CssClass="btn btn-default" align ="center"  Width="100%"/>
                    </div>
                    <div class ="col-md-3"></div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="Footer" runat="server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="VLAside" runat="server">
</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="scripts" runat="server">
</asp:Content>
