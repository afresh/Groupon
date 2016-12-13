using System.Threading.Tasks;
using Abp.Auditing;
using Abp.Authorization;
using Abp.AutoMapper;
using Groupon.Sessions.Dto;

namespace Groupon.Sessions
{
    [AbpAuthorize]
    public class SessionAppService : GrouponAppServiceBase, ISessionAppService
    {
        [DisableAuditing]
        public async Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations()
        {
            var output = new GetCurrentLoginInformationsOutput
            {
                User = (await GetCurrentUserAsync()).MapTo<UserLoginInfoDto>()
            };

            if (AbpSession.TenantId.HasValue)
            {
                output.Tenant = (await GetCurrentTenantAsync()).MapTo<TenantLoginInfoDto>();
            }

            output.Role = (await GetCurrentRole(output.User.Id)).MapTo<RoleLoginInfoDto>();

            return output;
        }
    }
}