using Abp.Events.Bus;

namespace FinTrakERP.MultiTenancy
{
    public class RecurringPaymentsEnabledEventData : EventData
    {
        public int TenantId { get; set; }
    }
}