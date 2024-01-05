
using Microsoft.AspNetCore.Mvc;
using Prueba.Core.DTOs;
using Prueba.Core.Interfaces;
using Prueba.Core.Responses;
using System.Collections.Generic;

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
        [Route("GetRoomReservation")]
        public ResponseQuery<ReservaHabitacionDto> GetRoomReservation(int id)
        {
            ResponseQuery<ReservaHabitacionDto> response = new ResponseQuery<ReservaHabitacionDto>();
            return reservaHabitacionServices.GetRoomReservation(id, response);            
        }

        [HttpGet]
        [Route("GetListRoomReservation")]
        public ResponseQuery<List<ReservaHabitacionDto>> GetListRoomReservation(int reservaId)
        {
            ResponseQuery<List<ReservaHabitacionDto>> response = new ResponseQuery<List<ReservaHabitacionDto>>();
            return reservaHabitacionServices.GetListRoomReservation(reservaId, response);            
        }

        [HttpPost]
        [Route("CreateRoomReservation")]
        public IActionResult CreateRoomReservation(ReservaHabitacionDto request)
        {
            ResponseQuery<ReservaHabitacionDto> response = new ResponseQuery<ReservaHabitacionDto>();
            reservaHabitacionServices.CreateRoomReservation(request, response);
            return Ok(response.Result);
        }


    }
}
