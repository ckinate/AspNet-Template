using Abp.AspNetCore.Mvc.ViewComponents;

namespace FinTrakERP.Web.Public.Views
{
    public abstract class FinTrakERPViewComponent : AbpViewComponent
    {
        protected FinTrakERPViewComponent()
        {
            LocalizationSourceName = FinTrakERPConsts.LocalizationSourceName;
        }
    }
}