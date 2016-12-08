using Abp.Authorization;
using Groupon.Authorization.Roles;
using Groupon.MultiTenancy;
using Groupon.Users;

namespace Groupon.Authorization
{
    public class PermissionChecker : PermissionChecker<Tenant, Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
