using F_Dinner.Application.Common.Interfaces.Authentication;

namespace F_Dinner.Application.Services.Authentication;

public class AuthenticationService : IAuthenticationService
{
    private readonly IJwtTokenGenerator _jwtTokenGenerator;
    public AuthenticationService(IJwtTokenGenerator jwtTokenGenerator)
    {
        _jwtTokenGenerator = jwtTokenGenerator;
    }

    public AuthenticationResponse Login(string Email, string Password)
    {
       return new AuthenticationResponse(
        Guid.NewGuid(), 
        "FirstName", 
        "LastName", 
        Email,
        Password, 
        "Token");
    }

    public AuthenticationResponse Register(string Firstname, string Email, string Lastname, string Password)
    {
        // Check if user exists

        //Create User(Generate unique userId)
        Guid userId = Guid.NewGuid();
        //Create JWT Token
        var token = _jwtTokenGenerator.GenerateToken(userId, Firstname, Lastname);
        return new AuthenticationResponse(
            userId,
            Firstname,
            Lastname,
            Email,
            Password,
            token);
    }
}
