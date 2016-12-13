using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Groupon.Authorization.Roles;

namespace Groupon.Sessions.Dto
{
    [AutoMapFrom(typeof(Role))]
    public class RoleLoginInfoDto : EntityDto
    {
        public string Name { get; set; }

        public string DisplayName { get; set; }
    }
}
