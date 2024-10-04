using Exercise_Tracker.Challenge;
using Microsoft.Extensions.DependencyInjection;

DotNetEnv.Env.Load();

ApplicationConnection.ConnectionString = Environment.GetEnvironmentVariable("ConnectionString");


var serviceProvder = new ServiceCollection()
    .AddSingleton<ApplicationController>()
    .AddSingleton<UserInput>()
    .BuildServiceProvider();

var app = serviceProvder.GetRequiredService<ApplicationController>();

app.Run();