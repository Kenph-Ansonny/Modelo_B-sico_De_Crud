using Capa_Controlador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_VVista
{
    public partial class Frm_Login : Form
    {
        public Frm_Login()
        {
            InitializeComponent();
        }

        private void Btn_Ingresar_Click(object sender, EventArgs e)
        {
            try
            {
                string usuarioNombre = Txt_Usuario.Text.Trim();
                string contraseña = Txt_Contraseña.Text.Trim();

                Cls_UsuarioControlador usuarioControlador = new Cls_UsuarioControlador();
                var datosUsuario = usuarioControlador.Login(usuarioNombre, contraseña);

                MessageBox.Show("Bienvenido al sistema", "Acceso permitido", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Cls_UsuarioConectado.IdUsuario = datosUsuario.idUsuario;
                Cls_UsuarioConectado.NombreUsuario = datosUsuario.nombreUsuario;

                Cls_BitacoraControlador bitacora = new Cls_BitacoraControlador();
                bitacora.InsertarBitacora(datosUsuario.idUsuario, 1000, "LGI");

                Frm_MDI ventanaMDIGeneral = new Frm_MDI();
                ventanaMDIGeneral.Show();
                this.Hide();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Btn_Salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
