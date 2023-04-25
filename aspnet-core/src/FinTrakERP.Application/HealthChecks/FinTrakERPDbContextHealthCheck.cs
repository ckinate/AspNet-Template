using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Diagnostics.HealthChecks;
using FinTrakERP.EntityFrameworkCore;

namespace FinTrakERP.HealthChecks
{
    public class FinTrakERPDbContextHealthCheck : IHealthCheck
    {
        private readonly DatabaseCheckHelper _checkHelper;

        public FinTrakERPDbContextHealthCheck(DatabaseCheckHelper checkHelper)
        {
            _checkHelper = checkHelper;
        }

        public Task<HealthCheckResult> CheckHealthAsync(HealthCheckContext context, CancellationToken cancellationToken = new CancellationToken())
        {
            if (_checkHelper.Exist("db"))
            {
                return Task.FromResult(HealthCheckResult.Healthy("FinTrakERPDbContext connected to database."));
            }

            return Task.FromResult(HealthCheckResult.Unhealthy("FinTrakERPDbContext could not connect to database"));
        }
    }
}
