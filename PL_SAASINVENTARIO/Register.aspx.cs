using System;
using BLL_SAASINVENTARIO;

namespace PL_SAASINVENTARIO
{
    public partial class Register : System.Web.UI.Page
    {
        UsuarioBLL usuarioBLL = new UsuarioBLL();

        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnRegistrar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text.Trim();
            string categoria = ddlCategoria.SelectedValue;
            string correo = txtCorreo.Text.Trim();
            string contrasena = txtContrasena.Text.Trim();
            string confirmar = txtConfirmar.Text.Trim();

            int resultado = usuarioBLL.RegistrarUsuario(nombre, categoria, correo, contrasena, confirmar);

            if (resultado > 0)
            {
                lblMensaje.ForeColor = System.Drawing.Color.LightGreen;
                lblMensaje.Text = "Usuario registrado correctamente.";

                txtNombre.Text = "";
                ddlCategoria.SelectedIndex = 0;
                txtCorreo.Text = "";
                txtContrasena.Text = "";
                txtConfirmar.Text = "";
            }
            else if (resultado == -1)
            {
                lblMensaje.ForeColor = System.Drawing.Color.Salmon;
                lblMensaje.Text = "El correo ya se encuentra registrado.";
            }
            else if (resultado == -2)
            {
                lblMensaje.ForeColor = System.Drawing.Color.Salmon;
                lblMensaje.Text = "Debe completar todos los campos.";
            }
            else if (resultado == -3)
            {
                lblMensaje.ForeColor = System.Drawing.Color.Salmon;
                lblMensaje.Text = "Debe ingresar un correo válido.";
            }
            else if (resultado == -4)
            {
                lblMensaje.ForeColor = System.Drawing.Color.Salmon;
                lblMensaje.Text = "Las contraseñas no coinciden.";
            }
            else if (resultado == -5)
            {
                lblMensaje.ForeColor = System.Drawing.Color.Salmon;
                lblMensaje.Text = "La contraseña debe tener al menos 6 caracteres.";
            }
            else
            {
                lblMensaje.ForeColor = System.Drawing.Color.Salmon;
                lblMensaje.Text = "Ocurrió un error al registrar el usuario.";
            }
        }
    }
}