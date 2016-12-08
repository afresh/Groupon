using System.Threading.Tasks;
using Abp.Application.Services;
using Groupon.Roles.Dto;

namespace Groupon.Roles
{
    public interface IRoleAppService : IApplicationService
    {
        Task UpdateRolePermissions(UpdateRolePermissionsInput input);
    }
}
