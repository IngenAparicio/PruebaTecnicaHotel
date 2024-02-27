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
                if (response.Result != null)
                {
                    response.Mensaje = "record Consulted correctly";
                    response.Exitosos = true;
                }
                else
                {
                    response.Mensaje = "Element not found";
                    response.Exitosos = false;
                }
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
                if (response.Result.Count != 0)
                {
                    response.Mensaje = "Records Consulted Correctly";
                    response.Exitosos = true;
                }
                else
                {
                    response.Mensaje = "Elements not found";
                    response.Exitosos = false;
                }
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
                response.Mensaje = "Record successfully Created";
            }
            catch (Exception ex)
            {
                response.Result = new ReservaHabitacionDto();
                response.Mensaje = ex.Message;
                response.Exitosos = false;
            }
            return response;
        }

        public ResponseQuery<List<HabitacionFiltradaDto>> GetRoomFiltered(DateTime fechaInicial, DateTime fechaFinal, int cantidadPersonas, string hotelCiudad, ResponseQuery<List<HabitacionFiltradaDto>> response)
        {
            try
            {
                response.Result = reservaHabitacionDataAccess.GetRoomFiltered(fechaInicial, fechaFinal, cantidadPersonas, hotelCiudad);
                if (response.Result.Count == 0 ||  response.Result[0] == null)
                {
                    response.Mensaje = "There are no Hotel rooms available for this city, number of guests or dates";
                    response.Exitosos = false;
                }
                else
                {
                    response.Mensaje = "Records Consulted Correctly";
                    response.Exitosos = true;
                    
                }
            }
            catch (Exception ex)
            {
                response.Result = new List<HabitacionFiltradaDto>();
                response.Mensaje = ex.Message;
                response.Exitosos = false;
            }
            return response;
        }

    }
}
