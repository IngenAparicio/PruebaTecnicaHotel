using Prueba.Core.DTOs;
using Prueba.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba.Core.Interfaces
{
    public interface IHuespedesReservaDataAccess
    {
        public HuespedesReservaDto GetGuestReserv(int id);

        public List<HuespedesReservaDto> GetListGuestReserv(int reservaId);

        public HuespedesReservaDto CreateGuestReserv(HuespedesReservaDto request);


    }
}
