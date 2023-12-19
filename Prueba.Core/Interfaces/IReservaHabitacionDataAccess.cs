using Prueba.Core.DTOs;
using Prueba.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba.Core.Interfaces
{
    public interface IReservaHabitacionDataAccess
    {
        public ReservaHabitacionDto ObtenerReservaHabitacion(ReservaHabitacionDto request);

        public List<ReservaHabitacionDto> ListaReservaHabitaciones(ReservaHabitacionDto request);

        public ReservaHabitacionDto CrearReservaHabitacion(ReservaHabitacionDto request);


    }
}
