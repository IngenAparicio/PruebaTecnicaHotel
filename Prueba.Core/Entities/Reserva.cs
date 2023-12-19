using System;
using System.Collections.Generic;

#nullable disable

namespace Prueba.Core.Entities
{
    public partial class Reserva
    {
        public Reserva()
        {
            HuespedesReserva = new HashSet<HuespedesReserva>();
            ReservaHabitacion = new HashSet<ReservaHabitacion>();
        }

        public int Id { get; set; }
        public int? HotelId { get; set; }
        public string Ciudad { get; set; }
        public int? NumeroPersonas { get; set; }
        public DateTime? FechaInicio { get; set; }
        public DateTime? FechaFin { get; set; }
        public double? ValorTotal { get; set; }
        public string NombreEmergencia { get; set; }
        public string TelefonoEmergencia { get; set; }

        public virtual ICollection<HuespedesReserva> HuespedesReserva { get; set; }
        public virtual ICollection<ReservaHabitacion> ReservaHabitacion { get; set; }
    }
}
