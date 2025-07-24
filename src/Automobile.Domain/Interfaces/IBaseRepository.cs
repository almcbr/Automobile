namespace Automobile.Domain.Interfaces;

public interface IBaseRepository<T> : IDisposable where T : class
{
    Task<List<T>> GetAllAsync();
    Task<T> GetByIdAsync(int id);
    Task AddAsync(T entity);
    Task UpdateAsync(T entity);
    Task DeleteAsync(int id);
    void SaveChanges();
}
