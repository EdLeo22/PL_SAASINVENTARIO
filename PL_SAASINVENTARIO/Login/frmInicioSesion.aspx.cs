using BLL_SAASINVENTARIO.Inventix;
using DAL_SAASINVENTARIO.Inventrix;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PL_SAASINVENTARIO.Login
{
    public partial class frmInicioSesion : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        [WebMethod]
        public static string InicioSesionUsuarios(List<string> obj_Parametros_JS, cls_Usuarios_DAL cls_Usuarios_DAL, string ex)
        {
            try
            {
                string _mensaje = string.Empty;

                cls_Usuarios_DAL objUsuarios_DAL = new cls_Usuarios_DAL();
                cls_Usuarios_BLL objUsuarios_BLL = new cls_Usuarios_BLL();
                
                cls_Usuarios_DAL.sCorreo = obj_Parametros_JS[0].ToString();
                cls_Usuarios_DAL.sContrasena = obj_Parametros_JS[1].ToString();

                objUsuarios_BLL.Inicio_Sesion_Usuarios(ref cls_Usuarios_DAL);

                if(objUsuarios_DAL.sValorScalar == "-1")
                {
                    _mensaje = "-1" + "<SPLITER>" + "El usuario se encuentra inactivo";
                }
                else if(objUsuarios_DAL.sValorScalar == "0")
                {
                    _mensaje = "-1" + "<SPLITER>" + "Las credenciales no son válidas";
                }

                return _mensaje;
            }
            catch (Exception es)
            {
                throw es;
            }
        }
    }
}
