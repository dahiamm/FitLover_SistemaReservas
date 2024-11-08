using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Reservas_Listas_
{
    public class Reserva
    {
        public int IdReserva { get; set; }
        public string NombreCliente { get; set; }
        public Servicio Servicio { get; set; }
        public DateTime FechaReserva { get; set; }

        public Reserva(int idReserva, string nombreCliente, Servicio servicio, DateTime fechaReserva)
        {
            IdReserva = idReserva;
            NombreCliente = nombreCliente;
            Servicio = servicio;
            FechaReserva = fechaReserva;
        }

        public override string ToString()
        {
            int capacidadDisponible = Servicio.ObtenerCapacidadParaFecha(FechaReserva);
            return $"ID: {IdReserva}, Cliente: {NombreCliente}, Servicio: {Servicio.NombreServicio}, Fecha: {FechaReserva.ToShortDateString()}, Cupos Disponible: {capacidadDisponible}";
        }
    }
}
