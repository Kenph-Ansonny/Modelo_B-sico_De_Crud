using Capa_Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Controlador
{
    public class Cls_UsuarioControlador
    {
        Cls_UsuarioDAO dao = new Cls_UsuarioDAO();

        //método para cargar los usuarios en el datagridview de Usuarios (en vista)
        public DataTable CargarUsuarios()
        {
            List<Cls_Usuario> lista = dao.Select();

            DataTable dt = new DataTable();
            dt.Columns.Add("ID Usuario", typeof(int));
            dt.Columns.Add("Nombre", typeof(string));
            dt.Columns.Add("Contraseña", typeof(string));

            foreach (var u in lista)
            {
                dt.Rows.Add(u.Id_usuario, u.UsuarioNombre, u.Contraseña);
            }

            return dt;
        }

        //método para consultar un usuario por su nombre de usuario
        public Cls_Usuario ConsultarUsuario(string usuarioNombre)
        {
            return dao.Query(usuarioNombre);
        }

        //método para el login
        public (int idUsuario, string nombreUsuario) Login(string usuarioNombre, string contraseña)
        {
            if (string.IsNullOrWhiteSpace(usuarioNombre) || string.IsNullOrWhiteSpace(contraseña))
                throw new ArgumentException("No pueden haber campos vacíos");

            Cls_Usuario usuario = dao.Query(usuarioNombre);

            if (usuario == null)
                throw new Exception("El usuario no existe.");

            if (usuario.Contraseña != contraseña)
                throw new Exception("Contraseña incorrecta.");

            // Retorna solo lo que la vista necesita
            return (usuario.Id_usuario, usuario.UsuarioNombre);
        }

        //CRUD USUARIOS
        //método para agregar un nuevo usuario (desde la vista de usuarios)
        public void AgregarUsuario(int idUsuario, string usuarioNombre, string contraseña)
        {
            if (idUsuario <= 0) throw new Exception("El ID de usuario debe ser mayor a 0.");
            if (string.IsNullOrWhiteSpace(usuarioNombre)) throw new Exception("El nombre de usuario no puede estar vacío.");
            if (string.IsNullOrWhiteSpace(contraseña)) throw new Exception("La contraseña no puede estar vacía.");

            var nuevoUsuario = new Cls_Usuario
            {
                Id_usuario = idUsuario,
                UsuarioNombre = usuarioNombre,
                Contraseña = contraseña
            };

            dao.Insert(nuevoUsuario);
        }

        //método para actualizar un usuario existente (desde la vista de usuarios)
        public void ActualizarUsuario(int idUsuario, string usuarioNombre, string contraseña)
        {
            if (idUsuario <= 0) throw new Exception("El ID de usuario debe ser mayor a 0.");
            if (string.IsNullOrWhiteSpace(usuarioNombre)) throw new Exception("El nombre de usuario no puede estar vacío.");
            if (string.IsNullOrWhiteSpace(contraseña)) throw new Exception("La contraseña no puede estar vacía.");

            var usuarioActualizado = new Cls_Usuario
            {
                Id_usuario = idUsuario,
                UsuarioNombre = usuarioNombre,
                Contraseña = contraseña
            };

            dao.Update(usuarioActualizado);
        }

        //método para eliminar un usuario (desde la vista de usuarios)
        public void EliminarUsuario(int idUsuario)
        {
            if (idUsuario <= 0) throw new Exception("El ID de usuario no es válido.");

            var usuarioEliminar = new Cls_Usuario { Id_usuario = idUsuario };
            dao.Delete(usuarioEliminar);
        }
    }
}
