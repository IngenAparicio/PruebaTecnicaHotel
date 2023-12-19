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
    public class ReservaHabitacionDataAccess : IReservaHabitacionDataAccess
    {
        protected PruebaTecnicaBdContext context;
        private readonly IMapper mapper;

        public ReservaHabitacionDataAccess(PruebaTecnicaBdContext _context, IMapper _mapper)
        {
            context = _context;
            mapper = _mapper;
        }

        public ReservaHabitacionDto ObtenerReservaHabitacion(ReservaHabitacionDto request)
        {
            ReservaHabitacion reservaHabitacion = new ReservaHabitacion();
            reservaHabitacion = context.ReservaHabitacion.FirstOrDefault(x => x.Id == request.Id);
            if (reservaHabitacion != null)
            {
                return mapper.Map<ReservaHabitacionDto>(reservaHabitacion);
            }
            else
            {
                return new ReservaHabitacionDto();
            }
            
        }

        public List<ReservaHabitacionDto> ListaReservaHabitaciones(ReservaHabitacionDto request)
        {            
            List<ReservaHabitacion> entidad = context.ReservaHabitacion.Where(x => x.ReservaId == request.ReservaId).ToList();            
            if(entidad != null && entidad.Count > 0)
            {
                return mapper.Map<List<ReservaHabitacionDto>>(entidad);
            }
            else
            {
                return new List<ReservaHabitacionDto>();
            }
                
        }

        public ReservaHabitacionDto CrearReservaHabitacion(ReservaHabitacionDto request)
        {
            var reservaHabitacion = mapper.Map<ReservaHabitacion>(request);
            context.ReservaHabitacion.Add(reservaHabitacion);
            context.SaveChanges();
            var reservaHabitacionResult = mapper.Map<ReservaHabitacionDto>(reservaHabitacion);
            return reservaHabitacionResult;
        }

    }
}