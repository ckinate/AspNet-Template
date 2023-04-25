using Abp.Authorization;
using FinTrakERP.Authorization.Roles;
using FinTrakERP.Authorization.Users;

namespace FinTrakERP.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
