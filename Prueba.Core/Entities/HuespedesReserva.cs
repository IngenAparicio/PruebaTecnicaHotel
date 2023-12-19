using System;
using System.Collections.Generic;

#nullable disable

namespace Prueba.Core.Entities
{
    public partial class HuespedesReserva
    {
        public int Id { get; set; }
        public int? ReservaId { get; set; }
        public string Nombre { get; set; }
        public DateTime? FechaNacimiento { get; set; }
        public string TipoDocumento { get; set; }
        public string NoDocumento { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }

        public virtual Reserva Reserva { get; set; }
    }
}
