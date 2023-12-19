
using Microsoft.AspNetCore.Mvc;
using Prueba.Core.DTOs;
using Prueba.Core.Interfaces;
using Prueba.Core.Responses;
using System.Collections.Generic;

namespace PruebaWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReservaController : Controller
    {
        readonly IReservaServices reservaServices;

        public ReservaController(IReservaServices _reservaServices)
        {
            reservaServices = _reservaServices;
        }

        [HttpPost]
        [Route("ObtenerReserva")]
        public IActionResult ObtenerReserva(ReservaDto request)
        {
            ResponseQuery<ReservaDto> response = new ResponseQuery<ReservaDto>();
            reservaServices.ObtenerReserva(request, response);
            return Ok(response.Result);
        }

        [HttpPost]
        [Route("ListaReservas")]
        public IActionResult ListaReservas(ObtenerReservasDto request)
        {
            ResponseQuery<List<ObtenerReservasDto>> response = new ResponseQuery<List<ObtenerReservasDto>>();
            reservaServices.ListaReservas(request, response);
            return Ok(response.Result);
        }

        [HttpPost]
        [Route("CrearReserva")]
        public IActionResult CrearReserva(ReservaDto request)
        {
            ResponseQuery<ReservaDto> response = new ResponseQuery<ReservaDto>();
            reservaServices.CrearReserva(request, response);
            return Ok(response.Result);
        }


    }
}
