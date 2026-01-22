using MediatR;
using Hypesoft.Application.DTOs;

namespace Hypesoft.Application.Queries.GetAllUsers;

public record GetAllUsersQuery() : IRequest<List<UserResponse>>;
