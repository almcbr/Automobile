namespace Automobile.Infra.Data;

public class CarModelRepository : BaseRepository<CarModel>, ICarModelRepository
{
    public CarModelRepository(AutomobileDbContext context) : base(context)
    {
    }
}