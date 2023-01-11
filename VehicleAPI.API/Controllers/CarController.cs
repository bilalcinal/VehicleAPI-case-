using Microsoft.AspNetCore.Mvc;
using VehicleAPI.API.Models;
using VehicleAPI.Business.Abstract;
using VehicleAPI.DataAccess.Abstract;

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

        [HttpGet("GetCarsByColor/{color}")]
        public async Task<ActionResult<List<CarVM>>> GetCarsByColor(string Color)
        {
            var result = await _carService.GetCarsByColor(Color);
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }

        [HttpPut("TurnOnOffHeadlights/{carId}/{status}")]
        public async Task<IActionResult> TurnOnOffHeadlights(Guid carId, bool status)
        {
            await _carService.TurnOnOffHeadlights(carId, status);
            return NoContent();
        }

        [HttpDelete("DeleteCar/{id}")]
        public async Task<IActionResult> DeleteCar(Guid Id)
        {
            await _carService.DeleteCar(Id);
            return NoContent();
        }
    }

}