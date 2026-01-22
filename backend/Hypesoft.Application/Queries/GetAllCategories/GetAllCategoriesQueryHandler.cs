using MediatR;
using Hypesoft.Domain.Repositories;
using Hypesoft.Application.DTOs;

namespace Hypesoft.Application.Queries.GetAllCategories;

public class GetAllCategoriesQueryHandler
    : IRequestHandler<GetAllCategoriesQuery, List<CategoryResponse>>
{
    private readonly ICategoryRepository _repository;

    public GetAllCategoriesQueryHandler(ICategoryRepository repository)
    {
        _repository = repository;
    }

    public async Task<List<CategoryResponse>> Handle(
        GetAllCategoriesQuery request,
        CancellationToken cancellationToken)
    {
        var categories = await _repository.GetAllAsync();

        return categories.Select(c =>
            new CategoryResponse(
                c.Id,
                c.Name
            )).ToList();
    }
}
