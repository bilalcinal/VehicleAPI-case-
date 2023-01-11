using Microsoft.AspNetCore.Mvc;
using VehicleAPI.API.Models;
using VehicleAPI.Business.Abstract;
using VehicleAPI.DataAccess.Abstract;
using VehicleAPI.Entities.Concrete;

namespace VehicleAPI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarController : ControllerBase
    {
        private readonly ICarService _carService;

        public CarController(ICarService carService)
        {
            _carService = carService;
        }

        [HttpGet("GetCarsByColor")]
        public async Task<ActionResult<List<CarModel>>> GetCarsByColor(string Color)
        {
            var result = await _carService.GetCarsByColor(Color);
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }

        [HttpPut("TurnOnOffHeadlights")]
        public async Task<IActionResult> TurnOnOffHeadlights(int carId, bool status)
        {
            await _carService.TurnOnOffHeadlights(carId, status);
            return Ok();
        }

        [HttpDelete("DeleteCar")]
        public async Task<IActionResult> DeleteCar(int Id)
        {
            await _carService.DeleteCar(Id);
            return Ok();
        }
    }

}