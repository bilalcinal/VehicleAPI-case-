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
    public class BusController : ControllerBase
    {
        private readonly IBusService _busService;

        public BusController(IBusService busService)
        {
            _busService = busService;
        }

        [HttpGet("GetCarsByColor")]
        public async Task<ActionResult<List<BusModel>>> GetCarsByColor(string Color)
        {
            var result = await _busService.GetBusByColor(Color);
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }
    }
}