using EfCore.Entities;
using EfCore.Services;
using Microsoft.AspNetCore.Mvc;

namespace EfCore.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CarController : ControllerBase
{
    private readonly CarService carService;

    public CarController(CarService carService)
    {
        this.carService = carService;
    }
    [HttpGet("GetAllCars")]
    public async Task<IActionResult> GetAllCars()
    {
        return Ok(await carService.GetAllCars());
    }

    [HttpPost("CreateCar")]
    public async Task<IActionResult> CreateCar(Car car)
    {
        await carService.CreateCar(car);
        return Ok(car);
    }
}
