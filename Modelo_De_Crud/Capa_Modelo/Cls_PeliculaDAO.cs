using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Modelo
{
    public class Cls_PeliculaDAO
    {
        private readonly Cls_ConexionODBC conexion = new Cls_ConexionODBC();

        private const string SQL_SELECT = "SELECT id_pelicula, titulo, descripcion, fecha_estreno, duracion, calificacion, disponible, creado_en FROM pelicula";
        private const string SQL_INSERT = @"INSERT INTO pelicula 
            (id_pelicula, titulo, descripcion, fecha_estreno, duracion, calificacion, disponible) 
            VALUES (?, ?, ?, ?, ?, ?, ?)";
        private const string SQL_UPDATE = @"UPDATE pelicula SET 
            titulo = ?, descripcion = ?, fecha_estreno = ?, duracion = ?, calificacion = ?, disponible = ? 
            WHERE id_pelicula = ?";
        private const string SQL_DELETE = "DELETE FROM pelicula WHERE id_pelicula = ?";

        // SELECT con DataTable
        public DataTable Select()
        {
            DataTable dt = new DataTable();
            using (OdbcConnection conn = conexion.conexion())
            {
                conn.Open();
                using (OdbcDataAdapter da = new OdbcDataAdapter(SQL_SELECT, conn))
                {
                    da.Fill(dt);
                }
            }
            return dt;
        }

        // INSERT
        public int Insert(int id, string titulo, string descripcion, DateTime? fechaEstreno, TimeSpan? duracion, decimal? calificacion, bool disponible)
        {
            using (OdbcConnection conn = conexion.conexion())
            {
                conn.Open();
                OdbcCommand cmd = new OdbcCommand(SQL_INSERT, conn);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@titulo", titulo);
                cmd.Parameters.AddWithValue("@descripcion", (object)descripcion ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@fechaEstreno", (object)fechaEstreno ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@duracion", (object)duracion ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@calificacion", (object)calificacion ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@disponible", disponible);
                return cmd.ExecuteNonQuery();
            }
        }

        // UPDATE
        public int Update(int id, string titulo, string descripcion, DateTime? fechaEstreno, TimeSpan? duracion, decimal? calificacion, bool disponible)
        {
            using (OdbcConnection conn = conexion.conexion())
            {
                conn.Open();
                OdbcCommand cmd = new OdbcCommand(SQL_UPDATE, conn);
                cmd.Parameters.AddWithValue("@titulo", titulo);
                cmd.Parameters.AddWithValue("@descripcion", (object)descripcion ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@fechaEstreno", (object)fechaEstreno ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@duracion", (object)duracion ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@calificacion", (object)calificacion ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@disponible", disponible);
                cmd.Parameters.AddWithValue("@id", id);
                return cmd.ExecuteNonQuery();
            }
        }

        // DELETE
        public int Delete(int id)
        {
            using (OdbcConnection conn = conexion.conexion())
            {
                conn.Open();
                OdbcCommand cmd = new OdbcCommand(SQL_DELETE, conn);
                cmd.Parameters.AddWithValue("@id", id);
                return cmd.ExecuteNonQuery();
            }
        }
    }
}

