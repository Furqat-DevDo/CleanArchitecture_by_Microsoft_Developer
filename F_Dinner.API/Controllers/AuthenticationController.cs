using F_Dinner.Contract.Authentication;
using Microsoft.AspNetCore.Mvc;
namespace F_Dinner.API.Controllers;

[Route("auth")]
[ApiController]
public class AuthenticationController : ControllerBase
{
    [HttpPost("login")]
    public IActionResult Login( LoginRequest request )
    {
        return Ok(request);
    }
    
    [HttpPost("register")]
    public IActionResult Register( RegisterRequest request )
    {
        return Ok(request);
    }
    
}