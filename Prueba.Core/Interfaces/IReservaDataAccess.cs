using Prueba.Core.DTOs;
using Prueba.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba.Core.Interfaces
{
    public interface IReservaDataAccess
    {
        public ReservaDto GetReservation(int id);

        public List<ReservaDto> GetListReservation(int hotelId);

        public ReservaDto CreateReservation(ReservaDto request);


    }
}
