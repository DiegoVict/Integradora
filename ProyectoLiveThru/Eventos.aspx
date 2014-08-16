<%@ Page Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Eventos.aspx.cs" Inherits="ProyectoLiveThru.Eventos" %>

<asp:content id="Body" contentplaceholderid="Body" runat="server">
<h2 class="font-thin m-b">
	Eventos
</h2>

<div class="row">
    <div class="col-sm-12">
		<div class="blog-post">
<asp:Panel ID="idPanelEvento" runat="server">


</asp:Panel>
		</div>
		<div class="text-center m-t-lg m-b-lg">
			<ul class="pagination pagination-md">
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
		</div>
	</div>
</div>
</asp:content>