using MediatR;
using Microsoft.AspNetCore.Mvc;
using Hypesoft.Application.Commands.CreateUser;

namespace Hypesoft.API.Controllers;

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
}
