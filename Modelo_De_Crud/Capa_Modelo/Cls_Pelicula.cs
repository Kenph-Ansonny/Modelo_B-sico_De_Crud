using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Modelo
{
    public class Cls_Pelicula
    {
        public int Id_pelicula { get; set; }
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public DateTime? FechaEstreno { get; set; }
        public TimeSpan? Duracion { get; set; }
        public decimal? Calificacion { get; set; }
        public bool Disponible { get; set; }
        public DateTime CreadoEn { get; set; }
    }
}
