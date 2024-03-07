var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "[Home page]");

app.Run();
