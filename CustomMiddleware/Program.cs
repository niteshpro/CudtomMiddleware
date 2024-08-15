var builder = WebApplication.CreateBuilder(args);

// Add logging to the services
builder.Logging.AddConsole(); // or other logging providers
var app = builder.Build();

// Use custom middleware
app.UseCustomMiddleware();

app.MapGet("/", () => "Hello World!");

app.Run();
