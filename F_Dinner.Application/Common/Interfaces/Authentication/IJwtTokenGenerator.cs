using F_Dinner.Domain.Entities;

namespace F_Dinner.Application.Common.Interfaces.Authentication
{
    public interface IJwtTokenGenerator
    {
        string GenerateToken(User user);
    }
}