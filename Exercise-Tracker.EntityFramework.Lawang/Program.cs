using Exercise_Tracker.EntityFramework.Lawang.Data;
using Exercise_Tracker.EntityFramework.Lawang.Models;
using Exercise_Tracker.EntityFramework.Lawang.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

DotNetEnv.Env.Load();

var connectionString = Environment.GetEnvironmentVariable("ConnectionString");

// instance of service collection is created to register the services
var serviceCollection = new ServiceCollection();

serviceCollection.AddDbContext<ApplicationDbContext>(options => 
{
    options.UseSqlServer(connectionString);
});

serviceCollection.AddScoped<IExerciseRepository, ExerciseRepository>();


// Creates the instance of sevice provider to get access the services from the service collection
var serviceProvider = serviceCollection.BuildServiceProvider();
