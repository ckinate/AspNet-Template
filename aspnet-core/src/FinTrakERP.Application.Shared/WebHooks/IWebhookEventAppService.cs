using System.Threading.Tasks;
using Abp.Webhooks;

namespace FinTrakERP.WebHooks
{
    public interface IWebhookEventAppService
    {
        Task<WebhookEvent> Get(string id);
    }
}
