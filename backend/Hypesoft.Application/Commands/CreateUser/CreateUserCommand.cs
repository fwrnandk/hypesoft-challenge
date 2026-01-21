using MediatR;

namespace Hypesoft.Application.Commands.CreateUser;

public class CreateUserCommand : IRequest<CreateUserResult>
{
    public string Name { get; init; } = string.Empty;
    public string Email { get; init; } = string.Empty;
}
