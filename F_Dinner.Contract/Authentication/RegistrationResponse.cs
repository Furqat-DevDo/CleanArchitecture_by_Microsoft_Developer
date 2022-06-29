namespace F_Dinner.Contract.Authentication;

public class RegistrationResponse
{
    public RegistrationResponse(Guid id, string firstName, string lastName, string email,string password,string token)
    {
        Id = id;
        FirstName = firstName;
        LastName = lastName;
        Email = email;
        Password = password; 
        Token = token;
    }

    public Guid Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string Token { get; set; }

    public string Password { get; set; }
}