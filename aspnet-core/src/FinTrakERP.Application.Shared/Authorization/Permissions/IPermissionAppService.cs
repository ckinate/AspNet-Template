using Abp.Application.Services;
using Abp.Application.Services.Dto;
using FinTrakERP.Authorization.Permissions.Dto;

namespace FinTrakERP.Authorization.Permissions
{
    public interface IPermissionAppService : IApplicationService
    {
        ListResultDto<FlatPermissionWithLevelDto> GetAllPermissions();
    }
}
