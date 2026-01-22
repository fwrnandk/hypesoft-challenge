using Hypesoft.Domain.Entities;
using Hypesoft.Domain.Repositories;

namespace Hypesoft.Infrastructure.Repositories;

public class CategoryRepository : ICategoryRepository
{
    private static readonly List<Category> _categories = new();

    public Task AddAsync(Category category)
    {
        _categories.Add(category);
        return Task.CompletedTask;
    }

    public Task<List<Category>> GetAllAsync()
    {
        return Task.FromResult(_categories);
    }
}
