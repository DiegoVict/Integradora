<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="UsuarioRegistro.aspx.cs" Inherits="ProyectoLiveThru.UsuarioRegistro" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Body" runat="server">
    <div class ="row">
        <div class="col-md-12 column">
            <br />
            <!-- DATOS USUARIO -->
            <div class ="row">
                <div class="panel panel-info">
                    <div class="panel-heading">
                        <h3>Usuario</h3>
                    </div>
                    <div class="panel-body">
                        <div class="row">
                            <div class="col-md-12">
                                <div class="col-md-6">
                                    <div class="r r-2x img-full">
                                        <asp:Image ID="imgUsuario" runat="server" Width ="150" Height ="150" ImageUrl="~/Images/yaranaika_money.jpg" />
                                    </div> 
                                    <asp:Label ID="lblImagen" runat="server" Text="Label"><h4>Imagen de Usuario</h4></asp:Label> 
                                    <asp:FileUpload ID="fupImagen" runat="server" CssClass="form-control"/>
                                    <asp:Label ID="lblStatus" runat="server" Text="Label"><h4></h4></asp:Label> 
                                    <asp:Label ID="lblTipo" runat="server" Text="Label"><h4>Tipo de Usuario</h4></asp:Label> 
                                    <asp:DropDownList ID="DropDownList1" runat="server" CssClass="form-control" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" AutoPostBack="true">
                                        <asp:ListItem>Comun</asp:ListItem>
                                        <asp:ListItem>Artista</asp:ListItem>
                                        <asp:ListItem>Organizador</asp:ListItem>
                                    </asp:DropDownList>
                                </div>
                                <div class="col-md-6">
                                    <asp:Label ID="lblUsuario" runat="server" Text="Label"><h4>Usuario</h4></asp:Label> 
                                    <asp:TextBox ID="txtUsuario" runat="server" CssClass="form-control" placeholder="Usuario..."></asp:TextBox>
                                    <asp:Label ID="lblContrasenia" runat="server" Text="Label"><h4>Contraseña</h4></asp:Label> 
                                    <asp:TextBox ID="txtContrasenia" runat="server" CssClass="form-control" placeholder="Contraseña..."></asp:TextBox>
                                    <asp:Label ID="lblConfirmaContra" runat="server" Text="Label"><h4>Confirmar Contraseña</h4></asp:Label> 
                                    <asp:TextBox ID="txtConfirmaContra" runat="server" CssClass="form-control" placeholder="Contraseña..."></asp:TextBox>
                                    <asp:Label ID="lblGenero" runat="server" Text="&lt;h4&gt;Genero de la banda&lt;/h4&gt;" Visible="False"></asp:Label> 
                                    <asp:DropDownList ID="ddlGenero" runat="server" CssClass="form-control" Visible="False">
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
            <!-- DATOS PERSONALES -->
            <div class="row">
                <div class="panel panel-info">
                    <div class="panel-heading">
                        <h3>Datos Personales</h3>
                    </div>
                    <div class="panel-body">
                        <div class="row">
                            <div class="col-md-12">
                                <div class="col-md-6">
                                    <asp:Label ID="lblNombre" runat="server" Text="Label"><h4>Nombre</h4></asp:Label> 
                                    <asp:TextBox ID="txtNombre" runat="server" CssClass="form-control" placeholder="Nombre Completo..."></asp:TextBox>
                                    <asp:Label ID="lblCorreo" runat="server" Text="Label"><h4>Correo</h4></asp:Label> 
                                    <asp:TextBox ID="txtCorreo" runat="server" CssClass="form-control" placeholder="Correo..."></asp:TextBox>   
                                    <asp:Label ID="lblNacimiento" runat="server" Text="Label"><h4>Fecha de Nacimiento (DD/mm/YYYY)</h4></asp:Label> 
                                    <asp:TextBox ID="txtNacimiento" runat="server" CssClass="form-control" placeholder="Fecha de Nacimiento..."></asp:TextBox>
                                    <asp:Label ID="lblSexo" runat="server" Text="Label"><h4>Sexo</h4></asp:Label>
                                    <asp:DropDownList ID="ddlSexo" runat="server" CssClass="form-control">
                                        <asp:ListItem>Hombre</asp:ListItem>
                                        <asp:ListItem>Mujer</asp:ListItem>
                                        <asp:ListItem>Otro</asp:ListItem>
                                    </asp:DropDownList>          
                                </div>
                                <div class="col-md-6">
                                    <asp:Label ID="lblDescripcion" runat="server" Text="Label"><h4>Descrpción</h4></asp:Label> 
                                    <asp:TextBox ID="txtDescripcion" runat="server" CssClass="form-control" placeholder="Descipción..." Height="200px" TextMode="MultiLine"></asp:TextBox>
                                </div>
                            </div>
                        </div>
                    </div>
                </div> 
            </div>
            <!-- REDES SOCIALES -->
            <div class="row">
                <div class="panel panel-info" >
                    <div class="panel-heading">
                        <h3>Redes Sociales</h3>
                    </div>
                    <div class="panel-body">
                        <div class="row">
                            <div class="col-md-12">
                                <div class="col-md-6">
                                    <asp:Label ID="lblTwitter" runat="server" Text="Label"><h4>Twitter</h4></asp:Label> 
                                    <asp:TextBox ID="txtTwitter" runat="server" CssClass="form-control" placeholder="Url Twitter..."></asp:TextBox>
                                    <asp:Label ID="lblFacebook" runat="server" Text="Label"><h4>Facebook</h4></asp:Label> 
                                    <asp:TextBox ID="txtFacebook" runat="server" CssClass="form-control" placeholder="Url Facebook..."></asp:TextBox>                                                
                                </div>
                                <div class="col-md-6">
                                    <asp:Label ID="lblYoutube" runat="server" Text="Label"><h4>Youtube</h4></asp:Label> 
                                    <asp:TextBox ID="txtYoutube" runat="server" CssClass="form-control" placeholder="Url Youtube..."></asp:TextBox>
                                    <asp:Label ID="lblURL" runat="server" Text="Label"><h4>Youtube</h4></asp:Label> 
                                    <asp:TextBox ID="txtURL" runat="server" CssClass="form-control" placeholder="Url Pagina..."></asp:TextBox>            
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
                    <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" CssClass="btn btn-default" align ="center"  Width="100%" OnClick="btnCancelar_Click"/>
                </div>
                <div class ="col-md-3"></div>
            </div>
            <br />
            <br />
        </div>
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="Footer" runat="server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="VLAside" runat="server">
</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="scripts" runat="server">
</asp:Content>
