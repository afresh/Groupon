using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Abp.Domain.Entities.Auditing;

namespace Groupon.MembershipCards
{
    [Description("商家会员卡")]
    public class MembershipCard : FullAuditedEntity<long>
    {
        [Description("商家名称")]
        [StringLength(20)]
        public string Name { get; set; }

        [Description("商家Logo")]
        public string Logo { get; set; }

        [Description("说明")]
        public string Description { get; set; }
    }
}
