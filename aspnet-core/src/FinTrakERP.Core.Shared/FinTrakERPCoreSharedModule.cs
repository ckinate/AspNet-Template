using Abp.Modules;
using Abp.Reflection.Extensions;

namespace FinTrakERP
{
    public class FinTrakERPCoreSharedModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(FinTrakERPCoreSharedModule).GetAssembly());
        }
    }
}