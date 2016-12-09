using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Abp.Domain.Entities.Auditing;

namespace Groupon.Grp.BusinessApplications
{
    [Description("商家申请")]
    public class BusinessApplication : FullAuditedEntity<long>
    {
        [Description("姓名")]
        [StringLength(20)]
        public virtual string RealName { get; set; }

        [Description("手机号")]
        [StringLength(20)]
        public virtual string Mobile { get; set; }

        [Description("经营范围")]
        public virtual string BusinessScope { get; set; }
    }
}
