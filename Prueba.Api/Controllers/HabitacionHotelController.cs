
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
    public class HabitacionHotelController : Controller
    {
        readonly IHabitacionHotelServices habitacionHotelServices;

        public HabitacionHotelController(IHabitacionHotelServices _habitacionHotelServices)
        {
            habitacionHotelServices = _habitacionHotelServices;
        }

        [HttpGet]
        [Route(nameof(HabitacionHotelController.GetHotelRoom))]
        public async Task<ResponseQuery<HabitacionHotelDto>> GetHotelRoom(int id)
        {
            return await Task.Run(() =>
            {
                ResponseQuery<HabitacionHotelDto> response = new ResponseQuery<HabitacionHotelDto>();
                return habitacionHotelServices.GetHotelRoom(id, response);
            });
        }

        [HttpGet]
        [Route(nameof(HabitacionHotelController.GetListHotelroom))]
        public async Task<IActionResult> GetListHotelroom()
        {
            return await Task.Run(() =>
            {
                ResponseQuery<List<HabitacionHotelDto>> response = new ResponseQuery<List<HabitacionHotelDto>>();
                habitacionHotelServices.GetListHotelroom(response);
                return Ok(response.Result);
            });
        }

        [HttpPost]
        [Route(nameof(HabitacionHotelController.CreateHotelRoom))]
        public async Task<IActionResult> CreateHotelRoom(HabitacionHotelDto request)
        {
            return await Task.Run(() =>
            {
                ResponseQuery<HabitacionHotelDto> response = new ResponseQuery<HabitacionHotelDto>();
                habitacionHotelServices.CreateHotelRoom(request, response);
                return Ok(response.Result);
            });
        }

        [HttpPost]
        [Route(nameof(HabitacionHotelController.EditHotelRoom))]
        public async Task<IActionResult> EditHotelRoom(HabitacionHotelDto request)
        {
            return await Task.Run(() =>
            {
                ResponseQuery<HabitacionHotelDto> response = new ResponseQuery<HabitacionHotelDto>();
                habitacionHotelServices.EditHotelRoom(request, response);
                return Ok(response.Result);
            });
        }

        [HttpGet]
        [Route(nameof(HabitacionHotelController.ActiveHotelRoom))]
        public async Task<IActionResult> ActiveHotelRoom(int id)
        {
            return await Task.Run(() =>
            {
                ResponseQuery<HabitacionHotelDto> response = new ResponseQuery<HabitacionHotelDto>();
                habitacionHotelServices.ActiveHotelRoom(id, response);
                return Ok(response.Result);
            });
        }

    }
}
