using System;
using Exercise_Tracker.EntityFramework.Lawang.Models;
using Exercise_Tracker.EntityFramework.Lawang.Repository;

namespace Exercise_Tracker.EntityFramework.Lawang.Services;

public class ExerciseService : IExerciseService
{
    private readonly IExerciseRepository _exerciseRepository;
    public ExerciseService(IExerciseRepository repo)
    {
        _exerciseRepository = repo;
    }
    public async Task<Exercise> CreateAsync(Exercise entity)
    {
        return await _exerciseRepository.CreateAsync(entity);
    }

    public async Task<Exercise> DeleteAsync(Exercise entity)
    {
        return await _exerciseRepository.DeleteAsync(entity);
    }

    public async Task<List<Exercise>> GetAllAsync()
    {
        return await _exerciseRepository.GetAllAsync();
    }

    public async Task<Exercise> UpdateAsync(Exercise entity)
    {
        return await _exerciseRepository.UpdateAsync(entity);
    }
}
