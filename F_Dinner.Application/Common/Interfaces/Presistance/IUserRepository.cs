using F_Dinner.Domain.Entities;
namespace F_Dinner.Application.Common.Interface.Presistance;

public interface IUserRepository
{
    void Add(User entity);
    User GetUserByEmail(string email);
}
