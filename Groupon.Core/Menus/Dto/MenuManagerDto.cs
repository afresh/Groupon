using System.Collections.Generic;

namespace Groupon.Menus.Dto
{
    public class MenuManagerDto
    {
        public string Name { get; set; }
        public string Icon { get; set; }
        public int Sort { get; set; }
        public string Url { get; set; }
        public string TemplateUrl { get; set; }
        public List<MenuManagerDto> ChildMenus { get; set; }
    }
}
