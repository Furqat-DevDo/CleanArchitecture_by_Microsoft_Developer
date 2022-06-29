namespace F_Dinner.Domain.Entities;
public class User
{
    public Guid Id { get; set; } = Guid.NewGuid();

    public string Firstname { get; set; }

    public string Lastname { get; set; }

    public string  Email { get; set; }

    public string  Password { get; set; }
}