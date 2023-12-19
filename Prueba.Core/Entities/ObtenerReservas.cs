using System;
using System.Collections.Generic;

namespace Prueba.Core.Entities
{
    public partial class ObtenerReservas
    {
        
        public int Id { get; set; }
        public int HotelId { get; set; }
        public string HotelNombre { get; set; }
        public string Ciudad { get; set; }
        public int? NumeroPersonas { get; set; }
        public DateTime? FechaInicio { get; set; }
        public DateTime? FechaFin { get; set; }
        public double? ValorTotal { get; set; }
        public string NombreEmergencia { get; set; }
        public string TelefonoEmergencia { get; set; }

    }
}
