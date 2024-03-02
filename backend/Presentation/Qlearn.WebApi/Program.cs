var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "[Home page]");
app.MapGet("/routerl", () => "[router page]");
app.MapGet("/testrouter", () => "[router page]");
app.MapGet("/testrouter", () => "[router page]");

app.Run();
