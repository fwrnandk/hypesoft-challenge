using MediatR;

namespace Hypesoft.Application.Commands.CreateProduct;

public record CreateProductCommand(
    string Name,
    decimal Price,
    Guid CategoryId
) : IRequest<Guid>;
