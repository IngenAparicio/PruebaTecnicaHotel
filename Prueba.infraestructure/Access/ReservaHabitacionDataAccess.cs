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
    public class ReservaHabitacionDataAccess : IReservaHabitacionDataAccess
    {
        protected PruebaTecnicaBdContext context;
        private readonly IMapper mapper;

        public ReservaHabitacionDataAccess(PruebaTecnicaBdContext _context, IMapper _mapper)
        {
            context = _context;
            mapper = _mapper;
        }

        public ReservaHabitacionDto GetRoomReservation(int id)
        {
            ReservaHabitacion reservaHabitacion = new ReservaHabitacion();
            reservaHabitacion = context.ReservaHabitacion.FirstOrDefault(x => x.Id == id);            
            return mapper.Map<ReservaHabitacionDto>(reservaHabitacion);

        }

        public List<ReservaHabitacionDto> GetListRoomReservation(int reservaId)
        {            
            List<ReservaHabitacion> entidad = context.ReservaHabitacion.Where(x => x.ReservaId == reservaId).ToList();                        
            return mapper.Map<List<ReservaHabitacionDto>>(entidad);

        }

        public ReservaHabitacionDto CreateRoomReservation(ReservaHabitacionDto request)
        {
            var reservaHabitacion = mapper.Map<ReservaHabitacion>(request);
            context.ReservaHabitacion.Add(reservaHabitacion);
            context.SaveChanges();
            var reservaHabitacionResult = mapper.Map<ReservaHabitacionDto>(reservaHabitacion);
            return reservaHabitacionResult;
        }

    }
}
