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
    public class HotelDataAccess : IHotelDataAccess
    {
        protected PruebaTecnicaBdContext context;
        private readonly IMapper mapper;

        public HotelDataAccess(PruebaTecnicaBdContext _context, IMapper _mapper)
        {
            context = _context;
            mapper = _mapper;
        }

        public HotelDto ObtenerHotel(HotelDto request)
        {
            Hotel hotel = new Hotel();
            hotel = context.Hotel.FirstOrDefault(x => x.Id == request.Id);
            if (hotel != null)
            {
                return mapper.Map<HotelDto>(hotel);
            }
            else
            {
                return new HotelDto();
            }
            
        }

        public List<HotelDto> ListaHoteles()
        {
            
            List<Hotel> entidad = context.Hotel.ToList();
            if(entidad != null && entidad.Count > 0)
            {
                return mapper.Map<List<HotelDto>>(entidad);
            }
            else
            {
                return new List<HotelDto>();
            }
                
        }

        public HotelDto CrearHotel(HotelDto request)
        {
            var hotel = mapper.Map<Hotel>(request);
            context.Hotel.Add(hotel);
            context.SaveChanges();
            var hotelResult = mapper.Map<HotelDto>(hotel);
            return hotelResult;
        }

        public HotelDto EditarHotel(HotelDto request)
        {

            var hotel = context.Hotel.FirstOrDefault(x => x.Id == request.Id);
            if (hotel != null)
            {
                // Campos a actualizar
                FrameworkTypeUtility.SetProperties(request, hotel);

                // Guardar cambios
                context.SaveChanges();
                var HotelResult = mapper.Map<HotelDto>(request);
                return HotelResult;
            }
            else
            {
                return new HotelDto();
            }
            
            
        }

        public HotelDto ActivoHotel(HotelDto request)
        {

            var hotel = context.Hotel.FirstOrDefault(x => x.Id == request.Id);
            request.Activo = !hotel.Activo;
            if (hotel != null)
            {
                // Campos a actualizar
                FrameworkTypeUtility.SetProperties(request, hotel);

                // Guardar cambios
                context.SaveChanges();
                var HotelResult = mapper.Map<HotelDto>(request);
                return HotelResult;
            }
            else
            {
                return new HotelDto();
            }


        }

    }
}
