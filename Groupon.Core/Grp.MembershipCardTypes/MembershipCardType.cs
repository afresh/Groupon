using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Abp.Domain.Entities.Auditing;
using Groupon.Grp.MembershipCards;

namespace Groupon.Grp.MembershipCardTypes
{
    [Description("商家会员卡类型")]
    public class MembershipCardType : FullAuditedEntity<long>
    {
        [Description("卡面")]
        public virtual string CardFace { get; set; }

        [Description("名称")]
        [StringLength(10)]
        public virtual string Name { get; set; }

        [Description("所属商家会员卡")]
        public virtual MembershipCard MembershipCard { get; set; }
    }
}
