using System.Collections.Generic;
using FinTrakERP.Authorization.Permissions.Dto;

namespace FinTrakERP.Authorization.Users.Dto
{
    public class GetUserPermissionsForEditOutput
    {
        public List<FlatPermissionDto> Permissions { get; set; }

        public List<string> GrantedPermissionNames { get; set; }
    }
}