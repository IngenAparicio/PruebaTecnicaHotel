
using Microsoft.AspNetCore.Mvc;
using Prueba.Core.DTOs;
using Prueba.Core.Interfaces;
using Prueba.Core.Responses;
using System.Collections.Generic;

namespace PruebaWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HabitacionHotelController : Controller
    {
        readonly IHabitacionHotelServices habitacionHotelServices;

        public HabitacionHotelController(IHabitacionHotelServices _habitacionHotelServices)
        {
            habitacionHotelServices = _habitacionHotelServices;
        }

        [HttpPost]
        [Route("ObtenerHabitacionHotel")]
        public IActionResult ObtenerHabitacionHotel(HabitacionHotelDto request)
        {
            ResponseQuery<HabitacionHotelDto> response = new ResponseQuery<HabitacionHotelDto>();
            habitacionHotelServices.ObtenerHabitacionHotel(request, response);
            return Ok(response.Result);
        }

        [HttpPost]
        [Route("ListaHabitacionesHotel")]
        public IActionResult ListaHabitacionesHotel()
        {
            ResponseQuery<List<HabitacionHotelDto>> response = new ResponseQuery<List<HabitacionHotelDto>>();
            habitacionHotelServices.ListaHabitacionesHotel(response);
            return Ok(response.Result);
        }

        [HttpPost]
        [Route("CrearHabitacionHotel")]
        public IActionResult CrearHabitacionHotel(HabitacionHotelDto request)
        {
            ResponseQuery<HabitacionHotelDto> response = new ResponseQuery<HabitacionHotelDto>();
            habitacionHotelServices.CrearHabitacionHotel(request, response);
            return Ok(response.Result);
        }

        [HttpPost]
        [Route("EditarHabitacionHotel")]
        public IActionResult EditarHabitacionHotel(HabitacionHotelDto request)
        {
            ResponseQuery<HabitacionHotelDto> response = new ResponseQuery<HabitacionHotelDto>();
            habitacionHotelServices.EditarHabitacionHotel(request, response);
            return Ok(response.Result);
        }

        [HttpPost]
        [Route("ActivoHabitacionHotel")]
        public IActionResult ActivoHabitacionHotel(HabitacionHotelDto request)
        {
            ResponseQuery<HabitacionHotelDto> response = new ResponseQuery<HabitacionHotelDto>();
            habitacionHotelServices.ActivoHabitacionHotel(request, response);
            return Ok(response.Result);
        }

    }
}
