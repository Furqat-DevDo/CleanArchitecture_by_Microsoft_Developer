namespace F_Dinner.Application.Common.Interfaces.Authentication
{
    public interface IJwtTokenGenerator
    {
        string GenerateToken(Guid userId,string Firstname,string Lastname);
    }
}