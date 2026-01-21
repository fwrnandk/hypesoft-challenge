using Hypesoft.Application.Health.DTOs;

namespace Hypesoft.Application.Health
{
    public class HealthCheckService : IHealthCheckService
    {
        public HealthStatusDto Check()
        {
            return new HealthStatusDto
            {
                Status = "API online",
                Timestamp = DateTime.Now
            };
        }
    }
}
