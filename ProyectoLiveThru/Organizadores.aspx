<%@ Page Language="C#" AutoEventWireup="true"  MasterPageFile="~/Master.Master" CodeBehind="Organizadores.aspx.cs" Inherits="ProyectoLiveThru.Organizadores" %>

<asp:content id="Body" contentplaceholderid="Body" runat="server">
<h2 class="font-thin m-b">
	<asp:Label ID="lblOrganizadores" runat="server">

	</asp:Label>
	<span class="musicbar animate inline m-l-sm" style="width:20px;height:20px">
		<span class="bar1 a1 bg-primary lter"></span>
		<span class="bar2 a2 bg-info lt"></span>
		<span class="bar3 a3 bg-success"></span>
		<span class="bar4 a4 bg-warning dk"></span>
		<span class="bar5 a5 bg-danger dker"></span>
	</span>
</h2>
<div class="row row-sm">

    <asp:Panel ID="idPanelOrganizador" runat="server">

    </asp:Panel>

</div>
</asp:content>
