using Prueba.Core.DTOs;
using Prueba.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba.Core.Interfaces
{
    public interface IReservaDataAccess
    {
        public ReservaDto ObtenerReserva(ReservaDto request);

        public List<ObtenerReservasDto> ListaReservas(ObtenerReservasDto request);

        public ReservaDto CrearReserva(ReservaDto request);


    }
}
