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
    public class HotelServices : IHotelServices
    {
        private readonly IHotelDataAccess hotelDataAccess;
        public HotelServices(IHotelDataAccess _hotelDataAccess)
        {
            hotelDataAccess = _hotelDataAccess;
        }

        public ResponseQuery<HotelDto> ObtenerHotel(HotelDto request, ResponseQuery<HotelDto> response)
        {
            try
            {
                response.Result = hotelDataAccess.ObtenerHotel(request);
                response.Exitosos = true;
            }
            catch (Exception ex)
            {
                response.Result = new HotelDto();
                response.Mensaje = ex.Message;
                response.Exitosos = false;
            }
            return response;
        }

        public ResponseQuery<List<HotelDto>> ListaHoteles(ResponseQuery<List<HotelDto>> response)
        {
            try
            {
                response.Result = hotelDataAccess.ListaHoteles();
                response.Exitosos = true;
            }
            catch (Exception ex)
            {
                response.Result = new List<HotelDto>();
                response.Mensaje = ex.Message;
                response.Exitosos = false;
            }
            return response;
        }

        public ResponseQuery<HotelDto> CrearHotel(HotelDto request, ResponseQuery<HotelDto> response)
        {
            try
            {
                response.Result = hotelDataAccess.CrearHotel(request);
                response.Exitosos = true;
            }
            catch (Exception ex)
            {
                response.Result = new HotelDto();
                response.Mensaje = ex.Message;
                response.Exitosos = false;
            }
            return response;
        }

        public ResponseQuery<HotelDto> EditarHotel(HotelDto request, ResponseQuery<HotelDto> response)
        {
            try
            {
                response.Result = hotelDataAccess.EditarHotel(request);
                response.Exitosos = true;
            }
            catch (Exception ex)
            {
                response.Result = new HotelDto();
                response.Mensaje = ex.Message;
                response.Exitosos = false;
            }
            return response;
        }

        public ResponseQuery<HotelDto> ActivoHotel(HotelDto request, ResponseQuery<HotelDto> response)
        {
            try
            {                
                response.Result = hotelDataAccess.ActivoHotel(request);
                response.Exitosos = true;
            }
            catch (Exception ex)
            {
                response.Result = new HotelDto();
                response.Mensaje = ex.Message;
                response.Exitosos = false;
            }
            return response;
        }

    }
}
