﻿<%@ Page Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="MasNuevo.aspx.cs" Inherits="ProyectoLiveThru.MasNuevo" %>

<asp:content id="Body" contentplaceholderid="Body" runat="server">
<h2 class="font-thin m-b">
	Lo + Nuevo
	<span class="musicbar animate inline m-l-sm" style="width:20px;height:20px">
		<span class="bar1 a1 bg-primary lter"></span>
		<span class="bar2 a2 bg-info lt"></span>
		<span class="bar3 a3 bg-success"></span>
		<span class="bar4 a4 bg-warning dk"></span>
		<span class="bar5 a5 bg-danger dker"></span>
	</span>
</h2>
<div class="row row-sm">
<asp:Panel ID="idPanelMasNuevo" runat="server">

</asp:Panel>

</div>
</asp:content>