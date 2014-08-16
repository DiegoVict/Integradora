<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Master.Master" CodeBehind="DashBoard.aspx.cs" Inherits="ProyectoLiveThru.DashBoard" %>

<asp:Content ID="Content2" ContentPlaceHolderID="Body" runat="server">
                <div class ="row">
                <div class="col-md-12 column">
                   
                        <div class="col-md-2 column"  align="left">
                            <br />
                            <asp:Button ID="btnAdminPerfil" runat="server" class="btn btn-inverse" Text="Administrar Perfil" BackColor="Black" ForeColor="White" Font-Bold="True" Width="100%" OnClick="btnAdminPerfil_Click" Visible="false"/>
                            <br />
                            <br />
                            <asp:Button ID="btnModoPerfilPublico" runat="server" class="btn btn-inverse" Text="Modo Perfil Publico" BackColor="Black" ForeColor="White" Font-Bold="True" Width="100%" OnClick="btnModoPerfilPublico_Click"/>
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
                    <div class="col-md-10 column">

                    </div> 
                </div>
                </div>
    </asp:Content>