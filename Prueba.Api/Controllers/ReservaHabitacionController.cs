
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

        [HttpPost]
        [Route("ObtenerReservaHabitacion")]
        public IActionResult ObtenerReservaHabitacion(ReservaHabitacionDto request)
        {
            ResponseQuery<ReservaHabitacionDto> response = new ResponseQuery<ReservaHabitacionDto>();
            reservaHabitacionServices.ObtenerReservaHabitacion(request, response);
            return Ok(response.Result);
        }

        [HttpPost]
        [Route("ListaReservaHabitaciones")]
        public IActionResult ListaReservaHabitaciones(ReservaHabitacionDto request)
        {
            ResponseQuery<List<ReservaHabitacionDto>> response = new ResponseQuery<List<ReservaHabitacionDto>>();
            reservaHabitacionServices.ListaReservaHabitaciones(request, response);
            return Ok(response.Result);
        }

        [HttpPost]
        [Route("CrearReservaHabitacion")]
        public IActionResult CrearReservaHabitacion(ReservaHabitacionDto request)
        {
            ResponseQuery<ReservaHabitacionDto> response = new ResponseQuery<ReservaHabitacionDto>();
            reservaHabitacionServices.CrearReservaHabitacion(request, response);
            return Ok(response.Result);
        }


    }
}
