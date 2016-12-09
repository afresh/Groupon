using Abp.Application.Services;

namespace Groupon.Menus
{
    public interface IMenuService : IApplicationService
    {
        ResultDto GetCurrentMenus();
    }
}
