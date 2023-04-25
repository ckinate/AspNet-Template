using System.Threading.Tasks;
using Abp.Application.Services;
using FinTrakERP.MultiTenancy.Payments.Dto;
using FinTrakERP.MultiTenancy.Payments.Stripe.Dto;

namespace FinTrakERP.MultiTenancy.Payments.Stripe
{
    public interface IStripePaymentAppService : IApplicationService
    {
        Task ConfirmPayment(StripeConfirmPaymentInput input);

        StripeConfigurationDto GetConfiguration();

        Task<SubscriptionPaymentDto> GetPaymentAsync(StripeGetPaymentInput input);

        Task<string> CreatePaymentSession(StripeCreatePaymentSessionInput input);
    }
}