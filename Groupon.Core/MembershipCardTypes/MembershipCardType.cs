using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Abp.Domain.Entities.Auditing;
using Groupon.MembershipCards;

namespace Groupon.MembershipCardTypes
{
    [Description("商家会员卡类型")]
    public class MembershipCardType : FullAuditedEntity<long>
    {
        [Description("卡面")]
        public string CardFace { get; set; }

        [Description("名称")]
        [StringLength(10)]
        public string Name { get; set; }

        [Description("所属商家会员卡")]
        public MembershipCard MembershipCard { get; set; }
    }
}
