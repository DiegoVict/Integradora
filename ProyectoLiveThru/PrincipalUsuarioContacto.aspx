<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" EnableEventValidation="false" ValidateRequest="false" AutoEventWireup="true" CodeBehind="PrincipalUsuarioContacto.aspx.cs" Inherits="ProyectoLiveThru.Formulario_web2" %>
<asp:Content ID="Body" ContentPlaceHolderID="Body" runat="server">
    <div class="panel panel-default">
			    <div class="panel-heading">
				    <h4>Contactos</h4>
			    </div>
			    <div class="panel-body">
                <div class ="row">
                <div class="col-md-12 column">
				    <div class="panel-body">
                    <ul class="nav nav-tabs">

                    <li id="tabOriganizador" class="active">
                    <a href="#Listado" data-toggle="tab">Listado De Contantos</a>
		                </li>
                    <li id="tbOrganizadorModificar">
                    <a href="#general" data-toggle="tab">Agregar Contacto(s)</a>
                    </li>
		             <li  id="tabContacto" >
                     <a href="#direccion" data-toggle="tab">Modificar Contacto(s)</a>
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
                                        <asp:BoundField DataField="NombreCompleto" HeaderText="Nombre" />
                                        <asp:BoundField DataField="telefono" HeaderText="Telefono" />
                                        <asp:BoundField DataField="correo" HeaderText="Correo" />
                                        <asp:BoundField DataField="rfc" HeaderText="frc" />
                                        <asp:BoundField DataField="descripcion" HeaderText="Descripcion" />
                                       <asp:TemplateField HeaderText="Opciones" InsertVisible="False" ShowHeader="False">
                                            <ItemTemplate>
                                                <asp:ImageButton ID="ImageButton1" runat="server" CausesValidation="False" CommandName="Select" ImageUrl="~/Images/1395795442_48111.ico" Text="Editar" />
                                                <asp:ImageButton ID="ImageButton2" runat="server" CausesValidation="False" CommandName="Delete" ImageUrl="~/Images/1395795438_11746.ico" Text="Eliminar"/>
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
     <asp:TextBox ID="TextBox1" runat="server" CssClass="form-control" Width="100%" 
     align="center" placeholder="" Enabled="False" MaxLength="7" ></asp:TextBox>
    <br />
    <asp:Label ID="Label2" runat="server" Text="Nombre"></asp:Label>
    <asp:TextBox ID="txtNombre" runat="server" class="form-control" Width="100%" 
     align="center" placeholder="Ingrese Nombre..."></asp:TextBox><br />
    <br />
    <asp:Label ID="Label3" runat="server" Text="Apellido Paterno"></asp:Label>
    <asp:TextBox ID="txtApellidoPat" runat="server" class="form-control" Width="100%" 
     align="center" placeholder="Ingrese Apellido Paterno..."></asp:TextBox><br />
    <br />
    <asp:Label ID="Label4" runat="server" Text="Apellido Materno"></asp:Label>
    <asp:TextBox ID="txtApellidoMat" runat="server" class="form-control" Width="100%" 
     align="center" placeholder="Ingrese Apellido Materno..."></asp:TextBox><br />
    <br />
     <asp:Label ID="Label8" runat="server" Text="Telefono"></asp:Label>
    <asp:TextBox ID="txtTelefono" runat="server" class="form-control" Width="100%" 
     align="center" placeholder="Ingrese Telefono..."></asp:TextBox><br />
    <br />
    <asp:Label ID="Label5" runat="server" Text="Correo"></asp:Label>
    <asp:TextBox ID="txtCorreo" runat="server" class="form-control" Width="100%" 
     align="center" placeholder="Ingrese Correo..."></asp:TextBox><br />
    <br />
    <asp:Label ID="Label6" runat="server" Text="RFC"></asp:Label>
    <asp:TextBox ID="txtRFC" runat="server" class="form-control" Width="100%" 
     align="center" placeholder="Ingrese RFC..."></asp:TextBox><br />
    <br />
    <asp:Label ID="Label7" runat="server" Text="Descripcion"></asp:Label>
    <asp:TextBox ID="txtDescripcion" runat="server" class="form-control" Width="100%" 
     align="center" placeholder="Ingrese Descripcion..."></asp:TextBox><br />
    <br />
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
                           <asp:Button ID="btnAgregarContacto" runat="server" Width="100%"  Text="Agregar Contacto" 
                            class="btn btn-inverse" BackColor="Black" ForeColor=White OnClick="btnAgregarContacto_Click"/>
                        
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
     <asp:Label runat="server" ID="lblClaveContacto" align="left"> <h4>Clave:</h4></asp:Label>
     <asp:TextBox ID="txtClaveContacto" runat="server" CssClass="form-control" Width="100%" 
     align="center" placeholder="" Enabled="False" MaxLength="7" ></asp:TextBox>
    <br />
    <asp:Label ID="Label10" runat="server" Text="Nombre"></asp:Label>
    <asp:TextBox ID="TextBox2" runat="server" class="form-control" Width="100%" 
     align="center" placeholder="Ingrese Nombre..."></asp:TextBox><br />
    <br />
    <asp:Label ID="Label11" runat="server" Text="Apellido Paterno"></asp:Label>
    <asp:TextBox ID="TextBox3" runat="server" class="form-control" Width="100%" 
     align="center" placeholder="Ingrese Apellido Paterno..."></asp:TextBox><br />
    <br />
    <asp:Label ID="Label12" runat="server" Text="Apellido Materno"></asp:Label>
    <asp:TextBox ID="TextBox4" runat="server" class="form-control" Width="100%" 
     align="center" placeholder="Ingrese Apellido Materno..."></asp:TextBox><br />
    <br />
     <asp:Label ID="Label13" runat="server" Text="Telefono"></asp:Label>
    <asp:TextBox ID="TextBox5" runat="server" class="form-control" Width="100%" 
     align="center" placeholder="Ingrese Telefono..."></asp:TextBox><br />
    <br />
    <asp:Label ID="Label14" runat="server" Text="Correo"></asp:Label>
    <asp:TextBox ID="TextBox6" runat="server" class="form-control" Width="100%" 
     align="center" placeholder="Ingrese Correo..."></asp:TextBox><br />
    <br />
    <asp:Label ID="Label15" runat="server" Text="RFC"></asp:Label>
    <asp:TextBox ID="TextBox7" runat="server" class="form-control" Width="100%" 
     align="center" placeholder="Ingrese RFC..."></asp:TextBox><br />
    <br />
    <asp:Label ID="Label16" runat="server" Text="Descripcion"></asp:Label>
    <asp:TextBox ID="TextBox8" runat="server" class="form-control" Width="100%" 
     align="center" placeholder="Ingrese Descripcion..."></asp:TextBox><br />
    <br />
                                    <br />
                                                            <div class="row">
                     <div class="col-md-12" align="center">
                 <div class="col-md-3">
                <div align="center"></div>
                </div>
                    <div class="col-md-6">
                    <div align="center">
                            <asp:Button ID="btnModificarContacto" runat="server" Width="100%"  Text="Modificar Contacto" 
                            class="btn btn-inverse" BackColor="Black" ForeColor=White OnClick="btnModificarContacto_Click" />
                        
                            </div>
                        </div>
                        <div class="col-md-3"></div>
