using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_SAASINVENTARIO.Inventrix
{
    public class cls_Usuarios_DAL
    {
        public string sMSJError;
        #region Variables Privadas
        /*Sección de campos de la tabla*/
        private int _iIdUsuario;
        private string _sCorreo; 
        private string _sContrasena; 
        private string _sNombreUsuario;
        private string _sCategoriaNegocio;
        private DateTime _tFechaRegistro;
        
        /*Sección presente en todas las clases*/
        private string _sValorScalar, _sAXN, _sMensajeError;
        private DataTable _dtDatos, _dtParametros;


        #endregion
        #region Variables Públicas o constructores
        public int iIdUsuario { get => _iIdUsuario; set => _iIdUsuario = value; }
        public string sCorreo { get => _sCorreo; set => _sCorreo = value; }
        public string sContrasena { get => _sContrasena; set => _sContrasena = value; }
        public string sNombreUsuario { get => _sNombreUsuario; set => _sNombreUsuario = value; }
        public string sCategoriaNegocio { get => _sCategoriaNegocio; set => _sCategoriaNegocio = value; }
        public DateTime tFechaRegistro { get => _tFechaRegistro; set => _tFechaRegistro = value; }
        public string sValorScalar { get => _sValorScalar; set => _sValorScalar = value; }
        public string sAXN { get => _sAXN; set => _sAXN = value; }
        public string sMensajeError { get => _sMensajeError; set => _sMensajeError = value; }
        public DataTable dtDatos { get => _dtDatos; set => _dtDatos = value; }
        public DataTable dtParametros { get => _dtParametros; set => _dtParametros = value; }

        #endregion

    }
}
