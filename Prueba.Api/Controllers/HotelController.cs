
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
        [Route("GetHotel")]
        public ResponseQuery<HotelDto> GetHotel(int id)
        {
            ResponseQuery<HotelDto> response = new ResponseQuery<HotelDto>();
            return hotelServices.GetHotel(id, response);            
        }

        [HttpGet]
        [Route("GetListHotel")]
        public IActionResult GetListHotel()
        {
            ResponseQuery<List<HotelDto>> response = new ResponseQuery<List<HotelDto>>();
            hotelServices.GetListHotel(response);
            return Ok(response.Result);
        }

        [HttpPost]
        [Route("CreateHotel")]
        public IActionResult CreateHotel(HotelDto request)
        {
            ResponseQuery<HotelDto> response = new ResponseQuery<HotelDto>();
            hotelServices.CreateHotel(request, response);
            return Ok(response.Result);
        }

        [HttpPost]
        [Route("UpdateHotel")]
        public IActionResult UpdateHotel(HotelDto request)
        {
            ResponseQuery<HotelDto> response = new ResponseQuery<HotelDto>();
            hotelServices.UpdateHotel(request, response);
            return Ok(response.Result);
        }

        [HttpGet]
        [Route("ActiveHotel")]
        public IActionResult ActiveHotel(int id)
        {
            ResponseQuery<HotelDto> response = new ResponseQuery<HotelDto>();
            hotelServices.ActiveHotel(id, response);
            return Ok(response.Result);
        }

    }
}
