<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="ProyectoLiveThru.Login._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Log In</title>
    <link href="StyleLogin.css" rel="stylesheet" />
    <link href="css/bootstrap.min.css" rel="stylesheet" />

</head>
<body>
    <div id="fullscreen_bg" class="fullscreen_bg"/>
<div class="container">

	<form class="form-signin" runat="server">
		<h2 class="form-signin-heading text-muted" style="color:white"  ><b>Live Thru</b></h2>
        <asp:TextBox ID="txtUsuario" runat="server" placeholder="Usuario" class="form-control" autofocus></asp:TextBox>
        <br />
        <asp:TextBox ID="txtPassword" runat="server" placeholder="Contraseña" type="password" class="form-control"></asp:TextBox>
        <asp:Button ID="btnAcceder" runat="server" Text="Acceder" class="btn btn-lg btn-primary btn-block" style="background-color : black; border-color:black" OnClick="btnAcceder_Click" />
	</form>

</div>
</body>
    
</html>
