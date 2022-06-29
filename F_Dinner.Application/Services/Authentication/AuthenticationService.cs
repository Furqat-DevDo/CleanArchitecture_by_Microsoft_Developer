using F_Dinner.Application.Common.Interface.Presistance;
using F_Dinner.Application.Common.Interfaces.Authentication;
using F_Dinner.Domain.Entities;

namespace F_Dinner.Application.Services.Authentication;

public class AuthenticationService : IAuthenticationService
{
    private readonly IJwtTokenGenerator _jwtTokenGenerator;
    private readonly IUserRepository _userrepository;
    public AuthenticationService(IJwtTokenGenerator jwtTokenGenerator,IUserRepository userrepository)
    {
        _jwtTokenGenerator = jwtTokenGenerator;
        _userrepository = userrepository;
    }

    public AuthenticationResponse Register(string firstname, string email, string lastname, string password)
    {
        // Check if user exists
        if(_userrepository.GetUserByEmail(email) is not null)
        {
            throw new Exception("User already exists");
        }
        //Create User(Generate unique userId)
        var user = new User
        {
            Firstname = firstname,
            Lastname= lastname,
            Email = email,
            Password = password
        };
        _userrepository.Add(user);
        //Create JWT Token
        var token = _jwtTokenGenerator.GenerateToken(user);
        return new AuthenticationResponse(
            user,
            token);
    }

    public AuthenticationResponse Login(string Email, string Password)
    {
        // Check if user exisit.
        if(_userrepository.GetUserByEmail(Email) is not User user)
        {
            throw new Exception("You don't have an account in our Site");
        }
        // Validate is password is correct.
        if(user.Password != Password)
        {
            throw new Exception("Your Email or Password is InCorrect");
        }
        // Generate JWT Token. 
        var token = _jwtTokenGenerator.GenerateToken(user);
        return new AuthenticationResponse(
        user,
        token);
    }
}
