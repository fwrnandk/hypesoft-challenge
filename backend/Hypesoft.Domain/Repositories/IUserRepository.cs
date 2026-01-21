using Hypesoft.Domain.Entities;

namespace Hypesoft.Domain.Repositories;

public interface IUserRepository
{
    Task AddAsync(User user);
    Task<User?> GetByEmailAsync(string email);
}
