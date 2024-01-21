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
    public class HuespedesReservaDataAccess : IHuespedesReservaDataAccess
    {
        protected PruebaTecnicaBdContext context;
        private readonly IMapper mapper;

        public HuespedesReservaDataAccess(PruebaTecnicaBdContext _context, IMapper _mapper)
        {
            context = _context;
            mapper = _mapper;
        }

        public HuespedesReservaDto GetGuestReserv(int id)
        {
            HuespedesReserva reservaHuespedes = new HuespedesReserva();
            reservaHuespedes = context.HuespedesReserva.FirstOrDefault(x => x.Id == id);            
            return mapper.Map<HuespedesReservaDto>(reservaHuespedes);

        }

        public List<HuespedesReservaDto> GetListGuestReserv(int reservaId)
        {
            List<HuespedesReserva> entidad = context.HuespedesReserva.Where(x => x.ReservaId == reservaId).ToList();                        
            return mapper.Map<List<HuespedesReservaDto>>(entidad);

        }

        public HuespedesReservaDto CreateGuestReserv(HuespedesReservaDto request)
        {
            var reservaHuespedes = mapper.Map<HuespedesReserva>(request);
            context.HuespedesReserva.Add(reservaHuespedes);
            context.SaveChanges();
            var reservaHuespedesResult = mapper.Map<HuespedesReservaDto>(reservaHuespedes);
            return reservaHuespedesResult;
        }

    }
}
