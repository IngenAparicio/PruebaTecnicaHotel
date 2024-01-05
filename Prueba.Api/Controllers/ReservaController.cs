
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

        [HttpGet]
        [Route("GetReservation")]
        public ResponseQuery<ReservaDto> GetReservation(int id)
        {
            ResponseQuery<ReservaDto> response = new ResponseQuery<ReservaDto>();
            return reservaServices.GetReservation(id, response);            
        }

        [HttpGet]
        [Route("GetListReservation")]
        public ResponseQuery<List<ReservaDto>> GetListReservation(int HotelId)
        {
            ResponseQuery<List<ReservaDto>> response = new ResponseQuery<List<ReservaDto>>();
            return reservaServices.GetListReservation(HotelId, response);            
        }

        [HttpPost]
        [Route("CreateReservation")]
        public IActionResult CreateReservation(ReservaDto request)
        {
            ResponseQuery<ReservaDto> response = new ResponseQuery<ReservaDto>();
            reservaServices.CreateReservation(request, response);
            return Ok(response.Result);
        }


    }
}
