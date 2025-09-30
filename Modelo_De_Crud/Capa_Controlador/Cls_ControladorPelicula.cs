using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Modelo;

namespace Capa_Controlador
{
    public class Cls_ControladorPelicula
    {
        Cls_PeliculaDAO dao = new Cls_PeliculaDAO();

        // Obtener todas las películas
        public DataTable ObtenerPeliculas()
        {
            return dao.Select();
        }

        public int Insertar(int id, string titulo, string descripcion, DateTime? fechaEstreno, TimeSpan? duracion, decimal? calificacion, bool disponible)
        {
            return dao.Insert(id, titulo, descripcion, fechaEstreno, duracion, calificacion, disponible);
        }

        public int Modificar(int id, string titulo, string descripcion, DateTime? fechaEstreno, TimeSpan? duracion, decimal? calificacion, bool disponible)
        {
            return dao.Update(id, titulo, descripcion, fechaEstreno, duracion, calificacion, disponible);
        }

        public int Eliminar(int id)
        {
            return dao.Delete(id);
        }
    }
}

