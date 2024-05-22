using CarRental.DatabaseManager.Models;

namespace CarRental.API.DTOs;

public class GetCarDetailsDto : GetCarDto
{
    public IList<Booking>? Bookings { get; set; }
}