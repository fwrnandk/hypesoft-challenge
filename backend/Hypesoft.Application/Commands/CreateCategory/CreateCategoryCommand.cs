using MediatR;

namespace Hypesoft.Application.Commands.CreateCategory;

public record CreateCategoryCommand(
    string Name
) : IRequest<Guid>;
