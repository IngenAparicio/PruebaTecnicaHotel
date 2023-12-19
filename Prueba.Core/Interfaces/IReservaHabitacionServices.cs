
using Prueba.Core.DTOs;
using Prueba.Core.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba.Core.Interfaces
{
    public interface IReservaHabitacionServices
    {
        public ResponseQuery<ReservaHabitacionDto> ObtenerReservaHabitacion(ReservaHabitacionDto request, ResponseQuery<ReservaHabitacionDto> response);

        public ResponseQuery<List<ReservaHabitacionDto>> ListaReservaHabitaciones(ReservaHabitacionDto request, ResponseQuery<List<ReservaHabitacionDto>> response);

        public ResponseQuery<ReservaHabitacionDto> CrearReservaHabitacion(ReservaHabitacionDto request, ResponseQuery<ReservaHabitacionDto> response);

    }
}
