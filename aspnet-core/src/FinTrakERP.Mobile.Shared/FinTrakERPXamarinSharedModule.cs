using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;

namespace FinTrakERP
{
    [DependsOn(typeof(FinTrakERPClientModule), typeof(AbpAutoMapperModule))]
    public class FinTrakERPXamarinSharedModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Localization.IsEnabled = false;
            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(FinTrakERPXamarinSharedModule).GetAssembly());
        }
    }
}