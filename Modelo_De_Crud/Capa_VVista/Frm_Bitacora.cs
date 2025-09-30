using Capa_Controlador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_VVista
{
    public partial class Frm_Bitacora : Form
    {
        Cls_BitacoraControlador controlador = new Cls_BitacoraControlador();
        public Frm_Bitacora()
        {
            InitializeComponent();
            CargarTodasLasBitacoras();
        }

        private void CargarTodasLasBitacoras()
        {
            DataTable tabla = controlador.ObtenerTodasBitacoras();
            Dgv_Bitacora.DataSource = tabla;
        }

        private void Btn_Buscar_Click(object sender, EventArgs e)
        {
            string fechaInicio = Txt_PrimeraFecha.Text.Trim();
            string fechaFin = Txt_SegundaFecha.Text.Trim();

            if (!DateTime.TryParseExact(fechaInicio, "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out _) ||
                !DateTime.TryParseExact(fechaFin, "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out _))
            {
                MessageBox.Show("Por favor ingresa fechas válidas en formato yyyy-MM-dd");
                return;
            }

            DataTable tabla = controlador.ObtenerBitacorasPorFechas(fechaInicio, fechaFin);
            Dgv_Bitacora.DataSource = tabla;
        }

        private void Btn_Limpiar_Click(object sender, EventArgs e)
        {
            Txt_PrimeraFecha.Clear();
            Txt_SegundaFecha.Clear();
        }
    }
}

