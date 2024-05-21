using CarRental.DatabaseManager;
using CarRental.DatabaseManager.Models;
using Microsoft.EntityFrameworkCore;

namespace CarRental.Core.Services;

public class CarDatabaseService(CarRentalDbContext dbContext)
{
    public async Task<IList<Car>> GetToursAsync()
    {
        return await dbContext.Cars.ToListAsync();
    }
}