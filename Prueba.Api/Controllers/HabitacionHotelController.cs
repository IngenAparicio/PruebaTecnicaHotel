
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

        [HttpGet]
        [Route("GetHotelRoom")]
        public ResponseQuery<HabitacionHotelDto> GetHotelRoom(int id)
        {
            ResponseQuery<HabitacionHotelDto> response = new ResponseQuery<HabitacionHotelDto>();
            return habitacionHotelServices.GetHotelRoom(id, response);            
        }

        [HttpGet]
        [Route("GetListHotelroom")]
        public IActionResult GetListHotelroom()
        {
            ResponseQuery<List<HabitacionHotelDto>> response = new ResponseQuery<List<HabitacionHotelDto>>();
            habitacionHotelServices.GetListHotelroom(response);
            return Ok(response.Result);
        }

        [HttpPost]
        [Route("CreateHotelRoom")]
        public IActionResult CreateHotelRoom(HabitacionHotelDto request)
        {
            ResponseQuery<HabitacionHotelDto> response = new ResponseQuery<HabitacionHotelDto>();
            habitacionHotelServices.CreateHotelRoom(request, response);
            return Ok(response.Result);
        }

        [HttpPost]
        [Route("EditHotelRoom")]
        public IActionResult EditHotelRoom(HabitacionHotelDto request)
        {
            ResponseQuery<HabitacionHotelDto> response = new ResponseQuery<HabitacionHotelDto>();
            habitacionHotelServices.EditHotelRoom(request, response);
            return Ok(response.Result);
        }

        [HttpGet]
        [Route("ActiveHotelRoom")]
        public IActionResult ActiveHotelRoom(int id)
        {
            ResponseQuery<HabitacionHotelDto> response = new ResponseQuery<HabitacionHotelDto>();
            habitacionHotelServices.ActiveHotelRoom(id, response);
            return Ok(response.Result);
        }

    }
}
