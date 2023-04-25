using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using FinTrakERP.Authorization;

namespace FinTrakERP
{
    /// <summary>
    /// Application layer module of the application.
    /// </summary>
    [DependsOn(
        typeof(FinTrakERPApplicationSharedModule),
        typeof(FinTrakERPCoreModule)
        )]
    public class FinTrakERPApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            //Adding authorization providers
            Configuration.Authorization.Providers.Add<AppAuthorizationProvider>();

            //Adding custom AutoMapper configuration
            Configuration.Modules.AbpAutoMapper().Configurators.Add(CustomDtoMapper.CreateMappings);
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(FinTrakERPApplicationModule).GetAssembly());
        }
    }
}