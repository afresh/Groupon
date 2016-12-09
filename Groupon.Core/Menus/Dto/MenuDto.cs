using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Groupon.Menus.Dto
{
    [Description("导航菜单")]
    [Serializable]
    public class MenuDto : ManagerDto<long>
    {
        [Description("代码")]
        [StringLength(4)]
        public virtual string Code { get; set; }

        [Description("父级代码")]
        [StringLength(4)]
        public virtual string ParentCode { get; set; }

        [Description("名称")]
        [StringLength(20)]
        public virtual string Name { get; set; }

        [Description("图标")]
        public virtual string Icon { get; set; }

        [Description("路由")]
        public virtual string Url { get; set; }

        [Description("模板地址")]
        public virtual string TemplateUrl { get; set; }

        [Description("是否静态")]
        public virtual bool IsStatic { get; set; }

        [Description("排序")]
        public virtual int Sort { get; set; }
    }
}
