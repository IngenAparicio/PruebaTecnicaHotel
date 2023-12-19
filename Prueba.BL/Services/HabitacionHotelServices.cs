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
    public class HabitacionHotelServices : IHabitacionHotelServices
    {
        private readonly IHabitacionHotelDataAccess habitacionHotelDataAccess;
        public HabitacionHotelServices(IHabitacionHotelDataAccess _habitacionHotelDataAccess)
        {
            habitacionHotelDataAccess = _habitacionHotelDataAccess;
        }

        public ResponseQuery<HabitacionHotelDto> ObtenerHabitacionHotel(HabitacionHotelDto request, ResponseQuery<HabitacionHotelDto> response)
        {
            try
            {
                response.Result = habitacionHotelDataAccess.ObtenerHabitacionHotel(request);
                response.Exitosos = true;
            }
            catch (Exception ex)
            {
                response.Result = new HabitacionHotelDto();
                response.Mensaje = ex.Message;
                response.Exitosos = false;
            }
            return response;
        }

        public ResponseQuery<List<HabitacionHotelDto>> ListaHabitacionesHotel(ResponseQuery<List<HabitacionHotelDto>> response)
        {
            try
            {
                response.Result = habitacionHotelDataAccess.ListaHabitacionesHotel();
                response.Exitosos = true;
            }
            catch (Exception ex)
            {
                response.Result = new List<HabitacionHotelDto>();
                response.Mensaje = ex.Message;
                response.Exitosos = false;
            }
            return response;
        }

        public ResponseQuery<HabitacionHotelDto> CrearHabitacionHotel(HabitacionHotelDto request, ResponseQuery<HabitacionHotelDto> response)
        {
            try
            {
                response.Result = habitacionHotelDataAccess.CrearHabitacionHotel(request);
                response.Exitosos = true;
            }
            catch (Exception ex)
            {
                response.Result = new HabitacionHotelDto();
                response.Mensaje = ex.Message;
                response.Exitosos = false;
            }
            return response;
        }

        public ResponseQuery<HabitacionHotelDto> EditarHabitacionHotel(HabitacionHotelDto request, ResponseQuery<HabitacionHotelDto> response)
        {
            try
            {
                response.Result = habitacionHotelDataAccess.EditarHabitacionHotel(request);
                response.Exitosos = true;
            }
            catch (Exception ex)
            {
                response.Result = new HabitacionHotelDto();
                response.Mensaje = ex.Message;
                response.Exitosos = false;
            }
            return response;
        }

        public ResponseQuery<HabitacionHotelDto> ActivoHabitacionHotel(HabitacionHotelDto request, ResponseQuery<HabitacionHotelDto> response)
        {
            try
            {                
                response.Result = habitacionHotelDataAccess.ActivoHabitacionHotel(request);
                response.Exitosos = true;
            }
            catch (Exception ex)
            {
                response.Result = new HabitacionHotelDto();
                response.Mensaje = ex.Message;
                response.Exitosos = false;
            }
            return response;
        }

    }
}
