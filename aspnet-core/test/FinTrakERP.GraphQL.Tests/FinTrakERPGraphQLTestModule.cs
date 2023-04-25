using Abp.Modules;
using Abp.Reflection.Extensions;
using Castle.Windsor.MsDependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using FinTrakERP.Configure;
using FinTrakERP.Startup;
using FinTrakERP.Test.Base;

namespace FinTrakERP.GraphQL.Tests
{
    [DependsOn(
        typeof(FinTrakERPGraphQLModule),
        typeof(FinTrakERPTestBaseModule))]
    public class FinTrakERPGraphQLTestModule : AbpModule
    {
        public override void PreInitialize()
        {
            IServiceCollection services = new ServiceCollection();
            
            services.AddAndConfigureGraphQL();

            WindsorRegistrationHelper.CreateServiceProvider(IocManager.IocContainer, services);
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(FinTrakERPGraphQLTestModule).GetAssembly());
        }
    }
}