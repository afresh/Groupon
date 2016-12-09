using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Abp.Domain.Entities.Auditing;

namespace Groupon.Grp.BusinessScopes
{
    [Description("经营范围")]
    public class BusinessScope : FullAuditedEntity<long>
    {
        [Description("代码")]
        [StringLength(4)]
        public virtual string Code { get; set; }

        [Description("名称")]
        [StringLength(6)]
        public virtual string Name { get; set; }

        [Description("背景颜色")]
        [StringLength(10)]
        public virtual string BgColor { get; set; }

        [Description("图标")]
        public virtual string Icon { get; set; }

        [Description("排序")]
        public virtual int Sort { get; set; }
    }
}
