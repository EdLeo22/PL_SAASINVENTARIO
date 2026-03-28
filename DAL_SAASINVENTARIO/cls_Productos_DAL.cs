using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DAL_SAASINVENTARIO.BD
{
    public class cls_Productos_DAL
    {
        public int iIdUsuario { get; set; }
        public string sNombre { get; set; }
        public int iIdEstado { get; set; }

        public DataTable dtDatos { get; set; }
        public DataTable dtParametros { get; set; }
    }
}
