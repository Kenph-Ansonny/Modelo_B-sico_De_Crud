using Capa_Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Controlador
{
    public class Cls_BitacoraControlador
    {
        private readonly Cls_BitacoraDAO dao = new Cls_BitacoraDAO();

        // Método para obtener todas las bitácoras
        public DataTable ObtenerTodasBitacoras()
        {
            return dao.ObtenerBitacorasDataTable();
        }

        // Método para insertar un insert
        public int InsertarBitacora(int idUsuario, int idAplicacion, string accion)
        {
            return dao.InsertarBitacora(idUsuario, idAplicacion, accion);
        }

        public DataTable ObtenerBitacorasPorFechas(string fechaInicio, string fechaFin)
        {
            return dao.ConsultarBitacorasPorFechaDataTable(fechaInicio, fechaFin);
        }
    }
}
