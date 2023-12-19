
using System;

namespace Prueba.Core.DTOs
{
    public class ReservaDto
    {
        public int Id { get; set; }
        public int? HotelId { get; set; }
        public string Ciudad { get; set; }
        public int? NumeroPersonas { get; set; }
        public DateTime? FechaInicio { get; set; }
        public DateTime? FechaFin { get; set; }
        public double? ValorTotal { get; set; }
        public string NombreEmergencia { get; set; }
        public string TelefonoEmergencia { get; set; }
    }
}
