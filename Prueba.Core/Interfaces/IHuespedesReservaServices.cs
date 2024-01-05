
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
        public ResponseQuery<HuespedesReservaDto> GetGuestReserv(int id, ResponseQuery<HuespedesReservaDto> response);

        public ResponseQuery<List<HuespedesReservaDto>> GetListGuestReserv(int reservaId, ResponseQuery<List<HuespedesReservaDto>> response);

        public ResponseQuery<HuespedesReservaDto> CreateGuestReserv(HuespedesReservaDto request, ResponseQuery<HuespedesReservaDto> response);

    }
}
