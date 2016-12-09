namespace Groupon.Menus
{
    public class MenuService : IMenuService
    {
        private readonly IMenuManager _menuManager;

        public MenuService(IMenuManager menuManager)
        {
            _menuManager = menuManager;
        }

        public ResultDto GetCurrentMenus()
        {
            var output = _menuManager.GetCurrentMenus();
            return new ResultDto {Code = 0, Message = "获取成功！", Data = output};
        }
    }
}