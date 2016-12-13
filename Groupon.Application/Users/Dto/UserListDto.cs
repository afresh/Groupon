using System;
using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Groupon.Roles.Dto;

namespace Groupon.Users.Dto
{
    [AutoMapFrom(typeof(User))]
    public class UserListDto : EntityDto<long>
    {
        public string Name { get; set; }

        public string Surname { get; set; }

        public string UserName { get; set; }

        public string FullName { get; set; }

        public string EmailAddress { get; set; }

        public bool IsEmailConfirmed { get; set; }

        public string PhoneNumber { get; set; }

        public bool IsPhoneNumberConfirmed { get; set; }

        public DateTime? LastLoginTime { get; set; }

        public bool IsActive { get; set; }

        public DateTime CreationTime { get; set; }

        public RoleListDto Role { get; set; }
    }
}