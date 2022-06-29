using F_Dinner.Application.Common.Interface.Presistance;
using F_Dinner.Domain.Entities;

namespace F_Dinner.Infrastucture.Persistance;

public class UserRepository : IUserRepository
{
    private static readonly List<User> users = new();
    public void Add(User entity)
    {
        users.Add(entity);
    }

    public User GetUserByEmail(string email)
    {
        return users.SingleOrDefault(p=>p.Email == email);
    }
}