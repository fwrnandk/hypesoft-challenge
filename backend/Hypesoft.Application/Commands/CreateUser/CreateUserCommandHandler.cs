using MediatR;
using Hypesoft.Domain.Entities;
using Hypesoft.Domain.Repositories;

namespace Hypesoft.Application.Commands.CreateUser;

public class CreateUserCommandHandler 
    : IRequestHandler<CreateUserCommand, Guid>
{
    private readonly IUserRepository _repository;

    public CreateUserCommandHandler(IUserRepository repository)
    {
        _repository = repository;
    }

    public async Task<Guid> Handle(
        CreateUserCommand request,
        CancellationToken cancellationToken)
    {
        var existing = await _repository.GetByEmailAsync(request.Email);

        if (existing is not null)
            throw new InvalidOperationException("E-mail já cadastrado");

        var user = new User(
            request.Name,
            request.Email,
            request.Password
        );

        await _repository.AddAsync(user);

        return user.Id;
    }
}
