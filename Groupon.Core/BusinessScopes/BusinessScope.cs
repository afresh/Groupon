using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Abp.Domain.Entities.Auditing;

namespace Groupon.BusinessScopes
{
    [Description("经营范围")]
    public class BusinessScope : FullAuditedEntity<long>
    {
        [Description("代码")]
        [StringLength(4)]
        public string Code { get; set; }

        [Description("名称")]
        [StringLength(6)]
        public string Name { get; set; }

        [Description("背景颜色")]
        [StringLength(10)]
        public string BgColor { get; set; }

        [Description("图标")]
        public string Icon { get; set; }

        [Description("排序")]
        public int Sort { get; set; }
    }
}
