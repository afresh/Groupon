using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Abp.Domain.Entities.Auditing;

namespace Groupon.Grp.InfoClasses
{
    [Description("资讯分类")]
    public class InfoClass : FullAuditedEntity<long>
    {
        [Description("代码")]
        [StringLength(4)]
        public virtual string Code { get; set; }

        [Description("名称")]
        [StringLength(20)]
        public virtual string Name { get; set; }

        [Description("排序")]
        public virtual int Sort { get; set; }

        [Description("是否默认")]
        public virtual bool IsDefault { get; set; }
    }
}
