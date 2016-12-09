using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Abp.Domain.Entities.Auditing;
using Groupon.Grp.Packages;

namespace Groupon.Grp.PackageMenus
{
    [Description("套餐菜单")]
    public class PackageMenu : FullAuditedEntity<long>
    {
        [Description("所属套餐")]
        public virtual Package Package { get; set; }

        [Description("标题")]
        [StringLength(20)]
        public virtual string Title { get; set; }

        [Description("标题排序")]
        public virtual int TitleSort { get; set; }

        [Description("名称")]
        [StringLength(20)]
        public virtual string Name { get; set; }

        [Description("数量")]
        public virtual int Number { get; set; }

        [Description("单位")]
        [StringLength(20)]
        public virtual string Unit { get; set; }

        [Description("价格")]
        public virtual decimal Price { get; set; }

        [Description("排序")]
        public virtual int Sort { get; set; }
    }
}
