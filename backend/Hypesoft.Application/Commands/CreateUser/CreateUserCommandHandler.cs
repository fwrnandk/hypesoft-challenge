using MediatR;
using Hypesoft.Domain.Entities;

namespace Hypesoft.Application.Commands.CreateUser;

public class CreateUserCommandHandler
    : IRequestHandler<CreateUserCommand, CreateUserResult>
{
    public Task<CreateUserResult> Handle(
        CreateUserCommand request,
        CancellationToken cancellationToken)
    {
        // Criação da entidade de domínio
        var user = new User(request.Name, request.Email);

        // Persistência virá no próximo passo (Repository)
        // Por enquanto, retornamos o resultado

        return Task.FromResult(new CreateUserResult
        {
            Id = user.Id,
            Name = user.Name,
            Email = user.Email
        });
    }
}
