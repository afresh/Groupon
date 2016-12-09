using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Abp.Domain.Entities.Auditing;
using Groupon.Grp.Members;
using Groupon.Grp.MembershipCardTypes;

namespace Groupon.Grp.MembershipCardRses
{
    [Description("会员持卡")]
    public class MembershipCardRs : FullAuditedEntity<long>
    {
        [Description("卡号")]
        [StringLength(20)]
        public virtual string No { get; set; }

        [Description("所属会员")]
        public virtual Member Member { get; set; }

        [Description("所属卡类型")]
        public virtual MembershipCardType MembershipCardType { get; set; }

        [Description("真实姓名")]
        [StringLength(20)]
        public virtual string RealName { get; set; }
    }
}
