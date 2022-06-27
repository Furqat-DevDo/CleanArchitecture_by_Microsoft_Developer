namespace F_Dinner.Application.Services.Authentication;

public class AuthenticationService : IAuthenticationService
{
    public AuthenticationResponse Login(string Email, string Password)
    {
       return new AuthenticationResponse(Guid.NewGuid(), "FirstName", "LastName", Email, "Token", Password);
    }

    public AuthenticationResponse Register(string Firstname, string Email, string Lastname, string Password)
    {
        return new AuthenticationResponse(Guid.NewGuid(),Firstname,Lastname,Email,Password,"Token");
    }
}
