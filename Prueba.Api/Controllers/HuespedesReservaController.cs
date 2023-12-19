
using Microsoft.AspNetCore.Mvc;
using Prueba.Core.DTOs;
using Prueba.Core.Interfaces;
using Prueba.Core.Responses;
using System.Collections.Generic;

namespace PruebaWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HuespedesReservaController : Controller
    {
        readonly IHuespedesReservaServices huespedesReservaServices;

        public HuespedesReservaController(IHuespedesReservaServices _huespedesReservaServices)
        {
            huespedesReservaServices = _huespedesReservaServices;
        }

        [HttpPost]
        [Route("ObtenerHuespedesReserva")]
        public IActionResult ObtenerHuespedesReserva(HuespedesReservaDto request)
        {
            ResponseQuery<HuespedesReservaDto> response = new ResponseQuery<HuespedesReservaDto>();
            huespedesReservaServices.ObtenerHuespedesReserva(request, response);
            return Ok(response.Result);
        }

        [HttpPost]
        [Route("ListaHuespedesReserva")]
        public IActionResult ListaHuespedesReserva(HuespedesReservaDto request)
        {
            ResponseQuery<List<HuespedesReservaDto>> response = new ResponseQuery<List<HuespedesReservaDto>>();
            huespedesReservaServices.ListaHuespedesReserva(request, response);
            return Ok(response.Result);
        }

        [HttpPost]
        [Route("CrearHuespedesReserva")]
        public IActionResult CrearHuespedesReserva(HuespedesReservaDto request)
        {
            ResponseQuery<HuespedesReservaDto> response = new ResponseQuery<HuespedesReservaDto>();
            huespedesReservaServices.CrearHuespedesReserva(request, response);
            return Ok(response.Result);
        }


    }
}
