using Exercise_Tracker.EntityFramework.Lawang.Models;

namespace Exercise_Tracker.EntityFramework.Lawang.Repository;

public interface IExerciseRepository : IRepository<Exercise>
{
    Task UpdateAsync(Exercise entity);
}
