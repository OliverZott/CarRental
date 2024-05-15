using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarRental.DatabaseManager.Models;

public class Customer
{
    [Key]
    public int Id { get; init; }

    [MaxLength(100)]
    [Required]
    public string? Name { get; init; }

    public IList<Booking>? Bookings { get; init; }
}