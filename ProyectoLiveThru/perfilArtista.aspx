<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Master.Master" CodeBehind="perfilArtista.aspx.cs" Inherits="ProyectoLiveThru.perfilArtista" %>

<asp:content id="Body" contentplaceholderid="Body" runat="server">
<section class="panel panel-default">
	<header class="panel-heading bg-light">
		<ul class="nav nav-tabs nav-justified">
			<li class="active">
				<a href="#historia" data-toggle="tab">Historia</a>
			</li>
			<li>
				<a href="#evento" data-toggle="tab">Eventos</a>
			</li>
			<li>
				<a href="#discografia" data-toggle="tab">Discografia</a>
			</li>
			<li>
				<a href="#contacto" data-toggle="tab">Contacto</a>
			</li>
            <li>
				<a href="#seguidor" data-toggle="tab">Seguidores</a>
			</li>
		</ul>
	</header>
	<div class="panel-body">
		<div class="tab-content">
			<div class="tab-pane active" id="historia">
				<div class="row">
                    <asp:Panel ID="idPanelHistoria" runat="server">


                    </asp:Panel>

				</div>
			</div>
			<div class="tab-pane" id="evento">
				<div class="row">
					<div class="col-md-12">
						<!--INICIO EVENTOS-->
							<section class="panel panel-default portlet-item">
								<header class="panel-heading">
									<ul class="nav nav-pills pull-right">
										<li>
											<a href="#" class="panel-toggle text-muted"> <i class="fa fa-caret-down text-active"></i> <i class="fa fa-caret-up text"></i>
											</a>
										</li>
									</ul>
									Listado de Eventos
								</header>
								<section class="panel-body">
                                    <asp:Panel ID="idPanelEvento" runat="server">


                                    </asp:Panel>
								</section>
							</section>
						<!--FIN EVENTOS-->
					</div>
				</div>
			</div>
			<div class="tab-pane" id="discografia">
				<!--INICIO DISCOGRAFIA-->
				<div class="row row-sm">
	<div class="col-xs-6 col-sm-4 col-md-3 col-lg-2">
		<div class="item">
			<div class="pos-rlt">
				<div class="bottom">
					<span class="badge bg-info m-l-sm m-b-sm">03:20</span>
				</div>
				<div class="item-overlay opacity r r-2x bg-black">
					<div class="text-info padder m-t-sm text-sm"> <i class="fa fa-star"></i> <i class="fa fa-star"></i>
						<i class="fa fa-star"></i>
						<i class="fa fa-star"></i>
						<i class="fa fa-star-o text-muted"></i>
					</div>
					<div class="center text-center m-t-n">
						<a href="#">
							<i class="icon-control-play i-2x"></i>
						</a>
					</div>
					<div class="bottom padder m-b-sm">
						<a href="#" class="pull-right">
							<i class="fa fa-heart-o"></i>
						</a>
						<a href="#">
							<i class="fa fa-plus-circle"></i>
						</a>
					</div>
				</div>
				<a href="#">
					<img src="/Content/Images/p1.jpg" alt="" class="r r-2x img-full"></a>
			</div>
			<div class="padder-v">
				<a href="#" class="text-ellipsis">Tempered Song</a>
				<a href="#" class="text-ellipsis text-xs text-muted">Miaow</a>
			</div>
		</div>
	</div>
	<div class="col-xs-6 col-sm-4 col-md-3 col-lg-2">
		<div class="item">
			<div class="pos-rlt">
				<div class="item-overlay opacity r r-2x bg-black active">
					<div class="text-info padder m-t-sm text-sm">
						<i class="fa fa-star"></i>
						<i class="fa fa-star"></i>
						<i class="fa fa-star"></i>
						<i class="fa fa-star-o text-muted"></i>
						<i class="fa fa-star-o text-muted"></i>
					</div>
					<div class="center text-center m-t-n">
						<a href="#" data-toggle="class">
							<i class="icon-control-play i-2x text"></i>
							<i class="icon-control-pause i-2x text-active"></i>
						</a>
					</div>
					<div class="bottom padder m-b-sm">
						<a href="#" class="pull-right active" data-toggle="class">
							<i class="fa fa-heart-o text"></i>
							<i class="fa fa-heart text-active text-danger"></i>
						</a>
						<a href="#" data-toggle="class">
							<i class="fa fa-plus-circle text"></i>
							<i class="fa fa-check-circle text-active text-info"></i>
						</a>
					</div>
				</div>
				<a href="#">
					<img src="/Content/Images/p2.jpg" alt="" class="r r-2x img-full"></a>
			</div>
			<div class="padder-v">
				<a href="#" class="text-ellipsis">Vivamus vel tincidunt libero</a>
				<a href="#" class="text-ellipsis text-xs text-muted">Lauren Taylor</a>
			</div>
		</div>
	</div>
	<div class="clearfix visible-xs"></div>
	<div class="col-xs-6 col-sm-4 col-md-3 col-lg-2">
		<div class="item">
			<div class="pos-rlt">
				<div class="item-overlay opacity r r-2x bg-black">
					<div class="text-info padder m-t-sm text-sm">
						<i class="fa fa-star"></i>
						<i class="fa fa-star"></i>
						<i class="fa fa-star"></i>
						<i class="fa fa-star"></i>
						<i class="fa fa-star-o text-muted"></i>
					</div>
					<div class="center text-center m-t-n">
						<a href="#">
							<i class="icon-control-play i-2x"></i>
						</a>
					</div>
					<div class="bottom padder m-b-sm">
						<a href="#" class="pull-right">
							<i class="fa fa-heart-o"></i>
						</a>
						<a href="#">
							<i class="fa fa-plus-circle"></i>
						</a>
					</div>
				</div>
				<a href="#">
					<img src="/Content/Images/p3.jpg" alt="" class="r r-2x img-full"></a>
			</div>
			<div class="padder-v">
				<a href="#" class="text-ellipsis">Morbi id neque quam liquam sollicitudin</a>
				<a href="#" class="text-ellipsis text-xs text-muted">Allen JH</a>
			</div>
		</div>
	</div>
	<div class="col-xs-6 col-sm-4 col-md-3 col-lg-2">
		<div class="item">
			<div class="pos-rlt">
				<div class="item-overlay opacity r r-2x bg-black">
					<div class="text-info padder m-t-sm text-sm">
						<i class="fa fa-star"></i>
						<i class="fa fa-star"></i>
						<i class="fa fa-star"></i>
						<i class="fa fa-star"></i>
						<i class="fa fa-star-o text-muted"></i>
					</div>
					<div class="center text-center m-t-n">
						<a href="#">
							<i class="icon-control-play i-2x"></i>
						</a>
					</div>
					<div class="bottom padder m-b-sm">
						<a href="#" class="pull-right">
							<i class="fa fa-heart-o"></i>
						</a>
						<a href="#">
							<i class="fa fa-plus-circle"></i>
						</a>
					</div>
				</div>
				<div class="top">
					<span class="pull-right m-t-n-xs m-r-sm text-white">
						<i class="fa fa-bookmark i-lg"></i>
					</span>
				</div>
				<a href="#">
					<img src="/Content/Images/p4.jpg" alt="" class="r r-2x img-full"></a>
			</div>
			<div class="padder-v">
				<a href="#" class="text-ellipsis">Tincidunt libero</a>
				<a href="#" class="text-ellipsis text-xs text-muted">Amanda Conlan</a>
			</div>
		</div>
	</div>
	<div class="clearfix visible-xs"></div>
	<div class="col-xs-6 col-sm-4 col-md-3 col-lg-2">
		<div class="item">
			<div class="pos-rlt">
				<div class="item-overlay opacity r r-2x bg-black">
					<div class="text-info padder m-t-sm text-sm">
						<i class="fa fa-star"></i>
						<i class="fa fa-star"></i>
						<i class="fa fa-star"></i>
						<i class="fa fa-star"></i>
						<i class="fa fa-star-o text-muted"></i>
					</div>
					<div class="center text-center m-t-n">
						<a href="#">
							<i class="icon-control-play i-2x"></i>
						</a>
					</div>
					<div class="bottom padder m-b-sm">
						<a href="#" class="pull-right">
							<i class="fa fa-heart-o"></i>
						</a>
						<a href="#">
							<i class="fa fa-plus-circle"></i>
						</a>
					</div>
				</div>
				<a href="#">
					<img src="/Content/Images/p5.jpg" alt="" class="r r-2x img-full"></a>
			</div>
			<div class="padder-v">
				<a href="#" class="text-ellipsis">Fermentum diam</a>
				<a href="#" class="text-ellipsis text-xs text-muted">Nisa Colen</a>
			</div>
		</div>
	</div>
	<div class="col-xs-6 col-sm-4 col-md-3 col-lg-2">
		<div class="item">
			<div class="pos-rlt">
				<div class="top">
					<span class="pull-right m-t-sm m-r-sm badge bg-info">6</span>
				</div>
				<div class="item-overlay opacity r r-2x bg-black">
					<div class="text-info padder m-t-sm text-sm">
						<i class="fa fa-star"></i>
						<i class="fa fa-star"></i>
						<i class="fa fa-star"></i>
						<i class="fa fa-star"></i>
						<i class="fa fa-star-o text-muted"></i>
					</div>
					<div class="center text-center m-t-n">
						<a href="#">
							<i class="icon-control-play i-2x"></i>
						</a>
					</div>
					<div class="bottom padder m-b-sm">
						<a href="#" class="pull-right">
							<i class="fa fa-heart-o"></i>
						</a>
						<a href="#">
							<i class="fa fa-plus-circle"></i>
						</a>
					</div>
				</div>
				<a href="#">
					<img src="/Content/Images/p6.jpg" alt="" class="r r-2x img-full"></a>
			</div>
			<div class="padder-v">
				<a href="#" class="text-ellipsis">Habitant</a>
				<a href="#" class="text-ellipsis text-xs text-muted">Dan Doorack</a>
			</div>
		</div>
	</div>
	<div class="clearfix visible-xs"></div>
	<div class="col-xs-6 col-sm-4 col-md-3 col-lg-2">
		<div class="item">
			<div class="pos-rlt">
				<div class="item-overlay opacity r r-2x bg-black">
					<div class="text-info padder m-t-sm text-sm">
						<i class="fa fa-star"></i>
						<i class="fa fa-star"></i>
						<i class="fa fa-star"></i>
						<i class="fa fa-star"></i>
						<i class="fa fa-star-o text-muted"></i>
					</div>
					<div class="center text-center m-t-n">
						<a href="#">
							<i class="icon-control-play i-2x"></i>
						</a>
					</div>
					<div class="bottom padder m-b-sm">
						<a href="#" class="pull-right">
							<i class="fa fa-heart-o"></i>
						</a>
						<a href="#">
							<i class="fa fa-plus-circle"></i>
						</a>
					</div>
				</div>
				<div class="top">
					<span class="pull-right m-t-sm m-r-sm badge bg-white">12</span>
				</div>
				<a href="#">
					<img src="/Content/Images/p7.jpg" alt="" class="r r-2x img-full"></a>
			</div>
			<div class="padder-v">
				<a href="#" class="text-ellipsis">Vivamus vel tincidunt libero</a>
				<a href="#" class="text-ellipsis text-xs text-muted">Ligula H</a>
			</div>
		</div>
	</div>
	<div class="col-xs-6 col-sm-4 col-md-3 col-lg-2">
		<div class="item">
			<div class="pos-rlt">
				<div class="item-overlay opacity r r-2x bg-black">
					<div class="text-info padder m-t-sm text-sm">
						<i class="fa fa-star"></i>
						<i class="fa fa-star"></i>
						<i class="fa fa-star"></i>
						<i class="fa fa-star"></i>
						<i class="fa fa-star-o text-muted"></i>
					</div>
					<div class="center text-center m-t-n">
						<a href="#">
							<i class="icon-control-play i-2x"></i>
						</a>
					</div>
					<div class="bottom padder m-b-sm">
						<a href="#" class="pull-right">
							<i class="fa fa-heart-o"></i>
						</a>
						<a href="#">
							<i class="fa fa-plus-circle"></i>
						</a>
					</div>
				</div>
				<a href="#">
					<img src="/Content/Images/p8.jpg" alt="" class="r r-2x img-full"></a>
			</div>
			<div class="padder-v">
				<a href="#" class="text-ellipsis">Aliquam sollicitudin venenati</a>
				<a href="#" class="text-ellipsis text-xs text-muted">James East</a>
			</div>
		</div>
	</div>
	<div class="clearfix visible-xs"></div>
	<div class="col-xs-6 col-sm-4 col-md-3 col-lg-2">
		<div class="item">
			<div class="pos-rlt">
				<div class="item-overlay opacity r r-2x bg-black">
					<div class="text-info padder m-t-sm text-sm">
						<i class="fa fa-star"></i>
						<i class="fa fa-star"></i>
						<i class="fa fa-star"></i>
						<i class="fa fa-star"></i>
						<i class="fa fa-star-o text-muted"></i>
					</div>
					<div class="center text-center m-t-n">
						<a href="#">
							<i class="icon-control-play i-2x"></i>
						</a>
					</div>
					<div class="bottom padder m-b-sm">
						<a href="#" class="pull-right">
							<i class="fa fa-heart-o"></i>
						</a>
						<a href="#">
							<i class="fa fa-plus-circle"></i>
						</a>
					</div>
				</div>
				<a href="#">
					<img src="/Content/Images/p9.jpg" alt="" class="r r-2x img-full"></a>
			</div>
			<div class="padder-v">
				<a href="#" class="text-ellipsis">Lementum ligula vitae</a>
				<a href="#" class="text-ellipsis text-xs text-muted">Lauren Taylor</a>
			</div>
		</div>
	</div>
	<div class="col-xs-6 col-sm-4 col-md-3 col-lg-2">
		<div class="item">
			<div class="pos-rlt">
				<div class="item-overlay r r-2x bg-light dker active">
					<div class="text-info padder m-t-sm text-sm">
						<i class="fa fa-star"></i>
						<i class="fa fa-star"></i>
						<i class="fa fa-star"></i>
						<i class="fa fa-star"></i>
						<i class="fa fa-star-o text-muted"></i>
					</div>
					<div class="center text-center m-t-n">
						<a href="#" data-toggle="class" class="active">
							<i class="icon-control-play i-2x text"></i>
							<i class="icon-control-pause i-2x text-active"></i>
						</a>
					</div>
					<div class="bottom padder m-b-sm">
						<a href="#" class="pull-right" data-toggle="class">
							<i class="fa fa-heart-o text"></i>
							<i class="fa fa-heart text-active text-danger"></i>
						</a>
						<a href="#" class="active" data-toggle="class">
							<i class="fa fa-plus-circle text"></i>
							<i class="fa fa-check-circle text-active text-info"></i>
						</a>
					</div>
				</div>
				<a href="#">
					<img src="/Content/Images/p10.jpg" alt="" class="r r-2x img-full"></a>
			</div>
			<div class="padder-v">
				<a href="#" class="text-ellipsis">Egestas dui nec fermentum</a>
				<a href="#" class="text-ellipsis text-xs text-muted">Chris Fox</a>
			</div>
		</div>
	</div>
	<div class="clearfix visible-xs"></div>
	<div class="col-xs-6 col-sm-4 col-md-3 col-lg-2">
		<div class="item">
			<div class="pos-rlt">
				<div class="item-overlay opacity r r-2x bg-black">
					<div class="text-info padder m-t-sm text-sm">
						<i class="fa fa-star"></i>
						<i class="fa fa-star"></i>
						<i class="fa fa-star"></i>
						<i class="fa fa-star"></i>
						<i class="fa fa-star-o text-muted"></i>
					</div>
					<div class="center text-center m-t-n">
						<a href="#">
							<i class="icon-control-play i-2x"></i>
						</a>
					</div>
					<div class="bottom padder m-b-sm">
						<a href="#" class="pull-right">
							<i class="fa fa-heart-o"></i>
						</a>
						<a href="#">
							<i class="fa fa-plus-circle"></i>
						</a>
					</div>
				</div>
				<a href="#">
					<img src="/Content/Images/p11.jpg" alt="" class="r r-2x img-full"></a>
			</div>
			<div class="padder-v">
				<a href="#" class="text-ellipsis">Aliquam sollicitudin venenatis ipsum</a>
				<a href="#" class="text-ellipsis text-xs text-muted">Jack Jason</a>
			</div>
		</div>
	</div>
	<div class="col-xs-6 col-sm-4 col-md-3 col-lg-2">
		<div class="item">
			<div class="pos-rlt">
				<div class="item-overlay opacity r r-2x bg-black">
					<div class="text-info padder m-t-sm text-sm">
						<i class="fa fa-star"></i>
						<i class="fa fa-star"></i>
						<i class="fa fa-star"></i>
						<i class="fa fa-star"></i>
						<i class="fa fa-star-o text-muted"></i>
					</div>
					<div class="center text-center m-t-n">
						<a href="#">
							<i class="icon-control-play i-2x"></i>
						</a>
					</div>
					<div class="bottom padder m-b-sm">
						<a href="#" class="pull-right">
							<i class="fa fa-heart-o"></i>
						</a>
						<a href="#">
							<i class="fa fa-plus-circle"></i>
						</a>
					</div>
				</div>
				<a href="#">
					<img src="/Content/Images/p12.jpg" alt="" class="r r-2x img-full"></a>
			</div>
			<div class="padder-v">
				<a href="#" class="text-ellipsis">Vestibulum ullamcorper</a>
				<a href="#" class="text-ellipsis text-xs text-muted">MM &amp; DD</a>
			</div>
		</div>
	</div>
</div>
				<!--FIN DISCOGRAFIA-->
			</div>
			<div class="tab-pane" id="contacto">
                <asp:Panel ID="idPanelContacto" runat="server">

                </asp:Panel>
				</div>
            <div class="tab-pane" id="seguidor">
				<!--INICIO SEGUIDOR-->
				<div class="row row-sm">
<asp:Panel ID="idPanelSeguidor" runat="server"> </asp:Panel>
</div>
				<!--FIN SEGUIDOR-->
			</div>

			</div>
		</div>
</section>
    </asp:content>