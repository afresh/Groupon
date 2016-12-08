using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Abp.Domain.Entities.Auditing;
using Groupon.Packages;

namespace Groupon.PackageMenus
{
    [Description("套餐菜单")]
    public class PackageMenu : FullAuditedEntity<long>
    {
        [Description("所属套餐")]
        public Package Package { get; set; }

        [Description("标题")]
        [StringLength(20)]
        public string Title { get; set; }

        [Description("标题排序")]
        public int TitleSort { get; set; }

        [Description("名称")]
        [StringLength(20)]
        public string Name { get; set; }

        [Description("数量")]
        public int Number { get; set; }

        [Description("单位")]
        [StringLength(20)]
        public string Unit { get; set; }

        [Description("价格")]
        public decimal Price { get; set; }

        [Description("排序")]
        public int Sort { get; set; }
    }
}
