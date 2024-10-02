using System;

namespace Exercise_Tracker.EntityFramework.Lawang.Repository;

public interface IRepository<T> where T : class
{
    Task<List<T>> GetAllAsync();
    Task CreateAsync(T entity);
    Task DeleteAsync(T entity);
    Task SaveAsync();
}
