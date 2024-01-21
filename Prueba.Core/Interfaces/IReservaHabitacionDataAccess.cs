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
        public ReservaHabitacionDto GetRoomReservation(int id);

        public List<ReservaHabitacionDto> GetListRoomReservation(int reservaId);

        public ReservaHabitacionDto CreateRoomReservation(ReservaHabitacionDto request);

        public List<HabitacionFiltradaDto> GetRoomFiltered(DateTime fechaInicial, DateTime fechaFinal, int cantidadPersonas, string hotelCiudad);

    }
}
