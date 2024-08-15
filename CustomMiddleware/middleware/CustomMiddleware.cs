using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;

public class CustomMiddleware
{
    private readonly RequestDelegate _next;
    private readonly ILogger<CustomMiddleware> _logger;

    public CustomMiddleware(RequestDelegate next, ILogger<CustomMiddleware> logger)
    {
        _next = next;
        _logger = logger;
    }

    public async Task InvokeAsync(HttpContext context)
    {
        // Log that the middleware is invoked
        _logger.LogInformation("CustomMiddleware invoked");

        // Execute the next middleware in the pipeline
        await _next(context);

        // Log after the next middleware has executed
        _logger.LogInformation("CustomMiddleware after next middleware");
    }
}
