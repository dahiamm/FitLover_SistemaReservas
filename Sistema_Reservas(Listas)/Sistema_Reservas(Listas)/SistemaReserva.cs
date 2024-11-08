using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Reservas_Listas_
{
    public class SistemaReserva
    {
        private Reserva[] reservas;
        private int idContador;
        private int reservasMax;
        public Servicio[] Servicios { get; private set; }

        public SistemaReserva(int maxReservas, int maxServicios)
        {
            reservasMax = maxReservas;
            reservas = new Reserva[reservasMax];
            Servicios = new Servicio[maxServicios];
            idContador = 1;

            Servicios = new Servicio[]
            {
                new Servicio("Entrenamiento personal", 10),
                new Servicio("Yoga", 20),
                new Servicio("Aeróbicos", 30),
                new Servicio("Spinning", 20),
                new Servicio("Evaluación de condición física", 10),
                new Servicio("Asesoría nutricional", 10),
            };
        }

        // Método para reservar un servicio en una fecha específica
        public void ReservarServicio(string nombreCliente, int indexServicio, DateTime fechaReserva)
        {
            Servicio servicio = Servicios[indexServicio];

            if (!servicio.ReservarFecha(fechaReserva))
            {
                throw new InvalidOperationException($"No se pueden agregar más reservas para {servicio.NombreServicio} en la fecha {fechaReserva.ToShortDateString()}. Capacidad alcanzada.");
            }

            for (int i = 0; i < reservasMax; i++)
            {
                if (reservas[i] == null)
                {
                    reservas[i] = new Reserva(idContador, nombreCliente, servicio, fechaReserva);
                    idContador++;
                    return;
                }
            }
            throw new InvalidOperationException("No se pueden agregar más reservas. Capacidad máxima del sistema alcanzada.");
        }

        // Método para listar todas las reservas
        public Reserva[] ListarReservas()
        {
            return reservas;
        }

        // Método para eliminar una reserva
        public void RetirarReserva(int idReserva)
        {
            for (int i = 0; i < reservasMax; i++)
            {
                if (reservas[i] != null && reservas[i].IdReserva == idReserva)
                {
                    reservas[i].Servicio.EliminarReserva(reservas[i].FechaReserva);
                    reservas[i] = null;
                    return;
                }
            }
            throw new InvalidOperationException("Reserva no encontrada.");
        }
    }
}
