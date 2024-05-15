using CarRental.DatabaseManager.Models;
using Microsoft.EntityFrameworkCore;


namespace CarRental.DatabaseManager;

public class CarRentalDbContext(DbContextOptions contextOptions) : DbContext(contextOptions)
{
    public DbSet<Customer> Customers { get; init; }
    public DbSet<Car> Cars { get; init; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Booking>()
            .HasOne(b => b.Car)
            .WithMany(c => c.Bookings)
            .HasForeignKey(b => b.CarId)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<Booking>()
            .HasOne(b => b.Customer)
            .WithMany(c => c.Bookings)
            .HasForeignKey(b => b.CustomerId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}