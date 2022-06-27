namespace F_Dinner.Contract.Authentication;

public class RegistrationResponse
{
    public RegistrationResponse(Guid id, string firstName, string lastName, string email, string token,string password)
    {
        Id = id;
        FirstName = firstName;
        LastName = lastName;
        Email = email;
        Token = token;
        Password = password;
    }

    public Guid Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string Token { get; set; }

    public string Password { get; set; }
}