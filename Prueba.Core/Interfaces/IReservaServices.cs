
using Prueba.Core.DTOs;
using Prueba.Core.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba.Core.Interfaces
{
    public interface IReservaServices
    {
        public ResponseQuery<ReservaDto> ObtenerReserva(ReservaDto request, ResponseQuery<ReservaDto> response);

        public ResponseQuery<List<ObtenerReservasDto>> ListaReservas(ObtenerReservasDto request, ResponseQuery<List<ObtenerReservasDto>> response);

        public ResponseQuery<ReservaDto> CrearReserva(ReservaDto request, ResponseQuery<ReservaDto> response);

    }
}
