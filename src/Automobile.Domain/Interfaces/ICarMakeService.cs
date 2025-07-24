namespace Automobile.Domain.Interfaces;

public interface ICarMakeService
{
    Task<List<CarMake>> GetAllAsync();
    Task<CarMake> GetByIdAsync(int id);
    Task AddAsync(CarMake carMake);
    Task UpdateAsync(CarMake carMake);
    Task DeleteAsync(int id);
}