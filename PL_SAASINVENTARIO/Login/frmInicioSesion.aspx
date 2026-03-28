<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmInicioSesion.aspx.cs" Inherits="PL_SAASINVENTARIO.Login.frmInicioSesion" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login</title>

    <!-- CSS -->
    <link href="css/style.css" rel="stylesheet" />
    <link href="css/font-awesome.min.css" rel="stylesheet" />
</head>

<body>
    <form id="form1" runat="server">

        <div class="login-box">
            <div class="icon">
                <i class="fa fa-user"></i>
            </div>

            <h2>Iniciar sesión</h2>
            <p>Bienvenido de nuevo</p>

            <div class="input-group">
                <label>Correo electrónico</label>
                <asp:TextBox ID="txtCorreo" runat="server" CssClass="input" />
            </div>
            
            <div class="input-group">
                <label>Contraseña</label>
                <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" CssClass="input" />
            </div>

            <div class="options">
                <label><input type="checkbox" /> Recordarme</label>
                <a href="#">¿Olvidaste tu contraseña?</a>
            </div>

            <asp:Button ID="btnLogin" runat="server" Text="Iniciar sesión" CssClass="btn-login" />

            <div class="register">
                ¿No tienes cuenta? <a href="#">Regístrate</a>
            </div>

        </div>

    </form>
</body>
</html>