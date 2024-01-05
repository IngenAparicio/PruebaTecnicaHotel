using Prueba.Core.DTOs;
using Prueba.Core.Interfaces;
using Prueba.Core.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba.BL.Services
{
    public class ReservaHabitacionServices : IReservaHabitacionServices
    {
        private readonly IReservaHabitacionDataAccess reservaHabitacionDataAccess;
        public ReservaHabitacionServices(IReservaHabitacionDataAccess _reservaHabitacionDataAccess)
        {
            reservaHabitacionDataAccess = _reservaHabitacionDataAccess;
        }

        public ResponseQuery<ReservaHabitacionDto> GetRoomReservation(int id, ResponseQuery<ReservaHabitacionDto> response)
        {
            try
            {
                response.Result = reservaHabitacionDataAccess.GetRoomReservation(id);
                response.Exitosos = true;
            }
            catch (Exception ex)
            {
                response.Result = new ReservaHabitacionDto();
                response.Mensaje = ex.Message;
                response.Exitosos = false;
            }
            return response;
        }

        public ResponseQuery<List<ReservaHabitacionDto>> GetListRoomReservation(int reservaId, ResponseQuery<List<ReservaHabitacionDto>> response)
        {
            try
            {
                response.Result = reservaHabitacionDataAccess.GetListRoomReservation(reservaId);
                response.Exitosos = true;
            }
            catch (Exception ex)
            {
                response.Result = new List<ReservaHabitacionDto>();
                response.Mensaje = ex.Message;
                response.Exitosos = false;
            }
            return response;
        }

        public ResponseQuery<ReservaHabitacionDto> CreateRoomReservation(ReservaHabitacionDto request, ResponseQuery<ReservaHabitacionDto> response)
        {
            try
            {
                response.Result = reservaHabitacionDataAccess.CreateRoomReservation(request);
                response.Exitosos = true;
            }
            catch (Exception ex)
            {
                response.Result = new ReservaHabitacionDto();
                response.Mensaje = ex.Message;
                response.Exitosos = false;
            }
            return response;
        }

    }
}
