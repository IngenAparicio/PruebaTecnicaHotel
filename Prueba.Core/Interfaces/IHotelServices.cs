
using Prueba.Core.DTOs;
using Prueba.Core.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba.Core.Interfaces
{
    public interface IHotelServices
    {
        public ResponseQuery<HotelDto> GetHotel(int id, ResponseQuery<HotelDto> response);

        public ResponseQuery<List<HotelDto>> GetListHotel(ResponseQuery<List<HotelDto>> response);

        public ResponseQuery<HotelDto> CreateHotel(HotelDto request, ResponseQuery<HotelDto> response);

        public ResponseQuery<HotelDto> UpdateHotel(HotelDto request, ResponseQuery<HotelDto> response);

        public ResponseQuery<HotelDto> ActiveHotel(int id, ResponseQuery<HotelDto> response);

    }
}
