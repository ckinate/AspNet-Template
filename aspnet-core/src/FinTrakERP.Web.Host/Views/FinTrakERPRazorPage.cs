using Abp.AspNetCore.Mvc.Views;

namespace FinTrakERP.Web.Views
{
    public abstract class FinTrakERPRazorPage<TModel> : AbpRazorPage<TModel>
    {
        protected FinTrakERPRazorPage()
        {
            LocalizationSourceName = FinTrakERPConsts.LocalizationSourceName;
        }
    }
}
