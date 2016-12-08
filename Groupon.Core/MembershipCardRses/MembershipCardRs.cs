using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Abp.Domain.Entities.Auditing;
using Groupon.Members;
using Groupon.MembershipCardTypes;

namespace Groupon.MembershipCardRses
{
    [Description("会员持卡")]
    public class MembershipCardRs : FullAuditedEntity<long>
    {
        [Description("卡号")]
        [StringLength(20)]
        public string No { get; set; }

        [Description("所属会员")]
        public Member Member { get; set; }

        [Description("所属卡类型")]
        public MembershipCardType MembershipCardType { get; set; }

        [Description("真实姓名")]
        [StringLength(20)]
        public string RealName { get; set; }
    }
}
