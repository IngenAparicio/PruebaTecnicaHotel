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
                if(response.Result != null)
                {
                    response.Mensaje = "Registro Consultado Correctamente";
                    response.Exitosos = true;
                }
                else
                {
                    response.Mensaje = "Elemento no Encontrado";
                    response.Exitosos = false;
                }
                
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
                if (response.Result.Count != 0)
                {
                    response.Mensaje = "Registros Consultados Correctamente";
                    response.Exitosos = true;
                }
                else
                {
                    response.Mensaje = "Elementos no Encontrados";
                    response.Exitosos = false;
                }
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
                response.Mensaje = "Hotel Creado Exitosamente";
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
                if (response.Result != null)
                {
                    response.Mensaje = "Registro se ha actualizado Correctamente";
                    response.Exitosos = true;
                }
                else
                {
                    response.Mensaje = "El registro No existe";
                    response.Exitosos = false;
                }
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
                if (response.Result.Id != 0)
                {
                    response.Mensaje = response.Result.Activo == true ? "Registro Activado Correctamente" : "Registro Desactivado Correctamente";
                    response.Exitosos = true;
                }
                else
                {
                    response.Mensaje = "El registro No existe";
                    response.Exitosos = false;
                }
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
