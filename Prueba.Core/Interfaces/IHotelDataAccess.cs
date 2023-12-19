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
        public HotelDto ObtenerHotel(HotelDto request);

        public List<HotelDto> ListaHoteles();

        public HotelDto CrearHotel(HotelDto request);

        public HotelDto EditarHotel(HotelDto request);

        public HotelDto ActivoHotel(HotelDto request);

    }
}
