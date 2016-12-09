using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Abp.Domain.Entities.Auditing;

namespace Groupon.Grp.MembershipCards
{
    [Description("商家会员卡")]
    public class MembershipCard : FullAuditedEntity<long>
    {
        [Description("商家名称")]
        [StringLength(20)]
        public virtual string Name { get; set; }

        [Description("商家Logo")]
        public virtual string Logo { get; set; }

        [Description("说明")]
        public virtual string Description { get; set; }
    }
}
