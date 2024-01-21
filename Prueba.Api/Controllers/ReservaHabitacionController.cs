
using Microsoft.AspNetCore.Mvc;
using Prueba.Core.DTOs;
using Prueba.Core.Interfaces;
using Prueba.Core.Responses;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PruebaWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReservaHabitacionController : Controller
    {
        readonly IReservaHabitacionServices reservaHabitacionServices;

        public ReservaHabitacionController(IReservaHabitacionServices _reservaHabitacionServices)
        {
            reservaHabitacionServices = _reservaHabitacionServices;
        }

        [HttpGet]
        [Route(nameof(ReservaHabitacionController.GetRoomReservation))]
        public async Task<ResponseQuery<ReservaHabitacionDto>> GetRoomReservation(int id)
        {
            return await Task.Run(() =>
            {
                ResponseQuery<ReservaHabitacionDto> response = new ResponseQuery<ReservaHabitacionDto>();
                return reservaHabitacionServices.GetRoomReservation(id, response);
            });
        }

        [HttpGet]
        [Route(nameof(ReservaHabitacionController.GetListRoomReservation))]
        public async Task<ResponseQuery<List<ReservaHabitacionDto>>> GetListRoomReservation(int reservaId)
        {
            return await Task.Run(() =>
            {
                ResponseQuery<List<ReservaHabitacionDto>> response = new ResponseQuery<List<ReservaHabitacionDto>>();
                return reservaHabitacionServices.GetListRoomReservation(reservaId, response);
            });
        }

        [HttpPost]
        [Route(nameof(ReservaHabitacionController.CreateRoomReservation))]
        public async Task<IActionResult> CreateRoomReservation(ReservaHabitacionDto request)
        {
            return await Task.Run(() =>
            {
                ResponseQuery<ReservaHabitacionDto> response = new ResponseQuery<ReservaHabitacionDto>();
                reservaHabitacionServices.CreateRoomReservation(request, response);
                return Ok(response);
            });
        }

        [HttpGet]
        [Route(nameof(ReservaHabitacionController.GetRoomFiltered))]
        public async Task<ResponseQuery<List<HabitacionFiltradaDto>>> GetRoomFiltered(DateTime fechaInicial, DateTime fechaFinal, int cantidadPersonas, string hotelCiudad)
        {
            return await Task.Run(() =>
            {
                ResponseQuery<List<HabitacionFiltradaDto>> response = new ResponseQuery<List<HabitacionFiltradaDto>>();
                return reservaHabitacionServices.GetRoomFiltered(fechaInicial, fechaFinal, cantidadPersonas, hotelCiudad, response);
            });
        }


    }
}
