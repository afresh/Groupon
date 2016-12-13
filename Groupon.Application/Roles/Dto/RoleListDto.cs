using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Groupon.Authorization.Roles;

namespace Groupon.Roles.Dto
{
    [AutoMapFrom(typeof(Role))]
    public class RoleListDto : EntityDto
    {
        public string Name { get; set; }

        public string DisplayName { get; set; }

        public bool IsStatic { get; set; }

        public bool IsDefault { get; set; }
    }
}
