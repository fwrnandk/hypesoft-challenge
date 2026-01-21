using Hypesoft.Application.Health.DTOs;

namespace Hypesoft.Application.Health
{
    public interface IHealthCheckService
    {
        HealthStatusDto Check();
    }
}
