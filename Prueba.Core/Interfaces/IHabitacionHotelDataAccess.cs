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
        public HabitacionHotelDto ObtenerHabitacionHotel(HabitacionHotelDto request);

        public List<HabitacionHotelDto> ListaHabitacionesHotel();

        public HabitacionHotelDto CrearHabitacionHotel(HabitacionHotelDto request);

        public HabitacionHotelDto EditarHabitacionHotel(HabitacionHotelDto request);

        public HabitacionHotelDto ActivoHabitacionHotel(HabitacionHotelDto request);

    }
}
