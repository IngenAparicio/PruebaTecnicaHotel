
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
        public ResponseQuery<ReservaHabitacionDto> GetRoomReservation(int id, ResponseQuery<ReservaHabitacionDto> response);

        public ResponseQuery<List<ReservaHabitacionDto>> GetListRoomReservation(int reservaId, ResponseQuery<List<ReservaHabitacionDto>> response);

        public ResponseQuery<ReservaHabitacionDto> CreateRoomReservation(ReservaHabitacionDto request, ResponseQuery<ReservaHabitacionDto> response);

        public ResponseQuery<List<HabitacionFiltradaDto>> GetRoomFiltered(DateTime fechaInicial, DateTime fechaFinal, int cantidadPersonas, string hotelCiudad, ResponseQuery<List<HabitacionFiltradaDto>> response);

    }
}
