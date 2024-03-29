﻿using Prueba.Core.DTOs;
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

        public ResponseQuery<HabitacionHotelDto> GetHotelRoom(int id, ResponseQuery<HabitacionHotelDto> response)
        {
            try
            {
                response.Result = habitacionHotelDataAccess.GetHotelRoom(id);
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
                response.Result = new HabitacionHotelDto();
                response.Mensaje = ex.Message;
                response.Exitosos = false;
            }
            return response;
        }

        public ResponseQuery<List<HabitacionHotelDto>> GetListHotelroom(ResponseQuery<List<HabitacionHotelDto>> response)
        {
            try
            {
                response.Result = habitacionHotelDataAccess.GetListHotelroom();
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
                response.Result = new List<HabitacionHotelDto>();
                response.Mensaje = ex.Message;
                response.Exitosos = false;
            }
            return response;
        }

        public ResponseQuery<HabitacionHotelDto> CreateHotelRoom(HabitacionHotelDto request, ResponseQuery<HabitacionHotelDto> response)
        {
            try
            {
                response.Result = habitacionHotelDataAccess.CreateHotelRoom(request);
                response.Exitosos = true;
                response.Mensaje = "Hotel room successfully Created";
            }
            catch (Exception ex)
            {
                response.Result = new HabitacionHotelDto();
                response.Mensaje = ex.Message;
                response.Exitosos = false;
            }
            return response;
        }

        public ResponseQuery<HabitacionHotelDto> EditHotelRoom(HabitacionHotelDto request, ResponseQuery<HabitacionHotelDto> response)
        {
            try
            {
                response.Result = habitacionHotelDataAccess.EditHotelRoom(request);
                if (response.Result != null)
                {
                    response.Mensaje = "Record successfully updated";
                    response.Exitosos = true;
                }
                else
                {
                    response.Mensaje = "The record doesn't exist";
                    response.Exitosos = false;
                }
            }
            catch (Exception ex)
            {
                response.Result = new HabitacionHotelDto();
                response.Mensaje = ex.Message;
                response.Exitosos = false;
            }
            return response;
        }

        public ResponseQuery<HabitacionHotelDto> ActiveHotelRoom(int id, ResponseQuery<HabitacionHotelDto> response)
        {
            try
            {                
                response.Result = habitacionHotelDataAccess.ActiveHotelRoom(id);
                if (response.Result.Id != 0)
                {
                    response.Mensaje = response.Result.Activo == true ? "record successfully Enabled" : "record successfully Disabled";
                    response.Exitosos = true;
                }
                else
                {
                    response.Mensaje = "The record doesn't exist";
                    response.Exitosos = false;
                }
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
