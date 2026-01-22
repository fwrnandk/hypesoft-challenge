using MediatR;
using Hypesoft.Domain.Repositories;
using Hypesoft.Application.DTOs;

namespace Hypesoft.Application.Queries.GetAllProducts;

public class GetAllProductsQueryHandler
    : IRequestHandler<GetAllProductsQuery, List<ProductResponse>>
{
    private readonly IProductRepository _repository;

    public GetAllProductsQueryHandler(IProductRepository repository)
    {
        _repository = repository;
    }

    public async Task<List<ProductResponse>> Handle(
        GetAllProductsQuery request,
        CancellationToken cancellationToken)
    {
        var products = await _repository.GetAllAsync();

        return products.Select(p =>
            new ProductResponse(
                p.Id,
                p.Name,
                p.Price,
                p.CategoryId
            )).ToList();
    }
}
