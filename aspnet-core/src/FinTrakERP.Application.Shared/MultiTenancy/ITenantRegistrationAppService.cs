using System.Threading.Tasks;
using Abp.Application.Services;
using FinTrakERP.Editions.Dto;
using FinTrakERP.MultiTenancy.Dto;

namespace FinTrakERP.MultiTenancy
{
    public interface ITenantRegistrationAppService: IApplicationService
    {
        Task<RegisterTenantOutput> RegisterTenant(RegisterTenantInput input);

        Task<EditionsSelectOutput> GetEditionsForSelect();

        Task<EditionSelectDto> GetEdition(int editionId);
    }
}