using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Abp.Domain.Entities.Auditing;

namespace Groupon.MemberLevels
{
    [Description("会员等级")]
    public class MemberLevel : FullAuditedEntity<long>
    {
        [Description("代码")]
        [StringLength(4)]
        public string Code { get; set; }

        [Description("级数")]
        public int Level { get; set; }

        [Description("配图")]
        public string Image { get; set; }

        [Description("成长值")]
        public int GrowthValue { get; set; }

        [Description("是否默认值")]
        public bool IsDefault { get; set; }
    }
}
