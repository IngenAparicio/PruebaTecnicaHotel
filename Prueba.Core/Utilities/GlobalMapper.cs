using AutoMapper;
using Prueba.Core.DTOs;
using Prueba.Core.Entities;

namespace Prueba.Core.Utilities
{
    public class GlobalMapper : Profile
    {

        public GlobalMapper()
        {
            CreateMap<HabitacionHotelDto, HabitacionHotel>().ReverseMap(); 
            CreateMap<HotelDto, Hotel>().ReverseMap();
            CreateMap<HuespedesReservaDto, HuespedesReserva>().ReverseMap();
            CreateMap<ObtenerReservasDto, ObtenerReservas>().ReverseMap();
            CreateMap<ReservaDto, Reserva>().ReverseMap();
            CreateMap<ReservaHabitacionDto, ReservaHabitacion>().ReverseMap();
        }
    }
}
