using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;
using Microsoft.AspNetCore.Mvc.Razor.Internal;

namespace FinTrakERP.Web.Public.Views
{
    public abstract class FinTrakERPRazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject]
        public IAbpSession AbpSession { get; set; }

        protected FinTrakERPRazorPage()
        {
            LocalizationSourceName = FinTrakERPConsts.LocalizationSourceName;
        }
    }
}
