using Abp.Modules;
using Abp.Reflection.Extensions;

namespace FinTrakERP
{
    [DependsOn(typeof(FinTrakERPCoreSharedModule))]
    public class FinTrakERPApplicationSharedModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(FinTrakERPApplicationSharedModule).GetAssembly());
        }
    }
}