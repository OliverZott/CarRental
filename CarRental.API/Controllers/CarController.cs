using AutoMapper;
using CarRental.API.DTOs;
using CarRental.Core.Services;
using CarRental.DatabaseManager.Models;
using Microsoft.AspNetCore.Mvc;

namespace CarRental.API.Controllers;

[Route("/api/[controller]")]
[ApiController]
public class CarController(CarDatabaseService databaseService, IMapper mapper) : ControllerBase
{
    [HttpGet]
    public async Task<ActionResult<IList<Car>>> GetAllTours()
    {
        var cars = await databaseService.GetToursAsync();
        var carDtos = mapper.Map<IList<GetCarDto>>(cars);
        return Ok(carDtos);
    }


    [HttpGet("{id:int}")]
    public async Task<ActionResult<GetCarDetailsDto>> GetCarById(int id)
    {
        var car = await databaseService.GetCarAsync(id);
        if (car == null) return NotFound();

        var carDetailsDto = mapper.Map<GetCarDetailsDto>(car);

        return Ok(carDetailsDto);
    }
}