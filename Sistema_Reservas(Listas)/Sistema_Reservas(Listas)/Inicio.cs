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
    public partial class FormInicio : Form
    {
        private SistemaReserva sistemaReserva;
        public FormInicio()
        {
            InitializeComponent();
            sistemaReserva = new SistemaReserva(100, 6); // Inicializa con 100 reservas y 6 servicios.
        }

        private void btnHacerReserva_Click(object sender, EventArgs e)
        {
            FormReservar formReserva = new FormReservar(sistemaReserva);
            formReserva.ShowDialog();
        }

        private void btnVerReserva_Click(object sender, EventArgs e)
        {
            FormListarReservas formListarReservas = new FormListarReservas(sistemaReserva);
            formListarReservas.ShowDialog();
        }
    }
}
