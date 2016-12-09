using System.Collections.Generic;
using Abp.Domain.Services;
using Groupon.Menus.Dto;

namespace Groupon.Menus
{
    public interface IMenuManager : IDomainService
    {
        List<MenuManagerDto> GetCurrentMenus();
    }
}
