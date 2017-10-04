using Abp.Authorization;
using MVC5AJ1.Authorization.Roles;
using MVC5AJ1.Authorization.Users;
using MVC5AJ1.MultiTenancy;

namespace MVC5AJ1.Authorization
{
    /// <summary>
    /// Implements <see cref="PermissionChecker"/>.
    /// </summary>
    public class PermissionChecker : PermissionChecker<Tenant, Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
