namespace F_Dinner.Application.Services.Authentication;

public class AuthenticationResponse
{
    public Guid Id { get; set; }

    public string FirstName { get; set; }

    public string LastName { get; set; }

    public string  Email { get; set; }

    public string  Token { get; set; }

    public string  Password { get; set; }

    public AuthenticationResponse(Guid ID,string FIRST,string LAST,string EMAIL,string TOKEN,string PASSWORD)
    {
        Id=ID;
        FirstName=FIRST;
        LastName=LAST;
        Email=EMAIL;
        Token=TOKEN;
        Password=PASSWORD;
    }
}