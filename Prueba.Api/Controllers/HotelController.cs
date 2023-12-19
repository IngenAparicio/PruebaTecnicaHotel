
using Microsoft.AspNetCore.Mvc;
using Prueba.Core.DTOs;
using Prueba.Core.Interfaces;
using Prueba.Core.Responses;
using System.Collections.Generic;

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

        [HttpPost]
        [Route("ObtenerHotel")]
        public IActionResult ObtenerHotel(HotelDto request)
        {
            ResponseQuery<HotelDto> response = new ResponseQuery<HotelDto>();
            hotelServices.ObtenerHotel(request, response);
            return Ok(response.Result);
        }

        [HttpPost]
        [Route("ListaHoteles")]
        public IActionResult ListaHoteles()
        {
            ResponseQuery<List<HotelDto>> response = new ResponseQuery<List<HotelDto>>();
            hotelServices.ListaHoteles(response);
            return Ok(response.Result);
        }

        [HttpPost]
        [Route("CrearHotel")]
        public IActionResult CrearHotel(HotelDto request)
        {
            ResponseQuery<HotelDto> response = new ResponseQuery<HotelDto>();
            hotelServices.CrearHotel(request, response);
            return Ok(response.Result);
        }

        [HttpPost]
        [Route("EditarHotel")]
        public IActionResult EditarHotel(HotelDto request)
        {
            ResponseQuery<HotelDto> response = new ResponseQuery<HotelDto>();
            hotelServices.EditarHotel(request, response);
            return Ok(response.Result);
        }

        [HttpPost]
        [Route("ActivoHotel")]
        public IActionResult ActivoHotel(HotelDto request)
        {
            ResponseQuery<HotelDto> response = new ResponseQuery<HotelDto>();
            hotelServices.ActivoHotel(request, response);
            return Ok(response.Result);
        }

    }
}
