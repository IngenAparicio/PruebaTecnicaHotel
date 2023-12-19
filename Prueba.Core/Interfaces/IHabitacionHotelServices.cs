
using Prueba.Core.DTOs;
using Prueba.Core.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba.Core.Interfaces
{
    public interface IHabitacionHotelServices
    {
        public ResponseQuery<HabitacionHotelDto> ObtenerHabitacionHotel(HabitacionHotelDto request, ResponseQuery<HabitacionHotelDto> response);

        public ResponseQuery<List<HabitacionHotelDto>> ListaHabitacionesHotel(ResponseQuery<List<HabitacionHotelDto>> response);

        public ResponseQuery<HabitacionHotelDto> CrearHabitacionHotel(HabitacionHotelDto request, ResponseQuery<HabitacionHotelDto> response);

        public ResponseQuery<HabitacionHotelDto> EditarHabitacionHotel(HabitacionHotelDto request, ResponseQuery<HabitacionHotelDto> response);

        public ResponseQuery<HabitacionHotelDto> ActivoHabitacionHotel(HabitacionHotelDto request, ResponseQuery<HabitacionHotelDto> response);

    }
}
