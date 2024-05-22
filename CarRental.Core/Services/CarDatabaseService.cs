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

    public async Task<Car?> GetCarAsync(int id)
    {
        var car = await dbContext.Set<Car>().FindAsync(id);
        return car;
    }
}