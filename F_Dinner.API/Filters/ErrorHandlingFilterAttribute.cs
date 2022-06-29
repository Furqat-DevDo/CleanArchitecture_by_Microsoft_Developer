using System.Net;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace F_Dinner.API.Filters;

public class ErrorHandlingFilterAttribute : ExceptionFilterAttribute
{
    public override void OnException(ExceptionContext context)
    {
        var exception = context.Exception;
        var problemDetail = new ProblemDetails
        {
            Type = "",
            Title = context.Exception.Message,
            Status = (int) HttpStatusCode.InternalServerError
        };
        context.Result = new ObjectResult(problemDetail);
        context.ExceptionHandled = true;
    }
}