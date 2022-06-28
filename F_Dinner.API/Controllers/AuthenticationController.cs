using F_Dinner.Application.Services.Authentication;
using F_Dinner.Contract.Authentication;
using Microsoft.AspNetCore.Mvc;
namespace F_Dinner.API.Controllers;

[Route("auth")]
[ApiController]
public class AuthenticationController : ControllerBase
{
    private readonly IAuthenticationService _authenticationService;
    public AuthenticationController(IAuthenticationService authenticationService)
    {
        _authenticationService = authenticationService;
    }
    [HttpPost("login")]
    public IActionResult Login( LoginRequest request )
    {
        var authresult = _authenticationService.Login(request.Email, request.Password);
        var response = new RegistrationResponse(authresult.userId,
                                                  authresult.FirstName,
                                                  authresult.LastName,
                                                  authresult.Email,
                                                  authresult.Password,
                                                  authresult.Token);
        return Ok(response);
    }
    
    [HttpPost("register")]
    public IActionResult Register( RegisterRequest request )
    {
        var authresult = _authenticationService.Register(request.FirstName,
                                                         request.Email,
                                                         request.LastName,
                                                         request.Password);
        var response = new RegistrationResponse(authresult.userId,
                                                  authresult.FirstName,
                                                  authresult.LastName,
                                                  authresult.Email,
                                                  authresult.Password,
                                                  authresult.Token);
        return Ok(response);
    }
    
}