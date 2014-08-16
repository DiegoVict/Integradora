<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Master.Master" CodeBehind="Index.aspx.cs" Inherits="ProyectoLiveThru.Index" %>

<asp:content id="head" contentplaceholderid="head" runat="server">
	<link rel="stylesheet" href="/Content/wowslider/engine1/style.css" type="text/css" />
    <script src="Content/wowslider/engine1/jquery.js"></script>
</asp:content>

<asp:content id="Body" contentplaceholderid="Body" runat="server">
    <!-- INICIO CArroucel -->
    <br />
    <!-- Start WOWSlider.com BODY section --> <!-- add to the <body> of your page -->
<div id="wowslider-container1">
	<div class="ws_images">
		<ul>
			<li>
				<img src="/Content/wowslider/data1/images/nocheblanca2.jpg" alt="" title="" id="wows1_0"/>
			</li>
			<li>
				<img src="/Content/wowslider/data1/images/hellandheaven.jpg" alt="" title="" id="wows1_1"/>
			</li>
			<li>
				<img src="/Content/wowslider/data1/images/xma.jpg" alt="" title="" id="wows1_2"/>
			</li>
			<li>
				<img src="/Content/wowslider/data1/images/tsunami.jpg" alt="" title="" id="wows1_3"/>
			</li>
			<li>
				<img src="/Content/wowslider/data1/images/vertigo.jpg" alt="" title="" id="wows1_4"/>
			</li>
			<li>
				<img src="/Content/wowslider/data1/images/tributoguns2.jpg" alt="" title="" id="wows1_5"/>
			</li>
            <li>
				<img src="/Content/wowslider/data1/images/redbull2.jpg" />" alt="" title="" id="Img1"/>
			</li>
		</ul>
	</div>   
    </div>
	<div class="ws_shadow"></div>

<!--Fin Carroucel-->
<!--<a href="#" class="pull-right text-muted m-t-lg" data-toggle="class:fa-spin" >
	<i class="icon-refresh i-lg inline" id="refresh"></i>
</a>-->
    <!-- espacio reservado para publicidad-->

    <br />
<div class="panel panel-warning">
  <div class="panel-body">
      <br />
    <h4><b>Espacio Reservado para publicidad</b></h4>
      <br />
  </div>
</div>


    <!-- espacio reservado para publicidad-->

<h2 class="font-thin m-b">
	Últimos eventos registrados
	<span class="musicbar animate inline m-l-sm" style="width:20px;height:20px">
		<span class="bar1 a1 bg-primary lter"></span>
		<span class="bar2 a2 bg-info lt"></span>
		<span class="bar3 a3 bg-success"></span>
		<span class="bar4 a4 bg-warning dk"></span>
		<span class="bar5 a5 bg-danger dker"></span>
	</span>
</h2>
<div class="row row-sm">
	<div class="col-xs-6 col-sm-4 col-md-4 col-lg-3">
		<div class="item">
			<div class="pos-rlt">
				<div class="bottom">
					<span class="badge bg-info m-l-sm m-b-sm">03:20</span>
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
					<img src="/Content/assets/images/p1.jpg" alt="" class="r r-2x img-full"></a>
			</div>
			<div class="padder-v">
				<a href="#" class="text-ellipsis">Evento 1</a>
				<a href="#" class="text-ellipsis text-xs text-muted">evento</a>
			</div>
		</div>
	</div>
	<div class="col-xs-6 col-sm-4 col-md-4 col-lg-3">
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
					<img src="/Content/assets/images/p2.jpg" alt="" class="r r-2x img-full"></a>
			</div>
			<div class="padder-v">
				<a href="#" class="text-ellipsis">Música en el apagon Mérida</a>
				<a href="#" class="text-ellipsis text-xs text-muted">Lauren Taylor</a>
			</div>
		</div>
	</div>
	<div class="clearfix visible-xs"></div>
	<div class="col-xs-6 col-sm-4 col-md-4 col-lg-3">
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
					<img src="/Content/assets/images/p3.jpg" alt="" class="r r-2x img-full"></a>
			</div>
			<div class="padder-v">
				<a href="#" class="text-ellipsis">Concierto Ferroviario</a>
				<a href="#" class="text-ellipsis text-xs text-muted">Allen JH</a>
			</div>
		</div>
	</div>
	<div class="col-xs-6 col-sm-4 col-md-4 col-lg-3">
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
					<img src="/Content/assets/images/p4.jpg" alt="" class="r r-2x img-full"></a>
			</div>
			<div class="padder-v">
				<a href="#" class="text-ellipsis">tsunami Mérida</a>
				<a href="#" class="text-ellipsis text-xs text-muted">Amanda Conlan</a>
			</div>
		</div>
	</div>
