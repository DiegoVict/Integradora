<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Master.Master" CodeBehind="Organizador.aspx.cs" Inherits="ProyectoLiveThru.Organizador" %>

<asp:content id="Body" contentplaceholderid="Body" runat="server">
<section class="panel panel-default">
	<header class="panel-heading bg-light">
		<ul class="nav nav-tabs nav-justified">
			<li class="active">
				<a href="#home" data-toggle="tab">Historia</a>
			</li>
			<li>
				<a href="#profile" data-toggle="tab">Eventos</a>
			</li>
			<li>
				<a href="#messages" data-toggle="tab">Discografia</a>
			</li>
			<li>
				<a href="#settings" data-toggle="tab">Contacto</a>
			</li>
		</ul>
	</header>
	<div class="panel-body">
		<div class="tab-content">
			<div class="tab-pane active" id="home">
				<div class="row">
					<div class="col-md-4">
						<h3>Organizador: <b>Flash Gordon</b></h3>
					</div>
					<div class="col-md-8">
						<div id="social-buttons">
							<a class="btn btn-default" data-toggle="button"> 
								<i class="fa fa-heart-o text"></i> 
								<i class="fa fa-heart text-active text-danger"></i>
							</a>
							<a class="btn btn-default" data-toggle="button">
								<span class="text"> <i class="fa fa-thumbs-up text-success"></i>
									25
								</span>
								<span class="text-active"> <i class="fa fa-thumbs-down text-danger"></i>
									10
								</span>
							</a>
							<a href="#" class="btn btn-rounded btn-sm btn-info"> <i class="fa fa-fw fa-twitter"></i>
								Twitter
							</a>
							<a href="#" class="btn btn-rounded btn-sm btn-primary"> <i class="fa fa-fw fa-facebook"></i>
								Facebook
							</a>
							<a href="#" class="btn btn-rounded btn-sm btn-danger">
								<i class="fa fa-fw fa-google-plus"></i>
								Google+
							</a>
						</div>
					</div>
					<div class="col-md-12"></div>
					<!--INICIO PROFILE-->
					<div class="col-md-4">
						<section class="panel panel-default">
							<div class="panel-body">
								<div class="clearfix text-center m-t">
									<div class="inline">
										<div class="easypiechart easyPieChart" data-percent="75" data-line-width="5" data-bar-color="#4cc0c1" data-track-color="#f5f5f5" data-scale-color="false" data-size="134" data-line-cap="butt" data-animate="1000" style="width: 305px; height: 285px; line-height: 134px;">
											<div class="thumbnail">
												<img src="/Content/Images/300eventos/flash.jpg" class="" alt="..."></div>
											<canvas width="134" height="134"></canvas>
										</div>
										<!--<div class="h4 m-t m-b-xs">John.Smith</div>
										<small class="text-muted m-b">Art director</small>-->
									</div>
								</div>
							</div>
							<footer class="panel-footer bg-info text-center">
								<div class="row pull-out">
									<div class="col-xs-6">
										<div class="padder-v">
											<span class="m-b-xs h3 block text-white">245</span>
											<small class="text-muted">Seguidores</small>
										</div>
									</div>
									<!--<div class="col-xs-4 dk">
										<div class="padder-v">
											<span class="m-b-xs h3 block text-white">55</span>
											<small class="text-muted">Siguiendo</small>
										</div>
									</div>-->
									<div class="col-xs-6">
										<div class="padder-v">
											<span class="m-b-xs h3 block text-white">3</span>
											<small class="text-muted">Eventos</small>
										</div>
									</div>
								</div>
							</footer>
						</section>
					</div>
					<!--FIN PROFILE-->
					<div class="col-md-8">
						<p>Flash Gordon es un grupo musical de horror puck y hardcore punk formado en 1977 en la cidudad de lodi 
						Lorem ipsum dolor sit amet, consectetur adipisicing elit. Unde eos earum, delectus sed necessitatibus rerum omnis qui iure aut, sit doloribus ipsa vitae eveniet architecto reiciendis dolorum commodi in accusantium.
						</p>
						<p>Flash Gordon comenzó su andadura el 7 de enero de 1934. Los guiones eran obra de Don Moore, editor de revistas de literatura pulp, quien, sin embargo, no aparece acreditado en la página. Perteneciente al género conocido como space opera, es una serie de acción con un punto de partida bastante delirante: Flash Gordon, un famoso jugador de fútbol americano de los New York Jets, y Dale Arden, futura novia del héroe, se lanzan en paracaídas cuando un meteorito alcanza el ala del avión en que viajaban. Caen cerca del laboratorio donde el científico Hans Zarkov prepara sus planes para desviar la trayectoria de un meteorito mayor que va a chocar contra la Tierra. El plan consiste nada menos que en lanzar contra el meteorito un cohete, al que obliga a subir a Dale Arden y Flash Gordon a punta de pistola. Como resultado, y sin ninguna explicación del guionista, los tres van a parar al planeta Mongo.</p>
						<p>Flash Gordon es un grupo musical de horror puck y hardcore punk formado en 1977 en la cidudad de lodi 
						Lorem ipsum dolor sit amet, consectetur adipisicing elit. Unde eos earum, delectus sed necessitatibus rerum omnis qui iure aut, sit doloribus ipsa vitae eveniet architecto reiciendis dolorum commodi in accusantium.
						</p>
						<p>Flash Gordon comenzó su andadura el 7 de enero de 1934. Los guiones eran obra de Don Moore, editor de revistas de literatura pulp, quien, sin embargo, no aparece acreditado en la página. Perteneciente al género conocido como space opera, es una serie de acción con un punto de partida bastante delirante: Flash Gordon, un famoso jugador de fútbol americano de los New York Jets, y Dale Arden, futura novia del héroe, se lanzan en paracaídas cuando un meteorito alcanza el ala del avión en que viajaban. Caen cerca del laboratorio donde el científico Hans Zarkov prepara sus planes para desviar la trayectoria de un meteorito mayor que va a chocar contra la Tierra. El plan consiste nada menos que en lanzar contra el meteorito un cohete, al que obliga a subir a Dale Arden y Flash Gordon a punta de pistola. Como resultado, y sin ninguna explicación del guionista, los tres van a parar al planeta Mongo.</p>
					</div>
				</div>
			</div>
			<div class="tab-pane" id="profile">
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
									Eventos activos
									<span class="badge bg-info">2</span>
								</header>
								<section class="panel-body">
									<article class="media">
										<!--<div class="pull-left">
											<span class="fa-stack fa-lg">-->
										<div class="pull-left">
											<span>
												
												<img src="/Content/Images/300eventos/flash.jpg" class="" alt="..." style="width:100px">
											</span>
										</div>
										<div class="media-body">
											<a href="#" class="h4 text-success">Campaña musical "voten por Flash"</a>
											<small class="block m-t-xs">Desfile politico</small>
											<em class="text-xs">
												Posted on
												<span class="text-danger">Feb 05, 2013</span>
											</em>
										</div>
									</article>
									<div class="line pull-in"></div>
									<article class="media">
										<div class="pull-left">
											<span><img src="/Content/Images/300eventos/thefox.jpg" class="" alt="..." style="width:100px"></span>
										</div>
										<div class="media-body">
											<a href="#" class="h4 text-success">Participa como animadora, sexo indistinto </a>
											<small class="block m-t-xs">Participa como princesa y reina del carnaval para promocionar a Flash 
											</small> <em class="text-xs">Posted on
												<span class="text-danger">Feb 23, 2013</span></em> 
										</div>
									</article>
									<div class="line pull-in"></div>
									<article class="media">
										<div class="pull-left">
											<span><img src="/Content/Images/300eventos/Contratista.jpg" class="" alt="..." style="width:100px"></span>
										</div>
										<div class="media-body">
											<a href="#" class="h4">Concierto para ayudar a los necesitados de ayuda divina.</a>
											<small class="block m-t-xs">
												There are a few easy ways to quickly get started with Bootstrap, each one appealing to a different skill level and use case. Read through to see what suits your particular needs.
											</small> <em class="text-xs">Posted on
												<span class="text-danger">Feb 12, 2013</span></em> 
										</div>
									</article>
								</section>
							</section>
						<!--FIN EVENTOS-->
					</div>
				</div>
			</div>
			<div class="tab-pane" id="messages">
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
			<div class="tab-pane" id="settings">
				<div class="row">
					<div class="col-md-12">
						<!--INICIO contacto-->
							<div class="well bg-light b m-t">
							<div class="row">
									<div class="col-xs-6"> <strong>Recursos Humanos:</strong>
										<h4>Fulano</h4>
										<p>
											2nd Floor
											<br>
											St John Street, Aberdeenshire 2541
											<br>
											Tekax Yucatán
											<br>
											Teléfono: 031-432-678
											<br>
											Email: fulano@gmail.com
											<br></p>
									</div>
									<div class="col-xs-6"> <strong>Administrador Financiero:</strong>
										<h4>Sotano</h4>
										<p>
											2nd Floor
											<br>
											St John Street, Aberdeenshire 2541
											<br>
											Kanada Yucatán
											<br>
											teléfono: 031-432-678
											<br>
											Email: sotano@gmail.com
											<br></p>
									</div>
								</div>
							</div>
							<div class="row">
									<div class="col-xs-6"> <strong>Jefe en Marketing:</strong>
										<h4>Mengano</h4>
										<p>
											2nd piso con fulano y mengano
											<br>
											Africa Yucatán
											<br>
											United Kingdom
											<br>
											Teléfono: 031-432-678
											<br>
											Email: Mengano@gmail.com
											<br></p>
									</div>
									<div class="col-xs-6"> <strong>Trabajor Oales:</strong>
										<h4>Edwin Gongora</h4>
										<p>
											2nd piso con todos los demas gays
											<br>
											St John Street, Aberdeenshire 2541
											<br>
											Méida Yucatán
											<br>
											Teléfono: 031-432-678
											<br>
											Email: edwin@gmail.com
											<br></p>
									</div>
								</div>
							</div>
						<!--FIN Contacto-->
					</div>
				</div>
			</div>
		</div>
</section>
</asp:content>