using System.Threading.Tasks;
using Abp.Application.Services;
using FinTrakERP.Configuration.Tenants.Dto;

namespace FinTrakERP.Configuration.Tenants
{
    public interface ITenantSettingsAppService : IApplicationService
    {
        Task<TenantSettingsEditDto> GetAllSettings();

        Task UpdateAllSettings(TenantSettingsEditDto input);

        Task ClearLogo();

        Task ClearCustomCss();
    }
}
