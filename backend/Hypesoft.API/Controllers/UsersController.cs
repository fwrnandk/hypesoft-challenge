using MediatR;
using Microsoft.AspNetCore.Mvc;
using Hypesoft.Application.Commands.CreateUser;
using Hypesoft.Application.Queries.GetUsers;
using Hypesoft.Application.Queries.GetAllUsers;
using Microsoft.AspNetCore.Authorization;


namespace Hypesoft.API.Controllers;

[Authorize]
[ApiController]
[Route("api/[controller]")]
public class UsersController : ControllerBase
{
    private readonly IMediator _mediator;

    public UsersController(IMediator mediator)
    {
        _mediator = mediator;
    }

    /// <summary>
    /// Cria um novo usuário
    /// </summary>
    [HttpPost]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> Create(
        [FromBody] CreateUserCommand command)
    {
        var id = await _mediator.Send(command);

	return CreatedAtAction(
    		nameof(Create),
    		new { id },
    		new { id }
	);

    }

	//// <summary>
/// Lista todos os usuários
/// </summary>
[HttpGet]
[ProducesResponseType(StatusCodes.Status200OK)]
public async Task<IActionResult> GetAll()
{
    var result = await _mediator.Send(new GetAllUsersQuery());
    return Ok(result);
}


}
