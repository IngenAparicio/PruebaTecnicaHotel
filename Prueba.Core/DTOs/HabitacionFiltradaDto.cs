
using System;

namespace Prueba.Core.DTOs
{
    public class HabitacionFiltradaDto
    {                      
        public DateTime? FechaInicio { get; set; }
        public DateTime? FechaFin { get; set; }
        public int? CantidadPersonas { get; set; }
        public string HotelCiudad { get; set; }
        public string HotelNombre { get; set; }
        public string HabitacionNombre { get; set; }
        public int? HabitacionCapacidad { get; set; }
        public double? HabitacionPrecio { get; set; }
    }
}
