using Prueba.Core.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba.Core.Interfaces
{
    public interface IHotelDataAccess
    {
        public HotelDto GetHotel(int id);

        public List<HotelDto> GetListHotel();

        public HotelDto CreateHotel(HotelDto request);

        public HotelDto UpdateHotel(HotelDto request);

        public HotelDto ActiveHotel(int id);

    }
}
