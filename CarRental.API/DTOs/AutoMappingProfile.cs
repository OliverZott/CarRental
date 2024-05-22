using AutoMapper;
using CarRental.DatabaseManager.Models;

namespace CarRental.API.DTOs;

public class AutoMappingProfile : Profile
{
    public AutoMappingProfile()
    {
        CreateMap<Car, GetCarDto>();
        CreateMap<Car, GetCarDetailsDto>();
    }
}