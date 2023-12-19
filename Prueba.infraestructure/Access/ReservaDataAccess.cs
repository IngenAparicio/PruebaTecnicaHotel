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
    public class ReservaDataAccess : IReservaDataAccess
    {
        protected PruebaTecnicaBdContext context;
        private readonly IMapper mapper;

        public ReservaDataAccess(PruebaTecnicaBdContext _context, IMapper _mapper)
        {
            context = _context;
            mapper = _mapper;
        }

        public ReservaDto ObtenerReserva(ReservaDto request)
        {
            Reserva reserva = new Reserva();
            reserva = context.Reserva.FirstOrDefault(x => x.Id == request.Id);
            if (reserva != null)
            {
                return mapper.Map<ReservaDto>(reserva);
            }
            else
            {
                return new ReservaDto();
            }
            
        }

        public List<ObtenerReservasDto> ListaReservas(ObtenerReservasDto request)
        {
            StringBuilder query = new StringBuilder("exec [dbo].[ObtenerReservas] ");
            query.Append($"@HotelId={request.HotelId}");
            List<ObtenerReservas> entidad = context.ObtenerReservas.FromSqlRaw(query.ToString()).ToList();            
            if(entidad != null && entidad.Count > 0)
            {
                return mapper.Map<List<ObtenerReservasDto>>(entidad);
            }
            else
            {
                return new List<ObtenerReservasDto>();
            }
                
        }

        public ReservaDto CrearReserva(ReservaDto request)
        {
            var reserva = mapper.Map<Reserva>(request);
            context.Reserva.Add(reserva);
            context.SaveChanges();
            var reservaResult = mapper.Map<ReservaDto>(reserva);
            return reservaResult;
        }

    }
}
