
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
        public ResponseQuery<HotelDto> ObtenerHotel(HotelDto request, ResponseQuery<HotelDto> response);

        public ResponseQuery<List<HotelDto>> ListaHoteles(ResponseQuery<List<HotelDto>> response);

        public ResponseQuery<HotelDto> CrearHotel(HotelDto request, ResponseQuery<HotelDto> response);

        public ResponseQuery<HotelDto> EditarHotel(HotelDto request, ResponseQuery<HotelDto> response);

        public ResponseQuery<HotelDto> ActivoHotel(HotelDto request, ResponseQuery<HotelDto> response);

    }
}
