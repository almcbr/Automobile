namespace Automobile.Domain.Interfaces;

public interface ICarModelService
{
    Task<List<CarModel>> GetAllAsync();
    Task<CarModel> GetByIdAsync(int id);
    Task AddAsync(CarModel carModel);
    Task UpdateAsync(CarModel carModel);
    Task DeleteAsync(int id);
}
