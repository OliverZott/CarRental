using CarRental.Core.Services;
using CarRental.DatabaseManager.Models;
using Microsoft.AspNetCore.Mvc;

namespace CarRental.API.Controllers;

[Route("/api/[controller]")]
[ApiController]
public class CarController(CarDatabaseService databaseService) : ControllerBase
{
    [HttpGet]
    public async Task<ActionResult<IList<Car>>> GetAllTours()
    {
        var tours = await databaseService.GetToursAsync();
        return Ok(tours);
    }
}