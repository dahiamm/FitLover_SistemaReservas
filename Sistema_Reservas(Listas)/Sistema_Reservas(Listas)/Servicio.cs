using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Reservas_Listas_
{
    public class Servicio
    {
        public string NombreServicio { get; set; }
        public int CapacidadMaxima { get; set; }
        private Dictionary<DateTime, int> capacidadXfecha;

        public Servicio(string nombreServicio, int capacidadMaxima)
        {
            NombreServicio = nombreServicio;
            CapacidadMaxima = capacidadMaxima;
            capacidadXfecha = new Dictionary<DateTime, int>();
        }

        // Método para reservar capacidad en una fecha específica
        public bool ReservarFecha(DateTime fecha)
        {
            fecha = fecha.Date; // Asegura que solo tomamos la fecha, sin hora

            if (!capacidadXfecha.ContainsKey(fecha))
            {
                // Si la fecha no existe en el diccionario, inicializa la capacidad en el máximo menos uno
                capacidadXfecha[fecha] = CapacidadMaxima - 1;
                return true;
            }
            else if (capacidadXfecha[fecha] > 0)
            {
                // Si ya existe, decrementa la capacidad si es mayor que cero
                capacidadXfecha[fecha]--;
                return true;
            }

            // Si la capacidad para esa fecha es cero, no permite más reservas
            return false;
        }

        // Método para eliminar una reserva en una fecha específica
        public void EliminarReserva(DateTime fecha)
        {
            fecha = fecha.Date;

            if (capacidadXfecha.ContainsKey(fecha) && capacidadXfecha[fecha] < CapacidadMaxima)
            {
                capacidadXfecha[fecha]++;
            }
        }

        // Método para obtener la capacidad disponible en una fecha específica
        public int ObtenerCapacidadParaFecha(DateTime fecha)
        {
            fecha = fecha.Date;

            if (capacidadXfecha.ContainsKey(fecha))
            {
                return capacidadXfecha[fecha];
            }
            else
            {
                return CapacidadMaxima;
            }
        }
    }
}
