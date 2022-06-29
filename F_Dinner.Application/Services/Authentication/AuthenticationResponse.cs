using F_Dinner.Domain.Entities;

namespace F_Dinner.Application.Services.Authentication;

public class AuthenticationResponse
{
    public Guid userId { get; set; }

    public string FirstName { get; set; }

    public string LastName { get; set; }

    public string  Email { get; set; }

    public string  Token { get; set; }

    public string  Password { get; set; }

    public AuthenticationResponse(User user,string token)
    {
        userId = user.Id;
        FirstName = user.Firstname;
        LastName = user.Lastname;
        Email = user.Email;
        Password =user.Password;
        Token = token;
    }
}