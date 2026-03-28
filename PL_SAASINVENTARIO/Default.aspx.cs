using BLL_SAASINVENTARIO;
using DAL_SAASINVENTARIO;
using DAL_SAASINVENTARIO.BD;
using System;
using System.Collections.Generic;
using System.Web.Services;
using System.Web.UI;

namespace PL_SAASINVENTARIO
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        [WebMethod]
        public static string CargarProductos(List<string> obj_Parametros_JS)
        {
            cls_Productos_DAL objDAL = new cls_Productos_DAL();
            cls_Productos_BLL objBLL = new cls_Productos_BLL();

            objDAL.iIdUsuario = Convert.ToInt32(obj_Parametros_JS[0]);
            objDAL.sNombre = obj_Parametros_JS[1];
            objDAL.iIdEstado = Convert.ToInt32(obj_Parametros_JS[2]);

            objBLL.ListarProductos(ref objDAL);

            string html = "";

            if (objDAL.dtDatos != null && objDAL.dtDatos.Rows.Count > 0)
            {
                html += "<thead><tr>" +
                        "<th>Nombre</th>" +
                        "<th>Stock</th>" +
                        "<th>Categoria</th>" +
                        "<th>Marca</th>" +
                        "<th>Estado</th>" +
                        "</tr></thead><tbody>";

                foreach (System.Data.DataRow row in objDAL.dtDatos.Rows)
                {
                    html += "<tr>" +
                            "<td>" + row["NombreProducto"] + "</td>" +
                            "<td>" + row["Stock"] + "</td>" +
                            "<td>" + row["NombreCategoria"] + "</td>" +
                            "<td>" + row["NombreMarca"] + "</td>" +
                            "<td>" + row["Estado"] + "</td>" +
                            "</tr>";
                }

                html += "</tbody>";
            }
            else
            {
                html = "No hay productos";
            }

            return html;
        }
    }
}