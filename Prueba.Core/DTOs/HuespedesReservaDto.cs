
using System;

namespace Prueba.Core.DTOs
{
    public class HuespedesReservaDto
    {
        public int Id { get; set; }
        public int? ReservaId { get; set; }
        public string Nombre { get; set; }
        public DateTime? FechaNacimiento { get; set; }
        public string TipoDocumento { get; set; }
        public string NoDocumento { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }
    }
}
