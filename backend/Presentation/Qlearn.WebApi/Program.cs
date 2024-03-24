var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

if (app.Environment.IsEnvironment("Test"))
{
    app.Run(async (context) => await context.Response.WriteAsync("In Test Stage."));
} else if (app.Environment.IsEnvironment("Development"))
{
    app.Run(async (context) => await context.Response.WriteAsync("In Development Stage."));
}
else
{
    app.Run(async (context) => await context.Response.WriteAsync("In Production Stage."));
}

app.Run();