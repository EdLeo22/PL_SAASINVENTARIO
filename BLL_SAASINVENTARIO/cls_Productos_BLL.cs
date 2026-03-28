using DAL_SAASINVENTARIO;
using DAL_SAASINVENTARIO.BD;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace BLL_SAASINVENTARIO
{
    public class cls_Productos_BLL
    {
        public void ListarProductos(ref cls_Productos_DAL objDAL)
        {
            try
            {
                string conexion = ConfigurationManager.ConnectionStrings["cnx"].ConnectionString;

                using (SqlConnection conn = new SqlConnection(conexion))
                {
                    SqlCommand cmd = new SqlCommand("USP_Listar_Productos", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@IdUsuario", objDAL.iIdUsuario);
                    cmd.Parameters.AddWithValue("@Nombre", objDAL.sNombre);
                    cmd.Parameters.AddWithValue("@IdEstado", objDAL.iIdEstado);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();

                    da.Fill(dt);

                    objDAL.dtDatos = dt;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}