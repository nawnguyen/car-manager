using CarManager.Domain.Entity;
using CarManager.Infrastructure.Configuration;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CarManager.API.Controllers;

[ApiController]
[Route("api")]
public class CarController(DatabaseContext context) : ControllerBase
{
    [HttpGet("cars")]
    public async Task<List<Car>> GetCars()
    {
        return await context.Cars.ToListAsync();
    }
}