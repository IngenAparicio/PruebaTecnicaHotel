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

        public HotelDto GetHotel(int id)
        {
            Hotel hotel = new Hotel();
            hotel = context.Hotel.FirstOrDefault(x => x.Id == id);           
            return mapper.Map<HotelDto>(hotel);

        }

        public List<HotelDto> GetListHotel()
        {
            
            List<Hotel> entidad = context.Hotel.ToList();
            return mapper.Map<List<HotelDto>>(entidad);

        }

        public HotelDto CreateHotel(HotelDto request)
        {
            var hotel = mapper.Map<Hotel>(request);
            context.Hotel.Add(hotel);
            context.SaveChanges();
            var hotelResult = mapper.Map<HotelDto>(hotel);
            return hotelResult;
        }

        public HotelDto UpdateHotel(HotelDto request)
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

        public HotelDto ActiveHotel(int id)
        {

            var hotel = context.Hotel.FirstOrDefault(x => x.Id == id);
            Hotel newHotel = new Hotel();
            newHotel = hotel;            
            if (hotel != null)
            {
                newHotel.Activo = !hotel.Activo;
                // Campos a actualizar
                FrameworkTypeUtility.SetProperties(newHotel, hotel);

                // Guardar cambios
                context.SaveChanges();
                var HotelResult = mapper.Map<HotelDto>(newHotel);
                return HotelResult;
            }
            else
            {
                return new HotelDto();
            }


        }

    }
}
