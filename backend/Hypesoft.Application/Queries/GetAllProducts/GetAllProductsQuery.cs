using MediatR;
using Hypesoft.Application.DTOs;

namespace Hypesoft.Application.Queries.GetAllProducts;

public record GetAllProductsQuery()
    : IRequest<List<ProductResponse>>;
