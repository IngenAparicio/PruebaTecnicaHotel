using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Prueba.Core.DTOs;
using Prueba.Core.Entities;
using Prueba.Core.Interfaces;
using Prueba.Core.Utilities;
using Prueba.infraestructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba.infraestructure.Access
{
    public class HabitacionHotelDataAccess : IHabitacionHotelDataAccess
    {
        protected PruebaTecnicaBdContext context;
        private readonly IMapper mapper;

        public HabitacionHotelDataAccess(PruebaTecnicaBdContext _context, IMapper _mapper)
        {
            context = _context;
            mapper = _mapper;
        }

        public HabitacionHotelDto GetHotelRoom(int id)
        {
            HabitacionHotel Habitacionhotel = new HabitacionHotel();
            Habitacionhotel = context.HabitacionHotel.FirstOrDefault(x => x.Id == id);            
            return mapper.Map<HabitacionHotelDto>(Habitacionhotel);

        }

        public List<HabitacionHotelDto> GetListHotelroom()
        {
            
            List<HabitacionHotel> entidad = context.HabitacionHotel.ToList();            
            return mapper.Map<List<HabitacionHotelDto>>(entidad);

        }

        public HabitacionHotelDto CreateHotelRoom(HabitacionHotelDto request)
        {
            var Habitacionhotel = mapper.Map<HabitacionHotel>(request);
            context.HabitacionHotel.Add(Habitacionhotel);
            context.SaveChanges();
            var HabitacionhotelResult = mapper.Map<HabitacionHotelDto>(Habitacionhotel);
            return HabitacionhotelResult;
        }

        public HabitacionHotelDto EditHotelRoom(HabitacionHotelDto request)
        {

            var Habitacionhotel = context.HabitacionHotel.FirstOrDefault(x => x.Id == request.Id);
            if (Habitacionhotel != null)
            {
                // Campos a actualizar
                FrameworkTypeUtility.SetProperties(request, Habitacionhotel);

                // Guardar cambios
                context.SaveChanges();
                var HabitacionhotelResult = mapper.Map<HabitacionHotelDto>(request);
                return HabitacionhotelResult;
            }
            else
            {
                return new HabitacionHotelDto();
            }
            
            
        }

        public HabitacionHotelDto ActiveHotelRoom(int id)
        {

            var Habitacionhotel = context.HabitacionHotel.FirstOrDefault(x => x.Id == id);
            HabitacionHotel HotelRoomTemp = new HabitacionHotel();
            HotelRoomTemp = Habitacionhotel;            
            if (Habitacionhotel != null)
            {
                HotelRoomTemp.Activo = !Habitacionhotel.Activo;
                // Campos a actualizar
                FrameworkTypeUtility.SetProperties(HotelRoomTemp, Habitacionhotel);

                // Guardar cambios
                context.SaveChanges();
                var HabitacionhotelResult = mapper.Map<HabitacionHotelDto>(HotelRoomTemp);
                return HabitacionhotelResult;
            }
            else
            {
                return new HabitacionHotelDto();
            }


        }

    }
}
