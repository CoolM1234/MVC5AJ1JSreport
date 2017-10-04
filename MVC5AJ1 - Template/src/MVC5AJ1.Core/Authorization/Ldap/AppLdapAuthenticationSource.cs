using Abp.Zero.Ldap.Authentication;
using Abp.Zero.Ldap.Configuration;
using MVC5AJ1.Authorization.Users;
using MVC5AJ1.MultiTenancy;

namespace MVC5AJ1.Authorization.Ldap
{
    public class AppLdapAuthenticationSource : LdapAuthenticationSource<Tenant, User>
    {
        public AppLdapAuthenticationSource(ILdapSettings settings, IAbpZeroLdapModuleConfig ldapModuleConfig)
            : base(settings, ldapModuleConfig)
        {
        }
    }
}
