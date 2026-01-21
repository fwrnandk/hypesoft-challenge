using MediatR;

namespace Hypesoft.Application.Commands.CreateUser;

public record CreateUserCommand(
    string Name,
    string Email,
    string Password
) : IRequest<Guid>;
