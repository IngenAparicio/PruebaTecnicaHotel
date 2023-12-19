
using System;

namespace Prueba.Core.DTOs
{
    public class ReservaHabitacionDto
    {
        public int Id { get; set; }
        public int? HabitacionId { get; set; }
        public int? ReservaId { get; set; }
        public DateTime? FechaInicio { get; set; }
        public DateTime? FechaFin { get; set; }
        public double? ValorLocal { get; set; }
    }
}
