using System;
using System.Collections.Generic;

#nullable disable

namespace Prueba.Core.Entities
{
    public partial class ReservaHabitacion
    {
        public int Id { get; set; }
        public int? HabitacionId { get; set; }
        public int? ReservaId { get; set; }
        public DateTime? FechaInicio { get; set; }
        public DateTime? FechaFin { get; set; }
        public double? ValorLocal { get; set; }

        public virtual HabitacionHotel Habitacion { get; set; }
        public virtual Reserva Reserva { get; set; }
    }
}
