using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarRental.DatabaseManager.Models;

public class Booking
{
    [Key]
    public int Id { get; init; }

    [Required]
    [DataType(DataType.Date)]
    public DateTime StartDate { get; init; }

    [Required]
    [DataType(DataType.Date)]
    public DateTime EndDate { get; init; }

    [Required]
    [ForeignKey(nameof(CustomerId))]
    public int CustomerId { get; init; }

    public Customer? Customer { get; init; } // navigation property

    [Required]
    [ForeignKey(nameof(CarId))]
    public int CarId { get; init; }

    public Car? Car { get; init; }
}