</div> 
        </div>

                            </div>
                        <div class="col-md-6" >
                            <br />
                             <div class="table-responsive">
                                 <!-- aqui va el datagrid-->
                                                         <asp:GridView ID="GridView1" runat="server" align="center" BackColor="White" 
                            BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" CellPadding="3" 
                            ForeColor="Black" GridLines="Vertical" AutoGenerateColumns="False" EmptyDataText="<strong>No se encontraron Contactos.</strong>"> 
                            <AlternatingRowStyle BackColor="#CCCCCC" />
                            <Columns>
                                <asp:BoundField DataField="idContacto" HeaderText="Clave Contacto" />
                                                                <asp:BoundField DataField="NombreContacto" HeaderText="Nombre del contacto" />
                                <asp:BoundField DataField="telefono" HeaderText="Telefono" />
                                <asp:BoundField DataField="correo" HeaderText="Correo" />
        <asp:TemplateField HeaderText="Opciones" InsertVisible="False" ShowHeader="False">
            <ItemTemplate>
                <asp:ImageButton ID="ImageButton1" runat="server" CausesValidation="False" CommandName="Select" ImageUrl="~/img/upateInfo.ico" Text="Seleccionar" />
                <asp:ImageButton ID="ImageButton2" runat="server" CausesValidation="False" CommandName="Delete" ImageUrl="~/img/1395795438_11746.ico" Text="Eliminar"/>
            </ItemTemplate>
        </asp:TemplateField>
                            </Columns>

                            <FooterStyle BackColor="#CCCCCC" />
                            <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
                            <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
                            <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
                        </asp:GridView>
</div>
                     </div>
                                

                            </div>
                                    </ContentTemplate>
        <Triggers>
            <asp:AsyncPostBackTrigger ControlID="btnAgregarContacto" />
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
