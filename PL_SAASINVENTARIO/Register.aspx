<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="PL_SAASINVENTARIO.Register" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Registro de usuarios</title>
    <style>
        * {
            box-sizing: border-box;
            margin: 0;
            padding: 0;
            font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif;
        }

        body {
            min-height: 100vh;
            background: radial-gradient(circle at top left, #0d1b4c, #07152f 45%, #04101f 100%);
            display: flex;
            justify-content: center;
            align-items: center;
        }

        .contenedor {
            width: 100%;
            max-width: 460px;
            padding: 20px;
        }

        .card {
            background: rgba(8, 20, 50, 0.92);
            border-radius: 22px;
            padding: 35px 30px;
            box-shadow: 0 12px 35px rgba(0, 0, 0, 0.35);
            border: 1px solid rgba(255,255,255,0.08);
        }

        .titulo {
            text-align: center;
            color: white;
            font-size: 34px;
            font-weight: 700;
            margin-bottom: 10px;
        }

        .subtitulo {
            text-align: center;
            color: #9fb4d9;
            margin-bottom: 25px;
            font-size: 15px;
        }

        .grupo {
            margin-bottom: 16px;
        }

        .grupo label {
            display: block;
            color: #d9e7ff;
            font-size: 14px;
            margin-bottom: 8px;
            font-weight: 600;
        }

        .input {
            width: 100%;
            padding: 14px 16px;
            border-radius: 12px;
            border: 1px solid #1d4f91;
            background: #0a2450;
            color: white;
            outline: none;
            font-size: 15px;
        }

        .input::placeholder {
            color: #8ea8cf;
        }

        .input:focus {
            border-color: #2dd4ff;
            box-shadow: 0 0 0 3px rgba(45, 212, 255, 0.12);
        }

        .boton {
            width: 100%;
            padding: 14px;
            border: none;
            border-radius: 14px;
            background: linear-gradient(90deg, #157bff, #10e0c5);
            color: white;
            font-size: 16px;
            font-weight: bold;
            cursor: pointer;
            margin-top: 8px;
        }

        .mensaje {
            display: block;
            margin-top: 16px;
            text-align: center;
            font-size: 14px;
        }

        .login-link {
            text-align: center;
            margin-top: 18px;
            color: #a9bddb;
        }

        .login-link a {
            color: #19e0c2;
            font-weight: bold;
            text-decoration: none;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="contenedor">
            <div class="card">
                <div class="titulo">Registrarse</div>
                <div class="subtitulo">Crea tu cuenta para comenzar a gestionar tu inventario</div>

                <div class="grupo">
                    <label for="txtNombre">Nombre</label>
                    <asp:TextBox ID="txtNombre" runat="server" CssClass="input" placeholder="Ingrese su nombre o negocio"></asp:TextBox>
                </div>

                <div class="grupo">
                    <label for="ddlCategoria">Categoría</label>
                    <asp:DropDownList ID="ddlCategoria" runat="server" CssClass="input">
                        <asp:ListItem Text="Seleccione una categoría" Value=""></asp:ListItem>
                        <asp:ListItem Text="Pulpería" Value="Pulpería"></asp:ListItem>
                        <asp:ListItem Text="Librería" Value="Librería"></asp:ListItem>
                        <asp:ListItem Text="Ferretería" Value="Ferretería"></asp:ListItem>
                        <asp:ListItem Text="Tienda de ropa" Value="Tienda de ropa"></asp:ListItem>
                        <asp:ListItem Text="Farmacia" Value="Farmacia"></asp:ListItem>
                        <asp:ListItem Text="Otro" Value="Otro"></asp:ListItem>
                    </asp:DropDownList>
                </div>

                <div class="grupo">
                    <label for="txtCorreo">Correo electrónico</label>
                    <asp:TextBox ID="txtCorreo" runat="server" CssClass="input" placeholder="ejemplo@correo.com"></asp:TextBox>
                </div>

                <div class="grupo">
                    <label for="txtContrasena">Contraseña</label>
                    <asp:TextBox ID="txtContrasena" runat="server" CssClass="input" TextMode="Password" placeholder="Ingrese su contraseña"></asp:TextBox>
                </div>

                <div class="grupo">
                    <label for="txtConfirmar">Confirmar contraseña</label>
                    <asp:TextBox ID="txtConfirmar" runat="server" CssClass="input" TextMode="Password" placeholder="Confirme su contraseña"></asp:TextBox>
                </div>

                <asp:Button ID="btnRegistrar" runat="server" Text="Crear cuenta" CssClass="boton" OnClick="btnRegistrar_Click" />

                <asp:Label ID="lblMensaje" runat="server" CssClass="mensaje"></asp:Label>

                <div class="login-link">
                    ¿Ya tienes cuenta?
                    <a href="Login.aspx">Inicia sesión</a>
                </div>
            </div>
        </div>
    </form>
</body>
</html>