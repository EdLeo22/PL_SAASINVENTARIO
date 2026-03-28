using BLL_SAASINVENTARIO.BD;
using DAL_SAASINVENTARIO.BD;
using DAL_SAASINVENTARIO.Inventrix;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_SAASINVENTARIO.Inventix
{
    public class cls_Usuarios_BLL
    {
        public void Inicio_Sesion_Usuarios(ref cls_Usuarios_DAL obj_Usuarios_DAL)
        {
            try
            {
                cls_BD_DAL obj_BD_DAL = new cls_BD_DAL();
                cls_BD_BLL obj_BD_BLL = new cls_BD_BLL();

                obj_Usuarios_DAL.dtParametros = null;
                obj_Usuarios_DAL.dtParametros = obj_BD_BLL.ObtieneDTParametros(obj_Usuarios_DAL.dtParametros);

                obj_Usuarios_DAL.dtParametros.Rows.Add("@Correo", "6", obj_Usuarios_DAL.sCorreo);
                obj_Usuarios_DAL.dtParametros.Rows.Add("@Contrasena", "6", obj_Usuarios_DAL.sContrasena);

                obj_BD_DAL.sNomSP = ConfigurationManager.AppSettings["SP_LogIn_Usuarios"];

                obj_BD_DAL.sIndAxn = "SCALAR";

                obj_BD_DAL.DT_Parametros = obj_Usuarios_DAL.dtParametros;

                if (obj_BD_DAL.sMsjErrorBD == string.Empty)
                {
                    obj_Usuarios_DAL.sMSJError = obj_BD_DAL.sMsjErrorBD;
                    obj_Usuarios_DAL.sValorScalar = null;
                }
                else
                {
                    obj_Usuarios_DAL.sMSJError = obj_BD_DAL.sMsjErrorBD;
                    obj_Usuarios_DAL.sValorScalar = obj_BD_DAL.sValorScalar;
                }
            }
            catch (Exception es)
            {
                throw es;
            }
        }
    }
}
