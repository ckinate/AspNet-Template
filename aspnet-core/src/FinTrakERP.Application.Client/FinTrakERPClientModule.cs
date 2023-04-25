using Abp.Modules;
using Abp.Reflection.Extensions;

namespace FinTrakERP
{
    public class FinTrakERPClientModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(FinTrakERPClientModule).GetAssembly());
        }
    }
}
