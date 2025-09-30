using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Controlador;

namespace Capa_VVista
{
    public partial class Frm_Usuarios : Form
    {
        Cls_UsuarioControlador usuarioController = new Cls_UsuarioControlador();
        Cls_BitacoraControlador auditoriaBitacora = new Cls_BitacoraControlador();
        int idUsuarioConectado;
        int codigoAplicacion = 2000; // código de aplicación "Usuario"
        public Frm_Usuarios()
        {
            InitializeComponent();
            idUsuarioConectado = Cls_UsuarioConectado.IdUsuario; // Obtener el ID del usuario conectado
            CargarUsuarios();
        }


        private void CargarUsuarios()
        {
            Dgv_Usuarios.DataSource = null;
            Dgv_Usuarios.DataSource = usuarioController.CargarUsuarios();
        }

        private void LimpiarCampos()
        {
            Txt_IdUsuario.Clear();
            Txt_Contraseña.Clear();
            Txt_Usuario.Clear();
        }

        private void Btn_Insertar_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(Txt_IdUsuario.Text.Trim());
                string nombre = Txt_Usuario.Text.Trim();
                string contraseña = Txt_Contraseña.Text.Trim();

                usuarioController.AgregarUsuario(id, nombre, contraseña);
                auditoriaBitacora.InsertarBitacora(idUsuarioConectado, codigoAplicacion, "INS");

                CargarUsuarios();
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void Btn_Modificar_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(Txt_IdUsuario.Text.Trim());
                string nombre = Txt_Usuario.Text.Trim();
                string contraseña = Txt_Contraseña.Text.Trim();

                usuarioController.ActualizarUsuario(id, nombre, contraseña);

                // registrar en bitácora
                auditoriaBitacora.InsertarBitacora(idUsuarioConectado, codigoAplicacion, "UPD");

                CargarUsuarios();
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void Btn_Eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(Txt_IdUsuario.Text.Trim());
                var confirm = MessageBox.Show("¿Eliminar este usuario?", "Confirmar", MessageBoxButtons.YesNo);

                if (confirm == DialogResult.Yes)
                {
                    usuarioController.EliminarUsuario(id);

                    // registrar en bitácora
                    auditoriaBitacora.InsertarBitacora(idUsuarioConectado, codigoAplicacion, "DEL");

                    CargarUsuarios();
                    LimpiarCampos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void Dgv_Usuarios_SelectionChanged(object sender, EventArgs e)
        {
            if (Dgv_Usuarios.CurrentRow != null)
            {
                Txt_IdUsuario.Text = Dgv_Usuarios.CurrentRow.Cells["ID Usuario"].Value.ToString();
                Txt_Usuario.Text = Dgv_Usuarios.CurrentRow.Cells["Nombre"].Value.ToString();
                Txt_Contraseña.Text = Dgv_Usuarios.CurrentRow.Cells["Contraseña"].Value.ToString();
            }
        }
    }
}
