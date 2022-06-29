using System.Net;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace F_Dinner.API.MiddleWare;

public class ErrorHandlingMiddleWare
{
    private readonly RequestDelegate _next;

    public ErrorHandlingMiddleWare(RequestDelegate next)
    {
        _next = next;
    }

    public async Task Invoke(HttpContext context)
    {
        try
        {
            await _next(context);
        }
        catch(Exception exc)
        {
            await HandleExceptionAsync(context,exc);
        }
    }

    private static  Task HandleExceptionAsync(HttpContext context, Exception exc)
    {
        var code = HttpStatusCode.InternalServerError;
        var result = JsonSerializer.Serialize(new {error = exc.Message});
        context.Response.ContentType = "application/json";
        context.Response.StatusCode = (int) code;
        return context.Response.WriteAsync(result);
    }
}