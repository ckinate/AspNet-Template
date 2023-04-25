using System.Threading.Tasks;
using Abp.Application.Services;
using FinTrakERP.Sessions.Dto;

namespace FinTrakERP.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();

        Task<UpdateUserSignInTokenOutput> UpdateUserSignInToken();
    }
}
