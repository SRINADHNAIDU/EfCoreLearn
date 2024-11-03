using EfCore.Entities;
using Microsoft.EntityFrameworkCore;

namespace EfCore.Services;

public class CarService
{
    private readonly EfCoreDbContext _efCoreDbContext;

    public CarService(EfCoreDbContext efCoreDbContext)
    {
        _efCoreDbContext = efCoreDbContext;
    }

    public async Task<List<Car>> GetAllCars()
    {
        return await _efCoreDbContext.Cars.ToListAsync();
    }

    public async Task CreateCar(Car car)
    {
        await _efCoreDbContext.Cars.AddAsync(car); 
        await _efCoreDbContext.SaveChangesAsync();
    } 
}
