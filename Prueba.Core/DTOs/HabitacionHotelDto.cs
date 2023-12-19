
using System;

namespace Prueba.Core.DTOs
{
    public class HabitacionHotelDto
    {
        public int Id { get; set; }
        public int? Piso { get; set; }
        public string Nombre { get; set; }
        public string Tipo { get; set; }
        public string Descripcion { get; set; }
        public double? ValorBase { get; set; }
        public double? Impuesto { get; set; }
        public double? ValorTotal { get; set; }
        public bool? Activo { get; set; }
        public int? HotelId { get; set; }
    }
}
