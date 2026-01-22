using Hypesoft.Domain.Entities;

namespace Hypesoft.Domain.Repositories;

public interface ICategoryRepository
{
    Task AddAsync(Category category);
    Task<List<Category>> GetAllAsync();
}
