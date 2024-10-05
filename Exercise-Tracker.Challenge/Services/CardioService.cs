using Exercise_Tracker.Challenge.Repositories;
using Spectre.Console;

namespace Exercise_Tracker.Challenge.Services;

public class CardioService
{
    private readonly ICardioRepository _exerciseRepository;
    public CardioService(ICardioRepository repo)
    {
        _exerciseRepository = repo;
    }
    public async Task<Exercise?> CreateAsync(Exercise entity)
    {
        try
        {
            return await AnsiConsole.Status().StartAsync("Creating in database...", async ctx =>
            {
                return await _exerciseRepository.CreateAsync(entity);
            });
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            Console.ReadLine();
        }
        return null;
    }

    public async Task<Exercise?> DeleteAsync(Exercise entity)
    {
        try
        {

            return await AnsiConsole.Status().StartAsync("[bold]Deleting data from repository...[/]", async ctx =>
            {
                return await _exerciseRepository.DeleteAsync(entity);
            });
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            Console.ReadLine();
        }
        return null;
    }

    public async Task<List<Exercise>?> GetAllAsync()
    {
        try
        {
            return await AnsiConsole.Status().StartAsync("[bold]Fetching data from repository..[/]", async ctx =>
            {
                return await _exerciseRepository.GetAllAsync();
            });
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            Console.ReadLine();
        }
        return null;
    }

    public async Task<Exercise?> UpdateAsync(Exercise entity)
    {
        try
        {
            return await AnsiConsole.Status().StartAsync("[bold]Updating data in repository...[/]", async ctx =>
            {
                return await _exerciseRepository.UpdateAsync(entity);
            });
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            Console.ReadLine();
        }
        return null;
    }
}
