using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_SAASINVENTARIO.BD
{
    public class cls_BD_DAL
    {
        public string sNomSP { get; set; }
        public string sNomTabla { get; set; }
        public string sMsjErrorBD { get; set; }

        public DataTable DT_Parametros { get; set; }
        public DataSet DS { get; set; }
    }
}
