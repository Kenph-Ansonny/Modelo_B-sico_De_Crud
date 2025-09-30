using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Capa_Modelo
{
    public class Cls_Usuario
    {
            public int Id_usuario { get; set; }
            public string UsuarioNombre { get; set; }
            public string Contraseña { get; set; }

            // Constructor vacio
            public Cls_Usuario() { }

            // Constructor con parámetros
            public Cls_Usuario(int id_usuario)
            {
                Id_usuario = id_usuario;
            }
            public Cls_Usuario(int id_usuario, string usuarioNombre)
            {
                Id_usuario = id_usuario;
                UsuarioNombre = usuarioNombre;
            }

            public Cls_Usuario(int id_usuario, string usuarioNombre, string contraseña)
                {
                    Id_usuario = id_usuario;
                    UsuarioNombre = usuarioNombre;
                    Contraseña = contraseña;
            }
    }
}
