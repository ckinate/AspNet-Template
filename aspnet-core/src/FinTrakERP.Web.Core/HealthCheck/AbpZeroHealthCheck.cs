﻿using Microsoft.Extensions.DependencyInjection;
using FinTrakERP.HealthChecks;

namespace FinTrakERP.Web.HealthCheck
{
    public static class AbpZeroHealthCheck
    {
        public static IHealthChecksBuilder AddAbpZeroHealthCheck(this IServiceCollection services)
        {
            var builder = services.AddHealthChecks();
            builder.AddCheck<FinTrakERPDbContextHealthCheck>("Database Connection");
            builder.AddCheck<FinTrakERPDbContextUsersHealthCheck>("Database Connection with user check");
            builder.AddCheck<CacheHealthCheck>("Cache");

            // add your custom health checks here
            // builder.AddCheck<MyCustomHealthCheck>("my health check");

            return builder;
        }
    }
}
