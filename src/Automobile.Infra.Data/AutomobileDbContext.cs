namespace Automobile.Infra.Data;

public class AutomobileDbContext : DbContext
{
    public AutomobileDbContext(DbContextOptions<AutomobileDbContext> options) : base(options)
    {
    }

    public DbSet<CarMake> CarMakes { get; set; }
    public DbSet<CarModel> CarModels { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<CarMake>(entity =>
        {
            entity.HasKey(e => e.Id);
            entity.Property(e => e.Name).IsRequired();
        });

        modelBuilder.Entity<CarModel>(entity =>
        {
            entity.HasKey(e => e.Id);
            entity.Property(e => e.Name).IsRequired();
            entity.HasOne(e => e.CarMake).WithMany(e => e.CarModels).HasForeignKey(e => e.CarMakeId);
        });
    }
}
