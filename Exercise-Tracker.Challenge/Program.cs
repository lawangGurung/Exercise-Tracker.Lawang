using Exercise_Tracker.Challenge;
using Exercise_Tracker.Challenge.Controllers;
using Exercise_Tracker.Challenge.Data;
using Exercise_Tracker.Challenge.Repositories;
using Exercise_Tracker.Challenge.Services;
using Microsoft.Extensions.DependencyInjection;

DotNetEnv.Env.Load();

ApplicationConnection.ConnectionString = Environment.GetEnvironmentVariable("ConnectionString");


var serviceProvder = new ServiceCollection()
    .AddTransient<ICardioRepository, CardioRepository>()
    .AddScoped<CardioDbContext>()
    .AddScoped<CardioService>()
    .AddSingleton<CardioController>()
    .AddSingleton<ApplicationController>()
    .AddSingleton<UserInput>()
    .BuildServiceProvider();


var app = serviceProvder.GetRequiredService<ApplicationController>();

await app.Run();