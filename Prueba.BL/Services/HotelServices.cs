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

        public ResponseQuery<HotelDto> GetHotel(int id, ResponseQuery<HotelDto> response)
        {
            try
            {
                response.Result = hotelDataAccess.GetHotel(id);
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

        public ResponseQuery<List<HotelDto>> GetListHotel(ResponseQuery<List<HotelDto>> response)
        {
            try
            {
                response.Result = hotelDataAccess.GetListHotel();
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

        public ResponseQuery<HotelDto> CreateHotel(HotelDto request, ResponseQuery<HotelDto> response)
        {
            try
            {
                response.Result = hotelDataAccess.CreateHotel(request);
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

        public ResponseQuery<HotelDto> UpdateHotel(HotelDto request, ResponseQuery<HotelDto> response)
        {
            try
            {
                response.Result = hotelDataAccess.UpdateHotel(request);
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

        public ResponseQuery<HotelDto> ActiveHotel(int id, ResponseQuery<HotelDto> response)
        {
            try
            {                
                response.Result = hotelDataAccess.ActiveHotel(id);
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
