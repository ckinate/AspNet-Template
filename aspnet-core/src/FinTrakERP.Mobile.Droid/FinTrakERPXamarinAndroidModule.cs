using Abp.Modules;
using Abp.Reflection.Extensions;

namespace FinTrakERP
{
    [DependsOn(typeof(FinTrakERPXamarinSharedModule))]
    public class FinTrakERPXamarinAndroidModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(FinTrakERPXamarinAndroidModule).GetAssembly());
        }
    }
}