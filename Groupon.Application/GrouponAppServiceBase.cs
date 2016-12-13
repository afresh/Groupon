using System;
using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.IdentityFramework;
using Abp.Runtime.Session;
using Groupon.Authorization.Roles;
using Groupon.MultiTenancy;
using Groupon.Users;
using Microsoft.AspNet.Identity;

namespace Groupon
{
    /// <summary>
    /// Derive your application services from this class.
    /// </summary>
    public abstract class GrouponAppServiceBase : ApplicationService
    {
        public TenantManager TenantManager { get; set; }

        public UserManager UserManager { get; set; }

        public RoleManager RoleManager { get; set; }

        protected GrouponAppServiceBase()
        {
            LocalizationSourceName = GrouponConsts.LocalizationSourceName;
        }

        protected virtual Task<User> GetCurrentUserAsync()
        {
            var user = UserManager.FindByIdAsync(AbpSession.GetUserId());
            if (user == null)
            {
                throw new ApplicationException("There is no current user!");
            }

            return user;
        }

        protected virtual Task<Tenant> GetCurrentTenantAsync()
        {
            return TenantManager.GetByIdAsync(AbpSession.GetTenantId());
        }

        protected async Task<Role> GetCurrentRole(long id)
        {
            var userRoles = await UserManager.GetRolesAsync(id);
            if (userRoles.Count == 0)
            {
                return null;
            }
            foreach (var role in RoleManager.Roles)
            {
                if (role.Name == userRoles[0])
                {
                    return role;
                }
            }
            return null;
        }

        protected virtual void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}