using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Abp.Domain.Entities.Auditing;

namespace Groupon.Grp.MemberLevels
{
    [Description("会员等级")]
    public class MemberLevel : FullAuditedEntity<long>
    {
        [Description("代码")]
        [StringLength(4)]
        public virtual string Code { get; set; }

        [Description("级数")]
        public virtual int Level { get; set; }

        [Description("配图")]
        public virtual string Image { get; set; }

        [Description("成长值")]
        public virtual int GrowthValue { get; set; }

        [Description("是否默认值")]
        public virtual bool IsDefault { get; set; }
    }
}
