using Abp.Domain.Services;

namespace FinTrakERP
{
    public abstract class FinTrakERPDomainServiceBase : DomainService
    {
        /* Add your common members for all your domain services. */

        protected FinTrakERPDomainServiceBase()
        {
            LocalizationSourceName = FinTrakERPConsts.LocalizationSourceName;
        }
    }
}
