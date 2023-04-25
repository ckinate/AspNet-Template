using Abp.Zero.Ldap.Authentication;
using Abp.Zero.Ldap.Configuration;
using FinTrakERP.Authorization.Users;
using FinTrakERP.MultiTenancy;

namespace FinTrakERP.Authorization.Ldap
{
    public class AppLdapAuthenticationSource : LdapAuthenticationSource<Tenant, User>
    {
        public AppLdapAuthenticationSource(ILdapSettings settings, IAbpZeroLdapModuleConfig ldapModuleConfig)
            : base(settings, ldapModuleConfig)
        {
        }
    }
}