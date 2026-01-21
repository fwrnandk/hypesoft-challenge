using Hypesoft.Application.Common.DTOs;
using Hypesoft.Application.Health;
using Microsoft.AspNetCore.Mvc;

namespace Hypesoft.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HealthController : ControllerBase
    {
        private readonly IHealthCheckService _healthCheckService;

        public HealthController(IHealthCheckService healthCheckService)
        {
            _healthCheckService = healthCheckService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var result = _healthCheckService.Check();

            return Ok(ApiResponseDto<object>.Ok(result));
        }
    }
}
