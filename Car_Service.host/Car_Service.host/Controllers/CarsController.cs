using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Car_Service.host.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarsController : ControllerBase
    {
        private readonly ICarService _carService;

        public CarsController(ICarService carService)
        {
            _carService = carService;
        }
        [HttpGet(nameof(GetAll))]
        public IActionResult GetAllCars()
        {
            var cars = _carService.GetAllCars();
            return Ok(cars);  
        }

        [HttpGet(nameof(GetById))]
        public IActionResult GetById(int id)
        {
            if(id <= 0)
            {
                return BadRequest("ID must be a positive number");
            }
            var car = _carService.GetById(id);
            if (car == null)
            {
                return NotFound($"Car with ID {id} not found");
            }
            return Ok(car);
        }

        [HttpDelete]
        public IActionResult DeleteCar(int id)
        {
            if (id <= 0)
            {
                return BadRequest("ID must be a positive number");
            }
            if (car == null)
            {
                return NotFound($"Car with ID {id} not found");
            }
            _carCrudeService.DeleteCar(id);
            return Ok();
        }


        [HttpPost]
        public IActionResult AddCar([FromBody] Car car)
        {
            if (car == null)
            {
                return BadRequest("Car data is null.");
            }
            _carCrudService.AddCar(car);
            return Ok();
        }

    }
}
