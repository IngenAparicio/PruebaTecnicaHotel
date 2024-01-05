
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
        public ResponseQuery<ReservaDto> GetReservation(int id, ResponseQuery<ReservaDto> response);

        public ResponseQuery<List<ReservaDto>> GetListReservation(int hotelId, ResponseQuery<List<ReservaDto>> response);

        public ResponseQuery<ReservaDto> CreateReservation(ReservaDto request, ResponseQuery<ReservaDto> response);

    }
}
