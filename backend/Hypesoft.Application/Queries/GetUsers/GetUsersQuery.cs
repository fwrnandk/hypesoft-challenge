using MediatR;

namespace Hypesoft.Application.Queries.GetUsers;

public record GetUsersQuery() : IRequest<List<UserDto>>;
