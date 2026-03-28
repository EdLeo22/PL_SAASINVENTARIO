using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace DAL_SAASINVENTARIO
{
    public class UsuarioDAL
    {
        private string conexion = ConfigurationManager.ConnectionStrings["cnSaaSInventario"].ConnectionString;

        public int RegistrarUsuario(string nombre, string categoria, string correo, string contrasena)
        {
            int resultado = 0;

            using (SqlConnection con = new SqlConnection(conexion))
            {
                using (SqlCommand cmd = new SqlCommand("USP_Insertar_Usuarios", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@NombreUsuario", nombre);
                    cmd.Parameters.AddWithValue("@CategoriaNegocio", categoria);
                    cmd.Parameters.AddWithValue("@Correo", correo);
                    cmd.Parameters.AddWithValue("@Contrasena", contrasena);

                    con.Open();

                    object valor = cmd.ExecuteScalar();

                    if (valor != null)
                    {
                        int.TryParse(valor.ToString(), out resultado);
                    }
                }
            }

            return resultado;
        }
    }
}