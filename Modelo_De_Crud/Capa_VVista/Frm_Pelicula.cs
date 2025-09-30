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
    public partial class Frm_Pelicula : Form
    {

        Cls_ControladorPelicula controlador = new Cls_ControladorPelicula();
        Cls_BitacoraControlador auditoriaBitacora = new Cls_BitacoraControlador();

        public Frm_Pelicula()
        {
            InitializeComponent();
            LlenarGrid();

        }

        private void LlenarGrid()
        {
            Dgv_Pelicula.DataSource = controlador.ObtenerPeliculas();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Insertar_Click(object sender, EventArgs e)
        {
            int filas = controlador.Insertar(
            int.Parse(Txt_IdPelicula.Text),
            Txt_Titulo.Text,
            Txt_Descripcion.Text,
            DateTime.TryParse(Txt_FechaEstreno.Text, out DateTime fecha) ? fecha : (DateTime?)null,
            TimeSpan.TryParse(Txt_Duracion.Text, out TimeSpan duracion) ? duracion : (TimeSpan?)null,
            decimal.TryParse(Txt_Calificacion.Text, out decimal calif) ? calif : (decimal?)null,
            Txt_Disponible.Text == "1" ? true : false
            );

            MessageBox.Show(filas > 0 ? "Película insertada correctamente" : "No se pudo insertar la película");
            LlenarGrid();
        }

        private void Btn_Modificar_Click(object sender, EventArgs e)
        {
            int filas = controlador.Modificar(
                int.Parse(Txt_IdPelicula.Text),
                Txt_Titulo.Text,
                Txt_Descripcion.Text,
                DateTime.TryParse(Txt_FechaEstreno.Text, out DateTime fecha) ? fecha : (DateTime?)null,
                TimeSpan.TryParse(Txt_Duracion.Text, out TimeSpan duracion) ? duracion : (TimeSpan?)null,
                decimal.TryParse(Txt_Calificacion.Text, out decimal calif) ? calif : (decimal?)null,
                Txt_Disponible.Text == "1"
            );

            MessageBox.Show(filas > 0 ? "Película modificada correctamente" : "No se pudo modificar la película");
            LlenarGrid();

        }

        private void Btn_Eliminar_Click(object sender, EventArgs e)
        {
            int filas = controlador.Eliminar(int.Parse(Txt_IdPelicula.Text));

            MessageBox.Show(filas > 0 ? "Película eliminada correctamente" : "No se pudo eliminar la película");
            LlenarGrid();
        }

        // llena el textbox con la fila seleccionada
        private void Dgv_Pelicula_SelectionChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = Dgv_Pelicula.Rows[e.RowIndex];

                Txt_IdPelicula.Text = fila.Cells["id_pelicula"].Value.ToString();
                Txt_Titulo.Text = fila.Cells["titulo"].Value.ToString();
                Txt_Descripcion.Text = fila.Cells["descripcion"].Value.ToString();
                Txt_FechaEstreno.Text = fila.Cells["fecha_estreno"].Value.ToString();
                Txt_Duracion.Text = fila.Cells["duracion"].Value.ToString();
                Txt_Calificacion.Text = fila.Cells["calificacion"].Value.ToString();
                Txt_Disponible.Text = fila.Cells["disponible"].Value.ToString() == "True" ? "1" : "0";
            }
        }
    }
}
