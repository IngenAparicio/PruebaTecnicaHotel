
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
    public class HuespedesReservaController : Controller
    {
        readonly IHuespedesReservaServices huespedesReservaServices;

        public HuespedesReservaController(IHuespedesReservaServices _huespedesReservaServices)
        {
            huespedesReservaServices = _huespedesReservaServices;
        }

        [HttpGet]
        [Route(nameof(HuespedesReservaController.GetGuestReserv))]
        public async Task<ResponseQuery<HuespedesReservaDto>> GetGuestReserv(int id)
        {
            return await Task.Run(() =>
            {
                ResponseQuery<HuespedesReservaDto> response = new ResponseQuery<HuespedesReservaDto>();
                return huespedesReservaServices.GetGuestReserv(id, response);
            });
        }

        [HttpGet]
        [Route(nameof(HuespedesReservaController.GetListGuestReserv))]
        public async Task<ResponseQuery<List<HuespedesReservaDto>>> GetListGuestReserv(int reservaId)
        {
            return await Task.Run(() =>
            {
                ResponseQuery<List<HuespedesReservaDto>> response = new ResponseQuery<List<HuespedesReservaDto>>();
                return huespedesReservaServices.GetListGuestReserv(reservaId, response);
            });
        }

        [HttpPost]
        [Route(nameof(HuespedesReservaController.CreateGuestReserv))]
        public async Task<IActionResult> CreateGuestReserv(HuespedesReservaDto request)
        {
            return await Task.Run(() =>
            {
                ResponseQuery<HuespedesReservaDto> response = new ResponseQuery<HuespedesReservaDto>();
                huespedesReservaServices.CreateGuestReserv(request, response);
                return Ok(response);
            });
        }


    }
}
