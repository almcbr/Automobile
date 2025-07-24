namespace Automobile.Domain.Entities;

public class CarMake
{
    public int Id { get; set; }
    public string Name { get; set; }
    virtual public List<CarModel> CarModels { get; set; }
}
