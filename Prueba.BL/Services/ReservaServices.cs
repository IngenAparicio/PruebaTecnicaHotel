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

        public ResponseQuery<ReservaDto> ObtenerReserva(ReservaDto request, ResponseQuery<ReservaDto> response)
        {
            try
            {
                response.Result = reservaDataAccess.ObtenerReserva(request);
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

        public ResponseQuery<List<ObtenerReservasDto>> ListaReservas(ObtenerReservasDto request, ResponseQuery<List<ObtenerReservasDto>> response)
        {
            try
            {
                response.Result = reservaDataAccess.ListaReservas(request);
                response.Exitosos = true;
            }
            catch (Exception ex)
            {
                response.Result = new List<ObtenerReservasDto>();
                response.Mensaje = ex.Message;
                response.Exitosos = false;
            }
            return response;
        }

        public ResponseQuery<ReservaDto> CrearReserva(ReservaDto request, ResponseQuery<ReservaDto> response)
        {
            try
            {
                response.Result = reservaDataAccess.CrearReserva(request);
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
