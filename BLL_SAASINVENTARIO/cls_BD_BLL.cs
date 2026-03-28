using System.Configuration;
using DAL_SAASINVENTARIO.BD;
using System;
using System.Data;
using System.Data.SqlClient;

namespace BLL_SAASINVENTARIO.BD
{
    public class cls_BD_BLL
    {
        public DataTable ObtieneDTParametros()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Nombre");
            dt.Columns.Add("Valor");
            return dt;
        }

        public void EjecutaSP(ref cls_BD_DAL objBD)
        {
            try
            {
                string conexion = ConfigurationManager.ConnectionStrings["ConexionBD"].ConnectionString;

                using (SqlConnection conn = new SqlConnection(conexion))
                {
                    SqlCommand cmd = new SqlCommand(objBD.sNomSP, conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    foreach (DataRow row in objBD.DT_Parametros.Rows)
                    {
                        cmd.Parameters.AddWithValue(row["Nombre"].ToString(), row["Valor"]);
                    }

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    objBD.DS = new DataSet();

                    conn.Open();
                    da.Fill(objBD.DS);
                    conn.Close();

                    objBD.sMsjErrorBD = "";
                }
            }
            catch (Exception ex)
            {
                objBD.sMsjErrorBD = ex.Message;
            }
        }
    }
}
