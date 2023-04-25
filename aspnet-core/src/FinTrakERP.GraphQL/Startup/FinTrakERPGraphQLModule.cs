using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;

namespace FinTrakERP.Startup
{
    [DependsOn(typeof(FinTrakERPCoreModule))]
    public class FinTrakERPGraphQLModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(FinTrakERPGraphQLModule).GetAssembly());
        }

        public override void PreInitialize()
        {
            base.PreInitialize();

            //Adding custom AutoMapper configuration
            Configuration.Modules.AbpAutoMapper().Configurators.Add(CustomDtoMapper.CreateMappings);
        }
    }
}