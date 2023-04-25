using Abp.Application.Services;
using FinTrakERP.Dto;
using FinTrakERP.Logging.Dto;

namespace FinTrakERP.Logging
{
    public interface IWebLogAppService : IApplicationService
    {
        GetLatestWebLogsOutput GetLatestWebLogs();

        FileDto DownloadWebLogs();
    }
}
