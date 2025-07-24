namespace Automobile.Domain.Entities;

public class CarModel
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int CarMakeId { get; set; }
    virtual CarMake CarMake { get; set; }
}
