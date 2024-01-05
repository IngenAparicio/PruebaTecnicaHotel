
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
        public ResponseQuery<HabitacionHotelDto> GetHotelRoom(int id, ResponseQuery<HabitacionHotelDto> response);

        public ResponseQuery<List<HabitacionHotelDto>> GetListHotelroom(ResponseQuery<List<HabitacionHotelDto>> response);

        public ResponseQuery<HabitacionHotelDto> CreateHotelRoom(HabitacionHotelDto request, ResponseQuery<HabitacionHotelDto> response);

        public ResponseQuery<HabitacionHotelDto> EditHotelRoom(HabitacionHotelDto request, ResponseQuery<HabitacionHotelDto> response);

        public ResponseQuery<HabitacionHotelDto> ActiveHotelRoom(int id, ResponseQuery<HabitacionHotelDto> response);

    }
}
