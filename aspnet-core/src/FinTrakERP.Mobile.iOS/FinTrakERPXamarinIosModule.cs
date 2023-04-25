using Abp.Modules;
using Abp.Reflection.Extensions;

namespace FinTrakERP
{
    [DependsOn(typeof(FinTrakERPXamarinSharedModule))]
    public class FinTrakERPXamarinIosModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(FinTrakERPXamarinIosModule).GetAssembly());
        }
    }
}