using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;

namespace F_Dinner.API.Controllers;
[ApiController]
[Route("error")]
public class ErrorController : ControllerBase
{
    public IActionResult Error()
    {
        Exception ? exception = HttpContext.Features.Get<IExceptionHandlerFeature>()?.Error;
        return Problem(title:exception?.Message,statusCode:400) ;
    }
}