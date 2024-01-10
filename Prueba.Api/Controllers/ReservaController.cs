
using Microsoft.AspNetCore.Mvc;
using Prueba.Core.DTOs;
using Prueba.Core.Interfaces;
using Prueba.Core.Responses;
using System.Collections.Generic;
using System.Threading.Tasks;

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
        [Route(nameof(ReservaController.GetReservation))]
        public async Task<ResponseQuery<ReservaDto>> GetReservation(int id)
        {
            return await Task.Run(() =>
            {
                ResponseQuery<ReservaDto> response = new ResponseQuery<ReservaDto>();
                return reservaServices.GetReservation(id, response);
            });
        }

        [HttpGet]
        [Route(nameof(ReservaController.GetListReservation))]
        public async Task<ResponseQuery<List<ReservaDto>>> GetListReservation(int HotelId)
        {
            return await Task.Run(() =>
            {
                ResponseQuery<List<ReservaDto>> response = new ResponseQuery<List<ReservaDto>>();
                return reservaServices.GetListReservation(HotelId, response);
            });
        }

        [HttpPost]
        [Route(nameof(ReservaController.CreateReservation))]
        public async Task<IActionResult> CreateReservation(ReservaDto request)
        {
            return await Task.Run(() =>
            {
                ResponseQuery<ReservaDto> response = new ResponseQuery<ReservaDto>();
                reservaServices.CreateReservation(request, response);
                return Ok(response.Result);
            });
        }


    }
}
