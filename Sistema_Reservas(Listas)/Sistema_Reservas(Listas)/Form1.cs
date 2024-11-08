using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Reservas_Listas_
{
    public partial class FormReservar : Form
    {
        private SistemaReserva sistemaReserva;
        public FormReservar(SistemaReserva sistema)
        {
            InitializeComponent();
            sistemaReserva = sistema;
            CargarServicios();
        }

        private void CargarServicios()
        {
            cboServicios.Items.Clear();
            foreach (var servicio in sistemaReserva.Servicios)
            {
                cboServicios.Items.Add(servicio.NombreServicio);
            }
        }

        //Método para agregar una reserva (evento btnAgregar)
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) || cboServicios.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, complete todos los campos y seleccione un servicio.");
                return;
            }

            try
            {
                string nombre = txtNombre.Text;
                int indexServicio = cboServicios.SelectedIndex;
                DateTime fechaReserva = dtFechaHora.Value;

                sistemaReserva.ReservarServicio(nombre, indexServicio, fechaReserva);
                MessageBox.Show("Reserva realizada con éxito.");
                LimpiarCampos();
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LimpiarCampos()
        {
            txtNombre.Clear();
            cboServicios.SelectedIndex = -1;
            dtFechaHora.Value = DateTime.Now;
        }
    }
}
