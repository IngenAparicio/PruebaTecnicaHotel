
using Prueba.Core.DTOs;
using Prueba.Core.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba.Core.Interfaces
{
    public interface IHuespedesReservaServices
    {
        public ResponseQuery<HuespedesReservaDto> ObtenerHuespedesReserva(HuespedesReservaDto request, ResponseQuery<HuespedesReservaDto> response);

        public ResponseQuery<List<HuespedesReservaDto>> ListaHuespedesReserva(HuespedesReservaDto request, ResponseQuery<List<HuespedesReservaDto>> response);

        public ResponseQuery<HuespedesReservaDto> CrearHuespedesReserva(HuespedesReservaDto request, ResponseQuery<HuespedesReservaDto> response);

    }
}
