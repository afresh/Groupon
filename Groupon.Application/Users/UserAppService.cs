using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using Abp.Authorization;
using Abp.AutoMapper;
using Abp.Domain.Repositories;
using Groupon.Authorization;
using Groupon.Authorization.Roles;
using Groupon.Roles.Dto;
using Groupon.Users.Dto;
using Microsoft.AspNet.Identity;

namespace Groupon.Users
{
    /* THIS IS JUST A SAMPLE. */
    [AbpAuthorize(PermissionNames.Pages_Users)]
    public class UserAppService : GrouponAppServiceBase, IUserAppService
    {
        private readonly IRepository<User, long> _userRepository;
        private readonly IRepository<Role> _roleRepository;
        private readonly IPermissionManager _permissionManager;

        public UserAppService(IRepository<User, long> userRepository, IPermissionManager permissionManager, IRepository<Role> roleRepository)
        {
            _userRepository = userRepository;
            _permissionManager = permissionManager;
            _roleRepository = roleRepository;
        }

        public async Task ProhibitPermission(ProhibitPermissionInput input)
        {
            var user = await UserManager.GetUserByIdAsync(input.UserId);
            var permission = _permissionManager.GetPermission(input.PermissionName);

            await UserManager.ProhibitPermissionAsync(user, permission);
        }

        //Example for primitive method parameters.
        public async Task RemoveFromRole(long userId, string roleName)
        {
            CheckErrors(await UserManager.RemoveFromRoleAsync(userId, roleName));
        }

        public async Task<ListResultDto<UserListDto>> GetUsers()
        {
            var users = await _userRepository.GetAllListAsync();
            var roles = await _roleRepository.GetAllListAsync();
            var roleListDto = roles.FirstOrDefault(o => o.IsDefault).MapTo<RoleListDto>();
            var userListDtos = new List<UserListDto>();
            foreach (var user in users)
            {
                var userListDto = user.MapTo<UserListDto>();
                var roleId = user.Roles.FirstOrDefault()?.RoleId;
                var role = roles.FirstOrDefault(o => o.Id == roleId);
                userListDto.Role = role == null ? roleListDto : role.MapTo<RoleListDto>();
                userListDtos.Add(userListDto);
            }
            return new ListResultDto<UserListDto>(userListDtos);
        }

        public async Task CreateUser(CreateUserInput input)
        {
            var user = input.MapTo<User>();

            user.TenantId = AbpSession.TenantId;
            user.Password = new PasswordHasher().HashPassword(input.Password);
            user.IsEmailConfirmed = true;

            CheckErrors(await UserManager.CreateAsync(user));
        }
    }
}