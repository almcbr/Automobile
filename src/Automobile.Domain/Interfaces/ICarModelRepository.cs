namespace Automobile.Domain.Interfaces;

public interface ICarModelRepository : IBaseRepository<CarModel>
{
    Task<List<CarModel>> GetAllByCarMakeIdAsync(int carMakeId);
}
