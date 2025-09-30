using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Modelo;

namespace Capa_Modelo
{
    public class Cls_UsuarioDAO
    {
        //instancia de la clase conexion
        private Cls_ConexionODBC conexion = new Cls_ConexionODBC();

        //sentencias sql para manejar la tabla de usuario
        private static readonly string SQL_SELECT = "SELECT id_usuario, usuario, contraseña FROM usuario";
        private static readonly string SQL_INSERT = "INSERT INTO usuario(id_usuario, usuario, contraseña) VALUES(?, ?, ?)";
        private static readonly string SQL_UPDATE = "UPDATE usuario SET usuario = ?, contraseña = ? WHERE id_usuario = ?";
        private static readonly string SQL_DELETE = "DELETE FROM usuario WHERE id_usuario = ?";
        private static readonly string SQL_QUERY = "SELECT id_usuario, usuario, contraseña FROM usuario WHERE usuario = ?";

        public List<Cls_Usuario> Select()
        {
            List<Cls_Usuario> usuarios = new List<Cls_Usuario>();
            OdbcConnection conn = conexion.conexion();
            try
            {
                conn.Open();
                OdbcCommand cmd = new OdbcCommand(SQL_SELECT, conn);
                using (OdbcDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Cls_Usuario usuario = new Cls_Usuario
                        {
                            Id_usuario = reader.GetInt32(0),
                            UsuarioNombre = reader.GetString(1),
                            Contraseña = reader.GetString(2)
                        };
                        usuarios.Add(usuario);
                    }
                }
            }
            finally
            {
                conexion.desconexion(conn);
            }
            return usuarios;
        }

        public int Insert(Cls_Usuario usuario)
        {
            int filasAfectadas = 0;
            OdbcConnection conn = conexion.conexion();
            try
            {
                conn.Open();
                OdbcCommand cmd = new OdbcCommand(SQL_INSERT, conn);
                cmd.Parameters.AddWithValue("id_usuario", usuario.Id_usuario);
                cmd.Parameters.AddWithValue("usuario", usuario.UsuarioNombre);
                cmd.Parameters.AddWithValue("contraseña", usuario.Contraseña);
                filasAfectadas = cmd.ExecuteNonQuery();
            }
            finally
            {
                conexion.desconexion(conn);
            }
            return filasAfectadas;
        }

        public int Update(Cls_Usuario usuario)
        {
            int filasAfectadas = 0;
            OdbcConnection conn = conexion.conexion();
            try
            {
                conn.Open();
                OdbcCommand cmd = new OdbcCommand(SQL_UPDATE, conn);
                cmd.Parameters.AddWithValue("usuario", usuario.UsuarioNombre);
                cmd.Parameters.AddWithValue("contraseña", usuario.Contraseña);
                cmd.Parameters.AddWithValue("id_usuario", usuario.Id_usuario);
                filasAfectadas = cmd.ExecuteNonQuery();
            }
            finally
            {
                conexion.desconexion(conn);
            }
            return filasAfectadas;
        }

        public int Delete(Cls_Usuario usuario)
        {
            int filasAfectadas = 0;
            OdbcConnection conn = conexion.conexion();
            try
            {
                conn.Open();
                OdbcCommand cmd = new OdbcCommand(SQL_DELETE, conn);
                cmd.Parameters.AddWithValue("id_usuario", usuario.Id_usuario);
                filasAfectadas = cmd.ExecuteNonQuery();
            }
            finally
            {
                conexion.desconexion(conn);
            }
            return filasAfectadas;
        }

        public Cls_Usuario Query(string usuarioNombre)
        {
            Cls_Usuario usuario = null;
            OdbcConnection conn = conexion.conexion();
            try
            {
                conn.Open();
                OdbcCommand cmd = new OdbcCommand(SQL_QUERY, conn);
                cmd.Parameters.AddWithValue("usuario", usuarioNombre);
                using (OdbcDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        usuario = new Cls_Usuario
                        {
                            Id_usuario = reader.GetInt32(0),
                            UsuarioNombre = reader.GetString(1),
                            Contraseña = reader.GetString(2)
                        };
                    }
                }
            }
            finally
            {
                conexion.desconexion(conn);
            }
            return usuario;
        }
    }
}
