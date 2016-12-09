using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Abp.Domain.Entities.Auditing;
using Groupon.Grp.Packages;

namespace Groupon.Grp.PackagePurchaseNotes
{
    [Description("套餐购买须知")]
    public class PackagePurchaseNote : FullAuditedEntity<long>
    {
        [Description("所属套餐")]
        public virtual Package Package { get; set; }

        [Description("标题")]
        [StringLength(20)]
        public virtual string Title { get; set; }

        [Description("详情")]
        public virtual string Detail { get; set; }

        [Description("排序")]
        public virtual int Sort { get; set; }

        [Description("是否默认值")]
        public virtual bool IsDefault { get; set; }
    }
}
