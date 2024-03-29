﻿using AutoMapper;
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
    public class ReservaDataAccess : IReservaDataAccess
    {
        protected PruebaTecnicaBdContext context;
        private readonly IMapper mapper;

        public ReservaDataAccess(PruebaTecnicaBdContext _context, IMapper _mapper)
        {
            context = _context;
            mapper = _mapper;
        }

        public ReservaDto GetReservation(int id)
        {
            Reserva reserva = new Reserva();
            reserva = context.Reserva.FirstOrDefault(x => x.Id == id);            
            return mapper.Map<ReservaDto>(reserva);

        }

        public List<ReservaDto> GetListReservation(int hotelId)
        {
            List<Reserva> entidad = context.Reserva.Where(x => x.HotelId == hotelId).ToList();                        
            return mapper.Map<List<ReservaDto>>(entidad);

        }

        public ReservaDto CreateReservation(ReservaDto request)
        {
            var reserva = mapper.Map<Reserva>(request);
            context.Reserva.Add(reserva);
            context.SaveChanges();
            var reservaResult = mapper.Map<ReservaDto>(reserva);
            return reservaResult;
        }

    }
}