</div>
<div class="row">
	<div class="col-md-7">
		<h3 class="font-thin">Ultimos artistas/bandas registradas</h3>
		<div class="row row-sm">
			<div class="col-xs-6 col-sm-3">
				<div class="item">
					<div class="pos-rlt">
						<div class="item-overlay opacity r r-2x bg-black">
							<div class="center text-center m-t-n">
								<a href="#">
									<i class="fa fa-play-circle i-2x"></i>
								</a>
							</div>
						</div>
						<a href="#">
							<img src="/Content/assets/images/a2.png" alt="" class="r r-2x img-full"></a>
					</div>
					<div class="padder-v">
						<a href="#" class="text-ellipsis">Spring rain</a>
						<a href="#" class="text-ellipsis text-xs text-muted">Miaow</a>
					</div>
				</div>
			</div>
			<div class="col-xs-6 col-sm-3">
				<div class="item">
					<div class="pos-rlt">
						<div class="item-overlay opacity r r-2x bg-black">
							<div class="center text-center m-t-n">
								<a href="#">
									<i class="fa fa-play-circle i-2x"></i>
								</a>
							</div>
						</div>
						<a href="#">
							<img src="/Content/assets/images/a3.png" alt="" class="r r-2x img-full"></a>
					</div>
					<div class="padder-v">
						<a href="#" class="text-ellipsis">Hope</a>
						<a href="#" class="text-ellipsis text-xs text-muted">Miya</a>
					</div>
				</div>
			</div>
			<div class="col-xs-6 col-sm-3">
				<div class="item">
					<div class="pos-rlt">
						<div class="item-overlay opacity r r-2x bg-black">
							<div class="center text-center m-t-n">
								<a href="#">
									<i class="fa fa-play-circle i-2x"></i>
								</a>
							</div>
						</div>
						<a href="#">
							<img src="/Content/assets/images/a8.png" alt="" class="r r-2x img-full"></a>
					</div>
					<div class="padder-v">
						<a href="#" class="text-ellipsis">Listen wind</a>
						<a href="#" class="text-ellipsis text-xs text-muted">Soyia Jess</a>
					</div>
				</div>
			</div>
			<div class="col-xs-6 col-sm-3">
				<div class="item">
					<div class="pos-rlt">
						<div class="item-overlay opacity r r-2x bg-black">
							<div class="center text-center m-t-n">
								<a href="#">
									<i class="fa fa-play-circle i-2x"></i>
								</a>
							</div>
						</div>
						<a href="#">
							<img src="/Content/assets/images/a9.png" alt="" class="r r-2x img-full"></a>
					</div>
					<div class="padder-v">
						<a href="#" class="text-ellipsis">Breaking me</a>
						<a href="#" class="text-ellipsis text-xs text-muted">Pett JA</a>
					</div>
				</div>
			</div>
			<div class="col-xs-6 col-sm-3">
				<div class="item">
					<div class="pos-rlt">
						<div class="item-overlay opacity r r-2x bg-black">
							<div class="center text-center m-t-n">
								<a href="#">
									<i class="fa fa-play-circle i-2x"></i>
								</a>
							</div>
						</div>
						<a href="#">
							<img src="/Content/assets/images/a1.png" alt="" class="r r-2x img-full"></a>
					</div>
					<div class="padder-v">
						<a href="#" class="text-ellipsis">Nothing</a>
						<a href="#" class="text-ellipsis text-xs text-muted">Willion</a>
					</div>
				</div>
			</div>
			<div class="col-xs-6 col-sm-3">
				<div class="item">
					<div class="pos-rlt">
						<div class="item-overlay opacity r r-2x bg-black">
							<div class="center text-center m-t-n">
								<a href="#">
									<i class="fa fa-play-circle i-2x"></i>
								</a>
							</div>
						</div>
						<a href="#">
							<img src="/Content/assets/images/a6.png" alt="" class="r r-2x img-full"></a>
					</div>
					<div class="padder-v">
						<a href="#" class="text-ellipsis">Panda Style</a>
						<a href="#" class="text-ellipsis text-xs text-muted">Lionie</a>
					</div>
				</div>
			</div>
			<div class="col-xs-6 col-sm-3">
				<div class="item">
					<div class="pos-rlt">
						<div class="item-overlay opacity r r-2x bg-black">
							<div class="center text-center m-t-n">
								<a href="#">
									<i class="fa fa-play-circle i-2x"></i>
								</a>
							</div>
						</div>
						<a href="#">
							<img src="/Content/assets/images/a7.png" alt="" class="r r-2x img-full"></a>
					</div>
					<div class="padder-v">
						<a href="#" class="text-ellipsis">Hook Me</a>
						<a href="#" class="text-ellipsis text-xs text-muted">Gossi</a>
					</div>
				</div>
			</div>
			<div class="col-xs-6 col-sm-3">
				<div class="item">
					<div class="pos-rlt">
						<div class="item-overlay opacity r r-2x bg-black">
							<div class="center text-center m-t-n">
								<a href="#">
									<i class="fa fa-play-circle i-2x"></i>
								</a>
							</div>
						</div>
						<a href="#">
							<img src="/Content/assets/images/a5.png" alt="" class="r r-2x img-full"></a>
					</div>
					<div class="padder-v">
						<a href="#" class="text-ellipsis">Nito Bimbo</a>
						<a href="#" class="text-ellipsis text-xs text-muted">Miaow</a>
					</div>
				</div>
			</div>
		</div>
	</div>
	<div class="col-md-5">
		<h3 class="font-thin">Top Artistas</h3>
		<div class="list-group bg-white list-group-lg no-bg auto">
			<a href="#" class="list-group-item clearfix">
				<span class="pull-right h2 text-muted m-l">1</span>
				<span class="pull-left thumb-sm avatar m-r">
					<img src="/Content/assets/images/a4.png" alt="..."></span>
				<span class="clear">
					<span>Little Town</span>
					<small class="text-muted clear text-ellipsis">by Chris Fox</small>
				</span>
			</a>
			<a href="#" class="list-group-item clearfix">
				<span class="pull-right h2 text-muted m-l">2</span>
				<span class="pull-left thumb-sm avatar m-r">
					<img src="/Content/assets/images/a5.png" alt="..."></span>
				<span class="clear">
					<span>Lementum ligula vitae</span>
					<small class="text-muted clear text-ellipsis">by Amanda Conlan</small>
				</span>
			</a>
			<a href="#" class="list-group-item clearfix">
				<span class="pull-right h2 text-muted m-l">3</span>
				<span class="pull-left thumb-sm avatar m-r">
					<img src="/Content/assets/images/a6.png" alt="..."></span>
				<span class="clear">
					<span>Aliquam sollicitudin venenatis</span>
					<small class="text-muted clear text-ellipsis">by Dan Doorack</small>
				</span>
			</a>
			<a href="#" class="list-group-item clearfix">
				<span class="pull-right h2 text-muted m-l">4</span>
				<span class="pull-left thumb-sm avatar m-r">
					<img src="/Content/assets/images/a7.png" alt="..."></span>
				<span class="clear">
					<span>Aliquam sollicitudin venenatis ipsum</span>
					<small class="text-muted clear text-ellipsis">by Lauren Taylor</small>
				</span>
			</a>
			<a href="#" class="list-group-item clearfix">
				<span class="pull-right h2 text-muted m-l">5</span>
				<span class="pull-left thumb-sm avatar m-r">
					<img src="/Content/assets/images/a8.png" alt="..."></span>
				<span class="clear">
					<span>Vestibulum ullamcorper</span>
					<small class="text-muted clear text-ellipsis">by Dan Doorack</small>
				</span>
			</a>
		</div>
	</div>
</div>
<div class="row m-t-lg m-b-lg">
	<div class="col-sm-6">
		<div class="bg-primary wrapper-md r">
			<a href="Login/default.aspx">
				<span class="h4 m-b-xs block">
					<i class=" icon-user-follow i-lg"></i>
					Iniciar sesión
				</span>
				<span class="text-muted">
					Guarda y comparte su lista de reproducción con tus amigos cuando inicie su sesión o crear una cuenta.
				</span>
			</a>
		</div>
	</div>
    	<div class="col-sm-6">
		<div class="bg-primary wrapper-md r">
			<a href="UsuarioRegistro.aspx">
				<span class="h4 m-b-xs block">
					<i class=" icon-user-follow i-lg"></i>
					Crear una cuenta
				</span>
				<span class="text-muted">
					Guarda y comparte su lista de reproducción con tus amigos cuando inicie su sesión o crear una cuenta.
				</span>
			</a>
		</div>
	</div>
</div>
</asp:content>