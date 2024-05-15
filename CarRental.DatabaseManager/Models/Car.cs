using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarRental.DatabaseManager.Models;

public class Car
{
    [Key]
    public int Id { get; init; }

    [MaxLength(100)]
    [Required]
    public string? Model { get; init; }

    public IList<Booking>? Bookings { get; set; }
}