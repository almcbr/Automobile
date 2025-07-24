namespace Automobile.Infra.Data;

public class CarMakeRepository : BaseRepository<CarMake>, ICarMakeRepository
{
    public CarMakeRepository(AutomobileDbContext context) : base(context)
    {
    }
}
