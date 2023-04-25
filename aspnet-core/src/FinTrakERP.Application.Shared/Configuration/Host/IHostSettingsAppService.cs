using System.Threading.Tasks;
using Abp.Application.Services;
using FinTrakERP.Configuration.Host.Dto;

namespace FinTrakERP.Configuration.Host
{
    public interface IHostSettingsAppService : IApplicationService
    {
        Task<HostSettingsEditDto> GetAllSettings();

        Task UpdateAllSettings(HostSettingsEditDto input);

        Task SendTestEmail(SendTestEmailInput input);
    }
}
