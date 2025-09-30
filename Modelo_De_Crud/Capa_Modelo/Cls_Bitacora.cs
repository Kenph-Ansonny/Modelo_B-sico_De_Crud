using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Modelo
{
    public class Cls_Bitacora
    {
        public int IdBitacora { get; set; }
        public string FechaBitacora { get; set; }
        public string AccionBitacora { get; set; }
        public int IdUsuario { get; set; }
        public int IdAplicacion { get; set; }
        public string IpBitacora { get; set; }
        public string NombrePcBitacora { get; set; }
    }
}
