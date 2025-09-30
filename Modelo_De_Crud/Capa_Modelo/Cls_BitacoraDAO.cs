using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Capa_Modelo
{
    public class Cls_BitacoraDAO
    {
        private static readonly string SQL_SELECT = "SELECT bitid, bitfecha, bitaccion, usuid, aplid, bitip, bitnombrepc FROM bitacora";
        private static readonly string SQL_INSERT = "INSERT INTO bitacora(bitfecha, bitaccion, usuid, aplid, bitip, bitnombrepc) VALUES(?, ?, ?, ?, ?, ?)";
        private static readonly string SQL_QUERY = "SELECT bitid, bitfecha, bitaccion, usuid, aplid, bitip, bitnombrepc FROM bitacora WHERE bitfecha BETWEEN ? AND ?";

        private readonly Cls_ConexionODBC conexion = new Cls_ConexionODBC();

        private string ObtenerIP()
        {
            foreach (var ip in Dns.GetHostEntry(Dns.GetHostName()).AddressList)
            {
                if (ip.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }
            return "127.0.0.1";
        }

        private string ObtenerNombrePc()
        {
            return Environment.MachineName;
        }

        private string FechaActual()
        {
            return DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
        }


        public List<Cls_Bitacora> ObtenerBitacoras()
        {
            List<Cls_Bitacora> lista = new List<Cls_Bitacora>();
            OdbcConnection conn = conexion.conexion();

            try
            {
                conn.Open();
                using (OdbcCommand cmd = new OdbcCommand(SQL_SELECT, conn))
                using (OdbcDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        lista.Add(new Cls_Bitacora
                        {
                            IdBitacora = reader.GetInt32(0),
                            FechaBitacora = reader.GetString(1),
                            AccionBitacora = reader.GetString(2),
                            IdUsuario = reader.GetInt32(3),
                            IdAplicacion = reader.GetInt32(4),
                            IpBitacora = reader.GetString(5),
                            NombrePcBitacora = reader.GetString(6)
                        });
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener bitácoras: " + ex.Message);
            }
            finally
            {
                conexion.desconexion(conn);
            }

            return lista;
        }

        public int InsertarBitacora(int idUsuario, int idAplicacion, string accion)
        {
            int filas = 0;
            OdbcConnection conn = conexion.conexion();

            try
            {
                conn.Open();
                using (OdbcCommand cmd = new OdbcCommand(SQL_INSERT, conn))
                {
                    cmd.Parameters.AddWithValue("@fecha", FechaActual());
                    cmd.Parameters.AddWithValue("@accion", accion);
                    cmd.Parameters.AddWithValue("@usuario", idUsuario);
                    cmd.Parameters.AddWithValue("@aplicacion", idAplicacion);
                    cmd.Parameters.AddWithValue("@ip", ObtenerIP());
                    cmd.Parameters.AddWithValue("@pc", ObtenerNombrePc());

                    filas = cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar bitácora: " + ex.Message);
            }
            finally
            {
                conexion.desconexion(conn);
            }

            return filas;
        }

        public List<Cls_Bitacora> ConsultarBitacorasPorFecha(string fechaInicio, string fechaFin)
        {
            List<Cls_Bitacora> lista = new List<Cls_Bitacora>();
            OdbcConnection conn = conexion.conexion();

            try
            {
                conn.Open();
                using (OdbcCommand cmd = new OdbcCommand(SQL_QUERY, conn))
                {
                    cmd.Parameters.AddWithValue("@inicio", fechaInicio);
                    cmd.Parameters.AddWithValue("@fin", fechaFin);

                    using (OdbcDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista.Add(new Cls_Bitacora
                            {
                                IdBitacora = reader.GetInt32(0),
                                FechaBitacora = reader.GetString(1),
                                AccionBitacora = reader.GetString(2),
                                IdUsuario = reader.GetInt32(3),
                                IdAplicacion = reader.GetInt32(4),
                                IpBitacora = reader.GetString(5),
                                NombrePcBitacora = reader.GetString(6)
                            });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al consultar bitácoras: " + ex.Message);
            }
            finally
            {
                conexion.desconexion(conn);
            }

            return lista;
        }

        public DataTable ObtenerBitacorasDataTable()
        {
            DataTable tabla = new DataTable();
            OdbcConnection conn = conexion.conexion();

            try
            {
                conn.Open();
                using (OdbcDataAdapter da = new OdbcDataAdapter(SQL_SELECT, conn))
                {
                    da.Fill(tabla);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener bitácoras (DataTable): " + ex.Message);
            }
            finally
            {
                conexion.desconexion(conn);
            }

            return tabla;
        }

        public DataTable ConsultarBitacorasPorFechaDataTable(string fechaInicio, string fechaFin)
        {
            DataTable tabla = new DataTable();
            OdbcConnection conn = conexion.conexion();

            try
            {
                conn.Open();
                using (OdbcCommand cmd = new OdbcCommand(SQL_QUERY, conn))
                {
                    cmd.Parameters.AddWithValue("?", fechaInicio);
                    cmd.Parameters.AddWithValue("?", fechaFin);

                    using (OdbcDataAdapter da = new OdbcDataAdapter(cmd))
                    {
                        da.Fill(tabla);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al consultar bitácoras (DataTable): " + ex.Message);
            }
            finally
            {
                conexion.desconexion(conn);
            }

            return tabla;
        }
    }
}
 
