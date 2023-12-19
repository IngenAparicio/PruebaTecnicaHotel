
using System;

namespace Prueba.Core.DTOs
{
    public class HotelDto
    {
        public int Id { get; set; }
        public string Direccion { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string Ciudad { get; set; }
        public bool? Activo { get; set; }
    }
}
