
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

        [HttpGet]
        [Route("GetGuestReserv")]
        public ResponseQuery<HuespedesReservaDto> GetGuestReserv(int id)
        {
            ResponseQuery<HuespedesReservaDto> response = new ResponseQuery<HuespedesReservaDto>();
            return huespedesReservaServices.GetGuestReserv(id, response);            
        }

        [HttpGet]
        [Route("GetListGuestReserv")]
        public ResponseQuery<List<HuespedesReservaDto>> GetListGuestReserv(int reservaId)
        {
            ResponseQuery<List<HuespedesReservaDto>> response = new ResponseQuery<List<HuespedesReservaDto>>();
            return huespedesReservaServices.GetListGuestReserv(reservaId, response);            
        }

        [HttpPost]
        [Route("CreateGuestReserv")]
        public IActionResult CreateGuestReserv(HuespedesReservaDto request)
        {
            ResponseQuery<HuespedesReservaDto> response = new ResponseQuery<HuespedesReservaDto>();
            huespedesReservaServices.CreateGuestReserv(request, response);
            return Ok(response.Result);
        }


    }
}
