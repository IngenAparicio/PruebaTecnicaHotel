using Prueba.Core.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba.Core.Interfaces
{
    public interface IHabitacionHotelDataAccess
    {
        public HabitacionHotelDto GetHotelRoom(int id);

        public List<HabitacionHotelDto> GetListHotelroom();

        public HabitacionHotelDto CreateHotelRoom(HabitacionHotelDto request);

        public HabitacionHotelDto EditHotelRoom(HabitacionHotelDto request);

        public HabitacionHotelDto ActiveHotelRoom(int id);

    }
}
