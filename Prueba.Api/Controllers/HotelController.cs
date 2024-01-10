
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
    public class HotelController : Controller
    {
        readonly IHotelServices hotelServices;

        public HotelController(IHotelServices _hotelServices)
        {
            hotelServices = _hotelServices;
        }

        [HttpGet]
        [Route(nameof(HotelController.GetHotel))]
        public async Task<ResponseQuery<HotelDto>> GetHotel(int id)
        {
            return await Task.Run(() =>
            {
                ResponseQuery<HotelDto> response = new ResponseQuery<HotelDto>();
                return hotelServices.GetHotel(id, response);
            });

        }

        [HttpGet]
        [Route(nameof(HotelController.GetListHotel))]
        public async Task<IActionResult> GetListHotel()
        {
            return await Task.Run(() =>
            {
                ResponseQuery<List<HotelDto>> response = new ResponseQuery<List<HotelDto>>();
                hotelServices.GetListHotel(response);
                return Ok(response.Result);
            });
        }


        [HttpPost]
        [Route(nameof(HotelController.CreateHotel))]
        public async Task<IActionResult> CreateHotel(HotelDto request)
        {
            return await Task.Run(() =>
            {
                ResponseQuery<HotelDto> response = new ResponseQuery<HotelDto>();
                hotelServices.CreateHotel(request, response);
                return Ok(response.Result);
            });
        }

        [HttpPost]
        [Route(nameof(HotelController.UpdateHotel))]
        public async Task<IActionResult> UpdateHotel(HotelDto request)
        {
            return await Task.Run(() =>
            {
                ResponseQuery<HotelDto> response = new ResponseQuery<HotelDto>();
                hotelServices.UpdateHotel(request, response);
                return Ok(response.Result);
            });
        }

        [HttpGet]
        [Route(nameof(HotelController.ActiveHotel))]
        public async Task<IActionResult> ActiveHotel(int id)
        {
            return await Task.Run(() =>
            {
                ResponseQuery<HotelDto> response = new ResponseQuery<HotelDto>();
                hotelServices.ActiveHotel(id, response);
                return Ok(response.Result);
            });
        }

    }
}
