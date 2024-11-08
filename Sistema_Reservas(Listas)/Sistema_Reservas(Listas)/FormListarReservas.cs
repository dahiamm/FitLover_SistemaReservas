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
    public partial class FormListarReservas : Form
    {
        private SistemaReserva sistemaReserva;
        public FormListarReservas(SistemaReserva sistema)
        {
            InitializeComponent();
            sistemaReserva = sistema;
            ActualizarListaReservas();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (lstReservas.SelectedItem == null)
            {
                MessageBox.Show("Seleccione la reserva que desea eliminar.");
                return;
            }

            string reservaSeleccionada = lstReservas.SelectedItem.ToString();
            int idReserva = ObtenerIdDeReserva(reservaSeleccionada);

            try
            {
                sistemaReserva.RetirarReserva(idReserva);
                ActualizarListaReservas();
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ActualizarListaReservas()
        {
            lstReservas.Items.Clear();
            foreach (var reserva in sistemaReserva.ListarReservas())
            {
                if (reserva != null)
                {
                    lstReservas.Items.Add(reserva.ToString());
                }
            }
        }
        private int ObtenerIdDeReserva(string reservaTexto)
        {
            string[] partes = reservaTexto.Split(',');
            string idParte = partes[0]; // Ejemplo: "ID: 1"
            return int.Parse(idParte.Replace("ID: ", "").Trim());
        }
    }
}
