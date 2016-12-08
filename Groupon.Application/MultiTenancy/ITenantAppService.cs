using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Groupon.MultiTenancy.Dto;

namespace Groupon.MultiTenancy
{
    public interface ITenantAppService : IApplicationService
    {
        ListResultDto<TenantListDto> GetTenants();

        Task CreateTenant(CreateTenantInput input);
    }
}
