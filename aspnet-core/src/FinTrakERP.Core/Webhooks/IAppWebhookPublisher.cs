using System.Threading.Tasks;
using FinTrakERP.Authorization.Users;

namespace FinTrakERP.WebHooks
{
    public interface IAppWebhookPublisher
    {
        Task PublishTestWebhook();
    }
}
