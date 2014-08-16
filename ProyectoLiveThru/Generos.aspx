<%@ Page Language="C#"  MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Generos.aspx.cs" Inherits="ProyectoLiveThru.Generos" %>

<asp:content id="Body" contentplaceholderid="Body" runat="server">

<h2 class="font-thin m-b">
	Géneros
	<span class="musicbar animate inline m-l-sm" style="width:20px;height:20px">
		<span class="bar1 a1 bg-primary lter"></span>
		<span class="bar2 a2 bg-info lt"></span>
		<span class="bar3 a3 bg-success"></span>
		<span class="bar4 a4 bg-warning dk"></span>
		<span class="bar5 a5 bg-danger dker"></span>
	</span>
</h2>
				<div class="row row-sm">
                    <asp:Panel ID="idPanelArtistas" runat="server">

                    </asp:Panel>
				</div>
				<ul class="pagination pagination">
					<li>
						<a href="#">
							<i class="fa fa-chevron-left"></i>
						</a>
					</li>
					<li class="active">
						<a href="#">1</a>
					</li>
					<li>
						<a href="#">2</a>
					</li>
					<li>
						<a href="#">3</a>
					</li>
					<li>
						<a href="#">4</a>
					</li>
					<li>
						<a href="#">5</a>
					</li>
					<li>
						<a href="#">
							<i class="fa fa-chevron-right"></i>
						</a>
					</li>
				</ul>
</asp:content>