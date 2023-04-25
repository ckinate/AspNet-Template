using System.Threading.Tasks;
using Abp.Application.Services;
using FinTrakERP.Install.Dto;

namespace FinTrakERP.Install
{
    public interface IInstallAppService : IApplicationService
    {
        Task Setup(InstallDto input);

        AppSettingsJsonDto GetAppSettingsJson();

        CheckDatabaseOutput CheckDatabase();
    }
}