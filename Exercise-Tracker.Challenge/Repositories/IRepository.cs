namespace Exercise_Tracker.Challenge.Repositories;

public interface IRepository<T> where T : class
{
    Task<List<T>?> GetAllAsync();
    Task<T?> UpdateAsync(T entity);
    Task<T?> DeleteAsync(T entity);
}
