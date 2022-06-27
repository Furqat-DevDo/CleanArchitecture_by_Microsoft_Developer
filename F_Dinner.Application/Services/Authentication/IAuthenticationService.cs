namespace F_Dinner.Application.Services.Authentication;
public interface IAuthenticationService
{
    AuthenticationResponse Login(string Email,string Password);

    AuthenticationResponse Register(string Firstname,string Email,string Lastname,string Password);
}