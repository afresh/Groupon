using System.Collections.Generic;
using System.Linq;
using Abp.Authorization.Users;
using Abp.Domain.Repositories;
using Abp.Domain.Services;
using Abp.Runtime.Session;
using Abp.UI;
using Groupon.Menus.Dto;
using Groupon.Users;

namespace Groupon.Menus
{
    public class MenuManager : DomainService, IMenuManager
    {
        private readonly IRepository<Menu, long> _menuRepository;
        private readonly IRepository<MenuPermission, long> _menuPermissionRepository;
        private IAbpSession AbpSession { get; set; }
        private readonly IRepository<User, long> _userRepository;
        private readonly IRepository<UserRole, long> _userRoleRepository;

        public MenuManager(IRepository<Menu, long> menuRepository, IRepository<MenuPermission, long> menuPermissionRepository, IAbpSession abpSession, IRepository<User, long> userRepository, IRepository<UserRole, long> userRoleRepository)
        {
            _menuRepository = menuRepository;
            _menuPermissionRepository = menuPermissionRepository;
            AbpSession = abpSession;
            _userRepository = userRepository;
            _userRoleRepository = userRoleRepository;
        }

        public List<MenuManagerDto> GetCurrentMenus()
        {
            var currentUserId = AbpSession.UserId;
            if (currentUserId == null)
            {
                throw new UserFriendlyException("当前用户会话失效，请重新登录。");
            }
            var currentUser = _userRepository.FirstOrDefault(o => o.Id == currentUserId);
            if (currentUser == null)
            {
                throw new UserFriendlyException("当前用户会话失效，请重新登录。");
            }
            var userRoleIds =
                _userRoleRepository.GetAllList(o => o.UserId == currentUser.Id).Select(o => o.RoleId).ToList();
            var enableMenuPermissions =
                _menuPermissionRepository.GetAllList(
                    o =>
                        o.IsEnable && o.RoleId != null &&
                        (userRoleIds.Contains(o.RoleId.Value) || o.UserId == currentUser.Id));
            var enableAllMenuCodes = enableMenuPermissions.GroupBy(o => o.MenuCode).Select(o => o.Key).ToList();
            var disableMenuPermissions =
                _menuPermissionRepository.GetAllList(o => !o.IsEnable && o.UserId == currentUser.Id);
            var disableMenuCodes = disableMenuPermissions.GroupBy(o => o.MenuCode).Select(o => o.Key).ToList();
            var enableMenuCodes = enableAllMenuCodes.Where(code => !disableMenuCodes.Contains(code)).ToList();
            var allMenus = _menuRepository.GetAllList();
            var enableParentMenus = allMenus.Where(o => o.ParentCode == "0000" && enableMenuCodes.Contains(o.Code)).ToList();
            var menuManagerDtos = new List<MenuManagerDto>();
            foreach (var enableParentMenu in enableParentMenus)
            {
                var menuManagerDto = new MenuManagerDto();
                menuManagerDto.Name = enableParentMenu.Name;
                menuManagerDto.Icon = enableParentMenu.Icon;
                menuManagerDto.Url = enableParentMenu.Url;
                menuManagerDto.TemplateUrl = enableParentMenu.TemplateUrl;
                menuManagerDto.Sort = enableParentMenu.Sort;
                var childMenuDtos = new List<MenuManagerDto>();
                var childMenus =
                    allMenus.Where(o => o.ParentCode == enableParentMenu.Code && enableMenuCodes.Contains(o.Code))
                        .ToList();
                foreach (var childMenu in childMenus)
                {
                    var childMenuDto = new MenuManagerDto();
                    childMenuDto.Name = childMenu.Name;
                    childMenuDto.Icon = childMenu.Icon;
                    childMenuDto.Url = childMenu.Url;
                    childMenuDto.TemplateUrl = childMenu.TemplateUrl;
                    childMenuDto.Sort = childMenu.Sort;
                    childMenuDtos.Add(childMenuDto);
                }
                menuManagerDto.ChildMenus = childMenuDtos.OrderBy(o => o.Sort).ToList();
                menuManagerDtos.Add(menuManagerDto);
            }
            return menuManagerDtos.OrderBy(o => o.Sort).ToList();
        }
    }
}
