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

        public HabitacionHotelDto ObtenerHabitacionHotel(HabitacionHotelDto request)
        {
            HabitacionHotel Habitacionhotel = new HabitacionHotel();
            Habitacionhotel = context.HabitacionHotel.FirstOrDefault(x => x.Id == request.Id);
            if (Habitacionhotel != null)
            {
                return mapper.Map<HabitacionHotelDto>(Habitacionhotel);
            }
            else
            {
                return new HabitacionHotelDto();
            }
            
        }

        public List<HabitacionHotelDto> ListaHabitacionesHotel()
        {
            
            List<HabitacionHotel> entidad = context.HabitacionHotel.ToList();
            if(entidad != null && entidad.Count > 0)
            {
                return mapper.Map<List<HabitacionHotelDto>>(entidad);
            }
            else
            {
                return new List<HabitacionHotelDto>();
            }
                
        }

        public HabitacionHotelDto CrearHabitacionHotel(HabitacionHotelDto request)
        {
            var Habitacionhotel = mapper.Map<HabitacionHotel>(request);
            context.HabitacionHotel.Add(Habitacionhotel);
            context.SaveChanges();
            var HabitacionhotelResult = mapper.Map<HabitacionHotelDto>(Habitacionhotel);
            return HabitacionhotelResult;
        }

        public HabitacionHotelDto EditarHabitacionHotel(HabitacionHotelDto request)
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

        public HabitacionHotelDto ActivoHabitacionHotel(HabitacionHotelDto request)
        {

            var Habitacionhotel = context.HabitacionHotel.FirstOrDefault(x => x.Id == request.Id);
            request.Activo = !Habitacionhotel.Activo;
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

    }
}
