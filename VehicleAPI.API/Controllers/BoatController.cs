using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using VehicleAPI.Business.Abstract;
using VehicleAPI.Entities.Concrete;

namespace VehicleAPI.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BoatController : ControllerBase
    {
        private readonly IBoatService _boatService;

        public BoatController(IBoatService boatService)
        {
            _boatService = boatService;
        }

        [HttpGet("GetCarsByColor")]
        public async Task<ActionResult<List<BoatModel>>> GetCarsByColor(string Color)
        {
            var result = await _boatService.GetBoatByColor(Color);
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }
    }
}