namespace Hypesoft.Application.Commands.CreateUser;

public class CreateUserResult
{
    public Guid Id { get; init; }
    public string Name { get; init; } = string.Empty;
    public string Email { get; init; } = string.Empty;
}
