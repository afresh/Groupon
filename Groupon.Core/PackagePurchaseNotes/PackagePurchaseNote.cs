using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Abp.Domain.Entities.Auditing;
using Groupon.Packages;

namespace Groupon.PackagePurchaseNotes
{
    [Description("套餐购买须知")]
    public class PackagePurchaseNote : FullAuditedEntity<long>
    {
        [Description("所属套餐")]
        public Package Package { get; set; }

        [Description("标题")]
        [StringLength(20)]
        public string Title { get; set; }

        [Description("详情")]
        public string Detail { get; set; }

        [Description("排序")]
        public int Sort { get; set; }

        [Description("是否默认值")]
        public bool IsDefault { get; set; }
    }
}
