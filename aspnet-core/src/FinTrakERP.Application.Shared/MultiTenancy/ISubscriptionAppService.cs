using System.Threading.Tasks;
using Abp.Application.Services;

namespace FinTrakERP.MultiTenancy
{
    public interface ISubscriptionAppService : IApplicationService
    {
        Task DisableRecurringPayments();

        Task EnableRecurringPayments();
    }
}
