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
    public class ReservaServices : IReservaServices
    {
        private readonly IReservaDataAccess reservaDataAccess;
        public ReservaServices(IReservaDataAccess _reservaDataAccess)
        {
            reservaDataAccess = _reservaDataAccess;
        }

        public ResponseQuery<ReservaDto> GetReservation(int id, ResponseQuery<ReservaDto> response)
        {
            try
            {
                response.Result = reservaDataAccess.GetReservation(id);
                response.Exitosos = true;
            }
            catch (Exception ex)
            {
                response.Result = new ReservaDto();
                response.Mensaje = ex.Message;
                response.Exitosos = false;
            }
            return response;
        }

        public ResponseQuery<List<ReservaDto>> GetListReservation(int hotelId, ResponseQuery<List<ReservaDto>> response)
        {
            try
            {

                response.Result = reservaDataAccess.GetListReservation(hotelId);
                response.Exitosos = true;
            }
            catch (Exception ex)
            {
                response.Result = new List<ReservaDto>();
                response.Mensaje = ex.Message;
                response.Exitosos = false;
            }
            return response;
        }

        public ResponseQuery<ReservaDto> CreateReservation(ReservaDto request, ResponseQuery<ReservaDto> response)
        {
            try
            {
                response.Result = reservaDataAccess.CreateReservation(request);
                response.Exitosos = true;
            }
            catch (Exception ex)
            {
                response.Result = new ReservaDto();
                response.Mensaje = ex.Message;
                response.Exitosos = false;
            }
            return response;
        }

    }
}
