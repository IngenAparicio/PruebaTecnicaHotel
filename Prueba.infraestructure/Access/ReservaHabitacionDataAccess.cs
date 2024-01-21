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

        public List<HabitacionFiltradaDto> GetRoomFiltered(DateTime fechaInicial, DateTime fechaFinal, int cantidadPersonas, string hotelCiudad)
        {
            if (fechaInicial < DateTime.Now)
            {
                return new List<HabitacionFiltradaDto> { null };
            }
            try
            {
                var reservasHabitacion = context.ReservaHabitacion.Where(x => x.FechaInicio >= fechaInicial.Date && x.FechaFin <= fechaFinal.Date).Select(x => x.HabitacionId).ToList();
                var ListHabitaciones = context.HabitacionHotel.Include(x => x.Hotel)
                .Where(x => x.Hotel.Ciudad.ToLower().Equals(hotelCiudad.ToLower()) && x.Capacidad == cantidadPersonas && x.Activo == true && x.Hotel.Activo == true).ToList();

                if(ListHabitaciones.Count > 0)
                {
                    ListHabitaciones.RemoveAll(x => reservasHabitacion.Contains(x.Id));
                    List<HabitacionFiltradaDto> habitacionesFiltradas = ListHabitaciones.Select(entity => new HabitacionFiltradaDto()
                    {
                        HotelNombre = entity.Hotel.Nombre,
                        HotelCiudad = entity.Hotel.Ciudad,
                        HabitacionNombre = entity.Nombre,
                        HabitacionCapacidad = entity.Capacidad,
                        HabitacionPrecio = entity.ValorTotal

                    }).ToList();
                    return habitacionesFiltradas;
                }
                else
                {
                    return new List<HabitacionFiltradaDto> { null };
                }
               

            }
            catch (Exception)
            {
                return new List<HabitacionFiltradaDto> { null };
            }

        }

    }
}
