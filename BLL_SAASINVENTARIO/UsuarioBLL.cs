using System;
using DAL_SAASINVENTARIO;

namespace BLL_SAASINVENTARIO
{
    public class UsuarioBLL
    {
        UsuarioDAL usuarioDAL = new UsuarioDAL();

        public int RegistrarUsuario(string nombre, string categoria, string correo, string contrasena, string confirmar)
        {
            if (string.IsNullOrWhiteSpace(nombre) ||
                string.IsNullOrWhiteSpace(categoria) ||
                string.IsNullOrWhiteSpace(correo) ||
                string.IsNullOrWhiteSpace(contrasena) ||
                string.IsNullOrWhiteSpace(confirmar))
            {
                return -2;
            }

            if (!correo.Contains("@") || !correo.Contains("."))
            {
                return -3;
            }

            if (contrasena != confirmar)
            {
                return -4;
            }

            if (contrasena.Length < 6)
            {
                return -5;
            }

            return usuarioDAL.RegistrarUsuario(nombre.Trim(), categoria.Trim(), correo.Trim(), contrasena.Trim());
        }
    }
}